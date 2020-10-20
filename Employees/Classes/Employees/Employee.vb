Namespace Classes.Employees

    Public Class Employee
#Region "Properties/Propriedades"
        Public Property Name As String
        Private Property _CPF As String
        Public ReadOnly Property CPF As String
            Get
                Return _CPF
            End Get
        End Property
        Private Property Salary As Double
        Public Property Salario As Double
            Get
                Return Salary
            End Get
            Protected Set(value As Double)
                Salary = value
            End Set
        End Property
        Private Shared _TotalEmployees As Integer
        Public Shared ReadOnly Property TotalEmployees As Integer
            Get
                Return _TotalEmployees
            End Get
        End Property
#End Region

#Region "Constructors/Construtores"
        Public Sub New(Nome As String, CPF_ As String, Salario As Double)
            Name = Nome
            _CPF = CPF_
            Salary = Salario
            _TotalEmployees += 1
        End Sub
#End Region
#Region "Methods/Métodos"
        ' Employee Anual Bonification
        ' Bonificação Anual do Funcionário
        Public MustOverride Function GetBonus()

        ' Increase Salary
        ' Aumento de Salário
        Public MustOverride Sub IncreaseSalary()
#End Region

    End Class
End Namespace
