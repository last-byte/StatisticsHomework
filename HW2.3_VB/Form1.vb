Imports System.IO


Public Class Form1
    Public Class Student
        Public Name As String
        Public Height As Double

    End Class

    Dim HeightMean As New List(Of Double)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Path As String = "..\..\..\StudentClass.csv"
        Using R As New StreamReader(Path)
            Do While Not R.EndOfStream

                Dim Line As String = R.ReadLine()
                Dim Value() As String = Line.Split(",".ToCharArray, StringSplitOptions.None)
                Me.TextBox2.AppendText(Line & Environment.NewLine)
                Try
                    HeightMean.Add(CDbl(Value(1)))
                Catch ex As Exception
                    Continue Do
                End Try

            Loop

        End Using


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TextBox1.AppendText(HeightMean.Average() & Environment.NewLine)
    End Sub
End Class
