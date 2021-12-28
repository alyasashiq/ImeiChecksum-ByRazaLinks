Public Class Form1
    Private imei As String
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    '...........................Form Dragble Code.............................'
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        draggable = False
    End Sub

    '...........................Form Visible Code.............................'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Coral
        TransparencyKey = BackColor
    End Sub


    '...........................Form Imei CheckSum Code.............................'
    Public Shared Function IMEIChecksum(ByVal imei As String) As String

        Dim last As Integer
        Dim a As Integer = 0
        Dim sum As Integer = 0

        For i As Integer = 0 To imei.Length - 1
            Dim d As Integer = Convert.ToInt32(imei.Substring(imei.Length - 1 - i, 1))
            If a Mod 2 = 0 Then d = d * 2
            If d > 9 Then d -= 9
            sum += d
            a += 1
        Next
        If sum Mod 10 = 0 Then
            last = 0
            Return "0"
        End If

        Dim j As Integer = 10 - (sum Mod 10)
        j = j * -1
        last = j
        'Return j.ToString()
        Return (10 - sum Mod 10).ToString()
    End Function

    '...........................Imei Write Box Code.............................'
    Private Sub ImeiRdBox_TextChanged(sender As Object, e As EventArgs) Handles ImeiRdBox.TextChanged
        ImeiCheckSumBox.Clear()
        ImeiWrBox.ForeColor = Color.Red
        If ImeiWrBox.TextLength = 14 Then
            imei = IMEIChecksum("" + ImeiWrBox.Text)
            ImeiCheckSumBox.Text = imei
            ImeiRdBox.Text = ImeiWrBox.Text + imei
            ImeiWrBox.ForeColor = Color.Green
            ImeiCheckSumBox.ForeColor = Color.Green
        End If
    End Sub

    '...........................Imei ReadBox Code.............................'
    Private Sub ImeiWrBox_TextChanged(sender As Object, e As EventArgs) Handles ImeiWrBox.TextChanged
        imei = IMEIChecksum("" + ImeiWrBox.Text)
        ImeiRdBox.Text = ImeiWrBox.Text + imei
    End Sub

    '...........................Copy Imei Number Code.............................'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetText(ImeiRdBox.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
