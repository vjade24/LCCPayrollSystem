Public Class Dashboard

    'Fields'
    Private currentBtn As Button
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        DisableButton()
        currentBtn = CType(senderBtn, Button)
        'currentBtn.BackColor = Color.FromArgb(31, 30, 68)
        'currentBtn.ForeColor = customColor
    End Sub

    Private Sub OpenChildForm(childForm As Form)
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
        LblBreadCrump.Text = childForm.Text
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.White
            'currentBtn.ForeColor = Color.Gainsboro
            'currentBtn.TextAlign = ContentAlignment.MiddleLeft
            'currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            'currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Public Structure RGBColors
        Public Shared color1 As Color = Color.FromArgb(172, 126, 241)
        Public Shared color2 As Color = Color.FromArgb(249, 118, 176)
        Public Shared color3 As Color = Color.FromArgb(253, 138, 114)
        Public Shared color4 As Color = Color.FromArgb(95, 77, 221)
        Public Shared color5 As Color = Color.FromArgb(249, 88, 155)
        Public Shared color6 As Color = Color.FromArgb(24, 161, 251)
    End Structure

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActiveButton(sender, RGBColors.color6)
        OpenChildForm(New Dashboard1)
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        ActiveButton(sender, RGBColors.color6)
        OpenChildForm(New Employee)
    End Sub

    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        ActiveButton(sender, RGBColors.color6)
        OpenChildForm(New Payroll)
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        ActiveButton(sender, RGBColors.color6)
        OpenChildForm(New Attendance)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ActiveButton(sender, RGBColors.color6)
        OpenChildForm(New Reports)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class