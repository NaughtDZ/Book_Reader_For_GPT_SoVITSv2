Imports System.IO
Imports LibVLCSharp.Shared

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        Button3 = New Button()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TrackBar1 = New TrackBar()
        VlcControl1 = New Vlc.DotNet.Forms.VlcControl()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        CType(VlcControl1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 581)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 40)
        Button1.TabIndex = 0
        Button1.Text = "提交播放"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(118, 581)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 40)
        Button2.TabIndex = 1
        Button2.Text = "停止所有播放"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 12)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Both
        TextBox1.Size = New Size(1117, 427)
        TextBox1.TabIndex = 2
        TextBox1.Text = "先帝创业未半而中道崩殂，今天下三分，益州疲弊，此诚危急存亡之秋也。"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(224, 581)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 40)
        Button3.TabIndex = 4
        Button3.Text = "暂停/恢复"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 454)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ScrollBars = ScrollBars.Both
        TextBox2.Size = New Size(1117, 42)
        TextBox2.TabIndex = 5
        TextBox2.Text = "http://127.0.0.1:9880/tts?text="
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(12, 502)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ScrollBars = ScrollBars.Both
        TextBox3.Size = New Size(1117, 41)
        TextBox3.TabIndex = 6
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' TrackBar1
        ' 
        TrackBar1.Location = New Point(330, 581)
        TrackBar1.Maximum = 100
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Size = New Size(799, 45)
        TrackBar1.TabIndex = 8
        TrackBar1.Value = 50
        ' 
        ' VlcControl1
        ' 
        VlcControl1.BackColor = Color.Black
        VlcControl1.Location = New Point(856, 564)
        VlcControl1.Name = "VlcControl1"
        VlcControl1.Size = New Size(75, 23)
        VlcControl1.Spu = -1
        VlcControl1.TabIndex = 9
        VlcControl1.Text = "VlcControl1"
        VlcControl1.VlcLibDirectory = New DirectoryInfo(".\libvlc\win-x64")
        VlcControl1.VlcMediaplayerOptions = Nothing
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1141, 630)
        Controls.Add(VlcControl1)
        Controls.Add(TrackBar1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Button3)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Book Reader For GPT-SoVITSv2"
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        CType(VlcControl1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents VlcControl1 As Vlc.DotNet.Forms.VlcControl

End Class
