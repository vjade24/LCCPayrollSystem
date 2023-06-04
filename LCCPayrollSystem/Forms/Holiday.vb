Imports System.Data.SqlClient
Public Class Holiday
    Private Sub Holiday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        BtnSave.Enabled = False
        BtnDelete.Enabled = False
    End Sub
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Public Sub RefreshData()
        Dim query = "SELECT * FROM holidays_tbl"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            Payroll_deduction_tblDataGridView.DataSource = dt
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim query = "SELECT * FROM holidays_tbl WHERE HolidayName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%'"
        CommonQuery(query, Payroll_deduction_tblDataGridView)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        LblAddEditMode.Text = "(Create new Record)"
        HolidayDateDateTimePicker.ResetText()
        HolidayNameTextBox.Text = ""
        IsWithPayCheckBox.Checked = False
        BtnSave.Enabled = True
        BtnDelete.Enabled = False

        HolidayDateDateTimePicker.Enabled = True
        'IdTextBox.Text = GetLastRow("Brand", "Id")

    End Sub
    Private Sub Payroll_deduction_tblDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Payroll_deduction_tblDataGridView.CellClick
        BtnSave.Enabled = True
        BtnDelete.Enabled = True
        LblAddEditMode.Text = "(Update existing Record)"

        HolidayDateDateTimePicker.ResetText()
        HolidayNameTextBox.Text = ""
        IsWithPayCheckBox.Checked = False

        HolidayDateDateTimePicker.Enabled = False

        HolidayDateDateTimePicker.Value = Payroll_deduction_tblDataGridView.CurrentRow.Cells(0).Value.ToString()
        HolidayNameTextBox.Text = Payroll_deduction_tblDataGridView.CurrentRow.Cells(1).Value.ToString()
        IsWithPayCheckBox.Checked = Payroll_deduction_tblDataGridView.CurrentRow.Cells(2).Value.ToString()

    End Sub

    Private Sub ClearEntry()
        HolidayDateDateTimePicker.ResetText()
        HolidayNameTextBox.Text = ""
        IsWithPayCheckBox.Checked = False
        BtnSave.Enabled = False
        BtnDelete.Enabled = False
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record (" + Payroll_deduction_tblDataGridView.CurrentRow.Cells(0).Value.ToString() + ")", "Delete Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No")
        ElseIf result = DialogResult.Yes Then
            Try
                Dim command1 As New SqlCommand("delete holidays_tbl where HolidayDate = @HolidayDate", conn)
                command1.Parameters.Add("@HolidayDate", SqlDbType.VarChar).Value = HolidayDateDateTimePicker.Value.ToString().Trim()
                Try
                    conn.Open()
                    result = command1.ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("No Data Deleted!", MsgBoxStyle.Critical)
                    Else
                        MsgBox("Successfully Deleted!", MsgBoxStyle.Information)
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                    conn.Close()
                End Try

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If
        RefreshData()
        ClearEntry()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click


        If LblAddEditMode.Text = "(Create new Record)" Then
            Dim command1 As New SqlCommand("insert into holidays_tbl values (@HolidayDate,@HolidayName,@IsWithPay)", conn)
            command1.Parameters.Add("@HolidayDate", SqlDbType.VarChar).Value = HolidayDateDateTimePicker.Value.ToString().Trim()
            command1.Parameters.Add("@HolidayName", SqlDbType.VarChar).Value = HolidayNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@IsWithPay", SqlDbType.VarChar).Value = IsWithPayCheckBox.Checked
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Successfully Inserted!", MsgBoxStyle.Information)
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try
        ElseIf LblAddEditMode.Text = "(Update existing Record)" Then
            Dim command1 As New SqlCommand("update holidays_tbl set HolidayName= @HolidayName,IsWithPay =@IsWithPay where HolidayDate = @HolidayDate", conn)
            command1.Parameters.Add("@HolidayDate", SqlDbType.VarChar).Value = HolidayDateDateTimePicker.Value.ToString().Trim()
            command1.Parameters.Add("@HolidayName", SqlDbType.VarChar).Value = HolidayNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@IsWithPay", SqlDbType.VarChar).Value = IsWithPayCheckBox.Checked
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Updated!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Successfully Updated!", MsgBoxStyle.Information)
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try
        End If
        RefreshData()
        ClearEntry()
    End Sub

End Class