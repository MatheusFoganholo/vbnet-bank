Namespace MazeBank
    Public Class Cliente
#Region "Properties/Propriedades"
        ' Name
        Public Property Nome As String

        ' CPF
        Private NumeroCPF As String
        Public Property CPF As String
            Get
                Return NumeroCPF
            End Get
            Set(value As String)
                NumeroCPF = TestaCPF(value)
            End Set
        End Property

        ' Job / Profissão
        Public Property Profissao As String

        ' City / Cidade
        Public Property Cidade As String
#End Region
#Region "Methods and Functions/Métodos e Funções"
        ' Validating CPF / Validando CPF
        Private Function TestaCPF(CPF As String) As String
            Dim dadosArray() As String = {"11111111111", "22222222222", "33333333333", "44444444444", "55555555555", "66666666666", "77777777777", "88888888888", "99999999999"}
            Dim vResultado As Boolean = True
            Dim i, x, n1, n2 As Integer
            CPF = CPF.Trim
            For i = 0 To dadosArray.Length - 1
                If CPF.Length <> 11 Or dadosArray(i).Equals(CPF) Then
                    vResultado = False
                End If
            Next
            If vResultado = False Then
                Return "00000000000"
            Else
                For x = 0 To 1
                    n1 = 0
                    For i = 0 To 8 + x
                        n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)
                    Next
                    n2 = 11 - (n1 - (Int(n1 / 11) * 11))
                    If n2 = 10 Or n2 = 11 Then n2 = 0
                    If n2 <> Val(CPF.Substring(9 + x, 1)) Then
                        vResultado = False
                        Exit For
                    End If
                Next
                If vResultado = False Then
                    Return "00000000000"
                End If
            End If
            Return CPF
        End Function
#End Region
    End Class
End Namespace


