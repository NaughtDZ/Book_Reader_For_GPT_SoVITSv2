Imports System.IO
Imports System.Net.Http
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports NAudio.Wave
Public Class Form1
    Private cancellationTokenSource As CancellationTokenSource
    Private audioOutput As WaveOutEvent
    Private audioStream As MemoryStream
    Private audioReader As WaveStream
    Private isPaused As Boolean = False ' 用于追踪音频是否暂停
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 停止之前的操作
        StopAudio()

        ' 初始化新的取消令牌
        cancellationTokenSource = New CancellationTokenSource()
        Dim token = cancellationTokenSource.Token

        ' 获取用户输入的长文本
        Dim longText As String = TextBox1.Text
        Dim paragraphs() As String = longText.Split(New String() {Environment.NewLine & Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

        Try
            For i As Integer = 0 To paragraphs.Length - 1
                If token.IsCancellationRequested Then
                    Exit For
                End If

                ' 发送网络请求并获取音频
                Dim audioData As Byte() = Await SendRequest(paragraphs(i), token)
                If audioData IsNot Nothing Then
                    ' 播放音频
                    PlayAudio(audioData)

                    ' 等待音频播放完成
                    Await Task.Run(Sub()
                                       While audioOutput.PlaybackState = PlaybackState.Playing OrElse isPaused
                                           Thread.Sleep(100)
                                       End While
                                   End Sub, token)
                End If
            Next
        Catch ex As OperationCanceledException
            ' 操作被取消
        Finally
            StopAudio()
        End Try
    End Sub

    Private Async Function SendRequest(text As String, token As CancellationToken) As Task(Of Byte())
        ' 网络请求发送函数
        Dim client As New HttpClient()
        Try
            Dim response As HttpResponseMessage = Await client.GetAsync("http://your-api-url?text=" & text, token)
            response.EnsureSuccessStatusCode()
            Return Await response.Content.ReadAsByteArrayAsync()
        Catch ex As Exception
            MessageBox.Show("请求失败: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub PlayAudio(audioData As Byte())
        StopAudio()

        ' 初始化内存流和NAudio音频流
        audioStream = New MemoryStream(audioData)
        audioReader = New WaveFileReader(audioStream)
        audioOutput = New WaveOutEvent()
        audioOutput.Init(audioReader)
        audioOutput.Play()
    End Sub

    Private Sub StopAudio()
        If audioOutput IsNot Nothing Then
            audioOutput.Stop()
            audioOutput.Dispose()
            audioOutput = Nothing
        End If
        If audioReader IsNot Nothing Then
            audioReader.Dispose()
            audioReader = Nothing
        End If
        If audioStream IsNot Nothing Then
            audioStream.Dispose()
            audioStream = Nothing
        End If
        isPaused = False ' 重置暂停状态
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 停止播放按钮事件
        If cancellationTokenSource IsNot Nothing Then
            cancellationTokenSource.Cancel()
        End If
        StopAudio()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 暂停/恢复按钮事件
        If audioOutput IsNot Nothing Then
            If audioOutput.PlaybackState = PlaybackState.Playing Then
                audioOutput.Pause()
                isPaused = True
            ElseIf isPaused Then
                audioOutput.Play()
                isPaused = False
            End If
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)
        ' 调节音量，TrackBar1的值在0到100之间
        If audioOutput IsNot Nothing Then
            audioOutput.Volume = TrackBar1.Value / 100.0F
        End If
    End Sub
End Class
