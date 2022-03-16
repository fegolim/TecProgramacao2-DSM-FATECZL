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
        Me.LbIdade1 = New System.Windows.Forms.Label()
        Me.LbIdade2 = New System.Windows.Forms.Label()
        Me.BtComp = New System.Windows.Forms.Button()
        Me.BtLimp = New System.Windows.Forms.Button()
        Me.TxtIdade1 = New System.Windows.Forms.TextBox()
        Me.TxtIdade2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LbIdade1
        '
        Me.LbIdade1.AutoSize = True
        Me.LbIdade1.Location = New System.Drawing.Point(75, 46)
        Me.LbIdade1.Name = "LbIdade1"
        Me.LbIdade1.Size = New System.Drawing.Size(77, 13)
        Me.LbIdade1.TabIndex = 0
        Me.LbIdade1.Text = "Primeira Idade:"
        '
        'LbIdade2
        '
        Me.LbIdade2.AutoSize = True
        Me.LbIdade2.Location = New System.Drawing.Point(75, 77)
        Me.LbIdade2.Name = "LbIdade2"
        Me.LbIdade2.Size = New System.Drawing.Size(83, 13)
        Me.LbIdade2.TabIndex = 1
        Me.LbIdade2.Text = "Segunda Idade:"
        '
        'BtComp
        '
        Me.BtComp.Location = New System.Drawing.Point(43, 110)
        Me.BtComp.Name = "BtComp"
        Me.BtComp.Size = New System.Drawing.Size(109, 23)
        Me.BtComp.TabIndex = 2
        Me.BtComp.Text = "Comparar Idades"
        Me.BtComp.UseVisualStyleBackColor = True
        '
        'BtLimp
        '
        Me.BtLimp.Location = New System.Drawing.Point(170, 110)
        Me.BtLimp.Name = "BtLimp"
        Me.BtLimp.Size = New System.Drawing.Size(109, 23)
        Me.BtLimp.TabIndex = 3
        Me.BtLimp.Text = "Limpar dados"
        Me.BtLimp.UseVisualStyleBackColor = True
        '
        'TxtIdade1
        '
        Me.TxtIdade1.Location = New System.Drawing.Point(158, 39)
        Me.TxtIdade1.Name = "TxtIdade1"
        Me.TxtIdade1.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdade1.TabIndex = 4
        '
        'TxtIdade2
        '
        Me.TxtIdade2.Location = New System.Drawing.Point(158, 70)
        Me.TxtIdade2.Name = "TxtIdade2"
        Me.TxtIdade2.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdade2.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 161)
        Me.Controls.Add(Me.TxtIdade2)
        Me.Controls.Add(Me.TxtIdade1)
        Me.Controls.Add(Me.BtLimp)
        Me.Controls.Add(Me.BtComp)
        Me.Controls.Add(Me.LbIdade2)
        Me.Controls.Add(Me.LbIdade1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbIdade1 As Label
    Friend WithEvents LbIdade2 As Label
    Friend WithEvents BtComp As Button
    Friend WithEvents BtLimp As Button
    Friend WithEvents TxtIdade1 As TextBox
    Friend WithEvents TxtIdade2 As TextBox
End Class
