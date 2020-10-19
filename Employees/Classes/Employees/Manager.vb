Namespace Classes.Employees
    Public Class Manager
        Inherits Employee
#Region "Constructors/Construtores"
        Public Sub New(Nome As String, CPF_ As String, Salario As Double)
            MyBase.New(Nome, CPF_, Salario)
        End Sub
#End Region
#Region "Methods/Métodos"
        ' Manager Anual Bonification
        ' Bonificação Anual do Gerente
        Public Overrides Function GetBonus() As Double
            Return Salary * 0.3
        End Function
#End Region
    End Class
End Namespace
