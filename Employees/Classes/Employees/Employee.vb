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
        Public Property Salary As Double
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
        Public Overridable Function GetBonus() As Double
            Return Salary * 0.1
        End Function
#End Region

    End Class
End Namespace
