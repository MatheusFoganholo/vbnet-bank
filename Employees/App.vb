Imports Employees.Classes.Employees
Imports Employees.Classes.Libs

Public Class App
    Public Sub New()
        InitializeComponent()
        Dim D01 As New Director("Carlos Antônio", "123.456.789.01", 10000)
        Dim M01 As New Manager("Neymar Júnior", "987.754.321.09", 5000)
        Dim BonusManagement As New EmployeesBonus()
        BonusManagement.Register(M01)
        BonusManagement.Register(D01)
        MsgBox($"Bônus total dos funcionários será de {BonusManagement.GetBonus()} e o número total de funcionários é {Employee.TotalEmployees}")
    End Sub
End Class
