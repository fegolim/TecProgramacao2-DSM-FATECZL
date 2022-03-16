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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtConta = New System.Windows.Forms.TextBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.TxtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.TxtAniversario = New System.Windows.Forms.TextBox()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.TxtSaldoFinal = New System.Windows.Forms.TextBox()
        Me.BtCriar = New System.Windows.Forms.Button()
        Me.BtDepositar = New System.Windows.Forms.Button()
        Me.BtSacar = New System.Windows.Forms.Button()
        Me.BtSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Saldo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(183, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Aniversário"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Valor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Saldo"
        '
        'TxtConta
        '
        Me.TxtConta.Location = New System.Drawing.Point(56, 16)
        Me.TxtConta.Name = "TxtConta"
        Me.TxtConta.Size = New System.Drawing.Size(100, 20)
        Me.TxtConta.TabIndex = 6
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(248, 16)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(100, 20)
        Me.TxtCliente.TabIndex = 7
        '
        'TxtSaldoInicial
        '
        Me.TxtSaldoInicial.Location = New System.Drawing.Point(56, 47)
        Me.TxtSaldoInicial.Name = "TxtSaldoInicial"
        Me.TxtSaldoInicial.Size = New System.Drawing.Size(100, 20)
        Me.TxtSaldoInicial.TabIndex = 8
        '
        'TxtAniversario
        '
        Me.TxtAniversario.Location = New System.Drawing.Point(248, 47)
        Me.TxtAniversario.Name = "TxtAniversario"
        Me.TxtAniversario.Size = New System.Drawing.Size(100, 20)
        Me.TxtAniversario.TabIndex = 9
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(19, 152)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(100, 20)
        Me.TxtValor.TabIndex = 10
        '
        'TxtSaldoFinal
        '
        Me.TxtSaldoFinal.Location = New System.Drawing.Point(225, 152)
        Me.TxtSaldoFinal.Name = "TxtSaldoFinal"
        Me.TxtSaldoFinal.Size = New System.Drawing.Size(100, 20)
        Me.TxtSaldoFinal.TabIndex = 11
        '
        'BtCriar
        '
        Me.BtCriar.Location = New System.Drawing.Point(132, 84)
        Me.BtCriar.Name = "BtCriar"
        Me.BtCriar.Size = New System.Drawing.Size(75, 23)
        Me.BtCriar.TabIndex = 12
        Me.BtCriar.Text = "Criar"
        Me.BtCriar.UseVisualStyleBackColor = True
        '
        'BtDepositar
        '
        Me.BtDepositar.Location = New System.Drawing.Point(132, 123)
        Me.BtDepositar.Name = "BtDepositar"
        Me.BtDepositar.Size = New System.Drawing.Size(75, 23)
        Me.BtDepositar.TabIndex = 13
        Me.BtDepositar.Text = "Depositar"
        Me.BtDepositar.UseVisualStyleBackColor = True
        '
        'BtSacar
        '
        Me.BtSacar.Location = New System.Drawing.Point(132, 152)
        Me.BtSacar.Name = "BtSacar"
        Me.BtSacar.Size = New System.Drawing.Size(75, 23)
        Me.BtSacar.TabIndex = 14
        Me.BtSacar.Text = "Sacar"
        Me.BtSacar.UseVisualStyleBackColor = True
        '
        'BtSair
        '
        Me.BtSair.Location = New System.Drawing.Point(131, 191)
        Me.BtSair.Name = "BtSair"
        Me.BtSair.Size = New System.Drawing.Size(75, 23)
        Me.BtSair.TabIndex = 15
        Me.BtSair.Text = "Sair"
        Me.BtSair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 226)
        Me.Controls.Add(Me.BtSair)
        Me.Controls.Add(Me.BtSacar)
        Me.Controls.Add(Me.BtDepositar)
        Me.Controls.Add(Me.BtCriar)
        Me.Controls.Add(Me.TxtSaldoFinal)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.TxtAniversario)
        Me.Controls.Add(Me.TxtSaldoInicial)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.TxtConta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtConta As TextBox
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents TxtSaldoInicial As TextBox
    Friend WithEvents TxtAniversario As TextBox
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents TxtSaldoFinal As TextBox
    Friend WithEvents BtCriar As Button
    Friend WithEvents BtDepositar As Button
    Friend WithEvents BtSacar As Button
    Friend WithEvents BtSair As Button
End Class
