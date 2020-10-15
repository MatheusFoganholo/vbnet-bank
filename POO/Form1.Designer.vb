<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.label_saldo = New System.Windows.Forms.Label()
        Me.tb_saldo = New System.Windows.Forms.TextBox()
        Me.label_operations = New System.Windows.Forms.Label()
        Me.tb_valor = New System.Windows.Forms.TextBox()
        Me.label_digite = New System.Windows.Forms.Label()
        Me.btn_deposito = New System.Windows.Forms.Button()
        Me.btn_sacar = New System.Windows.Forms.Button()
        Me.btn_transferir = New System.Windows.Forms.Button()
        Me.tb_extrato = New System.Windows.Forms.TextBox()
        Me.label_extrato = New System.Windows.Forms.Label()
        Me.gb_details = New System.Windows.Forms.GroupBox()
        Me.gb_details_2 = New System.Windows.Forms.GroupBox()
        Me.tb_extrato_2 = New System.Windows.Forms.TextBox()
        Me.label_extrato_2 = New System.Windows.Forms.Label()
        Me.label_saldo_2 = New System.Windows.Forms.Label()
        Me.tb_saldo_2 = New System.Windows.Forms.TextBox()
        Me.btn_transferir_2 = New System.Windows.Forms.Button()
        Me.label_operations_2 = New System.Windows.Forms.Label()
        Me.btn_sacar_2 = New System.Windows.Forms.Button()
        Me.tb_valor_2 = New System.Windows.Forms.TextBox()
        Me.btn_deposito_2 = New System.Windows.Forms.Button()
        Me.label_digite_2 = New System.Windows.Forms.Label()
        Me.gb_details.SuspendLayout()
        Me.gb_details_2.SuspendLayout()
        Me.SuspendLayout()
        '
        'label_saldo
        '
        Me.label_saldo.AutoSize = True
        Me.label_saldo.Location = New System.Drawing.Point(9, 87)
        Me.label_saldo.Name = "label_saldo"
        Me.label_saldo.Size = New System.Drawing.Size(89, 20)
        Me.label_saldo.TabIndex = 2
        Me.label_saldo.Text = "Saldo atual"
        '
        'tb_saldo
        '
        Me.tb_saldo.Enabled = False
        Me.tb_saldo.Location = New System.Drawing.Point(13, 110)
        Me.tb_saldo.Name = "tb_saldo"
        Me.tb_saldo.Size = New System.Drawing.Size(244, 26)
        Me.tb_saldo.TabIndex = 4
        '
        'label_operations
        '
        Me.label_operations.AutoSize = True
        Me.label_operations.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_operations.Location = New System.Drawing.Point(5, 164)
        Me.label_operations.Name = "label_operations"
        Me.label_operations.Size = New System.Drawing.Size(216, 46)
        Me.label_operations.TabIndex = 5
        Me.label_operations.Text = "Operações"
        '
        'tb_valor
        '
        Me.tb_valor.Location = New System.Drawing.Point(13, 249)
        Me.tb_valor.Name = "tb_valor"
        Me.tb_valor.Size = New System.Drawing.Size(244, 26)
        Me.tb_valor.TabIndex = 6
        '
        'label_digite
        '
        Me.label_digite.AutoSize = True
        Me.label_digite.Location = New System.Drawing.Point(9, 226)
        Me.label_digite.Name = "label_digite"
        Me.label_digite.Size = New System.Drawing.Size(113, 20)
        Me.label_digite.TabIndex = 7
        Me.label_digite.Text = "Digite um valor"
        '
        'btn_deposito
        '
        Me.btn_deposito.Location = New System.Drawing.Point(13, 285)
        Me.btn_deposito.Name = "btn_deposito"
        Me.btn_deposito.Size = New System.Drawing.Size(244, 42)
        Me.btn_deposito.TabIndex = 8
        Me.btn_deposito.Text = "Depositar"
        Me.btn_deposito.UseVisualStyleBackColor = True
        '
        'btn_sacar
        '
        Me.btn_sacar.Location = New System.Drawing.Point(13, 333)
        Me.btn_sacar.Name = "btn_sacar"
        Me.btn_sacar.Size = New System.Drawing.Size(244, 42)
        Me.btn_sacar.TabIndex = 9
        Me.btn_sacar.Text = "Sacar"
        Me.btn_sacar.UseVisualStyleBackColor = True
        '
        'btn_transferir
        '
        Me.btn_transferir.Location = New System.Drawing.Point(13, 381)
        Me.btn_transferir.Name = "btn_transferir"
        Me.btn_transferir.Size = New System.Drawing.Size(244, 42)
        Me.btn_transferir.TabIndex = 10
        Me.btn_transferir.Text = "Transferir"
        Me.btn_transferir.UseVisualStyleBackColor = True
        '
        'tb_extrato
        '
        Me.tb_extrato.Location = New System.Drawing.Point(293, 110)
        Me.tb_extrato.Multiline = True
        Me.tb_extrato.Name = "tb_extrato"
        Me.tb_extrato.ReadOnly = True
        Me.tb_extrato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_extrato.Size = New System.Drawing.Size(262, 313)
        Me.tb_extrato.TabIndex = 11
        '
        'label_extrato
        '
        Me.label_extrato.AutoSize = True
        Me.label_extrato.Location = New System.Drawing.Point(289, 87)
        Me.label_extrato.Name = "label_extrato"
        Me.label_extrato.Size = New System.Drawing.Size(237, 20)
        Me.label_extrato.TabIndex = 12
        Me.label_extrato.Text = "Histórico de operações (Extrato)"
        '
        'gb_details
        '
        Me.gb_details.Controls.Add(Me.tb_extrato)
        Me.gb_details.Controls.Add(Me.label_extrato)
        Me.gb_details.Controls.Add(Me.label_saldo)
        Me.gb_details.Controls.Add(Me.tb_saldo)
        Me.gb_details.Controls.Add(Me.btn_transferir)
        Me.gb_details.Controls.Add(Me.label_operations)
        Me.gb_details.Controls.Add(Me.btn_sacar)
        Me.gb_details.Controls.Add(Me.tb_valor)
        Me.gb_details.Controls.Add(Me.btn_deposito)
        Me.gb_details.Controls.Add(Me.label_digite)
        Me.gb_details.Location = New System.Drawing.Point(12, 12)
        Me.gb_details.Name = "gb_details"
        Me.gb_details.Size = New System.Drawing.Size(581, 446)
        Me.gb_details.TabIndex = 13
        Me.gb_details.TabStop = False
        Me.gb_details.Text = "Detalhes da Conta"
        '
        'gb_details_2
        '
        Me.gb_details_2.Controls.Add(Me.tb_extrato_2)
        Me.gb_details_2.Controls.Add(Me.label_extrato_2)
        Me.gb_details_2.Controls.Add(Me.label_saldo_2)
        Me.gb_details_2.Controls.Add(Me.tb_saldo_2)
        Me.gb_details_2.Controls.Add(Me.btn_transferir_2)
        Me.gb_details_2.Controls.Add(Me.label_operations_2)
        Me.gb_details_2.Controls.Add(Me.btn_sacar_2)
        Me.gb_details_2.Controls.Add(Me.tb_valor_2)
        Me.gb_details_2.Controls.Add(Me.btn_deposito_2)
        Me.gb_details_2.Controls.Add(Me.label_digite_2)
        Me.gb_details_2.Location = New System.Drawing.Point(621, 12)
        Me.gb_details_2.Name = "gb_details_2"
        Me.gb_details_2.Size = New System.Drawing.Size(581, 446)
        Me.gb_details_2.TabIndex = 14
        Me.gb_details_2.TabStop = False
        Me.gb_details_2.Text = "Detalhes da Conta"
        '
        'tb_extrato_2
        '
        Me.tb_extrato_2.Location = New System.Drawing.Point(293, 110)
        Me.tb_extrato_2.Multiline = True
        Me.tb_extrato_2.Name = "tb_extrato_2"
        Me.tb_extrato_2.ReadOnly = True
        Me.tb_extrato_2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_extrato_2.Size = New System.Drawing.Size(262, 313)
        Me.tb_extrato_2.TabIndex = 11
        '
        'label_extrato_2
        '
        Me.label_extrato_2.AutoSize = True
        Me.label_extrato_2.Location = New System.Drawing.Point(289, 87)
        Me.label_extrato_2.Name = "label_extrato_2"
        Me.label_extrato_2.Size = New System.Drawing.Size(237, 20)
        Me.label_extrato_2.TabIndex = 12
        Me.label_extrato_2.Text = "Histórico de operações (Extrato)"
        '
        'label_saldo_2
        '
        Me.label_saldo_2.AutoSize = True
        Me.label_saldo_2.Location = New System.Drawing.Point(9, 87)
        Me.label_saldo_2.Name = "label_saldo_2"
        Me.label_saldo_2.Size = New System.Drawing.Size(89, 20)
        Me.label_saldo_2.TabIndex = 2
        Me.label_saldo_2.Text = "Saldo atual"
        '
        'tb_saldo_2
        '
        Me.tb_saldo_2.Enabled = False
        Me.tb_saldo_2.Location = New System.Drawing.Point(13, 110)
        Me.tb_saldo_2.Name = "tb_saldo_2"
        Me.tb_saldo_2.Size = New System.Drawing.Size(244, 26)
        Me.tb_saldo_2.TabIndex = 4
        '
        'btn_transferir_2
        '
        Me.btn_transferir_2.Location = New System.Drawing.Point(13, 381)
        Me.btn_transferir_2.Name = "btn_transferir_2"
        Me.btn_transferir_2.Size = New System.Drawing.Size(244, 42)
        Me.btn_transferir_2.TabIndex = 10
        Me.btn_transferir_2.Text = "Transferir"
        Me.btn_transferir_2.UseVisualStyleBackColor = True
        '
        'label_operations_2
        '
        Me.label_operations_2.AutoSize = True
        Me.label_operations_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_operations_2.Location = New System.Drawing.Point(5, 164)
        Me.label_operations_2.Name = "label_operations_2"
        Me.label_operations_2.Size = New System.Drawing.Size(216, 46)
        Me.label_operations_2.TabIndex = 5
        Me.label_operations_2.Text = "Operações"
        '
        'btn_sacar_2
        '
        Me.btn_sacar_2.Location = New System.Drawing.Point(13, 333)
        Me.btn_sacar_2.Name = "btn_sacar_2"
        Me.btn_sacar_2.Size = New System.Drawing.Size(244, 42)
        Me.btn_sacar_2.TabIndex = 9
        Me.btn_sacar_2.Text = "Sacar"
        Me.btn_sacar_2.UseVisualStyleBackColor = True
        '
        'tb_valor_2
        '
        Me.tb_valor_2.Location = New System.Drawing.Point(13, 249)
        Me.tb_valor_2.Name = "tb_valor_2"
        Me.tb_valor_2.Size = New System.Drawing.Size(244, 26)
        Me.tb_valor_2.TabIndex = 6
        '
        'btn_deposito_2
        '
        Me.btn_deposito_2.Location = New System.Drawing.Point(13, 285)
        Me.btn_deposito_2.Name = "btn_deposito_2"
        Me.btn_deposito_2.Size = New System.Drawing.Size(244, 42)
        Me.btn_deposito_2.TabIndex = 8
        Me.btn_deposito_2.Text = "Depositar"
        Me.btn_deposito_2.UseVisualStyleBackColor = True
        '
        'label_digite_2
        '
        Me.label_digite_2.AutoSize = True
        Me.label_digite_2.Location = New System.Drawing.Point(9, 226)
        Me.label_digite_2.Name = "label_digite_2"
        Me.label_digite_2.Size = New System.Drawing.Size(113, 20)
        Me.label_digite_2.TabIndex = 7
        Me.label_digite_2.Text = "Digite um valor"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 469)
        Me.Controls.Add(Me.gb_details_2)
        Me.Controls.Add(Me.gb_details)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MazeBank"
        Me.gb_details.ResumeLayout(False)
        Me.gb_details.PerformLayout()
        Me.gb_details_2.ResumeLayout(False)
        Me.gb_details_2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents label_saldo As Label
    Friend WithEvents tb_saldo As TextBox
    Friend WithEvents label_operations As Label
    Friend WithEvents tb_valor As TextBox
    Friend WithEvents label_digite As Label
    Friend WithEvents btn_deposito As Button
    Friend WithEvents btn_sacar As Button
    Friend WithEvents btn_transferir As Button
    Friend WithEvents tb_extrato As TextBox
    Friend WithEvents label_extrato As Label
    Friend WithEvents gb_details As GroupBox
    Friend WithEvents gb_details_2 As GroupBox
    Friend WithEvents tb_extrato_2 As TextBox
    Friend WithEvents label_extrato_2 As Label
    Friend WithEvents label_saldo_2 As Label
    Friend WithEvents tb_saldo_2 As TextBox
    Friend WithEvents btn_transferir_2 As Button
    Friend WithEvents label_operations_2 As Label
    Friend WithEvents btn_sacar_2 As Button
    Friend WithEvents tb_valor_2 As TextBox
    Friend WithEvents btn_deposito_2 As Button
    Friend WithEvents label_digite_2 As Label
End Class
