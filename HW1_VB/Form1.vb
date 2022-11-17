Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        RichTextBox1.Text = ComputerName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UserName As String
        UserName = SystemInformation.UserName
        RichTextBox1.Text = UserName
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class