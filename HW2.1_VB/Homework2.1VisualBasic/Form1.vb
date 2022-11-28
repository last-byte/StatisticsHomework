Imports System.Security.Cryptography.X509Certificates

Public Class Form1

    Public R As New Random

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Timer1.Start()



    End Sub


    Public i As Integer
    Public CurrentArithmeticMean As Double = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'a new observation from the stream'
        i = i + 1
        Dim NameOfTheFemaleStudent = "Student " & i
        Dim HeightoftheFemaleStudent As Double = Me.R.Next(155, 180)

        'update the mean'
        CurrentArithmeticMean = CurrentArithmeticMean + (HeightoftheFemaleStudent - CurrentArithmeticMean) / i
        Me.RichTextBox1.AppendText(NameOfTheFemaleStudent.PadRight(10) &
                                   "  " & HeightoftheFemaleStudent & "cm" &
                                   " current mean:" & CurrentArithmeticMean &
                                   Environment.NewLine)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Timer1.Stop()
    End Sub
End Class
