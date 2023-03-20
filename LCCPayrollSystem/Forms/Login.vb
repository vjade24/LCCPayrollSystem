
Imports System.Data
Imports System.Data.SqlClient
Public Class login
    'Dim connection As New OleDbConnection(My.Settings.payrolldbConnectionString)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtb_username.Text = Nothing Or txtb_userpassword.Text = Nothing Then
            MsgBox("Enter credential", MsgBoxStyle.Exclamation)
        Else
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand("select * from user_tbl where user_name='" + txtb_username.Text + "' and user_password='" + txtb_userpassword.Text + "'", conn)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            sda.Fill(dt)

            If (dt.Rows.Count > 0) Then
                MsgBox("Welcome to LCC Payroll System!", MsgBoxStyle.Information)
                Me.Hide()
                Dashboard.lbl_welcome.Text = "Welcome, " + dt.Rows(0)("full_name").ToString()
                Dashboard.lbl_top.Text = dt.Rows(0)("full_name").ToString()
                Dashboard.Show()

                txtb_username.Text = ""
                txtb_userpassword.Text = ""
            Else
                MsgBox("Account not found!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtb_userpassword.PasswordChar = ""
        Else
            txtb_userpassword.PasswordChar = "*"
        End If
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
End Class
