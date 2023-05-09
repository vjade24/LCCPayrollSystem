Public Class Dashboard

    'Fields'
    Private currentBtn As Button
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    'Constructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, Button)
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = customColor
            'currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            'IconCurrentForm.IconChar = currentBtn.IconChar
            'IconCurrentForm.IconColor = customColor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = Color.Gainsboro
            'currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelMain.Controls.Add(childForm)
        PanelMain.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        'lblFormTitle.Text = childForm.Text
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        'IconCurrentForm.IconChar = IconChar.Home
        'IconCurrentForm.IconColor = Color.MediumPurple
        'lblFormTitle.Text = "Home"
    End Sub
    'Events'
    'Reset'
    'Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
    '    If currentChildForm IsNot Nothing Then
    '        currentChildForm.Close()
    '    End If
    '    Reset()
    'End Sub

    'Close-Maximize-Minimize'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    'Remove transparent border in maximized state'
    'Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    '    If WindowState = FormWindowState.Maximized Then
    '        FormBorderStyle = FormBorderStyle.None
    '    Else
    '        FormBorderStyle = FormBorderStyle.Sizable
    '    End If
    'End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New Register)
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        ActivateButton(sender, RGBColors.color2)
        OpenChildForm(New Dashboard1)
    End Sub

    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click

        ActivateButton(sender, RGBColors.color3)
        OpenChildForm(New Payroll)
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click

        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New Attendance)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ActivateButton(sender, RGBColors.color5)
        OpenChildForm(New Reports)
    End Sub

    Private Sub btnDeduction_Click(sender As Object, e As EventArgs) Handles btnDeduction.Click
        ActivateButton(sender, RGBColors.color6)
        OpenChildForm(New Deduction)
    End Sub


    Public Structure RGBColors
        Public Shared color1 As Color = Color.FromArgb(172, 126, 241)
        Public Shared color2 As Color = Color.FromArgb(249, 118, 176)
        Public Shared color3 As Color = Color.FromArgb(253, 138, 114)
        Public Shared color4 As Color = Color.FromArgb(95, 77, 221)
        Public Shared color5 As Color = Color.FromArgb(249, 88, 155)
        Public Shared color6 As Color = Color.FromArgb(24, 161, 251)
    End Structure

End Class