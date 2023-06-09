Imports System.Data.SqlClient
Public Class DTR
    Dim conn As New SqlConnection(connection)

    Public Sub Generate_DTR()
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



    End Sub

    Public Sub RefreshData(employee_id, period_from, period_to)
        Dim query As String = "select * from dtr_tbl where employee_id = '" + employee_id + "' AND dtr_date between '" + period_from + "' and '" + period_to + "' and id = (SELECT MAX(A1.id) FROM dtr_tbl A1 WHERE A1.employee_id = dtr_tbl.employee_id AND A1.dtr_date = dtr_tbl.dtr_date) ORDER BY dtr_date"
        CommonQuery(query, Dtr_tblDataGridView)

        Dim conn As SqlConnection = New SqlConnection(connection)
        Dim cmd1 As SqlCommand = New SqlCommand("select employee_name,ISNULL(SUM(late_time_min),0) AS late_time_min,ISNULL(SUM(under_time_min),0) AS under_time_min,ISNULL(SUM(ot_min),0) AS ot_min from dtr_tbl where employee_id = '" + employee_id + "' AND dtr_date between '" + period_from + "' and '" + period_to + "' and id = (SELECT MAX(A1.id) FROM dtr_tbl A1 WHERE A1.employee_id = dtr_tbl.employee_id AND A1.dtr_date = dtr_tbl.dtr_date) GROUP BY employee_name", conn)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd1)
        Dim dt As DataTable = New DataTable
        sda.Fill(dt)

        TextBox_employeename.Text = ""
        TextBox_Late.Text = ""
        TextBox_UnderTime.Text = ""
        TextBox_Overtime.Text = ""

        TextBox_employeename.Text = dt.Rows(0)("employee_name").ToString()
        TextBox_Late.Text = Double.Parse(dt.Rows(0)("late_time_min").ToString()).ToString()
        TextBox_UnderTime.Text = Double.Parse(dt.Rows(0)("under_time_min").ToString())
        TextBox_Overtime.Text = Double.Parse(dt.Rows(0)("ot_min").ToString())

        ' ******************************************************************************
        ' **** Calculate Late, undertime and Overtime **********************************
        ' ******************************************************************************
        Dim cmd_absent As SqlCommand = New SqlCommand("select employee_name,COUNT(ISNULL(is_absent,0)) AS is_absent from dtr_tbl where employee_id = '" + employee_id + "' AND dtr_date between '" + period_from + "' and '" + period_to + "' AND ISNULL(is_absent,0)<> 0 and id = (SELECT MAX(A1.id) FROM dtr_tbl A1 WHERE A1.employee_id = dtr_tbl.employee_id AND A1.dtr_date = dtr_tbl.dtr_date)  GROUP BY employee_name", conn)
        Dim sda_absent As SqlDataAdapter = New SqlDataAdapter(cmd_absent)
        Dim dt_absent As DataTable = New DataTable
        sda_absent.Fill(dt_absent)

        TextBox_Absent.Text = "0"
        If dt_absent.Rows.Count > 0 Then
            TextBox_Absent.Text = Double.Parse(dt_absent.Rows(0)("is_absent").ToString())
        End If
        ' ******************************************************************************
        ' **** Calculate Late, undertime and Overtime **********************************
        ' ******************************************************************************

        ' ************************************************************
        ' **** Calculate Worked Day **********************************
        ' ************************************************************
        Dim cmd_days_worked As SqlCommand = New SqlCommand("SELECT COUNT(*) AS days_worked FROM dtr_conso_tbl WHERE employee_id = '" + employee_id + "' AND dtr_date between '" + period_from + "' and '" + period_to + "'", conn)
        Dim sda_days_worked As SqlDataAdapter = New SqlDataAdapter(cmd_days_worked)
        Dim dt_days_worked As DataTable = New DataTable
        sda_days_worked.Fill(dt_days_worked)

        TextBox_DaysRendered.Text = "0"
        If dt_days_worked.Rows.Count > 0 Then
            TextBox_DaysRendered.Text = Double.Parse(dt_days_worked.Rows(0)("days_worked").ToString())
        End If
        ' ************************************************************
        ' **** Calculate Worked Day **********************************
        ' ************************************************************

    End Sub

    Private Sub Dtr_tblDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtr_tblDataGridView.CellClick

        Try
            If Dtr_tblDataGridView.Columns(e.ColumnIndex).Name = "Edit" Then

                GroupBox1.Visible = True
                Dtr_dateDateTimePicker.Value = DateTime.Parse(DateTime.Now)
                Tse_in_amDateTimePicker.Value = DateTime.Parse("5/8/2023 08:00:00 AM")
                Tse_out_amDateTimePicker.Value = DateTime.Parse("5/8/2023 12:00:00 PM")
                Tse_in_pmDateTimePicker.Value = DateTime.Parse("5/8/2023 12:31:00 PM")
                Tse_out_pmDateTimePicker.Value = DateTime.Parse("5/8/2023 05:00:00 PM")

                Dtr_dateDateTimePicker.Value = DateTime.Parse(Dtr_tblDataGridView.CurrentRow.Cells(3).Value.ToString())

                If Dtr_tblDataGridView.CurrentRow.Cells(5).Value.ToString() = "" Then
                    Tse_in_amDateTimePicker.Value = DateTime.Parse("5/8/2023 08:00:00 AM")
                Else
                    Tse_in_amDateTimePicker.Value = DateTime.Parse(Dtr_tblDataGridView.CurrentRow.Cells(5).Value.ToString())
                End If

                If Dtr_tblDataGridView.CurrentRow.Cells(6).Value.ToString() = "" Then
                    Tse_out_amDateTimePicker.Value = DateTime.Parse("5/8/2023 12:00:00 PM")
                Else
                    Tse_out_amDateTimePicker.Value = DateTime.Parse(Dtr_tblDataGridView.CurrentRow.Cells(6).Value.ToString())
                End If

                If Dtr_tblDataGridView.CurrentRow.Cells(7).Value.ToString() = "" Then
                    Tse_in_pmDateTimePicker.Value = DateTime.Parse("5/8/2023 12:31:00 PM")
                Else
                    Tse_in_pmDateTimePicker.Value = DateTime.Parse(Dtr_tblDataGridView.CurrentRow.Cells(7).Value.ToString())
                End If

                If Dtr_tblDataGridView.CurrentRow.Cells(8).Value.ToString() = "" Then
                    Tse_out_pmDateTimePicker.Value = DateTime.Parse("5/8/2023 05:00:00 PM")
                Else
                    Tse_out_pmDateTimePicker.Value = DateTime.Parse(Dtr_tblDataGridView.CurrentRow.Cells(8).Value.ToString())
                End If

                TextBox_employee_id.Text = Dtr_tblDataGridView.CurrentRow.Cells(1).Value.ToString()
                TextBox_employeename.Text = Dtr_tblDataGridView.CurrentRow.Cells(2).Value.ToString()

                'Is_absentCheckBox.Checked = Dtr_tblDataGridView.CurrentRow.Cells(12).Value

            ElseIf Dtr_tblDataGridView.Columns(e.ColumnIndex).Name = "DataGridViewCheckBoxColumn1" Then

                Dim conn As SqlConnection = New SqlConnection(connection)
                Dim cmd1 As SqlCommand = New SqlCommand("select  * FROM dtr_application_tbl where employee_id = '" + TextBox_employee_id.Text.ToString().Trim + "' AND dtr_date = '" + Dtr_tblDataGridView.CurrentRow.Cells(3).Value.ToString() + "'", conn)
                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd1)
                Dim dt As DataTable = New DataTable
                sda.Fill(dt)
                If Dtr_tblDataGridView.CurrentRow.Cells(12).Value = False Then

                    Dim result As New Boolean
                    Dim command1 As New SqlCommand("insert into dtr_application_tbl values (@employee_id,@dtr_date,@is_absent,@is_leave,@is_holiday)", conn)
                    command1.Parameters.Add("@employee_id", SqlDbType.VarChar).Value = TextBox_employee_id.Text.ToString().Trim
                    command1.Parameters.Add("@dtr_date", SqlDbType.VarChar).Value = Dtr_tblDataGridView.CurrentRow.Cells(3).Value.ToString()
                    command1.Parameters.Add("@is_absent", SqlDbType.VarChar).Value = "1"
                    command1.Parameters.Add("@is_leave", SqlDbType.VarChar).Value = "0"
                    command1.Parameters.Add("@is_holiday", SqlDbType.VarChar).Value = "0"
                    Try
                        conn.Open()
                        result = command1.ExecuteNonQuery()
                        If result = 0 Then
                            MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
                        Else

                            Dim command111 As New SqlCommand("delete from dtr_conso_tbl where employee_id = @employee_id AND dtr_date =@dtr_date", conn)
                            command111.Parameters.Add("@employee_id", SqlDbType.VarChar).Value = TextBox_employee_id.Text.ToString().Trim
                            command111.Parameters.Add("@dtr_date", SqlDbType.VarChar).Value = Dtr_tblDataGridView.CurrentRow.Cells(3).Value.ToString()
                            Try
                                'conn.Open()
                                result = command111.ExecuteNonQuery()
                                If result = 0 Then
                                    MsgBox("No Data Found!", MsgBoxStyle.Critical)
                                Else
                                    'MsgBox("Successfully Updated!", MsgBoxStyle.Information)
                                End If
                                'conn.Close()

                            Catch ex As Exception
                                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                                'conn.Close()
                            End Try
                        End If
                        conn.Close()
                    Catch ex As Exception
                        MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                        conn.Close()
                    End Try

                Else

                    Dim result As New Boolean
                    Dim command1 As New SqlCommand("update dtr_application_tbl set is_absent= @is_absent where employee_id = @employee_id and dtr_date =@dtr_date", conn)
                    command1.Parameters.Add("@employee_id", SqlDbType.VarChar).Value = TextBox_employee_id.Text.ToString().Trim
                    command1.Parameters.Add("@dtr_date", SqlDbType.VarChar).Value = Dtr_tblDataGridView.CurrentRow.Cells(3).Value.ToString()
                    command1.Parameters.Add("@is_absent", SqlDbType.VarChar).Value = "0"
                    command1.Parameters.Add("@is_leave", SqlDbType.VarChar).Value = "0"
                    command1.Parameters.Add("@is_holiday", SqlDbType.VarChar).Value = "0"
                    Try
                        conn.Open()
                        result = command1.ExecuteNonQuery()
                        If result = 0 Then
                            MsgBox("No Data Updated!", MsgBoxStyle.Critical)
                        Else
                            'MsgBox("Successfully Updated!", MsgBoxStyle.Information)
                        End If
                        conn.Close()
                    Catch ex As Exception
                        MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                        conn.Close()
                    End Try

                End If

                Generate_DTR()
                RefreshData(TextBox_employee_id.Text, DateTimePicker_PeriodFrom.Value, DateTimePicker_PeriodTo.Value)

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub DTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker_PeriodFrom.Value = DateTime.Now.Month.ToString().Trim() + "/01/" + DateTime.Now.Year().ToString().Trim()
        DateTimePicker_PeriodTo.Value = DateTime.Parse(DateTimePicker_PeriodFrom.Value).AddMonths(1).AddDays(-1)

        GroupBox1.Visible = False
        TextBox_employee_id.Select()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Generate_DTR()
        RefreshData(TextBox_employee_id.Text, DateTimePicker_PeriodFrom.Value, DateTimePicker_PeriodTo.Value)
    End Sub

    Private Sub btnRemove_Click_1(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this record?", "Remove Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No")
        ElseIf result = DialogResult.Yes Then
            Dim command1 As New SqlCommand("delete from dtr_conso_tbl where employee_id = @employee_id AND dtr_date =@dtr_date", conn)
            command1.Parameters.Add("@employee_id", SqlDbType.VarChar).Value = TextBox_employee_id.Text.ToString().Trim
            command1.Parameters.Add("@dtr_date", SqlDbType.VarChar).Value = Dtr_dateDateTimePicker.Value
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Found!", MsgBoxStyle.Critical)
                Else
                    'MsgBox("Successfully Updated!", MsgBoxStyle.Information)
                End If
                conn.Close()

            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try

            Generate_DTR()
            RefreshData(TextBox_employee_id.Text, DateTimePicker_PeriodFrom.Value, DateTimePicker_PeriodTo.Value)
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to save this record?", "Save Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No")
        ElseIf result = DialogResult.Yes Then
            Try

                Dim conn As SqlConnection = New SqlConnection(connection)
                Dim cmd1 As SqlCommand = New SqlCommand("select  * FROM dtr_conso_tbl where employee_id = '" + TextBox_employee_id.Text.ToString().Trim + "' AND dtr_date = '" + Dtr_dateDateTimePicker.Value + "'", conn)
                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd1)
                Dim dt As DataTable = New DataTable
                sda.Fill(dt)

                If dt.Rows.Count > 0 Then

                    'Dim query As String = "update dtr_conso_tbl set time_in_am = '" + Tse_in_amDateTimePicker.Value + "',time_out_am = '" + Tse_out_amDateTimePicker.Value + "',time_in_pm = '" + Tse_in_pmDateTimePicker.Value + "',time_out_pm = '" + Tse_out_pmDateTimePicker.Value + "' where employee_id = '" + TextBox_employee_id.Text.ToString().Trim + "' AND dtr_date = '" + Dtr_dateDateTimePicker.Value + "'"
                    'UpdateQuery(query)

                    Dim command1 As New SqlCommand("update dtr_conso_tbl set time_in_am= @time_in_am,time_out_am =@time_out_am,time_in_pm=@time_in_pm,time_out_pm=@time_out_pm where employee_id = @employee_id AND dtr_date =@dtr_date", conn)
                    command1.Parameters.Add("@time_in_am", SqlDbType.VarChar).Value = Tse_in_amDateTimePicker.Value
                    command1.Parameters.Add("@time_out_am", SqlDbType.VarChar).Value = Tse_out_amDateTimePicker.Value
                    command1.Parameters.Add("@time_in_pm", SqlDbType.VarChar).Value = Tse_in_pmDateTimePicker.Value
                    command1.Parameters.Add("@time_out_pm", SqlDbType.VarChar).Value = Tse_out_pmDateTimePicker.Value
                    command1.Parameters.Add("@employee_id", SqlDbType.VarChar).Value = TextBox_employee_id.Text.ToString().Trim
                    command1.Parameters.Add("@dtr_date", SqlDbType.VarChar).Value = Dtr_dateDateTimePicker.Value
                    Try
                        conn.Open()
                        result = command1.ExecuteNonQuery()
                        If result = 0 Then
                            MsgBox("No Data Updated!", MsgBoxStyle.Critical)
                        Else
                            'MsgBox("Successfully Updated!", MsgBoxStyle.Information)
                        End If
                        conn.Close()
                    Catch ex As Exception
                        MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                        conn.Close()
                    End Try

                Else

                    'Dim insert_query As String = "insert into dtr_conso_tbl values('" + TextBox_employee_id.Text.ToString().Trim + "','" + Dtr_dateDateTimePicker.Value.ToString() + "','" + Tse_in_amDateTimePicker.Value.ToString() + "','" + Tse_out_amDateTimePicker.Value.ToString() + "','" + Tse_in_pmDateTimePicker.Value.ToString() + "','" + Tse_out_pmDateTimePicker.Value.ToString() + "','" + "Admin" + "','" + DateTime.Now.ToString() + "','" + "" + "','" + "" + "')"
                    'InsertQuery(insert_query)

                    Dim command1 As New SqlCommand("insert into dtr_conso_tbl values (@employee_id,@dtr_date,@time_in_am,@time_out_am,@time_in_pm,@time_out_pm,@created_by,@created_dttm,@updated_by,@updated_dttm)", conn)
                    command1.Parameters.Add("@time_in_am", SqlDbType.VarChar).Value = Tse_in_amDateTimePicker.Value
                    command1.Parameters.Add("@time_out_am", SqlDbType.VarChar).Value = Tse_out_amDateTimePicker.Value
                    command1.Parameters.Add("@time_in_pm", SqlDbType.VarChar).Value = Tse_in_pmDateTimePicker.Value
                    command1.Parameters.Add("@time_out_pm", SqlDbType.VarChar).Value = Tse_out_pmDateTimePicker.Value
                    command1.Parameters.Add("@employee_id", SqlDbType.VarChar).Value = TextBox_employee_id.Text.ToString().Trim
                    command1.Parameters.Add("@dtr_date", SqlDbType.VarChar).Value = Dtr_dateDateTimePicker.Value
                    command1.Parameters.Add("@created_by", SqlDbType.VarChar).Value = "Admin"
                    command1.Parameters.Add("@created_dttm", SqlDbType.VarChar).Value = DateTime.Now
                    command1.Parameters.Add("@updated_by", SqlDbType.VarChar).Value = ""
                    command1.Parameters.Add("@updated_dttm", SqlDbType.VarChar).Value = ""
                    Try
                        conn.Open()
                        result = command1.ExecuteNonQuery()
                        If result = 0 Then
                            MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
                        Else
                            'MsgBox("Successfully Inserted!", MsgBoxStyle.Information)
                        End If
                        conn.Close()
                    Catch ex As Exception
                        MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                        conn.Close()
                    End Try
                End If

                Generate_DTR()
                RefreshData(TextBox_employee_id.Text, DateTimePicker_PeriodFrom.Value, DateTimePicker_PeriodTo.Value)
                GroupBox1.Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try

        End If
    End Sub
End Class