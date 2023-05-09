

Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports CrystalDecisions
Imports System.IO
Public Class Reports
    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrolldbDataSet.payroll_tbl' table. You can move, or remove it, as needed.
        Me.Payroll_tblTableAdapter.Fill(Me.PayrolldbDataSet.payroll_tbl)
        'TODO: This line of code loads data into the 'PayrolldbDataSet.vw_payroll_tbl' table. You can move, or remove it, as needed.
        Me.Vw_payroll_tblTableAdapter.Fill(Me.PayrolldbDataSet.vw_payroll_tbl)
        Dim query2 As String = "select * from vw_payroll_tbl where department_assigned = '' and payroll_no = ''"
        CommonQuery(query2, Vw_payroll_tblDataGridView)
        department_assigned.SelectedItem = 0
        'Payroll_noComboBox.SelectedItem = 0
    End Sub

    Private Sub department_assigned_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles department_assigned.SelectedIndexChanged
        'Dim query As String = "select distinct payroll_no from payroll_tbl where department_assigned = '" + department_assigned.Text.ToString().Trim() + "'"
        'ComboboxQuery(query, Payroll_noComboBox, "payroll_no", "payroll_no")

        Dim query1 As String = "select * from vw_payroll_tbl where department_assigned = '" + department_assigned.Text.ToString().Trim() + "' and (period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString().Trim() + "' AND '" + Period_toDateTimePicker.Value.ToString().Trim() + "' OR period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString().Trim() + "' AND '" + Period_toDateTimePicker.Value.ToString().Trim() + "') ORDER BY employee_name"
        CommonQuery(query1, Vw_payroll_tblDataGridView)
    End Sub

    'Private Sub Payroll_noComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    '    Dim query2 As String = "select * from vw_payroll_tbl where department_assigned = '" + department_assigned.Text.ToString().Trim() + "' and (period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString().Trim() + "' AND '" + Period_toDateTimePicker.Value.ToString().Trim() + "' OR period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString().Trim() + "' AND '" + Period_toDateTimePicker.Value.ToString().Trim() + "')"
    '    CommonQuery(query2, Vw_payroll_tblDataGridView)
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If department_assigned.Text.ToString().Trim() = "" Or Period_fromDateTimePicker.Value.ToString.Trim = Nothing Or Period_toDateTimePicker.Value.ToString.Trim = Nothing Then
                MsgBox("Department Assined and Payroll No is REQUIRED", MsgBoxStyle.Exclamation)
                Return
            ElseIf Vw_payroll_tblDataGridView.Rows.Count < 0 Then
                MsgBox("NO DATA FOUND", MsgBoxStyle.Exclamation)
                Return
            Else
                Dim OBJ As New ReportViewer
                OBJ.StringReportFile = "PayrollReport"
                OBJ.StringQuery = "select * from vw_payroll_tbl where department_assigned = '" + department_assigned.Text.ToString().Trim() + "' and (period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString().Trim() + "' AND '" + Period_toDateTimePicker.Value.ToString().Trim() + "' OR period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString().Trim() + "' AND '" + Period_toDateTimePicker.Value.ToString().Trim() + "') ORDER BY employee_name"
                OBJ.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Exclamation)
            Return
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If department_assigned.Text.ToString().Trim() = "" Or Period_fromDateTimePicker.Value.ToString.Trim = Nothing Or Period_toDateTimePicker.Value.ToString.Trim = Nothing Then
                MsgBox("Department Assined and Payroll No is REQUIRED", MsgBoxStyle.Exclamation)
                Return
            ElseIf Vw_payroll_tblDataGridView.Rows.Count < 0 Then
                MsgBox("NO DATA FOUND", MsgBoxStyle.Exclamation)
                Return
            Else
                Dim OBJ As New ReportViewer
                OBJ.StringReportFile = "PayslipReport"
                OBJ.StringQuery = "select * from vw_payroll_tbl where department_assigned = '" + department_assigned.Text.ToString().Trim() + "' and (period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString().Trim() + "' AND '" + Period_toDateTimePicker.Value.ToString().Trim() + "' OR period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString().Trim() + "' AND '" + Period_toDateTimePicker.Value.ToString().Trim() + "') ORDER BY employee_name"
                OBJ.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Exclamation)
            Return
        End Try
    End Sub

    Private Sub Period_fromDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Period_fromDateTimePicker.ValueChanged
        Dim query2 As String = "select * from vw_payroll_tbl where department_assigned = '" + department_assigned.Text.ToString().Trim() + "' and (period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString().Trim() + "' AND '" + Period_toDateTimePicker.Value.ToString().Trim() + "' OR period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString().Trim() + "' AND '" + Period_toDateTimePicker.Value.ToString().Trim() + "') ORDER BY employee_name"
        CommonQuery(query2, Vw_payroll_tblDataGridView)
    End Sub

    Private Sub Period_toDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Period_toDateTimePicker.ValueChanged
        Dim query2 As String = "select * from vw_payroll_tbl where department_assigned = '" + department_assigned.Text.ToString().Trim() + "' and (period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString().Trim() + "' AND '" + Period_toDateTimePicker.Value.ToString().Trim() + "' OR period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString().Trim() + "' AND '" + Period_toDateTimePicker.Value.ToString().Trim() + "') ORDER BY employee_name"
        CommonQuery(query2, Vw_payroll_tblDataGridView)
    End Sub
End Class