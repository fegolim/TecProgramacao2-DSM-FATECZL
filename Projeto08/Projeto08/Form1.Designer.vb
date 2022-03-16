<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.TxtAltura = New System.Windows.Forms.TextBox()
        Me.BtIMC = New System.Windows.Forms.Button()
        Me.BtLimpar = New System.Windows.Forms.Button()
        Me.BtSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculadora de IMC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Peso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Altura"
        '
        'TxtPeso
        '
        Me.TxtPeso.Location = New System.Drawing.Point(49, 76)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(100, 20)
        Me.TxtPeso.TabIndex = 3
        '
        'TxtAltura
        '
        Me.TxtAltura.Location = New System.Drawing.Point(239, 76)
        Me.TxtAltura.Name = "TxtAltura"
        Me.TxtAltura.Size = New System.Drawing.Size(100, 20)
        Me.TxtAltura.TabIndex = 4
        '
        'BtIMC
        '
        Me.BtIMC.Location = New System.Drawing.Point(74, 121)
        Me.BtIMC.Name = "BtIMC"
        Me.BtIMC.Size = New System.Drawing.Size(75, 23)
        Me.BtIMC.TabIndex = 5
        Me.BtIMC.Text = "Calcular IMC"
        Me.BtIMC.UseVisualStyleBackColor = True
        '
        'BtLimpar
        '
        Me.BtLimpar.Location = New System.Drawing.Point(155, 121)
        Me.BtLimpar.Name = "BtLimpar"
        Me.BtLimpar.Size = New System.Drawing.Size(75, 23)
        Me.BtLimpar.TabIndex = 6
        Me.BtLimpar.Text = "Limpar"
        Me.BtLimpar.UseVisualStyleBackColor = True
        '
        'BtSair
        '
        Me.BtSair.Location = New System.Drawing.Point(236, 121)
        Me.BtSair.Name = "BtSair"
        Me.BtSair.Size = New System.Drawing.Size(75, 23)
        Me.BtSair.TabIndex = 7
        Me.BtSair.Text = "Sair"
        Me.BtSair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 166)
        Me.Controls.Add(Me.BtSair)
        Me.Controls.Add(Me.BtLimpar)
        Me.Controls.Add(Me.BtIMC)
        Me.Controls.Add(Me.TxtAltura)
        Me.Controls.Add(Me.TxtPeso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPeso As TextBox
    Friend WithEvents TxtAltura As TextBox
    Friend WithEvents BtIMC As Button
    Friend WithEvents BtLimpar As Button
    Friend WithEvents BtSair As Button
End Class
