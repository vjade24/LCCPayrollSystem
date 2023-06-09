﻿Public Class Dashboard

    Private currentBtn As Button
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        DisableButton()
        currentBtn = CType(senderBtn, Button)
    End Sub

    Private Sub OpenChildForm(childForm As Form, LblBreadCrump_Text As String)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelMain.Controls.Add(childForm)
        PanelMain.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        'LblBreadCrump.Text = childForm.Text
        LblBreadCrump.Text = LblBreadCrump_Text
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.White
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActiveButton(sender, Color.ForestGreen)
        OpenChildForm(New Dashboard1, "Dashboard")
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        ActiveButton(sender, Color.ForestGreen)
        OpenChildForm(New Employee, "Employee")
    End Sub

    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        ActiveButton(sender, Color.ForestGreen)
        OpenChildForm(New Payroll, "Create New Payroll")
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs)
        ActiveButton(sender, Color.ForestGreen)
        OpenChildForm(New Attendance, "Attendance")
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ActiveButton(sender, Color.ForestGreen)
        OpenChildForm(New Reports, "Report")
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildForm(New Dashboard1, "Dashboard")
        lbl_datetime.Text = DateTime.Now.ToLongDateString + " " + DateTime.Now.ToShortTimeString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ActiveButton(sender, Color.ForestGreen)
        OpenChildForm(New DTRUpload, "DTR Upload")
    End Sub

    Private Sub btnDeduction_Click(sender As Object, e As EventArgs) Handles btnDeduction.Click
        ActiveButton(sender, Color.ForestGreen)
        OpenChildForm(New Deduction, "Deduction")
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Me.Dispose()
        login.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ActiveButton(sender, Color.ForestGreen)
        OpenChildForm(New Register, "Register")
    End Sub

    Private Sub btnHoliday_Click(sender As Object, e As EventArgs) Handles btnHoliday.Click
        ActiveButton(sender, Color.ForestGreen)
        OpenChildForm(New Holiday, "Holiday")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_datetime.Text = DateTime.Now.ToLongDateString + " " + DateTime.Now.ToShortTimeString
    End Sub

    Private Sub btnDeductionFixed_Click(sender As Object, e As EventArgs) Handles btnDeductionFixed.Click
        ActiveButton(sender, Color.ForestGreen)
        OpenChildForm(New DeductionFixed, "Fix Deduction")
    End Sub
End Class