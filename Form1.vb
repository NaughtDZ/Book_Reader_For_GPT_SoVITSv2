Imports System.IO
Imports System.Net.Http
Imports LibVLCSharp.Shared
Imports Vlc.DotNet.Forms
Imports System.Web
Public Class Form1

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim url As String = TextBox2.Text & HttpUtility.UrlEncode(TextBox1.Text) & TextBox3.Text
        MsgBox(url)
        VlcControl1.Stop()

        VlcControl1.SetMedia(url, String.Empty)

        VlcControl1.Play()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'VlcControl1.VlcLibDirectory = New DirectoryInfo(".\libvlc\win-x64")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VlcControl1.VlcMediaPlayer.Stop()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        VlcControl1.Audio.Volume = TrackBar1.Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If VlcControl1.VlcMediaPlayer.IsPlaying = True Then
            VlcControl1.Pause()
        Else
            VlcControl1.VlcMediaPlayer.Play()
        End If
    End Sub
End Class
