
Imports System.IO
Imports System.Data.SqlClient
Public Class DTRUpload
    Private FileName As String
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        FileName = TextBox1.Text.ToString().Trim()
        If (File.Exists(FileName)) Then
            Dim lines = File.ReadAllLines(FileName)
            For Each line As String In lines
                Try
                    Dim segments = line.Split(New String() {Microsoft.VisualBasic.vbTab}, StringSplitOptions.RemoveEmptyEntries)
                    Dim conn As SqlConnection = New SqlConnection(connection)
                    Dim insert_query As String = "insert into dtr_upload_tbl values ( '" + segments(0).ToString().Trim + "','" + segments(1).ToString().Trim() + "','" + segments(2).ToString().Trim() + "','" + segments(3).ToString().Trim() + "','" + segments(4).ToString().Trim() + "','" + segments(5).ToString().Trim() + "','" + "Admin" + "','" + DateTime.Now + "','" + TextBox1.Text.ToString().Trim() + "')"
                    Dim cmd1 As SqlCommand = New SqlCommand(insert_query, conn)
                    conn.Open()
                    cmd1.ExecuteNonQuery()
                    conn.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString())
                    Me.Close()
                End Try
            Next
        End If
        TextBox1.Text = ""
        Dim query As String = "select * from dtr_upload_tbl"
        CommonQuery(query, DataGridView1)
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
End Class