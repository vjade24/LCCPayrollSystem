
Imports System.Data.SqlClient
Imports System.Globalization

Public Class Attendance
    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim query As String = "select id,concat(last_name,',', first_name,' ', middle_name) as full_name from employee_tbl"
        ComboboxQuery(query, Employee_nameComboBox, "id", "full_name")

        Tse_in_amDateTimePicker.Value = DateTime.Parse("08:00AM")
        Tse_out_amDateTimePicker.Value = DateTime.Parse("12:00PM")
        Tse_in_pmDateTimePicker.Value = DateTime.Parse("01:00PM")
        Tse_out_pmDateTimePicker.Value = DateTime.Parse("05:00PM")

        ComboBoxYear.Text = DateTime.Now.Year.ToString()
        ComboBoxMonth.Text = MonthName(DateTime.Now.Month)

        btnSaveSked.Enabled = False
        btnRemoveEntry.Enabled = False
    End Sub

    Private Sub btnGenerateSked_Click(sender As Object, e As EventArgs) Handles btnGenerateSked.Click

        Try

            Dim monthName = ComboBoxMonth.Text.ToString().Trim()
            Dim monthNumber = DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture).Month

            Dim year As Integer = ComboBoxYear.Text

            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand("select * from time_schedule_empl_tbl where empl_id = '" + Employee_nameComboBox.SelectedValue.ToString().Trim + "' and year(tse_date) = " + ComboBoxYear.Text.ToString().Trim() + " and month(tse_date) = " + monthNumber.ToString().Trim() + "", conn)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            sda.Fill(dt)
            If (dt.Rows.Count > 0) Then
                MsgBox("Already have schedule for this Year and Month!", MsgBoxStyle.Exclamation)
                TimeScked()
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to generate schedule for this year and month?", "Generate Schedule", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    MessageBox.Show("You pressed No")
                ElseIf result = DialogResult.Yes Then

                    'Dim monthName = ComboBoxMonth.Text.ToString().Trim()
                    'Dim monthNumber = DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture).Month

                    Dim dayinMonth = DateTime.DaysInMonth(ComboBoxYear.Text, monthNumber)
                    Dim var_date = DateTime.Parse(year.ToString() + "-" + monthNumber.ToString() + "-01")

                    For index = 0 To (dayinMonth - 1)

                        If var_date.AddDays(index).DayOfWeek.ToString = "Sunday" Or var_date.AddDays(index).DayOfWeek.ToString = "Saturday" Then
                            Dim insert_query As String = "insert into time_schedule_empl_tbl values ( '" + var_date.AddDays(index) + "','" + Employee_nameComboBox.SelectedValue.ToString().Trim + "',NULL,NULL,NULL,NULL)"
                            Dim cmd1 As SqlCommand = New SqlCommand(insert_query, conn)
                            conn.Open()
                            result = cmd1.ExecuteNonQuery()
                            'If result = 0 Then
                            '    MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
                            'Else
                            '    If (index) = (dayinMonth - 1) Then
                            '        MsgBox("Successfully Inserted!", MsgBoxStyle.Information)
                            '    End If
                            'End If
                            conn.Close()
                        Else
                            Dim insert_query As String = "insert into time_schedule_empl_tbl values ( '" + var_date.AddDays(index) + "','" + Employee_nameComboBox.SelectedValue.ToString().Trim + "','" + Tse_in_amDateTimePicker.Value + "','" + Tse_out_amDateTimePicker.Value + "','" + Tse_in_pmDateTimePicker.Value + "','" + Tse_out_pmDateTimePicker.Value + "')"
                            Dim cmd1 As SqlCommand = New SqlCommand(insert_query, conn)
                            conn.Open()
                            result = cmd1.ExecuteNonQuery()
                            'If result = 0 Then
                            '    MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
                            'Else
                            '    If (index) = (dayinMonth - 1) Then
                            '        MsgBox("Successfully Inserted!", MsgBoxStyle.Information)
                            '    End If
                            'End If
                            conn.Close()
                        End If


                        If index = (dayinMonth - 1) Then
                            MsgBox("Successfully Inserted!", MsgBoxStyle.Information)
                        End If

                    Next

                    TimeScked()

                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        TimeScked()
    End Sub

    Private Sub TimeScked()
        Dim monthName = ComboBoxMonth.Text.ToString().Trim()
        Dim monthNumber = DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture).Month

        Dim query As String = "select * from vw_time_schedule_empl_tbl where empl_id = '" + Employee_nameComboBox.SelectedValue.ToString().Trim + "' and year(tse_date) = " + ComboBoxYear.Text.ToString().Trim() + " and month(tse_date) = " + monthNumber.ToString().Trim() + ""
        CommonQuery(query, Vw_time_schedule_empl_tblDataGridView)
    End Sub

    Private Sub Vw_time_schedule_empl_tblDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vw_time_schedule_empl_tblDataGridView.CellClick

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to edit this record?", "Edit Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No")
            btnSaveSked.Enabled = False
            btnRemoveEntry.Enabled = False
        ElseIf result = DialogResult.Yes Then
            btnSaveSked.Enabled = True
            btnRemoveEntry.Enabled = True
            Tse_dateDateTimePicker.Value = DateTime.Parse(Vw_time_schedule_empl_tblDataGridView.CurrentRow.Cells(2).Value.ToString())
            Tse_in_amDateTimePicker.Value = DateTime.Parse(Vw_time_schedule_empl_tblDataGridView.CurrentRow.Cells(5).Value.ToString())
            Tse_out_amDateTimePicker.Value = DateTime.Parse(Vw_time_schedule_empl_tblDataGridView.CurrentRow.Cells(6).Value.ToString())
            Tse_in_pmDateTimePicker.Value = DateTime.Parse(Vw_time_schedule_empl_tblDataGridView.CurrentRow.Cells(7).Value.ToString())
            Tse_out_pmDateTimePicker.Value = DateTime.Parse(Vw_time_schedule_empl_tblDataGridView.CurrentRow.Cells(8).Value.ToString())
        End If
    End Sub

    Private Sub btnSaveSked_Click(sender As Object, e As EventArgs) Handles btnSaveSked.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to save this record?", "Save Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No")
            btnSaveSked.Enabled = True
            btnRemoveEntry.Enabled = True
        ElseIf result = DialogResult.Yes Then
            btnSaveSked.Enabled = False
            btnRemoveEntry.Enabled = False

            Dim query As String = "update time_schedule_empl_tbl set tse_in_am = '" + Tse_in_amDateTimePicker.Value + "',tse_out_am = '" + Tse_out_amDateTimePicker.Value + "',tse_in_pm = '" + Tse_in_pmDateTimePicker.Value + "',tse_out_pm = '" + Tse_out_pmDateTimePicker.Value + "' where empl_id = '" + Employee_nameComboBox.SelectedValue.ToString().Trim + "' and tse_date = '" + Tse_dateDateTimePicker.Value.ToString.Trim() + "'"
            UpdateQuery(query)
            TimeScked()
        End If
    End Sub

    Private Sub btnRemoveEntry_Click(sender As Object, e As EventArgs) Handles btnRemoveEntry.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Remove entry?", "Remove Entry", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No")
            btnSaveSked.Enabled = True
            btnRemoveEntry.Enabled = True
        ElseIf result = DialogResult.Yes Then
            btnSaveSked.Enabled = False
            btnRemoveEntry.Enabled = False
            Dim query As String = "update time_schedule_empl_tbl set tse_in_am = NULL,tse_out_am = NULL,tse_in_pm = NULL,tse_out_pm = NULL where empl_id = '" + Employee_nameComboBox.SelectedValue.ToString().Trim + "' and tse_date = '" + Tse_dateDateTimePicker.Value.ToString.Trim() + "'"
            UpdateQuery(query)
            TimeScked()
        End If
    End Sub
End Class