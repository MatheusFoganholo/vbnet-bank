Imports Employees.Classes.Employees
Imports Employees.Classes.Libs

Public Class App
    Public Sub New()
        InitializeComponent()
        Dim D01 As New Director("Carlos Antônio", "123.456.789.01", 10000)
        Dim M01 As New Manager("Neymar Júnior", "987.754.321.09", 5000)
    End Sub
End Class
