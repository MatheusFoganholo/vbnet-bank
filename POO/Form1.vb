Public Class Main
    ReadOnly Conta01 As New ContaCorrente
    ReadOnly Conta02 As New ContaCorrente

    Public Sub New()
        InitializeComponent()
        ' Account 01 - Conta 01
        Conta01.Titular = "Matheus Foganholo"
        Conta01.NomeDoBanco = "NuBank"
        Conta01.Agencia = 1234
        Conta01.Conta = 5772992
        Conta01.Saldo = 5000
        tb_saldo.Text = FormatNumber(Conta01.Saldo, 2)
        gb_details.Text = $"Bem-vindo, {Conta01.Titular}{vbCrLf}Banco: {Conta01.NomeDoBanco}{vbCrLf}Agência: {Conta01.Agencia}{vbCrLf}Número da conta: {Conta01.Conta}"

        ' Account 02 - Conta 02
        Conta02.Titular = "Elís Peruchi"
        Conta02.NomeDoBanco = "Inter"
        Conta02.Agencia = 1234
        Conta02.Conta = 2202219
        Conta02.Saldo = 10000
        tb_saldo_2.Text = FormatNumber(Conta02.Saldo, 2)
        gb_details_2.Text = $"Bem-vinda, {Conta02.Titular}{vbCrLf}Banco: {Conta02.NomeDoBanco}{vbCrLf}Agência: {Conta02.Agencia}{vbCrLf}Número da conta: {Conta02.Conta}"
    End Sub

    ' Withdraw - Account 01
    ' Sacar - Account 01
    Public Sub btn_sacar_Click(sender As Object, e As EventArgs) Handles btn_sacar.Click

        Dim valorSaque As Double = Val(tb_valor.Text)
        Dim RetornoSaque As Boolean = Conta01.Sacar(valorSaque)

        If valorSaque.ToString = "" Or valorSaque <= 0 Then
            tb_valor.Text = ""
            MsgBox($"É impossível sacar essa quantia, digite um valor válido!", MsgBoxStyle.Critical, "Resultado do saque")
        Else
            If RetornoSaque = True Then
                tb_saldo.Text = FormatNumber(Conta01.Saldo, 2)
                tb_valor.Text = ""
                Conta01.Extrato += $"{Now} - Saque de R$ {FormatNumber(valorSaque, 2)} realizado. Saldo restante: R$ {FormatNumber(Conta01.Saldo, 2)}{vbCrLf}---------------------------------------------------{vbCrLf}"
                tb_extrato.Text = Conta01.Extrato
                MsgBox($"Você sacou R$ {FormatNumber(valorSaque, 2)} e restaram R$ {FormatNumber(Conta01.Saldo, 2)} em sua conta corrente.", MsgBoxStyle.Information, "Resultado do saque")
            Else
                tb_valor.Text = ""
                MsgBox($"Você tentou sacar um valor maior do que o seu saldo. Digite um valor válido.", MsgBoxStyle.Critical, "Resultado do saque")
            End If
        End If
    End Sub

    ' Deposit - Account 01
    ' Depositar - Account 01
    Private Sub btn_deposito_Click(sender As Object, e As EventArgs) Handles btn_deposito.Click
        Dim ValorDepositar As Double = Val(tb_valor.Text)

        If tb_valor.Text = "" Or ValorDepositar <= 0 Then
            MsgBox("É impossível depositar essa quantia. Digite um valor válido.", MsgBoxStyle.Critical)
        Else
            Conta01.Depositar(ValorDepositar)
            tb_saldo.Text = FormatNumber(Conta01.Saldo, 2)
            tb_valor.Text = ""
            Conta01.Extrato += $"{Now} - Depósito de R$ {FormatNumber(ValorDepositar, 2)} realizado. Saldo atual: R$ {FormatNumber(Conta01.Saldo, 2)}{vbCrLf}---------------------------------------------------{vbCrLf}"
            tb_extrato.Text = Conta01.Extrato
            MsgBox($"Depósito de R$ {FormatNumber(ValorDepositar, 2)} efetuado com sucesso!", MsgBoxStyle.Information, "Resultado do depósito")
        End If
    End Sub

    ' Transfer - Account 01
    ' Transferir - Conta 01
    Private Sub btn_transferir_Click(sender As Object, e As EventArgs) Handles btn_transferir.Click
        Dim ValorTransferencia As Double = Val(tb_valor.Text)
        Dim RetornoTransferencia As Boolean = Conta01.Transferir(ValorTransferencia, Conta02)

        If RetornoTransferencia = False Then
            If ValorTransferencia > Conta02.Saldo Then
                MsgBox("É impossível transferir um valor maior do que o seu saldo. Digite um valor válido", MsgBoxStyle.Critical)
            Else
                MsgBox("Impossível transferir essa quantia. Digite um valor válido!", MsgBoxStyle.Critical)
            End If
        Else
            tb_saldo.Text = Conta01.Saldo
                tb_saldo_2.Text = Conta02.Saldo
            Conta01.Extrato += $"{Now} - Transferência de R$ {FormatNumber(ValorTransferencia, 2)} realizada para {Conta02.Titular}. Saldo restante: R$ {FormatNumber(Conta01.Saldo, 2)}{vbCrLf}---------------------------------------------------{vbCrLf}"
            Conta02.Extrato += $"{Now} - Transferência de R$ {FormatNumber(ValorTransferencia, 2)} recebida de {Conta01.Titular}. Saldo atual: R$ {FormatNumber(Conta02.Saldo, 2)}{vbCrLf}---------------------------------------------------{vbCrLf}"
            tb_extrato.Text = Conta01.Extrato
                tb_extrato_2.Text = Conta02.Extrato
            MsgBox($"Transfêrencia de R$ {FormatNumber(ValorTransferencia, 2)} para {Conta02.Titular} efetuada com sucesso!", MsgBoxStyle.Information)

        End If
    End Sub

    ' Withdraw - Account 02
    ' Sacar - Conta 02
    Public Sub btn_sacar_2_Click(sender As Object, e As EventArgs) Handles btn_sacar_2.Click

        Dim valorSaque As Double = Val(tb_valor_2.Text)
        Dim RetornoSaque As Boolean = Conta02.Sacar(valorSaque)

        If valorSaque.ToString = "" Or valorSaque <= 0 Then
            tb_valor_2.Text = ""
            MsgBox($"É impossível sacar essa quantia, digite um valor válido!", MsgBoxStyle.Critical, "Resultado do saque")
        Else
            If RetornoSaque = True Then
                tb_saldo_2.Text = FormatNumber(Conta02.Saldo, 2)
                tb_valor_2.Text = ""
                Conta02.Extrato += $"{Now} - Saque de R$ {FormatNumber(valorSaque, 2)} realizado. Saldo restante: R$ {FormatNumber(Conta02.Saldo, 2)}{vbCrLf}---------------------------------------------------{vbCrLf}"
                tb_extrato_2.Text = Conta02.Extrato
                MsgBox($"Você sacou R$ {FormatNumber(valorSaque, 2)} e restaram R$ {FormatNumber(Conta02.Saldo, 2)} em sua conta corrente.", MsgBoxStyle.Information, "Resultado do saque")
            Else
                tb_valor.Text = ""
                MsgBox($"Você tentou sacar um valor maior do que o seu saldo. Digite um valor válido.", MsgBoxStyle.Critical, "Resultado do saque")
            End If
        End If
    End Sub

    ' Deposit - Account 02
    ' Depósitar - Conta 02
    Private Sub btn_deposito_2_Click(sender As Object, e As EventArgs) Handles btn_deposito_2.Click
        Dim ValorDepositar As Double = Val(tb_valor_2.Text)

        If tb_valor_2.Text = "" Or ValorDepositar <= 0 Then
            MsgBox("É impossível depositar essa quantia. Digite um valor válido.", MsgBoxStyle.Critical)
        Else
            Conta02.Depositar(ValorDepositar)
            tb_saldo_2.Text = FormatNumber(Conta02.Saldo, 2)
            tb_valor_2.Text = ""
            Conta02.Extrato += $"{Now} - Depósito de R$ {FormatNumber(ValorDepositar, 2)} realizado. Saldo atual: R$ {FormatNumber(Conta02.Saldo, 2)}{vbCrLf}---------------------------------------------------{vbCrLf}"
            tb_extrato_2.Text = Conta02.Extrato
            MsgBox($"Depósito de R$ {FormatNumber(ValorDepositar, 2)} efetuado com sucesso!", MsgBoxStyle.Information, "Resultado do depósito")
        End If
    End Sub

    ' Transfer - Account 02
    ' Transferir - Conta 02
    Private Sub btn_transferir_2_Click(sender As Object, e As EventArgs) Handles btn_transferir_2.Click
        Dim ValorTransferencia As Double = Val(tb_valor_2.Text)
        Dim RetornoTransferencia As Boolean = Conta02.Transferir(ValorTransferencia, Conta01)

        If RetornoTransferencia = False Then
            If ValorTransferencia > Conta02.Saldo Then
                MsgBox("É impossível transferir um valor maior do que o seu saldo. Digite um valor válido", MsgBoxStyle.Critical)
            Else
                MsgBox("Impossível transferir essa quantia. Digite um valor válido!", MsgBoxStyle.Critical)
            End If
        Else
            tb_saldo.Text = Conta01.Saldo
            tb_saldo_2.Text = Conta02.Saldo
            Conta01.Extrato += $"{Now} - Transferência de R$ {FormatNumber(ValorTransferencia, 2)} recebida de {Conta02.Titular}. Saldo atual: R$ {FormatNumber(Conta01.Saldo, 2)}{vbCrLf}---------------------------------------------------{vbCrLf}"
            Conta02.Extrato += $"{Now} - Transferência de R$ {FormatNumber(ValorTransferencia, 2)} realizada para {Conta01.Titular}. Saldo restante: R$ {FormatNumber(Conta02.Saldo, 2)}{vbCrLf}---------------------------------------------------{vbCrLf}"
            tb_extrato.Text = Conta01.Extrato
            tb_extrato_2.Text = Conta02.Extrato
            MsgBox($"Transfêrencia de R$ {FormatNumber(ValorTransferencia, 2)} para {Conta01.Titular} efetuada com sucesso!", MsgBoxStyle.Information)
        End If
    End Sub

End Class
