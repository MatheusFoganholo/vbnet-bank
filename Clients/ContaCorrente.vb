Imports Clients.MazeBank

Public Class ContaCorrente
#Region "Constructors/Construtores"
    Public Sub New(NomeBanco As String, NAgencia As Short, NConta As Integer, SaldoAtual As Double)
        NomeDoBanco = NomeBanco
        Agencia = NAgencia
        Conta = NConta
        Saldo = SaldoAtual
    End Sub
#End Region

#Region "Properties/Propriedades"
    ' Person/Titular
    Public Property Titular As Cliente
    ' Bank Name/Nome do Banco
    Public Property NomeDoBanco As String = "Banco do Brasil"
    ' Agency/Agência
    Public Property Agencia As Short = 1234
    ' Account Number/Número da Conta
    Public Property Conta As Integer
    ' Balance/Saldo
    Private SaldoAtual As Double = 0
    Public Property Saldo As Double
        Get
            Return SaldoAtual
        End Get
        Set(value As Double)
            If value < 0 Then
                SaldoAtual = 0
            Else
                SaldoAtual = value
            End If
        End Set
    End Property
    ' Extract/Extrato
    Public Property Extrato As String
#End Region

#Region "Methods/Métodos"
    ' Função Sacar
    ' Withdraw function
    Public Function Sacar(ValorSacar As Double) As Boolean
        Dim retorno As Boolean
        If SaldoAtual < ValorSacar Then
            retorno = False
        Else
            SaldoAtual -= ValorSacar
            retorno = True
        End If
        Return retorno
    End Function

    ' Método de Depósito
    ' Deposit Method
    Public Sub Depositar(ValorDeposito As Double)
        SaldoAtual += ValorDeposito
    End Sub

    ' Função de Transferência
    ' Transfer function
    Public Function Transferir(ValorTransferencia As Double, ByRef ContaDestino As ContaCorrente) As Boolean
        Dim Retorno As Boolean
        If SaldoAtual < ValorTransferencia Or ValorTransferencia <= 0 Then
            Retorno = False
        Else
            SaldoAtual -= ValorTransferencia
            ContaDestino.Depositar(ValorTransferencia)
            Retorno = True
        End If
        Return Retorno
    End Function
#End Region

End Class