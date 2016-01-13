Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SCProjectDataSet.Timesheets' table. You can move, or remove it, as needed.
        Me.TimesheetsTableAdapter.Fill(Me.SCProjectDataSet.Timesheets)
        'TODO: This line of code loads data into the 'SCProjectDataSet.Projects' table. You can move, or remove it, as needed.
        Me.ProjectsTableAdapter.Fill(Me.SCProjectDataSet.Projects)
        'TODO: This line of code loads data into the 'SCProjectDataSet.Departments' table. You can move, or remove it, as needed.
        Me.DepartmentsTableAdapter.Fill(Me.SCProjectDataSet.Departments)
        'TODO: This line of code loads data into the 'SCProjectDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.SCProjectDataSet.Employees)

    End Sub

End Class
