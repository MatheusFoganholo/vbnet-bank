Imports Employees.Classes.Employees
Namespace Classes.Libs
    Public Class EmployeesBonus
        Private _TotalBonus As Double
        Public Sub Register(Employee As Employee)
            _TotalBonus += Employee.GetBonus()
        End Sub

        Public Function GetBonus() As Double
            Return _TotalBonus
        End Function
    End Class
End Namespace
