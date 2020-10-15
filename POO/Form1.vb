Public Class Main
    ReadOnly Conta01 As New ContaCorrente

    Public Sub New()
        InitializeComponent()
        Conta01.Titular = "Matheus Foganholo"
        Conta01.NomeDoBanco = "NuBank"
        Conta01.Agencia = 1234
        Conta01.Conta = 577299
        Conta01.Saldo = 5000
        tb_saldo.Text = Conta01.Saldo
        gb_details.Text = $"Bem-vindo, {Conta01.Titular}{vbCrLf}Banco: {Conta01.NomeDoBanco}{vbCrLf}Agência: {Conta01.Agencia}{vbCrLf}Número da conta: {Conta01.Conta}"
    End Sub

    Public Sub btn_sacar_Click(sender As Object, e As EventArgs) Handles btn_sacar.Click

        Dim valorSaque As Double = Val(tb_valor.Text)
        Dim RetornoSaque As Boolean = Conta01.Sacar(valorSaque)

        If valorSaque.ToString = "" Or valorSaque <= 0 Then
            tb_valor.Text = ""
            MsgBox($"É impossível sacar essa quantia, digite um valor válido!", MsgBoxStyle.Critical, "Resultado do saque")
        Else
            If RetornoSaque = True Then
                tb_saldo.Text = Conta01.Saldo
                tb_valor.Text = ""
                MsgBox($"Você sacou R$ {FormatNumber(valorSaque, 2)} e restaram R$ {FormatNumber(Conta01.Saldo, 2)} em sua conta corrente.", MsgBoxStyle.Information, "Resultado do saque")
                Conta01.Extrato += $"{Now.ToString} - Saque de R$ {FormatNumber(valorSaque, 2)} realizado. Saldo restante: R$ {FormatNumber(Conta01.Saldo, 2)}{vbCrLf}"
                tb_extrato.Text = Conta01.Extrato
            Else
                tb_valor.Text = ""
                MsgBox($"Você tentou sacar um valor maior do que o seu saldo. Digite um valor válido.", MsgBoxStyle.Critical, "Resultado do saque")
            End If
        End If
    End Sub

    Private Sub btn_deposito_Click(sender As Object, e As EventArgs) Handles btn_deposito.Click
        Dim ValorDepositar As Double = Val(tb_valor.Text)
        Conta01.Depositar(ValorDepositar)
        tb_saldo.Text = Conta01.Saldo
        tb_valor.Text = ""
        MsgBox("Depósito efetuado com sucesso!", MsgBoxStyle.Information, "Resultado do depósito")
        Conta01.Extrato += $"{Now.ToString} - Depósito de R$ {FormatNumber(ValorDepositar, 2)} realizado. Saldo atual: R$ {FormatNumber(Conta01.Saldo, 2)}{vbCrLf}"
        tb_extrato.Text = Conta01.Extrato
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gb_details_2.Enter

    End Sub
End Class
