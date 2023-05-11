﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payroll
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
        Dim Period_toLabel As System.Windows.Forms.Label
        Dim Period_fromLabel As System.Windows.Forms.Label
        Dim Payroll_noLabel As System.Windows.Forms.Label
        Dim Department_assignedLabel As System.Windows.Forms.Label
        Dim Unit_rateLabel As System.Windows.Forms.Label
        Dim Hourly_rateLabel As System.Windows.Forms.Label
        Dim Daily_rateLabel As System.Windows.Forms.Label
        Dim Monthly_rateLabel As System.Windows.Forms.Label
        Dim Rate_basis_descrLabel As System.Windows.Forms.Label
        Dim Employee_idLabel As System.Windows.Forms.Label
        Dim Net_payLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim Regular_wagesLabel As System.Windows.Forms.Label
        Dim Gross_payLabel As System.Windows.Forms.Label
        Dim Adjustments_amtLabel As System.Windows.Forms.Label
        Dim Allowances_amtLabel As System.Windows.Forms.Label
        Dim Overtime_amtLabel As System.Windows.Forms.Label
        Dim Other_loans_amtLabel As System.Windows.Forms.Label
        Dim Other_ded_amtLabel As System.Windows.Forms.Label
        Dim Wtax_amtLabel As System.Windows.Forms.Label
        Dim Phic_amtLabel As System.Windows.Forms.Label
        Dim Pag_ibig_amtLabel As System.Windows.Forms.Label
        Dim Sss_loan_amtLabel As System.Windows.Forms.Label
        Dim Sss_med_amtLabel As System.Windows.Forms.Label
        Dim Cash_advance_amtLabel As System.Windows.Forms.Label
        Dim Lates_in_amtLabel As System.Windows.Forms.Label
        Dim Lates_in_minLabel As System.Windows.Forms.Label
        Dim Absent_amtLabel As System.Windows.Forms.Label
        Dim Absent_daysLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim Middle_nameLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim King_coop_loanLabel As System.Windows.Forms.Label
        Dim Lbp_loanLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payroll))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Period_toDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Period_fromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.department_assigned = New System.Windows.Forms.ComboBox()
        Me.Payroll_noComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PhotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Employee_idComboBox = New System.Windows.Forms.ComboBox()
        Me.Unit_rateTextBox = New System.Windows.Forms.TextBox()
        Me.rate_basis_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Hourly_rateTextBox = New System.Windows.Forms.TextBox()
        Me.Daily_rateTextBox = New System.Windows.Forms.TextBox()
        Me.Monthly_rateTextBox = New System.Windows.Forms.TextBox()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.Net_payTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Worked_daysLabel = New System.Windows.Forms.Label()
        Me.Worked_daysTextBox = New System.Windows.Forms.TextBox()
        Me.Regular_wagesTextBox = New System.Windows.Forms.TextBox()
        Me.Overtime_amtTextBox = New System.Windows.Forms.TextBox()
        Me.Gross_payTextBox = New System.Windows.Forms.TextBox()
        Me.Adjustments_amtTextBox = New System.Windows.Forms.TextBox()
        Me.Allowances_amtTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lbp_loanTextBox = New System.Windows.Forms.TextBox()
        Me.King_coop_loanTextBox = New System.Windows.Forms.TextBox()
        Me.Payroll_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrolldbDataSet = New LCCPayrollSystem.payrolldbDataSet()
        Me.total_deduction_TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Absent_daysTextBox = New System.Windows.Forms.TextBox()
        Me.Other_loans_amtTextBox = New System.Windows.Forms.TextBox()
        Me.Other_ded_amtTextBox = New System.Windows.Forms.TextBox()
        Me.Wtax_amtTextBox = New System.Windows.Forms.TextBox()
        Me.Phic_amtTextBox = New System.Windows.Forms.TextBox()
        Me.Pag_ibig_amtTextBox = New System.Windows.Forms.TextBox()
        Me.Sss_loan_amtTextBox = New System.Windows.Forms.TextBox()
        Me.Sss_med_amtTextBox = New System.Windows.Forms.TextBox()
        Me.Cash_advance_amtTextBox = New System.Windows.Forms.TextBox()
        Me.Lates_in_amtTextBox = New System.Windows.Forms.TextBox()
        Me.Lates_in_minTextBox = New System.Windows.Forms.TextBox()
        Me.Absent_amtTextBox = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Middle_nameTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Vw_payroll_tblDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayrollnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodfromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodtoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddlenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentassignedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatebasisdescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlyrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegularwagesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OvertimeamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllowancesamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdjustmentsamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkeddaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbsentdaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbsentamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatesinminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatesinamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashadvanceamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SssmedamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SssloanamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagibigamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhicamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WtaxamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherdedamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherloansamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrosspayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetpayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.photo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.king_coop_loan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbp_loan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwpayrolltblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbSearch = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.Vw_payroll_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.vw_payroll_tblTableAdapter()
        Me.Payroll_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.payroll_tblTableAdapter()
        Me.TableAdapterManager = New LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager()
        Me.PayrolldbDataSet1 = New LCCPayrollSystem.payrolldbDataSet()
        Period_toLabel = New System.Windows.Forms.Label()
        Period_fromLabel = New System.Windows.Forms.Label()
        Payroll_noLabel = New System.Windows.Forms.Label()
        Department_assignedLabel = New System.Windows.Forms.Label()
        Unit_rateLabel = New System.Windows.Forms.Label()
        Hourly_rateLabel = New System.Windows.Forms.Label()
        Daily_rateLabel = New System.Windows.Forms.Label()
        Monthly_rateLabel = New System.Windows.Forms.Label()
        Rate_basis_descrLabel = New System.Windows.Forms.Label()
        Employee_idLabel = New System.Windows.Forms.Label()
        Net_payLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        Regular_wagesLabel = New System.Windows.Forms.Label()
        Gross_payLabel = New System.Windows.Forms.Label()
        Adjustments_amtLabel = New System.Windows.Forms.Label()
        Allowances_amtLabel = New System.Windows.Forms.Label()
        Overtime_amtLabel = New System.Windows.Forms.Label()
        Other_loans_amtLabel = New System.Windows.Forms.Label()
        Other_ded_amtLabel = New System.Windows.Forms.Label()
        Wtax_amtLabel = New System.Windows.Forms.Label()
        Phic_amtLabel = New System.Windows.Forms.Label()
        Pag_ibig_amtLabel = New System.Windows.Forms.Label()
        Sss_loan_amtLabel = New System.Windows.Forms.Label()
        Sss_med_amtLabel = New System.Windows.Forms.Label()
        Cash_advance_amtLabel = New System.Windows.Forms.Label()
        Lates_in_amtLabel = New System.Windows.Forms.Label()
        Lates_in_minLabel = New System.Windows.Forms.Label()
        Absent_amtLabel = New System.Windows.Forms.Label()
        Absent_daysLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        Middle_nameLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        King_coop_loanLabel = New System.Windows.Forms.Label()
        Lbp_loanLabel = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Payroll_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Vw_payroll_tblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwpayrolltblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PayrolldbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Period_toLabel
        '
        Period_toLabel.AutoSize = True
        Period_toLabel.Location = New System.Drawing.Point(6, 122)
        Period_toLabel.Name = "Period_toLabel"
        Period_toLabel.Size = New System.Drawing.Size(64, 16)
        Period_toLabel.TabIndex = 7
        Period_toLabel.Text = "Period to:"
        '
        'Period_fromLabel
        '
        Period_fromLabel.AutoSize = True
        Period_fromLabel.Location = New System.Drawing.Point(4, 79)
        Period_fromLabel.Name = "Period_fromLabel"
        Period_fromLabel.Size = New System.Drawing.Size(78, 16)
        Period_fromLabel.TabIndex = 5
        Period_fromLabel.Text = "Period from:"
        '
        'Payroll_noLabel
        '
        Payroll_noLabel.AutoSize = True
        Payroll_noLabel.Location = New System.Drawing.Point(4, 27)
        Payroll_noLabel.Name = "Payroll_noLabel"
        Payroll_noLabel.Size = New System.Drawing.Size(72, 16)
        Payroll_noLabel.TabIndex = 3
        Payroll_noLabel.Text = "Payroll No:"
        '
        'Department_assignedLabel
        '
        Department_assignedLabel.AutoSize = True
        Department_assignedLabel.Location = New System.Drawing.Point(4, 164)
        Department_assignedLabel.Name = "Department_assignedLabel"
        Department_assignedLabel.Size = New System.Drawing.Size(79, 16)
        Department_assignedLabel.TabIndex = 17
        Department_assignedLabel.Text = "Department:"
        '
        'Unit_rateLabel
        '
        Unit_rateLabel.AutoSize = True
        Unit_rateLabel.Location = New System.Drawing.Point(99, 196)
        Unit_rateLabel.Name = "Unit_rateLabel"
        Unit_rateLabel.Size = New System.Drawing.Size(61, 16)
        Unit_rateLabel.TabIndex = 27
        Unit_rateLabel.Text = "Unit rate:"
        '
        'Hourly_rateLabel
        '
        Hourly_rateLabel.AutoSize = True
        Hourly_rateLabel.Location = New System.Drawing.Point(11, 195)
        Hourly_rateLabel.Name = "Hourly_rateLabel"
        Hourly_rateLabel.Size = New System.Drawing.Size(75, 16)
        Hourly_rateLabel.TabIndex = 25
        Hourly_rateLabel.Text = "Hourly rate:"
        '
        'Daily_rateLabel
        '
        Daily_rateLabel.AutoSize = True
        Daily_rateLabel.Location = New System.Drawing.Point(99, 142)
        Daily_rateLabel.Name = "Daily_rateLabel"
        Daily_rateLabel.Size = New System.Drawing.Size(67, 16)
        Daily_rateLabel.TabIndex = 23
        Daily_rateLabel.Text = "Daily rate:"
        '
        'Monthly_rateLabel
        '
        Monthly_rateLabel.AutoSize = True
        Monthly_rateLabel.Location = New System.Drawing.Point(11, 141)
        Monthly_rateLabel.Name = "Monthly_rateLabel"
        Monthly_rateLabel.Size = New System.Drawing.Size(84, 16)
        Monthly_rateLabel.TabIndex = 21
        Monthly_rateLabel.Text = "Monthly rate:"
        '
        'Rate_basis_descrLabel
        '
        Rate_basis_descrLabel.AutoSize = True
        Rate_basis_descrLabel.Location = New System.Drawing.Point(11, 81)
        Rate_basis_descrLabel.Name = "Rate_basis_descrLabel"
        Rate_basis_descrLabel.Size = New System.Drawing.Size(72, 16)
        Rate_basis_descrLabel.TabIndex = 19
        Rate_basis_descrLabel.Text = "Rate Basis"
        '
        'Employee_idLabel
        '
        Employee_idLabel.AutoSize = True
        Employee_idLabel.Location = New System.Drawing.Point(11, 28)
        Employee_idLabel.Name = "Employee_idLabel"
        Employee_idLabel.Size = New System.Drawing.Size(106, 16)
        Employee_idLabel.TabIndex = 9
        Employee_idLabel.Text = "Employee name:"
        '
        'Net_payLabel
        '
        Net_payLabel.AutoSize = True
        Net_payLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Net_payLabel.Location = New System.Drawing.Point(183, 303)
        Net_payLabel.Name = "Net_payLabel"
        Net_payLabel.Size = New System.Drawing.Size(73, 19)
        Net_payLabel.TabIndex = 63
        Net_payLabel.Text = "Net pay:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(11, 241)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(60, 16)
        RemarksLabel.TabIndex = 65
        RemarksLabel.Text = "Remarks"
        '
        'Regular_wagesLabel
        '
        Regular_wagesLabel.AutoSize = True
        Regular_wagesLabel.Location = New System.Drawing.Point(9, 53)
        Regular_wagesLabel.Name = "Regular_wagesLabel"
        Regular_wagesLabel.Size = New System.Drawing.Size(53, 16)
        Regular_wagesLabel.TabIndex = 63
        Regular_wagesLabel.Text = "Wages:"
        '
        'Gross_payLabel
        '
        Gross_payLabel.AutoSize = True
        Gross_payLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Gross_payLabel.Location = New System.Drawing.Point(182, 77)
        Gross_payLabel.Name = "Gross_payLabel"
        Gross_payLabel.Size = New System.Drawing.Size(93, 19)
        Gross_payLabel.TabIndex = 61
        Gross_payLabel.Text = "Gross pay:"
        '
        'Adjustments_amtLabel
        '
        Adjustments_amtLabel.AutoSize = True
        Adjustments_amtLabel.Location = New System.Drawing.Point(182, 48)
        Adjustments_amtLabel.Name = "Adjustments_amtLabel"
        Adjustments_amtLabel.Size = New System.Drawing.Size(78, 16)
        Adjustments_amtLabel.TabIndex = 33
        Adjustments_amtLabel.Text = "Adjustment:"
        '
        'Allowances_amtLabel
        '
        Allowances_amtLabel.AutoSize = True
        Allowances_amtLabel.Location = New System.Drawing.Point(182, 22)
        Allowances_amtLabel.Name = "Allowances_amtLabel"
        Allowances_amtLabel.Size = New System.Drawing.Size(71, 16)
        Allowances_amtLabel.TabIndex = 31
        Allowances_amtLabel.Text = "Allowance:"
        '
        'Overtime_amtLabel
        '
        Overtime_amtLabel.AutoSize = True
        Overtime_amtLabel.Location = New System.Drawing.Point(9, 79)
        Overtime_amtLabel.Name = "Overtime_amtLabel"
        Overtime_amtLabel.Size = New System.Drawing.Size(63, 16)
        Overtime_amtLabel.TabIndex = 29
        Overtime_amtLabel.Text = "Overtime:"
        '
        'Other_loans_amtLabel
        '
        Other_loans_amtLabel.AutoSize = True
        Other_loans_amtLabel.Location = New System.Drawing.Point(183, 183)
        Other_loans_amtLabel.Name = "Other_loans_amtLabel"
        Other_loans_amtLabel.Size = New System.Drawing.Size(83, 16)
        Other_loans_amtLabel.TabIndex = 59
        Other_loans_amtLabel.Text = "Other Loans:"
        '
        'Other_ded_amtLabel
        '
        Other_ded_amtLabel.AutoSize = True
        Other_ded_amtLabel.Location = New System.Drawing.Point(183, 154)
        Other_ded_amtLabel.Name = "Other_ded_amtLabel"
        Other_ded_amtLabel.Size = New System.Drawing.Size(75, 16)
        Other_ded_amtLabel.TabIndex = 57
        Other_ded_amtLabel.Text = "Other Ded.:"
        '
        'Wtax_amtLabel
        '
        Wtax_amtLabel.AutoSize = True
        Wtax_amtLabel.Location = New System.Drawing.Point(183, 124)
        Wtax_amtLabel.Name = "Wtax_amtLabel"
        Wtax_amtLabel.Size = New System.Drawing.Size(43, 16)
        Wtax_amtLabel.TabIndex = 55
        Wtax_amtLabel.Text = "Wtax:"
        '
        'Phic_amtLabel
        '
        Phic_amtLabel.AutoSize = True
        Phic_amtLabel.Location = New System.Drawing.Point(183, 94)
        Phic_amtLabel.Name = "Phic_amtLabel"
        Phic_amtLabel.Size = New System.Drawing.Size(69, 16)
        Phic_amtLabel.TabIndex = 53
        Phic_amtLabel.Text = "Philhealth:"
        '
        'Pag_ibig_amtLabel
        '
        Pag_ibig_amtLabel.AutoSize = True
        Pag_ibig_amtLabel.Location = New System.Drawing.Point(9, 183)
        Pag_ibig_amtLabel.Name = "Pag_ibig_amtLabel"
        Pag_ibig_amtLabel.Size = New System.Drawing.Size(59, 16)
        Pag_ibig_amtLabel.TabIndex = 51
        Pag_ibig_amtLabel.Text = "Pag-ibig:"
        '
        'Sss_loan_amtLabel
        '
        Sss_loan_amtLabel.AutoSize = True
        Sss_loan_amtLabel.Location = New System.Drawing.Point(9, 154)
        Sss_loan_amtLabel.Name = "Sss_loan_amtLabel"
        Sss_loan_amtLabel.Size = New System.Drawing.Size(67, 16)
        Sss_loan_amtLabel.TabIndex = 49
        Sss_loan_amtLabel.Text = "SSS loan:"
        '
        'Sss_med_amtLabel
        '
        Sss_med_amtLabel.AutoSize = True
        Sss_med_amtLabel.Location = New System.Drawing.Point(9, 124)
        Sss_med_amtLabel.Name = "Sss_med_amtLabel"
        Sss_med_amtLabel.Size = New System.Drawing.Size(72, 16)
        Sss_med_amtLabel.TabIndex = 47
        Sss_med_amtLabel.Text = "SSS Med.:"
        '
        'Cash_advance_amtLabel
        '
        Cash_advance_amtLabel.AutoSize = True
        Cash_advance_amtLabel.Location = New System.Drawing.Point(9, 94)
        Cash_advance_amtLabel.Name = "Cash_advance_amtLabel"
        Cash_advance_amtLabel.Size = New System.Drawing.Size(69, 16)
        Cash_advance_amtLabel.TabIndex = 45
        Cash_advance_amtLabel.Text = "Cash Adv.:"
        '
        'Lates_in_amtLabel
        '
        Lates_in_amtLabel.AutoSize = True
        Lates_in_amtLabel.Location = New System.Drawing.Point(183, 60)
        Lates_in_amtLabel.Name = "Lates_in_amtLabel"
        Lates_in_amtLabel.Size = New System.Drawing.Size(75, 16)
        Lates_in_amtLabel.TabIndex = 43
        Lates_in_amtLabel.Text = "Lates Amt.:"
        '
        'Lates_in_minLabel
        '
        Lates_in_minLabel.AutoSize = True
        Lates_in_minLabel.Location = New System.Drawing.Point(9, 63)
        Lates_in_minLabel.Name = "Lates_in_minLabel"
        Lates_in_minLabel.Size = New System.Drawing.Size(76, 16)
        Lates_in_minLabel.TabIndex = 41
        Lates_in_minLabel.Text = "Last in min."
        '
        'Absent_amtLabel
        '
        Absent_amtLabel.AutoSize = True
        Absent_amtLabel.Location = New System.Drawing.Point(183, 28)
        Absent_amtLabel.Name = "Absent_amtLabel"
        Absent_amtLabel.Size = New System.Drawing.Size(84, 16)
        Absent_amtLabel.TabIndex = 39
        Absent_amtLabel.Text = "Absent Amt.:"
        '
        'Absent_daysLabel
        '
        Absent_daysLabel.AutoSize = True
        Absent_daysLabel.Location = New System.Drawing.Point(9, 31)
        Absent_daysLabel.Name = "Absent_daysLabel"
        Absent_daysLabel.Size = New System.Drawing.Size(85, 16)
        Absent_daysLabel.TabIndex = 37
        Absent_daysLabel.Text = "Days absent:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.Location = New System.Drawing.Point(25, 50)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(69, 16)
        Last_nameLabel.TabIndex = 11
        Last_nameLabel.Text = "last name:"
        Last_nameLabel.Visible = False
        '
        'Middle_nameLabel
        '
        Middle_nameLabel.AutoSize = True
        Middle_nameLabel.Location = New System.Drawing.Point(25, 102)
        Middle_nameLabel.Name = "Middle_nameLabel"
        Middle_nameLabel.Size = New System.Drawing.Size(86, 16)
        Middle_nameLabel.TabIndex = 15
        Middle_nameLabel.Text = "middle name:"
        Middle_nameLabel.Visible = False
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.Location = New System.Drawing.Point(25, 76)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(69, 16)
        First_nameLabel.TabIndex = 13
        First_nameLabel.Text = "first name:"
        First_nameLabel.Visible = False
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(61, 18)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 16)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        IdLabel.Visible = False
        '
        'King_coop_loanLabel
        '
        King_coop_loanLabel.AutoSize = True
        King_coop_loanLabel.Location = New System.Drawing.Point(11, 212)
        King_coop_loanLabel.Name = "King_coop_loanLabel"
        King_coop_loanLabel.Size = New System.Drawing.Size(72, 16)
        King_coop_loanLabel.TabIndex = 117
        King_coop_loanLabel.Text = "King Coop:"
        '
        'Lbp_loanLabel
        '
        Lbp_loanLabel.AutoSize = True
        Lbp_loanLabel.Location = New System.Drawing.Point(183, 209)
        Lbp_loanLabel.Name = "Lbp_loanLabel"
        Lbp_loanLabel.Size = New System.Drawing.Size(69, 16)
        Lbp_loanLabel.TabIndex = 118
        Lbp_loanLabel.Text = "LBP Loan:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Period_toDateTimePicker)
        Me.GroupBox5.Controls.Add(Period_toLabel)
        Me.GroupBox5.Controls.Add(Me.Period_fromDateTimePicker)
        Me.GroupBox5.Controls.Add(Period_fromLabel)
        Me.GroupBox5.Controls.Add(Me.department_assigned)
        Me.GroupBox5.Controls.Add(Me.Payroll_noComboBox)
        Me.GroupBox5.Controls.Add(Payroll_noLabel)
        Me.GroupBox5.Controls.Add(Department_assignedLabel)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(341, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(182, 217)
        Me.GroupBox5.TabIndex = 121
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Payroll Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(119, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "(Required)"
        '
        'Period_toDateTimePicker
        '
        Me.Period_toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Period_toDateTimePicker.Location = New System.Drawing.Point(7, 140)
        Me.Period_toDateTimePicker.Name = "Period_toDateTimePicker"
        Me.Period_toDateTimePicker.Size = New System.Drawing.Size(165, 22)
        Me.Period_toDateTimePicker.TabIndex = 8
        '
        'Period_fromDateTimePicker
        '
        Me.Period_fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Period_fromDateTimePicker.Location = New System.Drawing.Point(8, 98)
        Me.Period_fromDateTimePicker.Name = "Period_fromDateTimePicker"
        Me.Period_fromDateTimePicker.Size = New System.Drawing.Size(165, 22)
        Me.Period_fromDateTimePicker.TabIndex = 6
        '
        'department_assigned
        '
        Me.department_assigned.FormattingEnabled = True
        Me.department_assigned.Items.AddRange(New Object() {"College", "Senior High School", "Junior High School", "Elementary"})
        Me.department_assigned.Location = New System.Drawing.Point(7, 183)
        Me.department_assigned.Name = "department_assigned"
        Me.department_assigned.Size = New System.Drawing.Size(165, 24)
        Me.department_assigned.TabIndex = 109
        '
        'Payroll_noComboBox
        '
        Me.Payroll_noComboBox.Enabled = False
        Me.Payroll_noComboBox.FormattingEnabled = True
        Me.Payroll_noComboBox.Location = New System.Drawing.Point(7, 51)
        Me.Payroll_noComboBox.Name = "Payroll_noComboBox"
        Me.Payroll_noComboBox.Size = New System.Drawing.Size(89, 24)
        Me.Payroll_noComboBox.TabIndex = 70
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PhotoPictureBox)
        Me.GroupBox2.Controls.Add(Me.Employee_idComboBox)
        Me.GroupBox2.Controls.Add(Me.Unit_rateTextBox)
        Me.GroupBox2.Controls.Add(Unit_rateLabel)
        Me.GroupBox2.Controls.Add(Me.rate_basis_ComboBox)
        Me.GroupBox2.Controls.Add(Me.Hourly_rateTextBox)
        Me.GroupBox2.Controls.Add(Hourly_rateLabel)
        Me.GroupBox2.Controls.Add(Me.Daily_rateTextBox)
        Me.GroupBox2.Controls.Add(Daily_rateLabel)
        Me.GroupBox2.Controls.Add(Me.Monthly_rateTextBox)
        Me.GroupBox2.Controls.Add(Monthly_rateLabel)
        Me.GroupBox2.Controls.Add(Rate_basis_descrLabel)
        Me.GroupBox2.Controls.Add(Employee_idLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(341, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(182, 245)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(109, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "(Required)"
        '
        'PhotoPictureBox
        '
        Me.PhotoPictureBox.Image = CType(resources.GetObject("PhotoPictureBox.Image"), System.Drawing.Image)
        Me.PhotoPictureBox.InitialImage = Nothing
        Me.PhotoPictureBox.Location = New System.Drawing.Point(121, 81)
        Me.PhotoPictureBox.Name = "PhotoPictureBox"
        Me.PhotoPictureBox.Size = New System.Drawing.Size(47, 48)
        Me.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PhotoPictureBox.TabIndex = 121
        Me.PhotoPictureBox.TabStop = False
        Me.PhotoPictureBox.WaitOnLoad = True
        '
        'Employee_idComboBox
        '
        Me.Employee_idComboBox.FormattingEnabled = True
        Me.Employee_idComboBox.Location = New System.Drawing.Point(8, 50)
        Me.Employee_idComboBox.Name = "Employee_idComboBox"
        Me.Employee_idComboBox.Size = New System.Drawing.Size(164, 24)
        Me.Employee_idComboBox.TabIndex = 69
        '
        'Unit_rateTextBox
        '
        Me.Unit_rateTextBox.Location = New System.Drawing.Point(103, 217)
        Me.Unit_rateTextBox.Name = "Unit_rateTextBox"
        Me.Unit_rateTextBox.Size = New System.Drawing.Size(69, 22)
        Me.Unit_rateTextBox.TabIndex = 28
        Me.Unit_rateTextBox.Text = "0.00"
        Me.Unit_rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rate_basis_ComboBox
        '
        Me.rate_basis_ComboBox.FormattingEnabled = True
        Me.rate_basis_ComboBox.Items.AddRange(New Object() {"Monthly", "Daily", "Hourly", "Per Unit"})
        Me.rate_basis_ComboBox.Location = New System.Drawing.Point(9, 103)
        Me.rate_basis_ComboBox.Name = "rate_basis_ComboBox"
        Me.rate_basis_ComboBox.Size = New System.Drawing.Size(106, 24)
        Me.rate_basis_ComboBox.TabIndex = 111
        '
        'Hourly_rateTextBox
        '
        Me.Hourly_rateTextBox.Location = New System.Drawing.Point(15, 216)
        Me.Hourly_rateTextBox.Name = "Hourly_rateTextBox"
        Me.Hourly_rateTextBox.Size = New System.Drawing.Size(69, 22)
        Me.Hourly_rateTextBox.TabIndex = 26
        Me.Hourly_rateTextBox.Text = "0.00"
        Me.Hourly_rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Daily_rateTextBox
        '
        Me.Daily_rateTextBox.Location = New System.Drawing.Point(103, 163)
        Me.Daily_rateTextBox.Name = "Daily_rateTextBox"
        Me.Daily_rateTextBox.Size = New System.Drawing.Size(69, 22)
        Me.Daily_rateTextBox.TabIndex = 24
        Me.Daily_rateTextBox.Text = "0.00"
        Me.Daily_rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Monthly_rateTextBox
        '
        Me.Monthly_rateTextBox.Location = New System.Drawing.Point(15, 162)
        Me.Monthly_rateTextBox.Name = "Monthly_rateTextBox"
        Me.Monthly_rateTextBox.Size = New System.Drawing.Size(69, 22)
        Me.Monthly_rateTextBox.TabIndex = 22
        Me.Monthly_rateTextBox.Text = "0.00"
        Me.Monthly_rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_calculate
        '
        Me.btn_calculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_calculate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculate.ForeColor = System.Drawing.Color.White
        Me.btn_calculate.Location = New System.Drawing.Point(273, 262)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(89, 35)
        Me.btn_calculate.TabIndex = 117
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = False
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.Location = New System.Drawing.Point(89, 240)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(88, 57)
        Me.RemarksTextBox.TabIndex = 66
        '
        'Net_payTextBox
        '
        Me.Net_payTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Net_payTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Net_payTextBox.Location = New System.Drawing.Point(273, 300)
        Me.Net_payTextBox.Name = "Net_payTextBox"
        Me.Net_payTextBox.ReadOnly = True
        Me.Net_payTextBox.Size = New System.Drawing.Size(88, 26)
        Me.Net_payTextBox.TabIndex = 64
        Me.Net_payTextBox.Text = "0.00"
        Me.Net_payTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Worked_daysLabel)
        Me.GroupBox4.Controls.Add(Me.Worked_daysTextBox)
        Me.GroupBox4.Controls.Add(Regular_wagesLabel)
        Me.GroupBox4.Controls.Add(Me.Regular_wagesTextBox)
        Me.GroupBox4.Controls.Add(Me.Overtime_amtTextBox)
        Me.GroupBox4.Controls.Add(Me.Gross_payTextBox)
        Me.GroupBox4.Controls.Add(Gross_payLabel)
        Me.GroupBox4.Controls.Add(Me.Adjustments_amtTextBox)
        Me.GroupBox4.Controls.Add(Adjustments_amtLabel)
        Me.GroupBox4.Controls.Add(Me.Allowances_amtTextBox)
        Me.GroupBox4.Controls.Add(Allowances_amtLabel)
        Me.GroupBox4.Controls.Add(Overtime_amtLabel)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(529, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(370, 116)
        Me.GroupBox4.TabIndex = 120
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Income"
        '
        'Worked_daysLabel
        '
        Me.Worked_daysLabel.AutoSize = True
        Me.Worked_daysLabel.Location = New System.Drawing.Point(9, 23)
        Me.Worked_daysLabel.Name = "Worked_daysLabel"
        Me.Worked_daysLabel.Size = New System.Drawing.Size(67, 16)
        Me.Worked_daysLabel.TabIndex = 64
        Me.Worked_daysLabel.Text = "Rendered:"
        '
        'Worked_daysTextBox
        '
        Me.Worked_daysTextBox.Location = New System.Drawing.Point(88, 20)
        Me.Worked_daysTextBox.Name = "Worked_daysTextBox"
        Me.Worked_daysTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Worked_daysTextBox.TabIndex = 65
        Me.Worked_daysTextBox.Text = "0.00"
        Me.Worked_daysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Regular_wagesTextBox
        '
        Me.Regular_wagesTextBox.Enabled = False
        Me.Regular_wagesTextBox.Location = New System.Drawing.Point(88, 50)
        Me.Regular_wagesTextBox.Name = "Regular_wagesTextBox"
        Me.Regular_wagesTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Regular_wagesTextBox.TabIndex = 64
        Me.Regular_wagesTextBox.Text = "0.00"
        Me.Regular_wagesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Overtime_amtTextBox
        '
        Me.Overtime_amtTextBox.Location = New System.Drawing.Point(88, 80)
        Me.Overtime_amtTextBox.Name = "Overtime_amtTextBox"
        Me.Overtime_amtTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Overtime_amtTextBox.TabIndex = 30
        Me.Overtime_amtTextBox.Text = "0.00"
        Me.Overtime_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Gross_payTextBox
        '
        Me.Gross_payTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Gross_payTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gross_payTextBox.Location = New System.Drawing.Point(272, 79)
        Me.Gross_payTextBox.Name = "Gross_payTextBox"
        Me.Gross_payTextBox.ReadOnly = True
        Me.Gross_payTextBox.Size = New System.Drawing.Size(88, 26)
        Me.Gross_payTextBox.TabIndex = 62
        Me.Gross_payTextBox.Text = "0.00"
        Me.Gross_payTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Adjustments_amtTextBox
        '
        Me.Adjustments_amtTextBox.Location = New System.Drawing.Point(272, 49)
        Me.Adjustments_amtTextBox.Name = "Adjustments_amtTextBox"
        Me.Adjustments_amtTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Adjustments_amtTextBox.TabIndex = 34
        Me.Adjustments_amtTextBox.Text = "0.00"
        Me.Adjustments_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Allowances_amtTextBox
        '
        Me.Allowances_amtTextBox.Location = New System.Drawing.Point(272, 20)
        Me.Allowances_amtTextBox.Name = "Allowances_amtTextBox"
        Me.Allowances_amtTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Allowances_amtTextBox.TabIndex = 32
        Me.Allowances_amtTextBox.Text = "0.00"
        Me.Allowances_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Lbp_loanLabel)
        Me.GroupBox1.Controls.Add(Me.Lbp_loanTextBox)
        Me.GroupBox1.Controls.Add(King_coop_loanLabel)
        Me.GroupBox1.Controls.Add(Me.King_coop_loanTextBox)
        Me.GroupBox1.Controls.Add(Me.RemarksTextBox)
        Me.GroupBox1.Controls.Add(Me.btn_calculate)
        Me.GroupBox1.Controls.Add(Me.total_deduction_TextBox)
        Me.GroupBox1.Controls.Add(RemarksLabel)
        Me.GroupBox1.Controls.Add(Net_payLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Net_payTextBox)
        Me.GroupBox1.Controls.Add(Me.Absent_daysTextBox)
        Me.GroupBox1.Controls.Add(Me.Other_loans_amtTextBox)
        Me.GroupBox1.Controls.Add(Other_loans_amtLabel)
        Me.GroupBox1.Controls.Add(Me.Other_ded_amtTextBox)
        Me.GroupBox1.Controls.Add(Other_ded_amtLabel)
        Me.GroupBox1.Controls.Add(Me.Wtax_amtTextBox)
        Me.GroupBox1.Controls.Add(Wtax_amtLabel)
        Me.GroupBox1.Controls.Add(Me.Phic_amtTextBox)
        Me.GroupBox1.Controls.Add(Phic_amtLabel)
        Me.GroupBox1.Controls.Add(Me.Pag_ibig_amtTextBox)
        Me.GroupBox1.Controls.Add(Pag_ibig_amtLabel)
        Me.GroupBox1.Controls.Add(Me.Sss_loan_amtTextBox)
        Me.GroupBox1.Controls.Add(Sss_loan_amtLabel)
        Me.GroupBox1.Controls.Add(Me.Sss_med_amtTextBox)
        Me.GroupBox1.Controls.Add(Sss_med_amtLabel)
        Me.GroupBox1.Controls.Add(Me.Cash_advance_amtTextBox)
        Me.GroupBox1.Controls.Add(Cash_advance_amtLabel)
        Me.GroupBox1.Controls.Add(Me.Lates_in_amtTextBox)
        Me.GroupBox1.Controls.Add(Lates_in_amtLabel)
        Me.GroupBox1.Controls.Add(Me.Lates_in_minTextBox)
        Me.GroupBox1.Controls.Add(Lates_in_minLabel)
        Me.GroupBox1.Controls.Add(Me.Absent_amtTextBox)
        Me.GroupBox1.Controls.Add(Absent_amtLabel)
        Me.GroupBox1.Controls.Add(Absent_daysLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(528, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 335)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deductions"
        '
        'Lbp_loanTextBox
        '
        Me.Lbp_loanTextBox.Location = New System.Drawing.Point(272, 203)
        Me.Lbp_loanTextBox.Name = "Lbp_loanTextBox"
        Me.Lbp_loanTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Lbp_loanTextBox.TabIndex = 119
        Me.Lbp_loanTextBox.Text = "0.00"
        Me.Lbp_loanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'King_coop_loanTextBox
        '
        Me.King_coop_loanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Payroll_tblBindingSource, "king_coop_loan", True))
        Me.King_coop_loanTextBox.Location = New System.Drawing.Point(89, 208)
        Me.King_coop_loanTextBox.Name = "King_coop_loanTextBox"
        Me.King_coop_loanTextBox.Size = New System.Drawing.Size(88, 22)
        Me.King_coop_loanTextBox.TabIndex = 118
        Me.King_coop_loanTextBox.Text = "0.00"
        Me.King_coop_loanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Payroll_tblBindingSource
        '
        Me.Payroll_tblBindingSource.DataMember = "payroll_tbl"
        Me.Payroll_tblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'PayrolldbDataSet
        '
        Me.PayrolldbDataSet.DataSetName = "payrolldbDataSet"
        Me.PayrolldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'total_deduction_TextBox
        '
        Me.total_deduction_TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.total_deduction_TextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_deduction_TextBox.Location = New System.Drawing.Point(272, 232)
        Me.total_deduction_TextBox.Name = "total_deduction_TextBox"
        Me.total_deduction_TextBox.ReadOnly = True
        Me.total_deduction_TextBox.Size = New System.Drawing.Size(88, 26)
        Me.total_deduction_TextBox.TabIndex = 62
        Me.total_deduction_TextBox.Text = "0.00"
        Me.total_deduction_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(183, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Total Ded.:"
        '
        'Absent_daysTextBox
        '
        Me.Absent_daysTextBox.Location = New System.Drawing.Point(89, 27)
        Me.Absent_daysTextBox.Name = "Absent_daysTextBox"
        Me.Absent_daysTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Absent_daysTextBox.TabIndex = 38
        Me.Absent_daysTextBox.Text = "0.00"
        Me.Absent_daysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Other_loans_amtTextBox
        '
        Me.Other_loans_amtTextBox.Location = New System.Drawing.Point(273, 177)
        Me.Other_loans_amtTextBox.Name = "Other_loans_amtTextBox"
        Me.Other_loans_amtTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Other_loans_amtTextBox.TabIndex = 60
        Me.Other_loans_amtTextBox.Text = "0.00"
        Me.Other_loans_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Other_ded_amtTextBox
        '
        Me.Other_ded_amtTextBox.Location = New System.Drawing.Point(273, 148)
        Me.Other_ded_amtTextBox.Name = "Other_ded_amtTextBox"
        Me.Other_ded_amtTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Other_ded_amtTextBox.TabIndex = 58
        Me.Other_ded_amtTextBox.Text = "0.00"
        Me.Other_ded_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Wtax_amtTextBox
        '
        Me.Wtax_amtTextBox.Location = New System.Drawing.Point(273, 118)
        Me.Wtax_amtTextBox.Name = "Wtax_amtTextBox"
        Me.Wtax_amtTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Wtax_amtTextBox.TabIndex = 56
        Me.Wtax_amtTextBox.Text = "0.00"
        Me.Wtax_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Phic_amtTextBox
        '
        Me.Phic_amtTextBox.Location = New System.Drawing.Point(273, 88)
        Me.Phic_amtTextBox.Name = "Phic_amtTextBox"
        Me.Phic_amtTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Phic_amtTextBox.TabIndex = 54
        Me.Phic_amtTextBox.Text = "0.00"
        Me.Phic_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Pag_ibig_amtTextBox
        '
        Me.Pag_ibig_amtTextBox.Location = New System.Drawing.Point(89, 179)
        Me.Pag_ibig_amtTextBox.Name = "Pag_ibig_amtTextBox"
        Me.Pag_ibig_amtTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Pag_ibig_amtTextBox.TabIndex = 52
        Me.Pag_ibig_amtTextBox.Text = "0.00"
        Me.Pag_ibig_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Sss_loan_amtTextBox
        '
        Me.Sss_loan_amtTextBox.Location = New System.Drawing.Point(89, 150)
        Me.Sss_loan_amtTextBox.Name = "Sss_loan_amtTextBox"
        Me.Sss_loan_amtTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Sss_loan_amtTextBox.TabIndex = 50
        Me.Sss_loan_amtTextBox.Text = "0.00"
        Me.Sss_loan_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Sss_med_amtTextBox
        '
        Me.Sss_med_amtTextBox.Location = New System.Drawing.Point(89, 120)
        Me.Sss_med_amtTextBox.Name = "Sss_med_amtTextBox"
        Me.Sss_med_amtTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Sss_med_amtTextBox.TabIndex = 48
        Me.Sss_med_amtTextBox.Text = "0.00"
        Me.Sss_med_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Cash_advance_amtTextBox
        '
        Me.Cash_advance_amtTextBox.Location = New System.Drawing.Point(89, 90)
        Me.Cash_advance_amtTextBox.Name = "Cash_advance_amtTextBox"
        Me.Cash_advance_amtTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Cash_advance_amtTextBox.TabIndex = 46
        Me.Cash_advance_amtTextBox.Text = "0.00"
        Me.Cash_advance_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lates_in_amtTextBox
        '
        Me.Lates_in_amtTextBox.Location = New System.Drawing.Point(273, 57)
        Me.Lates_in_amtTextBox.Name = "Lates_in_amtTextBox"
        Me.Lates_in_amtTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Lates_in_amtTextBox.TabIndex = 44
        Me.Lates_in_amtTextBox.Text = "0.00"
        Me.Lates_in_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lates_in_minTextBox
        '
        Me.Lates_in_minTextBox.Location = New System.Drawing.Point(89, 59)
        Me.Lates_in_minTextBox.Name = "Lates_in_minTextBox"
        Me.Lates_in_minTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Lates_in_minTextBox.TabIndex = 42
        Me.Lates_in_minTextBox.Text = "0.00"
        Me.Lates_in_minTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Absent_amtTextBox
        '
        Me.Absent_amtTextBox.Location = New System.Drawing.Point(273, 25)
        Me.Absent_amtTextBox.Name = "Absent_amtTextBox"
        Me.Absent_amtTextBox.Size = New System.Drawing.Size(88, 22)
        Me.Absent_amtTextBox.TabIndex = 40
        Me.Absent_amtTextBox.Text = "0.00"
        Me.Absent_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.ImageKey = "(none)"
        Me.btnCancel.Location = New System.Drawing.Point(636, 478)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 28)
        Me.btnCancel.TabIndex = 151
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.SystemColors.Control
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnupdate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnupdate.Location = New System.Drawing.Point(725, 478)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(83, 28)
        Me.btnupdate.TabIndex = 150
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.Control
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_save.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_save.Location = New System.Drawing.Point(814, 478)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(83, 28)
        Me.btn_save.TabIndex = 148
        Me.btn_save.Text = "Create"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Last_nameLabel)
        Me.GroupBox6.Controls.Add(Me.Middle_nameTextBox)
        Me.GroupBox6.Controls.Add(Me.IdTextBox)
        Me.GroupBox6.Controls.Add(Middle_nameLabel)
        Me.GroupBox6.Controls.Add(Me.First_nameTextBox)
        Me.GroupBox6.Controls.Add(First_nameLabel)
        Me.GroupBox6.Controls.Add(Me.Last_nameTextBox)
        Me.GroupBox6.Controls.Add(IdLabel)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(917, 57)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(264, 145)
        Me.GroupBox6.TabIndex = 122
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        Me.GroupBox6.Visible = False
        '
        'Middle_nameTextBox
        '
        Me.Middle_nameTextBox.Location = New System.Drawing.Point(97, 99)
        Me.Middle_nameTextBox.Name = "Middle_nameTextBox"
        Me.Middle_nameTextBox.Size = New System.Drawing.Size(145, 22)
        Me.Middle_nameTextBox.TabIndex = 16
        Me.Middle_nameTextBox.Visible = False
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(97, 21)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(145, 22)
        Me.IdTextBox.TabIndex = 2
        Me.IdTextBox.Visible = False
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.Location = New System.Drawing.Point(97, 73)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(145, 22)
        Me.First_nameTextBox.TabIndex = 14
        Me.First_nameTextBox.Visible = False
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.Location = New System.Drawing.Point(97, 47)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(145, 22)
        Me.Last_nameTextBox.TabIndex = 12
        Me.Last_nameTextBox.Visible = False
        '
        'Vw_payroll_tblDataGridView
        '
        Me.Vw_payroll_tblDataGridView.AllowUserToAddRows = False
        Me.Vw_payroll_tblDataGridView.AllowUserToDeleteRows = False
        Me.Vw_payroll_tblDataGridView.AutoGenerateColumns = False
        Me.Vw_payroll_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_payroll_tblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.PayrollnoDataGridViewTextBoxColumn, Me.PeriodfromDataGridViewTextBoxColumn, Me.PeriodtoDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.MiddlenameDataGridViewTextBoxColumn, Me.DepartmentassignedDataGridViewTextBoxColumn, Me.RatebasisdescrDataGridViewTextBoxColumn, Me.MonthlyrateDataGridViewTextBoxColumn, Me.DailyrateDataGridViewTextBoxColumn, Me.HourlyrateDataGridViewTextBoxColumn, Me.UnitrateDataGridViewTextBoxColumn, Me.RegularwagesDataGridViewTextBoxColumn, Me.OvertimeamtDataGridViewTextBoxColumn, Me.AllowancesamtDataGridViewTextBoxColumn, Me.AdjustmentsamtDataGridViewTextBoxColumn, Me.WorkeddaysDataGridViewTextBoxColumn, Me.AbsentdaysDataGridViewTextBoxColumn, Me.AbsentamtDataGridViewTextBoxColumn, Me.LatesinminDataGridViewTextBoxColumn, Me.LatesinamtDataGridViewTextBoxColumn, Me.CashadvanceamtDataGridViewTextBoxColumn, Me.SssmedamtDataGridViewTextBoxColumn, Me.SssloanamtDataGridViewTextBoxColumn, Me.PagibigamtDataGridViewTextBoxColumn, Me.PhicamtDataGridViewTextBoxColumn, Me.WtaxamtDataGridViewTextBoxColumn, Me.OtherdedamtDataGridViewTextBoxColumn, Me.OtherloansamtDataGridViewTextBoxColumn, Me.GrosspayDataGridViewTextBoxColumn, Me.NetpayDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn, Me.photo, Me.king_coop_loan, Me.lbp_loan})
        Me.Vw_payroll_tblDataGridView.DataSource = Me.VwpayrolltblBindingSource
        Me.Vw_payroll_tblDataGridView.Location = New System.Drawing.Point(15, 98)
        Me.Vw_payroll_tblDataGridView.Name = "Vw_payroll_tblDataGridView"
        Me.Vw_payroll_tblDataGridView.ReadOnly = True
        Me.Vw_payroll_tblDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Vw_payroll_tblDataGridView.Size = New System.Drawing.Size(295, 359)
        Me.Vw_payroll_tblDataGridView.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'PayrollnoDataGridViewTextBoxColumn
        '
        Me.PayrollnoDataGridViewTextBoxColumn.DataPropertyName = "payroll_no"
        Me.PayrollnoDataGridViewTextBoxColumn.HeaderText = "Payroll No"
        Me.PayrollnoDataGridViewTextBoxColumn.Name = "PayrollnoDataGridViewTextBoxColumn"
        Me.PayrollnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeriodfromDataGridViewTextBoxColumn
        '
        Me.PeriodfromDataGridViewTextBoxColumn.DataPropertyName = "period_from"
        Me.PeriodfromDataGridViewTextBoxColumn.HeaderText = "period_from"
        Me.PeriodfromDataGridViewTextBoxColumn.Name = "PeriodfromDataGridViewTextBoxColumn"
        Me.PeriodfromDataGridViewTextBoxColumn.ReadOnly = True
        Me.PeriodfromDataGridViewTextBoxColumn.Visible = False
        '
        'PeriodtoDataGridViewTextBoxColumn
        '
        Me.PeriodtoDataGridViewTextBoxColumn.DataPropertyName = "period_to"
        Me.PeriodtoDataGridViewTextBoxColumn.HeaderText = "period_to"
        Me.PeriodtoDataGridViewTextBoxColumn.Name = "PeriodtoDataGridViewTextBoxColumn"
        Me.PeriodtoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PeriodtoDataGridViewTextBoxColumn.Visible = False
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        Me.EmployeeidDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeidDataGridViewTextBoxColumn.Visible = False
        '
        'EmployeenameDataGridViewTextBoxColumn
        '
        Me.EmployeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name"
        Me.EmployeenameDataGridViewTextBoxColumn.HeaderText = "Employee Name"
        Me.EmployeenameDataGridViewTextBoxColumn.Name = "EmployeenameDataGridViewTextBoxColumn"
        Me.EmployeenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastnameDataGridViewTextBoxColumn.Visible = False
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstnameDataGridViewTextBoxColumn.Visible = False
        '
        'MiddlenameDataGridViewTextBoxColumn
        '
        Me.MiddlenameDataGridViewTextBoxColumn.DataPropertyName = "middle_name"
        Me.MiddlenameDataGridViewTextBoxColumn.HeaderText = "middle_name"
        Me.MiddlenameDataGridViewTextBoxColumn.Name = "MiddlenameDataGridViewTextBoxColumn"
        Me.MiddlenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MiddlenameDataGridViewTextBoxColumn.Visible = False
        '
        'DepartmentassignedDataGridViewTextBoxColumn
        '
        Me.DepartmentassignedDataGridViewTextBoxColumn.DataPropertyName = "department_assigned"
        Me.DepartmentassignedDataGridViewTextBoxColumn.HeaderText = "department_assigned"
        Me.DepartmentassignedDataGridViewTextBoxColumn.Name = "DepartmentassignedDataGridViewTextBoxColumn"
        Me.DepartmentassignedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentassignedDataGridViewTextBoxColumn.Visible = False
        '
        'RatebasisdescrDataGridViewTextBoxColumn
        '
        Me.RatebasisdescrDataGridViewTextBoxColumn.DataPropertyName = "rate_basis_descr"
        Me.RatebasisdescrDataGridViewTextBoxColumn.HeaderText = "rate_basis_descr"
        Me.RatebasisdescrDataGridViewTextBoxColumn.Name = "RatebasisdescrDataGridViewTextBoxColumn"
        Me.RatebasisdescrDataGridViewTextBoxColumn.ReadOnly = True
        Me.RatebasisdescrDataGridViewTextBoxColumn.Visible = False
        '
        'MonthlyrateDataGridViewTextBoxColumn
        '
        Me.MonthlyrateDataGridViewTextBoxColumn.DataPropertyName = "monthly_rate"
        Me.MonthlyrateDataGridViewTextBoxColumn.HeaderText = "monthly_rate"
        Me.MonthlyrateDataGridViewTextBoxColumn.Name = "MonthlyrateDataGridViewTextBoxColumn"
        Me.MonthlyrateDataGridViewTextBoxColumn.ReadOnly = True
        Me.MonthlyrateDataGridViewTextBoxColumn.Visible = False
        '
        'DailyrateDataGridViewTextBoxColumn
        '
        Me.DailyrateDataGridViewTextBoxColumn.DataPropertyName = "daily_rate"
        Me.DailyrateDataGridViewTextBoxColumn.HeaderText = "daily_rate"
        Me.DailyrateDataGridViewTextBoxColumn.Name = "DailyrateDataGridViewTextBoxColumn"
        Me.DailyrateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DailyrateDataGridViewTextBoxColumn.Visible = False
        '
        'HourlyrateDataGridViewTextBoxColumn
        '
        Me.HourlyrateDataGridViewTextBoxColumn.DataPropertyName = "hourly_rate"
        Me.HourlyrateDataGridViewTextBoxColumn.HeaderText = "hourly_rate"
        Me.HourlyrateDataGridViewTextBoxColumn.Name = "HourlyrateDataGridViewTextBoxColumn"
        Me.HourlyrateDataGridViewTextBoxColumn.ReadOnly = True
        Me.HourlyrateDataGridViewTextBoxColumn.Visible = False
        '
        'UnitrateDataGridViewTextBoxColumn
        '
        Me.UnitrateDataGridViewTextBoxColumn.DataPropertyName = "unit_rate"
        Me.UnitrateDataGridViewTextBoxColumn.HeaderText = "unit_rate"
        Me.UnitrateDataGridViewTextBoxColumn.Name = "UnitrateDataGridViewTextBoxColumn"
        Me.UnitrateDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnitrateDataGridViewTextBoxColumn.Visible = False
        '
        'RegularwagesDataGridViewTextBoxColumn
        '
        Me.RegularwagesDataGridViewTextBoxColumn.DataPropertyName = "regular_wages"
        Me.RegularwagesDataGridViewTextBoxColumn.HeaderText = "regular_wages"
        Me.RegularwagesDataGridViewTextBoxColumn.Name = "RegularwagesDataGridViewTextBoxColumn"
        Me.RegularwagesDataGridViewTextBoxColumn.ReadOnly = True
        Me.RegularwagesDataGridViewTextBoxColumn.Visible = False
        '
        'OvertimeamtDataGridViewTextBoxColumn
        '
        Me.OvertimeamtDataGridViewTextBoxColumn.DataPropertyName = "overtime_amt"
        Me.OvertimeamtDataGridViewTextBoxColumn.HeaderText = "overtime_amt"
        Me.OvertimeamtDataGridViewTextBoxColumn.Name = "OvertimeamtDataGridViewTextBoxColumn"
        Me.OvertimeamtDataGridViewTextBoxColumn.ReadOnly = True
        Me.OvertimeamtDataGridViewTextBoxColumn.Visible = False
        '
        'AllowancesamtDataGridViewTextBoxColumn
        '
        Me.AllowancesamtDataGridViewTextBoxColumn.DataPropertyName = "allowances_amt"
        Me.AllowancesamtDataGridViewTextBoxColumn.HeaderText = "allowances_amt"
        Me.AllowancesamtDataGridViewTextBoxColumn.Name = "AllowancesamtDataGridViewTextBoxColumn"
        Me.AllowancesamtDataGridViewTextBoxColumn.ReadOnly = True
        Me.AllowancesamtDataGridViewTextBoxColumn.Visible = False
        '
        'AdjustmentsamtDataGridViewTextBoxColumn
        '
        Me.AdjustmentsamtDataGridViewTextBoxColumn.DataPropertyName = "adjustments_amt"
        Me.AdjustmentsamtDataGridViewTextBoxColumn.HeaderText = "adjustments_amt"
        Me.AdjustmentsamtDataGridViewTextBoxColumn.Name = "AdjustmentsamtDataGridViewTextBoxColumn"
        Me.AdjustmentsamtDataGridViewTextBoxColumn.ReadOnly = True
        Me.AdjustmentsamtDataGridViewTextBoxColumn.Visible = False
        '
        'WorkeddaysDataGridViewTextBoxColumn
        '
        Me.WorkeddaysDataGridViewTextBoxColumn.DataPropertyName = "worked_days"
        Me.WorkeddaysDataGridViewTextBoxColumn.HeaderText = "worked_days"
        Me.WorkeddaysDataGridViewTextBoxColumn.Name = "WorkeddaysDataGridViewTextBoxColumn"
        Me.WorkeddaysDataGridViewTextBoxColumn.ReadOnly = True
        Me.WorkeddaysDataGridViewTextBoxColumn.Visible = False
        '
        'AbsentdaysDataGridViewTextBoxColumn
        '
        Me.AbsentdaysDataGridViewTextBoxColumn.DataPropertyName = "absent_days"
        Me.AbsentdaysDataGridViewTextBoxColumn.HeaderText = "absent_days"
        Me.AbsentdaysDataGridViewTextBoxColumn.Name = "AbsentdaysDataGridViewTextBoxColumn"
        Me.AbsentdaysDataGridViewTextBoxColumn.ReadOnly = True
        Me.AbsentdaysDataGridViewTextBoxColumn.Visible = False
        '
        'AbsentamtDataGridViewTextBoxColumn
        '
        Me.AbsentamtDataGridViewTextBoxColumn.DataPropertyName = "absent_amt"
        Me.AbsentamtDataGridViewTextBoxColumn.HeaderText = "absent_amt"
        Me.AbsentamtDataGridViewTextBoxColumn.Name = "AbsentamtDataGridViewTextBoxColumn"
        Me.AbsentamtDataGridViewTextBoxColumn.ReadOnly = True
        Me.AbsentamtDataGridViewTextBoxColumn.Visible = False
        '
        'LatesinminDataGridViewTextBoxColumn
        '
        Me.LatesinminDataGridViewTextBoxColumn.DataPropertyName = "lates_in_min"
        Me.LatesinminDataGridViewTextBoxColumn.HeaderText = "lates_in_min"
        Me.LatesinminDataGridViewTextBoxColumn.Name = "LatesinminDataGridViewTextBoxColumn"
        Me.LatesinminDataGridViewTextBoxColumn.ReadOnly = True
        Me.LatesinminDataGridViewTextBoxColumn.Visible = False
        '
        'LatesinamtDataGridViewTextBoxColumn
        '
        Me.LatesinamtDataGridViewTextBoxColumn.DataPropertyName = "lates_in_amt"
        Me.LatesinamtDataGridViewTextBoxColumn.HeaderText = "lates_in_amt"
        Me.LatesinamtDataGridViewTextBoxColumn.Name = "LatesinamtDataGridViewTextBoxColumn"
        Me.LatesinamtDataGridViewTextBoxColumn.ReadOnly = True
        Me.LatesinamtDataGridViewTextBoxColumn.Visible = False
        '
        'CashadvanceamtDataGridViewTextBoxColumn
        '
        Me.CashadvanceamtDataGridViewTextBoxColumn.DataPropertyName = "cash_advance_amt"
        Me.CashadvanceamtDataGridViewTextBoxColumn.HeaderText = "cash_advance_amt"
        Me.CashadvanceamtDataGridViewTextBoxColumn.Name = "CashadvanceamtDataGridViewTextBoxColumn"
        Me.CashadvanceamtDataGridViewTextBoxColumn.ReadOnly = True
        Me.CashadvanceamtDataGridViewTextBoxColumn.Visible = False
        '
        'SssmedamtDataGridViewTextBoxColumn
        '
        Me.SssmedamtDataGridViewTextBoxColumn.DataPropertyName = "sss_med_amt"
        Me.SssmedamtDataGridViewTextBoxColumn.HeaderText = "sss_med_amt"
        Me.SssmedamtDataGridViewTextBoxColumn.Name = "SssmedamtDataGridViewTextBoxColumn"
        Me.SssmedamtDataGridViewTextBoxColumn.ReadOnly = True
        Me.SssmedamtDataGridViewTextBoxColumn.Visible = False
        '
        'SssloanamtDataGridViewTextBoxColumn
        '
        Me.SssloanamtDataGridViewTextBoxColumn.DataPropertyName = "sss_loan_amt"
        Me.SssloanamtDataGridViewTextBoxColumn.HeaderText = "sss_loan_amt"
        Me.SssloanamtDataGridViewTextBoxColumn.Name = "SssloanamtDataGridViewTextBoxColumn"
        Me.SssloanamtDataGridViewTextBoxColumn.ReadOnly = True
        Me.SssloanamtDataGridViewTextBoxColumn.Visible = False
        '
        'PagibigamtDataGridViewTextBoxColumn
        '
        Me.PagibigamtDataGridViewTextBoxColumn.DataPropertyName = "pag_ibig_amt"
        Me.PagibigamtDataGridViewTextBoxColumn.HeaderText = "pag_ibig_amt"
        Me.PagibigamtDataGridViewTextBoxColumn.Name = "PagibigamtDataGridViewTextBoxColumn"
        Me.PagibigamtDataGridViewTextBoxColumn.ReadOnly = True
        Me.PagibigamtDataGridViewTextBoxColumn.Visible = False
        '
        'PhicamtDataGridViewTextBoxColumn
        '
        Me.PhicamtDataGridViewTextBoxColumn.DataPropertyName = "phic_amt"
        Me.PhicamtDataGridViewTextBoxColumn.HeaderText = "phic_amt"
        Me.PhicamtDataGridViewTextBoxColumn.Name = "PhicamtDataGridViewTextBoxColumn"
        Me.PhicamtDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhicamtDataGridViewTextBoxColumn.Visible = False
        '
        'WtaxamtDataGridViewTextBoxColumn
        '
        Me.WtaxamtDataGridViewTextBoxColumn.DataPropertyName = "wtax_amt"
        Me.WtaxamtDataGridViewTextBoxColumn.HeaderText = "wtax_amt"
        Me.WtaxamtDataGridViewTextBoxColumn.Name = "WtaxamtDataGridViewTextBoxColumn"
        Me.WtaxamtDataGridViewTextBoxColumn.ReadOnly = True
        Me.WtaxamtDataGridViewTextBoxColumn.Visible = False
        '
        'OtherdedamtDataGridViewTextBoxColumn
        '
        Me.OtherdedamtDataGridViewTextBoxColumn.DataPropertyName = "other_ded_amt"
        Me.OtherdedamtDataGridViewTextBoxColumn.HeaderText = "other_ded_amt"
        Me.OtherdedamtDataGridViewTextBoxColumn.Name = "OtherdedamtDataGridViewTextBoxColumn"
        Me.OtherdedamtDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtherdedamtDataGridViewTextBoxColumn.Visible = False
        '
        'OtherloansamtDataGridViewTextBoxColumn
        '
        Me.OtherloansamtDataGridViewTextBoxColumn.DataPropertyName = "other_loans_amt"
        Me.OtherloansamtDataGridViewTextBoxColumn.HeaderText = "other_loans_amt"
        Me.OtherloansamtDataGridViewTextBoxColumn.Name = "OtherloansamtDataGridViewTextBoxColumn"
        Me.OtherloansamtDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtherloansamtDataGridViewTextBoxColumn.Visible = False
        '
        'GrosspayDataGridViewTextBoxColumn
        '
        Me.GrosspayDataGridViewTextBoxColumn.DataPropertyName = "gross_pay"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.GrosspayDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.GrosspayDataGridViewTextBoxColumn.HeaderText = "Gross Pay"
        Me.GrosspayDataGridViewTextBoxColumn.Name = "GrosspayDataGridViewTextBoxColumn"
        Me.GrosspayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NetpayDataGridViewTextBoxColumn
        '
        Me.NetpayDataGridViewTextBoxColumn.DataPropertyName = "net_pay"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.NetpayDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.NetpayDataGridViewTextBoxColumn.HeaderText = "Net Pay"
        Me.NetpayDataGridViewTextBoxColumn.Name = "NetpayDataGridViewTextBoxColumn"
        Me.NetpayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        Me.RemarksDataGridViewTextBoxColumn.ReadOnly = True
        Me.RemarksDataGridViewTextBoxColumn.Visible = False
        '
        'photo
        '
        Me.photo.DataPropertyName = "photo"
        Me.photo.HeaderText = "photo"
        Me.photo.Name = "photo"
        Me.photo.ReadOnly = True
        Me.photo.Visible = False
        '
        'king_coop_loan
        '
        Me.king_coop_loan.DataPropertyName = "king_coop_loan"
        Me.king_coop_loan.HeaderText = "king_coop_loan"
        Me.king_coop_loan.Name = "king_coop_loan"
        Me.king_coop_loan.ReadOnly = True
        Me.king_coop_loan.Visible = False
        '
        'lbp_loan
        '
        Me.lbp_loan.DataPropertyName = "lbp_loan"
        Me.lbp_loan.HeaderText = "lbp_loan"
        Me.lbp_loan.Name = "lbp_loan"
        Me.lbp_loan.ReadOnly = True
        Me.lbp_loan.Visible = False
        '
        'VwpayrolltblBindingSource
        '
        Me.VwpayrolltblBindingSource.DataMember = "vw_payroll_tbl"
        Me.VwpayrolltblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.txtbSearch)
        Me.GroupBox7.Controls.Add(Me.btnCreate)
        Me.GroupBox7.Controls.Add(Me.Vw_payroll_tblDataGridView)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(323, 491)
        Me.GroupBox7.TabIndex = 152
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Payroll List"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(12, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 14)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "(First Name or Lastname)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(11, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 20)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Search :"
        '
        'txtbSearch
        '
        Me.txtbSearch.Location = New System.Drawing.Point(15, 70)
        Me.txtbSearch.Name = "txtbSearch"
        Me.txtbSearch.Size = New System.Drawing.Size(152, 22)
        Me.txtbSearch.TabIndex = 39
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(184, 60)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(126, 33)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Text = "Create New Payroll"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.SystemColors.Control
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btndel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btndel.Location = New System.Drawing.Point(529, 478)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(83, 28)
        Me.btndel.TabIndex = 149
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'Vw_payroll_tblTableAdapter
        '
        Me.Vw_payroll_tblTableAdapter.ClearBeforeFill = True
        '
        'Payroll_tblTableAdapter
        '
        Me.Payroll_tblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.deduction_list_tblTableAdapter = Nothing
        Me.TableAdapterManager.dtr_conso_tblTableAdapter = Nothing
        Me.TableAdapterManager.employee_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_deduction_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_tblTableAdapter = Me.Payroll_tblTableAdapter
        Me.TableAdapterManager.time_schedule_empl_tblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_tblTableAdapter = Nothing
        '
        'PayrolldbDataSet1
        '
        Me.PayrolldbDataSet1.DataSetName = "payrolldbDataSet"
        Me.PayrolldbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 525)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btndel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Payroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Payroll_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.Vw_payroll_tblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwpayrolltblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PayrolldbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Period_toDateTimePicker As DateTimePicker
    Friend WithEvents Period_fromDateTimePicker As DateTimePicker
    Friend WithEvents department_assigned As ComboBox
    Friend WithEvents Payroll_noComboBox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PhotoPictureBox As PictureBox
    Friend WithEvents Employee_idComboBox As ComboBox
    Friend WithEvents Unit_rateTextBox As TextBox
    Friend WithEvents rate_basis_ComboBox As ComboBox
    Friend WithEvents Hourly_rateTextBox As TextBox
    Friend WithEvents Daily_rateTextBox As TextBox
    Friend WithEvents Monthly_rateTextBox As TextBox
    Friend WithEvents btn_calculate As Button
    Friend WithEvents RemarksTextBox As TextBox
    Friend WithEvents Net_payTextBox As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Worked_daysLabel As Label
    Friend WithEvents Worked_daysTextBox As TextBox
    Friend WithEvents Regular_wagesTextBox As TextBox
    Friend WithEvents Overtime_amtTextBox As TextBox
    Friend WithEvents Gross_payTextBox As TextBox
    Friend WithEvents Adjustments_amtTextBox As TextBox
    Friend WithEvents Allowances_amtTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents total_deduction_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Absent_daysTextBox As TextBox
    Friend WithEvents Other_loans_amtTextBox As TextBox
    Friend WithEvents Other_ded_amtTextBox As TextBox
    Friend WithEvents Wtax_amtTextBox As TextBox
    Friend WithEvents Phic_amtTextBox As TextBox
    Friend WithEvents Pag_ibig_amtTextBox As TextBox
    Friend WithEvents Sss_loan_amtTextBox As TextBox
    Friend WithEvents Sss_med_amtTextBox As TextBox
    Friend WithEvents Cash_advance_amtTextBox As TextBox
    Friend WithEvents Lates_in_amtTextBox As TextBox
    Friend WithEvents Lates_in_minTextBox As TextBox
    Friend WithEvents Absent_amtTextBox As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Middle_nameTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents Last_nameTextBox As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Vw_payroll_tblDataGridView As DataGridView
    Friend WithEvents PayrolldbDataSet As payrolldbDataSet
    Friend WithEvents VwpayrolltblBindingSource As BindingSource
    Friend WithEvents Vw_payroll_tblTableAdapter As payrolldbDataSetTableAdapters.vw_payroll_tblTableAdapter
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbSearch As TextBox
    Friend WithEvents btndel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Payroll_tblBindingSource As BindingSource
    Friend WithEvents Payroll_tblTableAdapter As payrolldbDataSetTableAdapters.payroll_tblTableAdapter
    Friend WithEvents TableAdapterManager As payrolldbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents King_coop_loanTextBox As TextBox
    Friend WithEvents Lbp_loanTextBox As TextBox
    Friend WithEvents PayrolldbDataSet1 As payrolldbDataSet
    Friend WithEvents photo As DataGridViewImageColumn
    Friend WithEvents king_coop_loan As DataGridViewTextBoxColumn
    Friend WithEvents lbp_loan As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PayrollnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeriodfromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeriodtoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddlenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentassignedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RatebasisdescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthlyrateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DailyrateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourlyrateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitrateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegularwagesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OvertimeamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AllowancesamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdjustmentsamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WorkeddaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbsentdaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbsentamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LatesinminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LatesinamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashadvanceamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SssmedamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SssloanamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagibigamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhicamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WtaxamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherdedamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherloansamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrosspayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NetpayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
