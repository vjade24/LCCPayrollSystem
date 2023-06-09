<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnPayroll = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.picEmployee = New System.Windows.Forms.PictureBox()
        Me.picPayroll = New System.Windows.Forms.PictureBox()
        Me.picReport = New System.Windows.Forms.PictureBox()
        Me.picDashboard = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lbl_welcome = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.picHoliday = New System.Windows.Forms.PictureBox()
        Me.btnHoliday = New System.Windows.Forms.Button()
        Me.picRegister = New System.Windows.Forms.PictureBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.picDeduction = New System.Windows.Forms.PictureBox()
        Me.btnDeduction = New System.Windows.Forms.Button()
        Me.picAttendance = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.textbox_login = New System.Windows.Forms.TextBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.LblBreadCrump = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_datetime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picDeductionFixed = New System.Windows.Forms.PictureBox()
        Me.btnDeductionFixed = New System.Windows.Forms.Button()
        CType(Me.picEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        CType(Me.picHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picDeductionFixed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEmployee
        '
        Me.btnEmployee.BackColor = System.Drawing.Color.White
        Me.btnEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.Location = New System.Drawing.Point(12, 257)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(179, 47)
        Me.btnEmployee.TabIndex = 20
        Me.btnEmployee.Text = "    Employee"
        Me.btnEmployee.UseVisualStyleBackColor = False
        '
        'btnPayroll
        '
        Me.btnPayroll.BackColor = System.Drawing.Color.White
        Me.btnPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayroll.Location = New System.Drawing.Point(12, 97)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Size = New System.Drawing.Size(179, 46)
        Me.btnPayroll.TabIndex = 21
        Me.btnPayroll.Text = "Payroll"
        Me.btnPayroll.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.White
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(12, 205)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(179, 44)
        Me.btnReport.TabIndex = 22
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.White
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.Location = New System.Drawing.Point(12, 42)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(179, 47)
        Me.btnDashboard.TabIndex = 24
        Me.btnDashboard.Text = "     Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'picEmployee
        '
        Me.picEmployee.BackColor = System.Drawing.Color.Transparent
        Me.picEmployee.Image = CType(resources.GetObject("picEmployee.Image"), System.Drawing.Image)
        Me.picEmployee.Location = New System.Drawing.Point(30, 265)
        Me.picEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.picEmployee.Name = "picEmployee"
        Me.picEmployee.Size = New System.Drawing.Size(27, 30)
        Me.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEmployee.TabIndex = 25
        Me.picEmployee.TabStop = False
        '
        'picPayroll
        '
        Me.picPayroll.BackColor = System.Drawing.Color.Transparent
        Me.picPayroll.Image = CType(resources.GetObject("picPayroll.Image"), System.Drawing.Image)
        Me.picPayroll.Location = New System.Drawing.Point(30, 105)
        Me.picPayroll.Margin = New System.Windows.Forms.Padding(2)
        Me.picPayroll.Name = "picPayroll"
        Me.picPayroll.Size = New System.Drawing.Size(27, 30)
        Me.picPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayroll.TabIndex = 26
        Me.picPayroll.TabStop = False
        '
        'picReport
        '
        Me.picReport.BackColor = System.Drawing.Color.Transparent
        Me.picReport.Image = CType(resources.GetObject("picReport.Image"), System.Drawing.Image)
        Me.picReport.Location = New System.Drawing.Point(30, 212)
        Me.picReport.Margin = New System.Windows.Forms.Padding(2)
        Me.picReport.Name = "picReport"
        Me.picReport.Size = New System.Drawing.Size(27, 30)
        Me.picReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picReport.TabIndex = 28
        Me.picReport.TabStop = False
        '
        'picDashboard
        '
        Me.picDashboard.BackColor = System.Drawing.Color.Transparent
        Me.picDashboard.Image = CType(resources.GetObject("picDashboard.Image"), System.Drawing.Image)
        Me.picDashboard.Location = New System.Drawing.Point(30, 50)
        Me.picDashboard.Margin = New System.Windows.Forms.Padding(2)
        Me.picDashboard.Name = "picDashboard"
        Me.picDashboard.Size = New System.Drawing.Size(27, 30)
        Me.picDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDashboard.TabIndex = 29
        Me.picDashboard.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.White
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(0, 525)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(217, 44)
        Me.btnLogout.TabIndex = 30
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lbl_welcome
        '
        Me.lbl_welcome.AutoSize = True
        Me.lbl_welcome.BackColor = System.Drawing.Color.Transparent
        Me.lbl_welcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_welcome.ForeColor = System.Drawing.Color.Black
        Me.lbl_welcome.Location = New System.Drawing.Point(14, 14)
        Me.lbl_welcome.Name = "lbl_welcome"
        Me.lbl_welcome.Size = New System.Drawing.Size(13, 13)
        Me.lbl_welcome.TabIndex = 31
        Me.lbl_welcome.Text = "--"
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PanelMenu.Controls.Add(Me.picDeductionFixed)
        Me.PanelMenu.Controls.Add(Me.btnDeductionFixed)
        Me.PanelMenu.Controls.Add(Me.picHoliday)
        Me.PanelMenu.Controls.Add(Me.btnHoliday)
        Me.PanelMenu.Controls.Add(Me.picRegister)
        Me.PanelMenu.Controls.Add(Me.btnRegister)
        Me.PanelMenu.Controls.Add(Me.picDeduction)
        Me.PanelMenu.Controls.Add(Me.btnDeduction)
        Me.PanelMenu.Controls.Add(Me.picAttendance)
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Controls.Add(Me.lbl_welcome)
        Me.PanelMenu.Controls.Add(Me.btnLogout)
        Me.PanelMenu.Controls.Add(Me.picDashboard)
        Me.PanelMenu.Controls.Add(Me.picReport)
        Me.PanelMenu.Controls.Add(Me.picPayroll)
        Me.PanelMenu.Controls.Add(Me.picEmployee)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.btnReport)
        Me.PanelMenu.Controls.Add(Me.btnPayroll)
        Me.PanelMenu.Controls.Add(Me.btnEmployee)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 55)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(217, 569)
        Me.PanelMenu.TabIndex = 7
        '
        'picHoliday
        '
        Me.picHoliday.BackColor = System.Drawing.Color.Transparent
        Me.picHoliday.Image = CType(resources.GetObject("picHoliday.Image"), System.Drawing.Image)
        Me.picHoliday.Location = New System.Drawing.Point(30, 480)
        Me.picHoliday.Margin = New System.Windows.Forms.Padding(2)
        Me.picHoliday.Name = "picHoliday"
        Me.picHoliday.Size = New System.Drawing.Size(27, 30)
        Me.picHoliday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHoliday.TabIndex = 39
        Me.picHoliday.TabStop = False
        '
        'btnHoliday
        '
        Me.btnHoliday.BackColor = System.Drawing.Color.White
        Me.btnHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoliday.Location = New System.Drawing.Point(12, 472)
        Me.btnHoliday.Name = "btnHoliday"
        Me.btnHoliday.Size = New System.Drawing.Size(179, 46)
        Me.btnHoliday.TabIndex = 38
        Me.btnHoliday.Text = "      Holiday List"
        Me.btnHoliday.UseVisualStyleBackColor = False
        '
        'picRegister
        '
        Me.picRegister.BackColor = System.Drawing.Color.Transparent
        Me.picRegister.Image = CType(resources.GetObject("picRegister.Image"), System.Drawing.Image)
        Me.picRegister.Location = New System.Drawing.Point(30, 427)
        Me.picRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.picRegister.Name = "picRegister"
        Me.picRegister.Size = New System.Drawing.Size(27, 30)
        Me.picRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRegister.TabIndex = 37
        Me.picRegister.TabStop = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.White
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(12, 420)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(179, 44)
        Me.btnRegister.TabIndex = 36
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'picDeduction
        '
        Me.picDeduction.BackColor = System.Drawing.Color.Transparent
        Me.picDeduction.Image = CType(resources.GetObject("picDeduction.Image"), System.Drawing.Image)
        Me.picDeduction.Location = New System.Drawing.Point(30, 320)
        Me.picDeduction.Margin = New System.Windows.Forms.Padding(2)
        Me.picDeduction.Name = "picDeduction"
        Me.picDeduction.Size = New System.Drawing.Size(27, 30)
        Me.picDeduction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeduction.TabIndex = 35
        Me.picDeduction.TabStop = False
        '
        'btnDeduction
        '
        Me.btnDeduction.BackColor = System.Drawing.Color.White
        Me.btnDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeduction.Location = New System.Drawing.Point(12, 312)
        Me.btnDeduction.Name = "btnDeduction"
        Me.btnDeduction.Size = New System.Drawing.Size(179, 46)
        Me.btnDeduction.TabIndex = 34
        Me.btnDeduction.Text = "     Deduction"
        Me.btnDeduction.UseVisualStyleBackColor = False
        '
        'picAttendance
        '
        Me.picAttendance.BackColor = System.Drawing.Color.Transparent
        Me.picAttendance.Image = CType(resources.GetObject("picAttendance.Image"), System.Drawing.Image)
        Me.picAttendance.Location = New System.Drawing.Point(30, 157)
        Me.picAttendance.Margin = New System.Windows.Forms.Padding(2)
        Me.picAttendance.Name = "picAttendance"
        Me.picAttendance.Size = New System.Drawing.Size(27, 30)
        Me.picAttendance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAttendance.TabIndex = 33
        Me.picAttendance.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 46)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "      Attendance"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.textbox_login)
        Me.Panel1.Controls.Add(Me.PictureBox13)
        Me.Panel1.Controls.Add(Me.LblBreadCrump)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(217, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 44)
        Me.Panel1.TabIndex = 8
        '
        'textbox_login
        '
        Me.textbox_login.BackColor = System.Drawing.SystemColors.Control
        Me.textbox_login.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textbox_login.Cursor = System.Windows.Forms.Cursors.Default
        Me.textbox_login.Location = New System.Drawing.Point(633, 19)
        Me.textbox_login.Name = "textbox_login"
        Me.textbox_login.ReadOnly = True
        Me.textbox_login.Size = New System.Drawing.Size(225, 13)
        Me.textbox_login.TabIndex = 45
        Me.textbox_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(863, 8)
        Me.PictureBox13.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(31, 28)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 44
        Me.PictureBox13.TabStop = False
        '
        'LblBreadCrump
        '
        Me.LblBreadCrump.AutoSize = True
        Me.LblBreadCrump.BackColor = System.Drawing.Color.Transparent
        Me.LblBreadCrump.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBreadCrump.ForeColor = System.Drawing.Color.DimGray
        Me.LblBreadCrump.Location = New System.Drawing.Point(6, 8)
        Me.LblBreadCrump.Name = "LblBreadCrump"
        Me.LblBreadCrump.Size = New System.Drawing.Size(22, 24)
        Me.LblBreadCrump.TabIndex = 43
        Me.LblBreadCrump.Text = "--"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.lbl_datetime)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1122, 55)
        Me.Panel2.TabIndex = 1
        '
        'lbl_datetime
        '
        Me.lbl_datetime.AutoSize = True
        Me.lbl_datetime.BackColor = System.Drawing.Color.Transparent
        Me.lbl_datetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datetime.ForeColor = System.Drawing.Color.White
        Me.lbl_datetime.Location = New System.Drawing.Point(14, 24)
        Me.lbl_datetime.Name = "lbl_datetime"
        Me.lbl_datetime.Size = New System.Drawing.Size(13, 13)
        Me.lbl_datetime.TabIndex = 46
        Me.lbl_datetime.Text = "--"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(414, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "LCC Payroll Management System "
        '
        'PanelMain
        '
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(217, 99)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(905, 525)
        Me.PanelMain.TabIndex = 9
        '
        'Timer1
        '
        '
        'picDeductionFixed
        '
        Me.picDeductionFixed.BackColor = System.Drawing.Color.Transparent
        Me.picDeductionFixed.Image = CType(resources.GetObject("picDeductionFixed.Image"), System.Drawing.Image)
        Me.picDeductionFixed.Location = New System.Drawing.Point(30, 374)
        Me.picDeductionFixed.Margin = New System.Windows.Forms.Padding(2)
        Me.picDeductionFixed.Name = "picDeductionFixed"
        Me.picDeductionFixed.Size = New System.Drawing.Size(27, 30)
        Me.picDeductionFixed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeductionFixed.TabIndex = 41
        Me.picDeductionFixed.TabStop = False
        '
        'btnDeductionFixed
        '
        Me.btnDeductionFixed.BackColor = System.Drawing.Color.White
        Me.btnDeductionFixed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeductionFixed.Location = New System.Drawing.Point(12, 366)
        Me.btnDeductionFixed.Name = "btnDeductionFixed"
        Me.btnDeductionFixed.Size = New System.Drawing.Size(179, 46)
        Me.btnDeductionFixed.TabIndex = 40
        Me.btnDeductionFixed.Text = "           Fix Deduction"
        Me.btnDeductionFixed.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 624)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.picEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.picHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRegister, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picDeductionFixed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnPayroll As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents picEmployee As PictureBox
    Friend WithEvents picPayroll As PictureBox
    Friend WithEvents picReport As PictureBox
    Friend WithEvents picDashboard As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents lbl_welcome As Label
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents textbox_login As TextBox
    Friend WithEvents LblBreadCrump As Label
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents picAttendance As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents picDeduction As PictureBox
    Friend WithEvents btnDeduction As Button
    Friend WithEvents picRegister As PictureBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents picHoliday As PictureBox
    Friend WithEvents btnHoliday As Button
    Friend WithEvents lbl_datetime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picDeductionFixed As PictureBox
    Friend WithEvents btnDeductionFixed As Button
End Class
