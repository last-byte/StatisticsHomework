<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ButtonMeanVariance = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.RichTextBoxM_V = New System.Windows.Forms.RichTextBox()
        Me.TextBoxN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChartMean = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.ChartMean, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonMeanVariance
        '
        Me.ButtonMeanVariance.Location = New System.Drawing.Point(282, 14)
        Me.ButtonMeanVariance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonMeanVariance.Name = "ButtonMeanVariance"
        Me.ButtonMeanVariance.Size = New System.Drawing.Size(224, 98)
        Me.ButtonMeanVariance.TabIndex = 0
        Me.ButtonMeanVariance.Text = "Calculate mean and variance"
        Me.ButtonMeanVariance.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Location = New System.Drawing.Point(1253, 949)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(224, 98)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "Terminate program"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'RichTextBoxM_V
        '
        Me.RichTextBoxM_V.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxM_V.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxM_V.Location = New System.Drawing.Point(514, 14)
        Me.RichTextBoxM_V.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RichTextBoxM_V.Name = "RichTextBoxM_V"
        Me.RichTextBoxM_V.Size = New System.Drawing.Size(688, 96)
        Me.RichTextBoxM_V.TabIndex = 3
        Me.RichTextBoxM_V.Text = ""
        '
        'TextBoxN
        '
        Me.TextBoxN.Location = New System.Drawing.Point(18, 39)
        Me.TextBoxN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxN.Name = "TextBoxN"
        Me.TextBoxN.Size = New System.Drawing.Size(134, 31)
        Me.TextBoxN.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Number of throws"
        '
        'ChartMean
        '
        Me.ChartMean.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.ChartMean.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartMean.Legends.Add(Legend1)
        Me.ChartMean.Location = New System.Drawing.Point(18, 122)
        Me.ChartMean.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChartMean.Name = "ChartMean"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Throws results"
        Me.ChartMean.Series.Add(Series1)
        Me.ChartMean.Size = New System.Drawing.Size(1184, 925)
        Me.ChartMean.TabIndex = 7
        Me.ChartMean.Text = "Chart1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1490, 1061)
        Me.Controls.Add(Me.ChartMean)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxN)
        Me.Controls.Add(Me.RichTextBoxM_V)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonMeanVariance)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Dice throw mean and variance"
        CType(Me.ChartMean, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonMeanVariance As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents RichTextBoxM_V As RichTextBox
    Friend WithEvents TextBoxN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ChartMean As DataVisualization.Charting.Chart
End Class
