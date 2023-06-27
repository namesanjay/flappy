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
        components = New ComponentModel.Container()
        bird = New PictureBox()
        Timer2 = New Timer(components)
        CType(bird, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bird
        ' 
        bird.BackColor = Color.DarkMagenta
        bird.Location = New Point(61, 76)
        bird.Name = "bird"
        bird.Size = New Size(38, 38)
        bird.TabIndex = 0
        bird.TabStop = False
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 40
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(382, 403)
        Controls.Add(bird)
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        CType(bird, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents bird As PictureBox
    Friend WithEvents Timer2 As Timer
End Class
