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
        Me.TxtRgmAluno = New System.Windows.Forms.TextBox()
        Me.TxtNomeAluno = New System.Windows.Forms.TextBox()
        Me.BtExibirAluno = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtProfTitulo = New System.Windows.Forms.TextBox()
        Me.TxtNomeProf = New System.Windows.Forms.TextBox()
        Me.BtExibirProf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aluno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RGM:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome:"
        '
        'TxtRgmAluno
        '
        Me.TxtRgmAluno.Location = New System.Drawing.Point(70, 58)
        Me.TxtRgmAluno.Name = "TxtRgmAluno"
        Me.TxtRgmAluno.Size = New System.Drawing.Size(211, 20)
        Me.TxtRgmAluno.TabIndex = 3
        '
        'TxtNomeAluno
        '
        Me.TxtNomeAluno.Location = New System.Drawing.Point(70, 81)
        Me.TxtNomeAluno.Name = "TxtNomeAluno"
        Me.TxtNomeAluno.Size = New System.Drawing.Size(292, 20)
        Me.TxtNomeAluno.TabIndex = 4
        '
        'BtExibirAluno
        '
        Me.BtExibirAluno.Location = New System.Drawing.Point(287, 55)
        Me.BtExibirAluno.Name = "BtExibirAluno"
        Me.BtExibirAluno.Size = New System.Drawing.Size(75, 23)
        Me.BtExibirAluno.TabIndex = 5
        Me.BtExibirAluno.Text = "Exibir"
        Me.BtExibirAluno.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Professor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Título:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nome:"
        '
        'TxtProfTitulo
        '
        Me.TxtProfTitulo.Location = New System.Drawing.Point(70, 152)
        Me.TxtProfTitulo.Name = "TxtProfTitulo"
        Me.TxtProfTitulo.Size = New System.Drawing.Size(211, 20)
        Me.TxtProfTitulo.TabIndex = 9
        '
        'TxtNomeProf
        '
        Me.TxtNomeProf.Location = New System.Drawing.Point(70, 178)
        Me.TxtNomeProf.Name = "TxtNomeProf"
        Me.TxtNomeProf.Size = New System.Drawing.Size(292, 20)
        Me.TxtNomeProf.TabIndex = 10
        '
        'BtExibirProf
        '
        Me.BtExibirProf.Location = New System.Drawing.Point(287, 149)
        Me.BtExibirProf.Name = "BtExibirProf"
        Me.BtExibirProf.Size = New System.Drawing.Size(75, 23)
        Me.BtExibirProf.TabIndex = 11
        Me.BtExibirProf.Text = "Exibir"
        Me.BtExibirProf.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 229)
        Me.Controls.Add(Me.BtExibirProf)
        Me.Controls.Add(Me.TxtNomeProf)
        Me.Controls.Add(Me.TxtProfTitulo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtExibirAluno)
        Me.Controls.Add(Me.TxtNomeAluno)
        Me.Controls.Add(Me.TxtRgmAluno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtRgmAluno As TextBox
    Friend WithEvents TxtNomeAluno As TextBox
    Friend WithEvents BtExibirAluno As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtProfTitulo As TextBox
    Friend WithEvents TxtNomeProf As TextBox
    Friend WithEvents BtExibirProf As Button
End Class
