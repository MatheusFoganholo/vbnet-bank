Imports POO.MazeBank

Public Class ContaCorrente

    Public Titular As Cliente
    Public NomeDoBanco As String = "Banco do Brasil"
    Public Agencia As Short = 1234
    Public Conta As Integer = 0
    Public Saldo As Double = 0
    Public Extrato As String = ""

    ' Função Sacar
    ' Withdraw function
    Public Function Sacar(ValorSacar As Double) As Boolean
        Dim retorno As Boolean
        If Saldo < ValorSacar Then
            retorno = False
        Else
            Saldo -= ValorSacar
            retorno = True
        End If
        Return retorno
    End Function

    ' Método de Depósito
    ' Deposit Method
    Public Sub Depositar(ValorDeposito As Double)
        Saldo += ValorDeposito
    End Sub

    ' Função de Transferência
    ' Transfer function
    Public Function Transferir(ValorTransferencia As Double, ByRef ContaDestino As ContaCorrente) As Boolean
        Dim Retorno As Boolean
        If Saldo < ValorTransferencia Or ValorTransferencia <= 0 Then
            Retorno = False
        Else
            Saldo -= ValorTransferencia
            ContaDestino.Depositar(ValorTransferencia)
            Retorno = True
        End If
        Return Retorno
    End Function

End Class