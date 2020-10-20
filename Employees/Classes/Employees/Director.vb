Namespace Classes.Employees
    Public Class Director
        Inherits Employee
#Region "Constructors/Construtores"
        Public Sub New(Nome As String, CPF_ As String, Salario As Double)
            MyBase.New(Nome, CPF_, Salario)
        End Sub
#End Region
#Region "Methods/Métodos"
        ' Director Anual Bonification
        ' Bonificação Anual do Diretor
        Public Overrides Function GetBonus() As Double
            Return Salario * 0.5
        End Function

        ' Increase Salary
        ' Aumento de Salário
        Public Overrides Function IncreaseSalary() As Double
            Return Salario + (Salario * 1.1)
        End Function
#End Region
    End Class
End Namespace
