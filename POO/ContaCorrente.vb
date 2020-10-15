Public Class ContaCorrente

    Public Titular As String = "Nome Indefinido"
    Public NomeDoBanco As String = "Banco do Brasil"
    Public Agencia As Short = 1234
    Public Conta As Integer = 0
    Public Saldo As Double = 0
    Public Extrato As String = ""

    ' Função Sacar
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
    Public Sub Depositar(ValorDeposito As Double)
        Saldo += ValorDeposito
    End Sub


End Class