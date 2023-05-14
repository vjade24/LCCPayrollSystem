
Imports System.Data
Imports System.Data.SqlClient
Public Class login
    'Dim connection As New OleDbConnection(My.Settings.payrolldbConnectionString)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim date1 As DateTime = DateTime.Now
        Dim date2 As DateTime = DateTime.Parse(expire_date)

        If date1.Date > date2.Date Then

            MsgBox("Application is Expired!", MsgBoxStyle.Exclamation)
        Else

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

                    Dim FormDashboard1 As New Dashboard
                    FormDashboard1.lbl_welcome.Text = "Welcome, " + dt.Rows(0)("full_name").ToString()
                    FormDashboard1.textbox_login.Text = dt.Rows(0)("full_name").ToString() + " (" + dt.Rows(0)("user_type").ToString().Trim + ")"
                    FormDashboard1.Show()

                    txtb_username.Text = ""
                    txtb_userpassword.Text = ""

                    If dt.Rows(0)("user_type").ToString().Trim = "Admin" Then

                        FormDashboard1.btnDashboard.Visible = True
                        FormDashboard1.btnPayroll.Visible = True
                        'FormDashboard1.btnAttendance.Visible = True
                        FormDashboard1.Button1.Visible = True
                        FormDashboard1.btnReport.Visible = True
                        FormDashboard1.btnEmployee.Visible = True
                        FormDashboard1.btnDeduction.Visible = True
                        FormDashboard1.btnRegister.Visible = True

                        FormDashboard1.picDashboard.Visible = True
                        FormDashboard1.picPayroll.Visible = True
                        FormDashboard1.picAttendance.Visible = True
                        FormDashboard1.picReport.Visible = True
                        FormDashboard1.picEmployee.Visible = True
                        FormDashboard1.picDeduction.Visible = True
                        FormDashboard1.picRegister.Visible = True

                    ElseIf dt.Rows(0)("user_type").ToString().Trim = "Staff" Then

                        FormDashboard1.btnDashboard.Visible = True
                        FormDashboard1.btnPayroll.Visible = True
                        'FormDashboard1.btnAttendance.Visible = True
                        FormDashboard1.Button1.Visible = True
                        FormDashboard1.btnReport.Visible = False
                        FormDashboard1.btnEmployee.Visible = False
                        FormDashboard1.btnDeduction.Visible = False
                        FormDashboard1.btnRegister.Visible = False

                        FormDashboard1.picDashboard.Visible = True
                        FormDashboard1.picPayroll.Visible = True
                        FormDashboard1.picAttendance.Visible = True
                        FormDashboard1.picReport.Visible = False
                        FormDashboard1.picEmployee.Visible = False
                        FormDashboard1.picDeduction.Visible = False
                        FormDashboard1.picRegister.Visible = False

                    ElseIf dt.Rows(0)("user_type").ToString().Trim = "Employee" Then

                        FormDashboard1.btnDashboard.Visible = True
                        FormDashboard1.btnPayroll.Visible = False
                        'FormDashboard1.btnAttendance.Visible = True
                        FormDashboard1.Button1.Visible = True
                        FormDashboard1.btnReport.Visible = True
                        FormDashboard1.btnEmployee.Visible = False
                        FormDashboard1.btnDeduction.Visible = False
                        FormDashboard1.btnRegister.Visible = False

                        FormDashboard1.picDashboard.Visible = True
                        FormDashboard1.picPayroll.Visible = False
                        FormDashboard1.picAttendance.Visible = False
                        FormDashboard1.picReport.Visible = True
                        FormDashboard1.picEmployee.Visible = False
                        FormDashboard1.picDeduction.Visible = False
                        FormDashboard1.picRegister.Visible = False
                    Else

                        MsgBox("This User is no User Type", MsgBoxStyle.Information)
                        FormDashboard1.btnDashboard.Visible = True
                        FormDashboard1.btnPayroll.Visible = False
                        'FormDashboard1.btnAttendance.Visible = True
                        FormDashboard1.Button1.Visible = True
                        FormDashboard1.btnReport.Visible = False
                        FormDashboard1.btnEmployee.Visible = False
                        FormDashboard1.btnDeduction.Visible = False
                        FormDashboard1.btnRegister.Visible = False

                        FormDashboard1.picDashboard.Visible = True
                        FormDashboard1.picPayroll.Visible = False
                        FormDashboard1.picAttendance.Visible = False
                        FormDashboard1.picReport.Visible = False
                        FormDashboard1.picEmployee.Visible = False
                        FormDashboard1.picDeduction.Visible = False
                        FormDashboard1.picRegister.Visible = False

                    End If
                    conn.Dispose()
                Else
                    MsgBox("Account not found!", MsgBoxStyle.Critical)
                    conn.Dispose()

                End If
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
