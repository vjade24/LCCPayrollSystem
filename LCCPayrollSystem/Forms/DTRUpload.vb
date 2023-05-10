
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
                    If DateTime.Parse(segments(1).ToString().Trim()).Year = Int32.Parse(ComboBoxYear.Text) And DateTime.Parse(segments(1).ToString().Trim()).Month = DateTime.ParseExact(ComboBoxMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month Then
                        Dim conn As SqlConnection = New SqlConnection(connection)
                        Dim insert_query As String = "insert into dtr_upload_tbl values ( '" + segments(0).ToString().Trim + "','" + segments(1).ToString().Trim() + "','" + segments(2).ToString().Trim() + "','" + segments(3).ToString().Trim() + "','" + segments(4).ToString().Trim() + "','" + segments(5).ToString().Trim() + "','" + p_generated_by + "','" + DateTime.Now + "','" + TextBox1.Text.ToString().Trim() + "')"
                        Dim cmd1 As SqlCommand = New SqlCommand(insert_query, conn)
                        conn.Open()
                        cmd1.ExecuteNonQuery()
                        conn.Close()
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
        ComboBoxYear.Text = DateTime.Now.Year.ToString()
        ComboBoxMonth.Text = MonthName(DateTime.Now.Month)
        RefreshData()
    End Sub

    Private Sub RefreshData()
        Dim monthName = ComboBoxMonth.Text.ToString().Trim()
        Dim monthNumber = DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture).Month
        Dim query As String = "select id,employee_id,bio_datetime from dtr_upload_tbl where YEAR(CONVERT(date,bio_datetime)) = '" + Int32.Parse(ComboBoxYear.Text).ToString().Trim() + "' AND MONTH(CONVERT(date,bio_datetime)) = '" + monthNumber.ToString().Trim() + "'"
        CommonQuery(query, DataGridView1)
    End Sub
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        RefreshData()
    End Sub
End Class