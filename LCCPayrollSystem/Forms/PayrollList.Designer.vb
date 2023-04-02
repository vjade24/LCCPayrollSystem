<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayrollList))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Vw_payroll_tblDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbSearch = New System.Windows.Forms.TextBox()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.Vw_payroll_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrolldbDataSet = New LCCPayrollSystem.payrolldbDataSet()
        Me.Vw_payroll_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.vw_payroll_tblTableAdapter()
        Me.TableAdapterManager = New LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_payroll_tblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_payroll_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(897, 57)
        Me.Panel2.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(870, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 31)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "x"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(26, 11)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(27, 30)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 12
        Me.PictureBox7.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(201, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "List of Payrolls"
        '
        'Vw_payroll_tblDataGridView
        '
        Me.Vw_payroll_tblDataGridView.AllowUserToAddRows = False
        Me.Vw_payroll_tblDataGridView.AllowUserToDeleteRows = False
        Me.Vw_payroll_tblDataGridView.AutoGenerateColumns = False
        Me.Vw_payroll_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_payroll_tblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.PayrollnoDataGridViewTextBoxColumn, Me.PeriodfromDataGridViewTextBoxColumn, Me.PeriodtoDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.MiddlenameDataGridViewTextBoxColumn, Me.DepartmentassignedDataGridViewTextBoxColumn, Me.RatebasisdescrDataGridViewTextBoxColumn, Me.MonthlyrateDataGridViewTextBoxColumn, Me.DailyrateDataGridViewTextBoxColumn, Me.HourlyrateDataGridViewTextBoxColumn, Me.UnitrateDataGridViewTextBoxColumn, Me.RegularwagesDataGridViewTextBoxColumn, Me.OvertimeamtDataGridViewTextBoxColumn, Me.AllowancesamtDataGridViewTextBoxColumn, Me.AdjustmentsamtDataGridViewTextBoxColumn, Me.WorkeddaysDataGridViewTextBoxColumn, Me.AbsentdaysDataGridViewTextBoxColumn, Me.AbsentamtDataGridViewTextBoxColumn, Me.LatesinminDataGridViewTextBoxColumn, Me.LatesinamtDataGridViewTextBoxColumn, Me.CashadvanceamtDataGridViewTextBoxColumn, Me.SssmedamtDataGridViewTextBoxColumn, Me.SssloanamtDataGridViewTextBoxColumn, Me.PagibigamtDataGridViewTextBoxColumn, Me.PhicamtDataGridViewTextBoxColumn, Me.WtaxamtDataGridViewTextBoxColumn, Me.OtherdedamtDataGridViewTextBoxColumn, Me.OtherloansamtDataGridViewTextBoxColumn, Me.GrosspayDataGridViewTextBoxColumn, Me.NetpayDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn})
        Me.Vw_payroll_tblDataGridView.DataSource = Me.Vw_payroll_tblBindingSource
        Me.Vw_payroll_tblDataGridView.Location = New System.Drawing.Point(14, 122)
        Me.Vw_payroll_tblDataGridView.Name = "Vw_payroll_tblDataGridView"
        Me.Vw_payroll_tblDataGridView.ReadOnly = True
        Me.Vw_payroll_tblDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Vw_payroll_tblDataGridView.Size = New System.Drawing.Size(872, 397)
        Me.Vw_payroll_tblDataGridView.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(95, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 13)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "(First Name or Lastname)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(13, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 20)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Search :"
        '
        'txtbSearch
        '
        Me.txtbSearch.Location = New System.Drawing.Point(14, 96)
        Me.txtbSearch.Name = "txtbSearch"
        Me.txtbSearch.Size = New System.Drawing.Size(230, 20)
        Me.txtbSearch.TabIndex = 36
        '
        'btn_create
        '
        Me.btn_create.Location = New System.Drawing.Point(749, 80)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(137, 36)
        Me.btn_create.TabIndex = 39
        Me.btn_create.Text = "Create Payroll"
        Me.btn_create.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 36)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Reload"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.PayrollnoDataGridViewTextBoxColumn.HeaderText = "payroll_no"
        Me.PayrollnoDataGridViewTextBoxColumn.Name = "PayrollnoDataGridViewTextBoxColumn"
        Me.PayrollnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeriodfromDataGridViewTextBoxColumn
        '
        Me.PeriodfromDataGridViewTextBoxColumn.DataPropertyName = "period_from"
        Me.PeriodfromDataGridViewTextBoxColumn.HeaderText = "period_from"
        Me.PeriodfromDataGridViewTextBoxColumn.Name = "PeriodfromDataGridViewTextBoxColumn"
        Me.PeriodfromDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeriodtoDataGridViewTextBoxColumn
        '
        Me.PeriodtoDataGridViewTextBoxColumn.DataPropertyName = "period_to"
        Me.PeriodtoDataGridViewTextBoxColumn.HeaderText = "period_to"
        Me.PeriodtoDataGridViewTextBoxColumn.Name = "PeriodtoDataGridViewTextBoxColumn"
        Me.PeriodtoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        Me.EmployeeidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeenameDataGridViewTextBoxColumn
        '
        Me.EmployeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name"
        Me.EmployeenameDataGridViewTextBoxColumn.HeaderText = "employee_name"
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
        Me.GrosspayDataGridViewTextBoxColumn.HeaderText = "gross_pay"
        Me.GrosspayDataGridViewTextBoxColumn.Name = "GrosspayDataGridViewTextBoxColumn"
        Me.GrosspayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NetpayDataGridViewTextBoxColumn
        '
        Me.NetpayDataGridViewTextBoxColumn.DataPropertyName = "net_pay"
        Me.NetpayDataGridViewTextBoxColumn.HeaderText = "net_pay"
        Me.NetpayDataGridViewTextBoxColumn.Name = "NetpayDataGridViewTextBoxColumn"
        Me.NetpayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        Me.RemarksDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Vw_payroll_tblBindingSource
        '
        Me.Vw_payroll_tblBindingSource.DataMember = "vw_payroll_tbl"
        Me.Vw_payroll_tblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'PayrolldbDataSet
        '
        Me.PayrolldbDataSet.DataSetName = "payrolldbDataSet"
        Me.PayrolldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_payroll_tblTableAdapter
        '
        Me.Vw_payroll_tblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.deduction_list_tblTableAdapter = Nothing
        Me.TableAdapterManager.employee_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_deduction_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_tblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_tblTableAdapter = Nothing
        '
        'PayrollList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(898, 535)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtbSearch)
        Me.Controls.Add(Me.Vw_payroll_tblDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PayrollList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PayrollList"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_payroll_tblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_payroll_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PayrolldbDataSet As payrolldbDataSet
    Friend WithEvents Vw_payroll_tblBindingSource As BindingSource
    Friend WithEvents Vw_payroll_tblTableAdapter As payrolldbDataSetTableAdapters.vw_payroll_tblTableAdapter
    Friend WithEvents TableAdapterManager As payrolldbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Vw_payroll_tblDataGridView As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbSearch As TextBox
    Friend WithEvents btn_create As Button
    Friend WithEvents Button1 As Button
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
