
Imports System.IO
Imports System.Data.SqlClient
Imports System.Globalization

Public Class DTRUpload
    Private FileName As String
    Private p_generated_by As String = "Admin"

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        FileName = TextBox1.Text.ToString().Trim()
        If (File.Exists(FileName)) Then
            Dim lines = File.ReadAllLines(FileName)
            For Each line As String In lines
                Try
                    Dim segments = line.Split(New String() {Microsoft.VisualBasic.vbTab}, StringSplitOptions.RemoveEmptyEntries)
                    If segments.Length = 6 Then
                        If DateTime.Parse(segments(1).ToString().Trim()).Year = Int32.Parse(ComboBoxYear.Text) And DateTime.Parse(segments(1).ToString().Trim()).Month = DateTime.ParseExact(ComboBoxMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month Then
                            Dim conn As SqlConnection = New SqlConnection(connection)
                            Dim insert_query As String = "insert into dtr_upload_tbl values ( '" + segments(0).ToString().Trim + "','" + segments(1).ToString().Trim() + "','" + segments(2).ToString().Trim() + "','" + segments(3).ToString().Trim() + "','" + segments(4).ToString().Trim() + "','" + segments(5).ToString().Trim() + "','" + p_generated_by + "','" + DateTime.Now + "','" + TextBox1.Text.ToString().Trim() + "')"
                            Dim cmd1 As SqlCommand = New SqlCommand(insert_query, conn)
                            conn.Open()
                            cmd1.ExecuteNonQuery()
                            conn.Close()
                        End If
                    Else
                        MessageBox.Show("This file is not valid for uploading!")
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString())
                    Me.Close()
                End Try
            Next

            Dim monthName = ComboBoxMonth.Text.ToString().Trim()
            Dim monthNumber = DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture).Month
            Dim conn1 As New SqlConnection(connection)
            Dim cmd As SqlCommand = conn1.CreateCommand
            conn1.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_dtr_conso_generation"
            cmd.Parameters.Add(New SqlParameter("@p_dtr_year", Int32.Parse(ComboBoxYear.Text).ToString().Trim()))
            cmd.Parameters.Add(New SqlParameter("@p_dtr_month", monthNumber.ToString().Trim()))
            cmd.Parameters.Add(New SqlParameter("@p_generated_by", p_generated_by))
            cmd.ExecuteNonQuery()
            conn1.Close()

            MessageBox.Show("Successfully Uploaded!")
            TextBox1.Text = ""
            RefreshData()
        Else
            MessageBox.Show("No Filename")
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        OpenFileDialog1.FileName = ""
        ' define the filters (first description | first filter; second description ...
        OpenFileDialog1.Filter = "Data File|*.dat"
        'select the first filter
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.DefaultExt = "dat"
        OpenFileDialog1.AddExtension = True

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub DTRUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrolldbDataSet.vw_dtr_upload_tbl' table. You can move, or remove it, as needed.
        'Me.Vw_dtr_upload_tblTableAdapter.Fill(Me.PayrolldbDataSet.vw_dtr_upload_tbl)
        'TODO: This line of code loads data into the 'PayrolldbDataSet.dtr_upload_tbl' table. You can move, or remove it, as needed.
        'Me.Dtr_upload_tblTableAdapter.Fill(Me.PayrolldbDataSet.dtr_upload_tbl)
        'TODO: This line of code loads data into the 'PayrolldbDataSet.dtr_conso_tbl' table. You can move, or remove it, as needed.
        'Me.Dtr_conso_tblTableAdapter.Fill(Me.PayrolldbDataSet.dtr_conso_tbl)
        'TODO: This line of code loads data into the 'PayrolldbDataSet.dtr_conso_tbl' table. You can move, or remove it, as needed.
        'Me.Dtr_conso_tblTableAdapter.Fill(Me.PayrolldbDataSet.dtr_conso_tbl)
        'TODO: This line of code loads data into the 'PayrolldbDataSet.dtr_conso_tbl' table. You can move, or remove it, as needed.
        ' Me.Dtr_conso_tblTableAdapter.Fill(Me.PayrolldbDataSet.dtr_conso_tbl)
        ComboBoxYear.Text = DateTime.Now.Year.ToString()
        ComboBoxMonth.Text = MonthName(DateTime.Now.Month)
        RefreshData()


        If user_login = "Staff" Then
            btnUpload.Visible = False
            btnLoad.Visible = False
            btnShowGenerate.Visible = False
        ElseIf user_login = "Admin" Then
            btnUpload.Visible = True
            btnLoad.Visible = True
            btnShowGenerate.Visible = True
        End If
    End Sub

    Private Sub RefreshData()
        Dim monthName = ComboBoxMonth.Text.ToString().Trim()
        Dim monthNumber = DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture).Month

        Dim query As String = "select * FROM  vw_dtr_upload_tbl where YEAR(CONVERT(date,bio_datetime)) = '" + Int32.Parse(ComboBoxYear.Text).ToString().Trim() + "' AND MONTH(CONVERT(date,bio_datetime)) = '" + monthNumber.ToString().Trim() + "'"
        CommonQuery(query, DataGridView1)

        'Dim query_conso As String = "select A.id,A.employee_id,B.employee_name,A.dtr_date,A.time_in_am,A.time_out_am,A.time_in_pm,A.time_out_pm from dtr_conso_tbl A INNER JOIN vw_employee_tbl B ON B.Id = A.employee_id where YEAR(CONVERT(date,dtr_date)) = '" + Int32.Parse(ComboBoxYear.Text).ToString().Trim() + "' AND MONTH(CONVERT(date,dtr_date)) = '" + monthNumber.ToString().Trim() + "'"
        'CommonQuery(query_conso, Dtr_conso_tblDataGridView)
    End Sub
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        RefreshData()
    End Sub

    'Private Sub Dtr_conso_tblDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)
    '    Dim result As DialogResult = MessageBox.Show("Are you sure you want to edit this record?", "Edit Record", MessageBoxButtons.YesNo)
    '    If result = DialogResult.No Then
    '        MessageBox.Show("You pressed No")
    '    ElseIf result = DialogResult.Yes Then
    '        IdTextBox.Text = Dtr_conso_tblDataGridView.CurrentRow.Cells(0).Value.ToString()
    '        Employee_idTextBox.Text = Dtr_conso_tblDataGridView.CurrentRow.Cells(2).Value.ToString()
    '        Dtr_dateDateTimePicker.Value = DateTime.Parse(Dtr_conso_tblDataGridView.CurrentRow.Cells(3).Value.ToString())
    '        Tse_in_amDateTimePicker.Value = DateTime.Parse(Dtr_conso_tblDataGridView.CurrentRow.Cells(4).Value.ToString())
    '        Tse_out_amDateTimePicker.Value = DateTime.Parse(Dtr_conso_tblDataGridView.CurrentRow.Cells(5).Value.ToString())
    '        Tse_in_pmDateTimePicker.Value = DateTime.Parse(Dtr_conso_tblDataGridView.CurrentRow.Cells(6).Value.ToString())
    '        Tse_out_pmDateTimePicker.Value = DateTime.Parse(Dtr_conso_tblDataGridView.CurrentRow.Cells(7).Value.ToString())
    '    End If
    'End Sub


    'Private Sub Dtr_conso_tblBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.Dtr_conso_tblBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.PayrolldbDataSet)

    'End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs)
    '    Dim result As DialogResult = MessageBox.Show("Are you sure you want to save this record?", "Save Record", MessageBoxButtons.YesNo)
    '    If result = DialogResult.No Then
    '        MessageBox.Show("You pressed No")
    '    ElseIf result = DialogResult.Yes Then
    '        Try
    '            Dim monthName = ComboBoxMonth.Text.ToString().Trim()
    '            Dim monthNumber = DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture).Month

    '            Dim query As String = "update dtr_conso_tbl set time_in_am = '" + Tse_in_amDateTimePicker.Value + "',time_out_am = '" + Tse_out_amDateTimePicker.Value + "',time_in_pm = '" + Tse_in_pmDateTimePicker.Value + "',time_out_pm = '" + Tse_out_pmDateTimePicker.Value + "' where id = '" + IdTextBox.Text.ToString().Trim + "'"
    '            UpdateQuery(query)

    '            Dim query_conso As String = "select A.id,A.employee_id,B.employee_name,A.dtr_date,A.time_in_am,A.time_out_am,A.time_in_pm,A.time_out_pm from dtr_conso_tbl A INNER JOIN vw_employee_tbl B ON B.Id = A.employee_id where YEAR(CONVERT(date,dtr_date)) = '" + Int32.Parse(ComboBoxYear.Text).ToString().Trim() + "' AND MONTH(CONVERT(date,dtr_date)) = '" + monthNumber.ToString().Trim() + "'"
    '            CommonQuery(query_conso, Dtr_conso_tblDataGridView)
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message.ToString)
    '        End Try

    '    End If
    'End Sub

    Private Sub btnShowGenerate_Click(sender As Object, e As EventArgs) Handles btnShowGenerate.Click
        DTR.ShowDialog()
    End Sub

End Class