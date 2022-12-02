Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Dim n = 12
    'Dim coin As New List(Of String)({"T", "C"})

    Function CheckLimit()
        If String.IsNullOrEmpty(TextBoxLambda.Text) Then
            MsgBox("Insert Lambda into Box (es. 1,...,100)")
            Return False
        End If
        Return True
    End Function
    Function Factorial(n As Integer) As Integer
        If n <= 1 Then
            Return 1
        End If
        Return Factorial(n - 1) * n
    End Function
    Private Sub ButtonIteration_Click(sender As Object, e As EventArgs) Handles ButtonIteration.Click
        Chart.Titles.Clear()
        Chart.Series.Clear()
        If CheckLimit() Then
            Try
                'CHART
                Chart.Titles.Add("Discrete distribution function")
                Dim s As New Series
                Dim lambda = CInt(TextBoxLambda.Text)
                Dim p = lambda / 100
                Dim q As Double = 1 - p
                Console.WriteLine(p & " " & q)
                s.Name = "p: " & p & "\nn: " & n
                'Change to a line graph.
                s.ChartType = SeriesChartType.Point
                For k As Integer = 0 To n
                    Dim factorial_n = Factorial(n)
                    Console.WriteLine(factorial_n)
                    Dim factorial_k = Factorial(k) * Factorial(n - k)
                    Console.WriteLine(factorial_k)
                    Dim fraction_fact_n_fact_k As Double = factorial_n / factorial_k
                    Dim value = fraction_fact_n_fact_k * Math.Pow(p, k) * Math.Pow(q, n - k)
                    Console.WriteLine(value)
                    s.Points.AddXY(k, value)
                Next
                Chart.Series.Add(s)
            Catch ex As Exception
                MsgBox("Please insert an integer.")
            End Try
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
