Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Hallo Welt"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "2. Hallo Welt"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "2. Hallo Welt" Then
            Label2.Text = "GitHub funtioniert"
        Else
            Label2.Text = " "
        End If
    End Sub
End Class
