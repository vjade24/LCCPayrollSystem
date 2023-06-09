Imports System.Data.SqlClient
Public Class DeductionFixed
    Private Sub DeductionFixed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrolldbDataSet.deduction_list_tbl' table. You can move, or remove it, as needed.
        Me.Deduction_list_tblTableAdapter.Fill(Me.PayrolldbDataSet.deduction_list_tbl)
        'TODO: This line of code loads data into the 'PayrolldbDataSet.payroll_deduction_fixed_tbl' table. You can move, or remove it, as needed.
        Me.Payroll_deduction_fixed_tblTableAdapter.Fill(Me.PayrolldbDataSet.payroll_deduction_fixed_tbl)
        RefreshData()
        BtnSave.Enabled = False
        BtnDelete.Enabled = False
    End Sub
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Public Sub RefreshData()
        Dim query = "SELECT * FROM payroll_deduction_fixed_tbl"
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
        Dim query = "SELECT * FROM payroll_deduction_fixed_tbl WHERE DeductionDescr LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%'"
        CommonQuery(query, Payroll_deduction_tblDataGridView)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        LblAddEditMode.Text = "(Create new Record)"

        IdTextBox.Text = ""
        DeductionCodeTextBox.Text = ""
        DeductionDescrComboBox.Text = ""
        EmploymentStatusComboBox.Text = ""
        FixedAmountTextBox.Text = "0.00"

        BtnSave.Enabled = True
        BtnDelete.Enabled = False

        'HolidayDateDateTimePicker.Enabled = True
        'IdTextBox.Text = GetLastRow("payroll_deduction_fixed_tbl", "Id")

    End Sub
    Private Sub Payroll_deduction_tblDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Payroll_deduction_tblDataGridView.CellClick
        BtnSave.Enabled = True
        BtnDelete.Enabled = True
        LblAddEditMode.Text = "(Update existing Record)"

        IdTextBox.Text = ""
        DeductionCodeTextBox.Text = ""
        DeductionDescrComboBox.Text = ""
        EmploymentStatusComboBox.Text = ""
        FixedAmountTextBox.Text = "0.00"

        IdTextBox.Text = Payroll_deduction_tblDataGridView.CurrentRow.Cells(0).Value.ToString()
        DeductionCodeTextBox.Text = Payroll_deduction_tblDataGridView.CurrentRow.Cells(1).Value.ToString()
        DeductionDescrComboBox.Text = Payroll_deduction_tblDataGridView.CurrentRow.Cells(2).Value.ToString()
        EmploymentStatusComboBox.Text = Payroll_deduction_tblDataGridView.CurrentRow.Cells(3).Value.ToString()
        FixedAmountTextBox.Text = Payroll_deduction_tblDataGridView.CurrentRow.Cells(4).Value.ToString()

    End Sub

    Private Sub ClearEntry()

        IdTextBox.Text = ""
        DeductionCodeTextBox.Text = ""
        DeductionDescrComboBox.Text = ""
        EmploymentStatusComboBox.Text = ""
        FixedAmountTextBox.Text = "0.00"

        BtnSave.Enabled = False
        BtnDelete.Enabled = False
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record (" + Payroll_deduction_tblDataGridView.CurrentRow.Cells(0).Value.ToString() + ")", "Delete Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No")
        ElseIf result = DialogResult.Yes Then
            Try
                Dim command1 As New SqlCommand("delete payroll_deduction_fixed_tbl where Id = @Id", conn)
                command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
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
            Dim command1 As New SqlCommand("insert into payroll_deduction_fixed_tbl values (@DeductionCode,@DeductionDescr,@EmploymentStatus,@FixedAmount)", conn)
            command1.Parameters.Add("@DeductionCode", SqlDbType.VarChar).Value = DeductionCodeTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@DeductionDescr", SqlDbType.VarChar).Value = DeductionDescrComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@EmploymentStatus", SqlDbType.VarChar).Value = EmploymentStatusComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@FixedAmount", SqlDbType.VarChar).Value = FixedAmountTextBox.Text.ToString().Trim()
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
            Dim command1 As New SqlCommand("update payroll_deduction_fixed_tbl set DeductionCode= @DeductionCode,DeductionDescr =@DeductionDescr,EmploymentStatus=@EmploymentStatus,FixedAmount=@FixedAmount where Id = @Id", conn)
            command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@DeductionCode", SqlDbType.VarChar).Value = DeductionCodeTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@DeductionDescr", SqlDbType.VarChar).Value = DeductionDescrComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@EmploymentStatus", SqlDbType.VarChar).Value = EmploymentStatusComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@FixedAmount", SqlDbType.VarChar).Value = FixedAmountTextBox.Text.ToString().Trim()
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

    Private Sub DeductionDescrComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeductionDescrComboBox.SelectedIndexChanged
        Try
            DeductionCodeTextBox.Text = DeductionDescrComboBox.SelectedValue.ToString()
        Catch ex As Exception

        End Try
    End Sub
End Class