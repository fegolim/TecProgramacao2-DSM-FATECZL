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
        Me.LblName = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.BtOk = New System.Windows.Forms.Button()
        Me.BtSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(49, 30)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(86, 13)
        Me.LblName.TabIndex = 0
        Me.LblName.Text = "Digite seu nome:"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(52, 57)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(283, 20)
        Me.TxtNome.TabIndex = 1
        '
        'BtOk
        '
        Me.BtOk.Location = New System.Drawing.Point(52, 101)
        Me.BtOk.Name = "BtOk"
        Me.BtOk.Size = New System.Drawing.Size(75, 23)
        Me.BtOk.TabIndex = 2
        Me.BtOk.Text = "Ok"
        Me.BtOk.UseVisualStyleBackColor = True
        '
        'BtSair
        '
        Me.BtSair.Location = New System.Drawing.Point(178, 101)
        Me.BtSair.Name = "BtSair"
        Me.BtSair.Size = New System.Drawing.Size(75, 23)
        Me.BtSair.TabIndex = 3
        Me.BtSair.Text = "Sair"
        Me.BtSair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 160)
        Me.Controls.Add(Me.BtSair)
        Me.Controls.Add(Me.BtOk)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.LblName)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblName As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents BtOk As Button
    Friend WithEvents BtSair As Button
End Class
