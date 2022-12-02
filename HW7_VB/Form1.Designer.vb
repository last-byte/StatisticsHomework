<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ButtonIteration = New System.Windows.Forms.Button()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TextBoxLambda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonIteration
        '
        Me.ButtonIteration.Location = New System.Drawing.Point(18, 19)
        Me.ButtonIteration.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonIteration.Name = "ButtonIteration"
        Me.ButtonIteration.Size = New System.Drawing.Size(177, 84)
        Me.ButtonIteration.TabIndex = 7
        Me.ButtonIteration.Text = "Start"
        Me.ButtonIteration.UseVisualStyleBackColor = True
        '
        'Chart
        '
        Me.Chart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.Chart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart.Legends.Add(Legend1)
        Me.Chart.Location = New System.Drawing.Point(18, 112)
        Me.Chart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chart.Name = "Chart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = " "
        Me.Chart.Series.Add(Series1)
        Me.Chart.Size = New System.Drawing.Size(945, 822)
        Me.Chart.TabIndex = 8
        Me.Chart.Text = "Chart1"
        '
        'TextBoxLambda
        '
        Me.TextBoxLambda.Location = New System.Drawing.Point(232, 67)
        Me.TextBoxLambda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxLambda.Name = "TextBoxLambda"
        Me.TextBoxLambda.Size = New System.Drawing.Size(148, 31)
        Me.TextBoxLambda.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Lambda Value"
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(982, 850)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(177, 84)
        Me.ButtonClose.TabIndex = 12
        Me.ButtonClose.Text = "Terminate"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 953)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxLambda)
        Me.Controls.Add(Me.Chart)
        Me.Controls.Add(Me.ButtonIteration)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Sum Bernoulli Distribution"
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonIteration As Button
    Friend WithEvents Chart As DataVisualization.Charting.Chart
    Friend WithEvents TextBoxLambda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonClose As Button
End Class
