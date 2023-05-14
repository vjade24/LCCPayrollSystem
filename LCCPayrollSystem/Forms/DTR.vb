Imports System.Data.SqlClient
Public Class DTR

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim conn1 As New SqlConnection(connection)
        Dim cmd As SqlCommand = conn1.CreateCommand
        conn1.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_dtr_empl"
        cmd.Parameters.Add(New SqlParameter("@p_period_from", DateTimePicker_PeriodFrom.Value))
        cmd.Parameters.Add(New SqlParameter("@p_period_to", DateTimePicker_PeriodTo.Value))
        cmd.Parameters.Add(New SqlParameter("@p_employee_id", TextBox_employee_id.Text))
        cmd.ExecuteNonQuery()
        conn1.Close()

        MessageBox.Show("Successfully Generated!")
        Dim query As String = "select * from dtr_tbl where employee_id = '" + TextBox_employee_id.Text + "' AND dtr_date between '" + DateTimePicker_PeriodFrom.Value + "' and '" + DateTimePicker_PeriodTo.Value + "'"
        CommonQuery(query, Dtr_tblDataGridView)

    End Sub
End Class