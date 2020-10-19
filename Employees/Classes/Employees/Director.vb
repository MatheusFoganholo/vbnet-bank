Namespace Classes.Employees
    Public Class Director
        Inherits Employee
#Region "Properties/Propriedades"

#End Region

#Region "Constructors/Construtores"
        Public Sub New(Nome As String, CPF_ As String, Salario As Double)
            MyBase.New(Nome, CPF_, Salario)
        End Sub
#End Region
#Region "Methods/Métodos"
        ' Director Anual Bonification
        ' Bonificação Anual do Diretor
        Public Overrides Function GetBonus() As Double
            Return Salary * 0.5
        End Function
#End Region
    End Class
End Namespace
