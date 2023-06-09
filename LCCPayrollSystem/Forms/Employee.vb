﻿Imports System.Data.SqlClient

Public Class Employee


    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        'Dashboard.Show()
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub txtbSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbSearch.TextChanged
        Dim query As String = "select id AS Id,first_name AS FirstName,last_name AS LastName,middle_name as MiddleName,date_hire as DateHired,employee_status AS EmployeeStatus from employee_tbl where last_name like '%" + txtbSearch.Text.ToString().Trim() + "%' or first_name like '%" + txtbSearch.Text.ToString().Trim() + "%' or Id like '%" + txtbSearch.Text.ToString().Trim() + "%'"
        CommonQuery(query, Employee_tblDataGridView)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToShortTimeString
        lblDate.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub CountEmployee()

        Dim dt As New DataTable
        dt = RetrieveData("select count(id) as total_employee from employee_tbl")
        lbltotalemployee.Text = dt.Rows(0)("total_employee").ToString()

        Dim dt1 As New DataTable
        dt1 = RetrieveData("select count(id) as total_active_employee from employee_tbl where employee_status = 'Active'")
        lblactive.Text = dt1.Rows(0)("total_active_employee").ToString()

        Dim dt2 As New DataTable
        dt2 = RetrieveData("select count(id) as total_inactive_employee from employee_tbl where employee_status <> 'Active'")
        lblinactive.Text = dt2.Rows(0)("total_inactive_employee").ToString()

    End Sub

    Private Sub BTNNEW_Click(sender As Object, e As EventArgs) Handles BTNNEW.Click
        'Me.Hide()
        'Me.Dispose()
        EmployeeAddUpdate.ShowDialog()

        'ActiveButton(sender, Color.ForestGreen)
        'OpenChildForm(New EmployeeAddUpdate)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim OBJ As New ReportViewer
        OBJ.StringReportFile = "EmployeeListReport"
        OBJ.StringQuery = "select * from employee_tbl"
        OBJ.Show()
        Me.Hide()

    End Sub

    'Private currentBtn As Button
    'Private leftBorderBtn As Panel
    'Private currentChildForm As Form

    'Private Sub ActiveButton(senderBtn As Object, customColor As Color)
    '    DisableButton()
    '    currentBtn = CType(senderBtn, Button)
    'End Sub

    'Private Sub OpenChildForm(childForm As Form)

    '    Dim OBJ_dashboard As New Dashboard

    '    If currentChildForm IsNot Nothing Then
    '        currentChildForm.Close()
    '    End If
    '    currentChildForm = childForm
    '    childForm.TopLevel = False
    '    childForm.FormBorderStyle = FormBorderStyle.None
    '    childForm.Dock = DockStyle.Fill
    '    OBJ_dashboard.PanelMain.Controls.Add(childForm)
    '    OBJ_dashboard.PanelMain.Tag = childForm
    '    childForm.BringToFront()
    '    childForm.Show()
    '    OBJ_dashboard.LblBreadCrump.Text = "Create New Employee"
    'End Sub

    'Private Sub DisableButton()
    '    If currentBtn IsNot Nothing Then
    '        currentBtn.BackColor = Color.White
    '    End If
    'End Sub


    Public Sub RefreshData()
        Dim query As String = "select id AS ID,first_name AS FirstName,last_name AS LastName,middle_name as MiddleName,date_hire as DateHired,employee_status AS Status from employee_tbl"
        CommonQuery(query, Employee_tblDataGridView)
        CountEmployee()
    End Sub

End Class