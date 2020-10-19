Public Class Employee
#Region "Properties/Propriedades"
    Public Property Name As String
    Public Property CPF As String
    Public Property Salary As Double
#End Region
#Region "Methods/Métodos"
    ' Employee Anual Bonification
    ' Bonificação Anual do Funcionário
    Public Function GetBonus() As Double
        Return Salary * 0.1
    End Function
#End Region

End Class
