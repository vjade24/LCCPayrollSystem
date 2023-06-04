
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Public Class Dashboard1
    Private Sub Dashboard1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload_dashboard()
        OverAllTotals()
        'Label16.Text = DateTime.Now.ToShortTimeString
        'Label17.Text = DateTime.Now.ToLongDateString
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs)
        'Me.Close()
        Register.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
        login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Me.Close()
        Employee.Show()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs)
        'Me.Close()
        Deduction.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'Me.Close()
        Payroll.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        'Me.Close()
        Reports.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        reload_dashboard()
    End Sub

    Private Sub reload_dashboard()

        Try
            Using dt As New DataTable()
                Using conn As SqlConnection = New SqlConnection(connection)
                    Using cmd As SqlCommand = New SqlCommand("sp_dashboard", conn)
                        cmd.CommandType = CommandType.StoredProcedure
                        Using adp As New SqlDataAdapter()
                            adp.SelectCommand = cmd
                            adp.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                Label6.Text = dt.Rows(0)("total_active_empl").ToString()
                                Label9.Text = dt.Rows(0)("total_department").ToString()
                                Label12.Text = dt.Rows(0)("total_empl").ToString()
                                Label15.Text = dt.Rows(0)("total_active_empl").ToString()
                            Else
                                MsgBox("NO DATA FOUND!", MsgBoxStyle.Exclamation)
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString().Trim(), MsgBoxStyle.Exclamation)
        End Try

        ' *************************************************************************************
        Try
            Using dt As New DataTable()
                Using conn As SqlConnection = New SqlConnection(connection)
                    Using cmd As SqlCommand = New SqlCommand("select * from employee_tbl", conn)
                        'cmd.CommandType = CommandType.StoredProcedure
                        Using adp As New SqlDataAdapter()
                            adp.SelectCommand = cmd
                            'cmd.Parameters.Add("@p_payroll_incharge_position", SqlDbType.VarChar).Value = TextBox_incharge_desig.Text.ToString().Trim()
                            adp.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                Dim cryRpt As New ReportDocument
                                'Dim report_path As String = Path.Combine(Application.StartupPath, "Dashboard.rpt")
                                'Dim report_path As String = "D:\03 - Work\02 - Solutions\PayrollSystem\PayrollSystem\PayrollSystem\Reports\Payslip.rpt"
                                Dim report_path As String = Path.Combine(Application.StartupPath, "DashboardReport.rpt").Replace("bin\Debug", "\Reports").Replace("bin\Release", "\Reports")
                                cryRpt.Load(report_path)
                                cryRpt.SetDataSource(dt)
                                CrystalReportViewer1.ReportSource = cryRpt
                                CrystalReportViewer1.Zoom(130)
                                CrystalReportViewer1.Refresh()
                            Else
                                MsgBox("NO DATA FOUND!", MsgBoxStyle.Exclamation)
                                Dim cryRpt As New ReportDocument
                                CrystalReportViewer1.ReportSource = cryRpt
                                CrystalReportViewer1.Refresh()
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString().Trim(), MsgBoxStyle.Exclamation)
        End Try
    End Sub
    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Label16.Text = DateTime.Now.ToShortTimeString
    '    Label17.Text = DateTime.Now.ToLongDateString
    'End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs)
        Attendance.Show()
    End Sub

    Private Sub OverAllTotals()
        Dim query As String = "select SUM(gross_pay) AS total_gross_pay,SUM(net_pay) AS total_net_pay from vw_payroll_tbl"
        lbl_total_gross_overall.Text = "00,000.00"
        lbl_total_net_overall.Text = "00,000.00"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                lbl_total_gross_overall.Text = Double.Parse(dt.Rows(0)("total_gross_pay").ToString()).ToString("##,##0.00")
                lbl_total_net_overall.Text = Double.Parse(dt.Rows(0)("total_net_pay").ToString()).ToString("##,##0.00")
            Else
                lbl_total_gross_overall.Text = "00,000.00"
                lbl_total_net_overall.Text = "00,000.00"
            End If
        Catch ex As Exception
            'MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            'Return
        End Try
    End Sub
End Class