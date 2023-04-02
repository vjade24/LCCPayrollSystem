Public Class PayrollList
    Private Sub PayrollList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrolldbDataSet.vw_payroll_tbl' table. You can move, or remove it, as needed.
        Me.Vw_payroll_tblTableAdapter.Fill(Me.PayrolldbDataSet.vw_payroll_tbl)

    End Sub

    Private Sub txtbSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbSearch.TextChanged
        Dim query As String = "select * from vw_payroll_tbl where last_name like '%" + txtbSearch.Text.ToString().Trim() + "%' or first_name like '%" + txtbSearch.Text.ToString().Trim() + "%'"
        CommonQuery(query, Vw_payroll_tblDataGridView)
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Me.Hide()
        Me.Dispose()
        Payroll.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        'Dashboard.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "select * from vw_payroll_tbl"
        CommonQuery(query, Vw_payroll_tblDataGridView)
    End Sub
End Class