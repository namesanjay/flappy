Imports System.Diagnostics.CodeAnalysis
Imports System.IO.Pipes
Imports System.Threading


Public Class Form1
    Dim yspeed As Integer = -0.9
    Dim gravity As Integer = 2.9
    Dim pipe(1) As PictureBox
    Dim TopPipe(1) As PictureBox
    Dim pipegaps As Integer = 500
    Dim pipeSpeed As Single = 3
    'Dim a As Integer
    'Dim b As Integer = 200
    'Private Sub ResizeFormToScreen()
    ' Set the form height and width based on the screen size
    'Me.Height = Screen.PrimaryScreen.Bounds.Height
    'Me.Width = Screen.PrimaryScreen.Bounds.Width
    'End Sub

    Sub Pauseform()
        Thread.Sleep(3000)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Timer2.Enabled = True
        CreatePipes(1)
        CreateTopPipes(1)


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        yspeed += gravity
        bird.Top += yspeed
        For i = 0 To 1
            pipe(i).Left -= pipeSpeed
            TopPipe(i).Left -= pipeSpeed
            If (Collision(pipe(i), bird) = True) Or (Collision(TopPipe(i), bird)) Then

                Pauseform()
                Application.Exit()
            End If
            If pipe(i).Left < 0 Then
                pipe(i).Left += 400
                TopPipe(i).Left += 400
                pipe(i).Top = 75 + 300 * Rnd()
                TopPipe(i).Top = pipe(i).Top - pipegaps

            End If


        Next

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        '  StartPosition 

        If e.KeyCode = Keys.Space Then
            yspeed = -20

        End If
    End Sub

    Private Sub CreatePipes(ByVal Number As Integer)
        'ReDim pipe(Number)'
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 50
            temp.Height = 350
            temp.BorderStyle = BorderStyle.FixedSingle
            temp.BackColor = Color.Red
            temp.Top = 75 + 300 * Rnd()
            temp.Left = (i * 200) + 300
            pipe(i) = temp
            pipe(i).Visible = True
        Next
    End Sub
    Private Sub CreateTopPipes(ByVal Number As Integer)
        'ReDim pipe(Number)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 50
            temp.Height = 350
            temp.BorderStyle = BorderStyle.FixedSingle
            temp.BackColor = Color.Red
            temp.Top = pipe(i).Top - pipegaps
            temp.Left = (i * 200) + 300
            TopPipe(i) = temp
            TopPipe(i).Visible = True

        Next
    End Sub

    Private Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim Collided As Boolean = False
        If Object1.Top + Object1.Height >= Object2.Top And
            Object2.Top + Object2.Height >= Object1.Top And
            Object1.Left + Object1.Width >= Object2.Left And
            Object2.Left + Object2.Width >= Object1.Left And
            Object1.visible = True And Object2.visible = True Then

            Collided = True

        End If

        Return Collided
    End Function

    Private Sub bird_Click(sender As Object, e As EventArgs) Handles bird.Click

    End Sub
End Class
