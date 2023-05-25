<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deduction
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim Deduct_amtLabel As System.Windows.Forms.Label
        Dim Deduct_period_toLabel As System.Windows.Forms.Label
        Dim Deduct_period_fromLabel As System.Windows.Forms.Label
        Dim Employee_idLabel As System.Windows.Forms.Label
        Dim Deduction_descrLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deduction))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Deduct_amtTextBox = New System.Windows.Forms.TextBox()
        Me.Deduct_period_toDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Deduct_period_fromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Employee_idComboBox = New System.Windows.Forms.ComboBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Deduction_descrComboBox = New System.Windows.Forms.ComboBox()
        Me.DeductionlisttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrolldbDataSet = New LCCPayrollSystem.payrolldbDataSet()
        Me.Payroll_deduction_tblDataGridView = New System.Windows.Forms.DataGridView()
        Me.PayrolldeductiontblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtb_search = New System.Windows.Forms.TextBox()
        Me.Deduction_list_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.deduction_list_tblTableAdapter()
        Me.Payroll_deduction_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.payroll_deduction_tblTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New FontAwesome.Sharp.IconButton()
        Me.btnupdate = New FontAwesome.Sharp.IconButton()
        Me.btndel = New FontAwesome.Sharp.IconButton()
        Me.Button2 = New FontAwesome.Sharp.IconButton()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductioncodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductiondescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductperiodfromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductperiodtoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        Deduct_amtLabel = New System.Windows.Forms.Label()
        Deduct_period_toLabel = New System.Windows.Forms.Label()
        Deduct_period_fromLabel = New System.Windows.Forms.Label()
        Employee_idLabel = New System.Windows.Forms.Label()
        Deduction_descrLabel = New System.Windows.Forms.Label()
        CType(Me.DeductionlisttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payroll_deduction_tblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldeductiontblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.ForeColor = System.Drawing.Color.Black
        IdLabel.Location = New System.Drawing.Point(56, 29)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(67, 14)
        IdLabel.TabIndex = 132
        IdLabel.Text = "Employee Id:"
        IdLabel.Visible = False
        '
        'Deduct_amtLabel
        '
        Deduct_amtLabel.AutoSize = True
        Deduct_amtLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Deduct_amtLabel.ForeColor = System.Drawing.Color.Black
        Deduct_amtLabel.Location = New System.Drawing.Point(452, 78)
        Deduct_amtLabel.Name = "Deduct_amtLabel"
        Deduct_amtLabel.Size = New System.Drawing.Size(86, 14)
        Deduct_amtLabel.TabIndex = 142
        Deduct_amtLabel.Text = "Deduct. Amount:"
        '
        'Deduct_period_toLabel
        '
        Deduct_period_toLabel.AutoSize = True
        Deduct_period_toLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Deduct_period_toLabel.ForeColor = System.Drawing.Color.Black
        Deduct_period_toLabel.Location = New System.Drawing.Point(574, 24)
        Deduct_period_toLabel.Name = "Deduct_period_toLabel"
        Deduct_period_toLabel.Size = New System.Drawing.Size(49, 14)
        Deduct_period_toLabel.TabIndex = 140
        Deduct_period_toLabel.Text = "Period to"
        '
        'Deduct_period_fromLabel
        '
        Deduct_period_fromLabel.AutoSize = True
        Deduct_period_fromLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Deduct_period_fromLabel.ForeColor = System.Drawing.Color.Black
        Deduct_period_fromLabel.Location = New System.Drawing.Point(452, 24)
        Deduct_period_fromLabel.Name = "Deduct_period_fromLabel"
        Deduct_period_fromLabel.Size = New System.Drawing.Size(65, 14)
        Deduct_period_fromLabel.TabIndex = 138
        Deduct_period_fromLabel.Text = "Period from:"
        '
        'Employee_idLabel
        '
        Employee_idLabel.AutoSize = True
        Employee_idLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employee_idLabel.ForeColor = System.Drawing.Color.Black
        Employee_idLabel.Location = New System.Drawing.Point(205, 79)
        Employee_idLabel.Name = "Employee_idLabel"
        Employee_idLabel.Size = New System.Drawing.Size(86, 14)
        Employee_idLabel.TabIndex = 136
        Employee_idLabel.Text = "Employee Name:"
        '
        'Deduction_descrLabel
        '
        Deduction_descrLabel.AutoSize = True
        Deduction_descrLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Deduction_descrLabel.ForeColor = System.Drawing.Color.Black
        Deduction_descrLabel.Location = New System.Drawing.Point(205, 29)
        Deduction_descrLabel.Name = "Deduction_descrLabel"
        Deduction_descrLabel.Size = New System.Drawing.Size(58, 14)
        Deduction_descrLabel.TabIndex = 134
        Deduction_descrLabel.Text = "Deduction:"
        '
        'Deduct_amtTextBox
        '
        Me.Deduct_amtTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deduct_amtTextBox.Location = New System.Drawing.Point(452, 102)
        Me.Deduct_amtTextBox.Name = "Deduct_amtTextBox"
        Me.Deduct_amtTextBox.Size = New System.Drawing.Size(241, 20)
        Me.Deduct_amtTextBox.TabIndex = 143
        Me.Deduct_amtTextBox.Text = "0.00"
        Me.Deduct_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Deduct_period_toDateTimePicker
        '
        Me.Deduct_period_toDateTimePicker.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deduct_period_toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Deduct_period_toDateTimePicker.Location = New System.Drawing.Point(574, 48)
        Me.Deduct_period_toDateTimePicker.Name = "Deduct_period_toDateTimePicker"
        Me.Deduct_period_toDateTimePicker.Size = New System.Drawing.Size(119, 20)
        Me.Deduct_period_toDateTimePicker.TabIndex = 141
        Me.Deduct_period_toDateTimePicker.Value = New Date(2023, 12, 31, 0, 0, 0, 0)
        '
        'Deduct_period_fromDateTimePicker
        '
        Me.Deduct_period_fromDateTimePicker.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deduct_period_fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Deduct_period_fromDateTimePicker.Location = New System.Drawing.Point(452, 48)
        Me.Deduct_period_fromDateTimePicker.Name = "Deduct_period_fromDateTimePicker"
        Me.Deduct_period_fromDateTimePicker.Size = New System.Drawing.Size(119, 20)
        Me.Deduct_period_fromDateTimePicker.TabIndex = 139
        Me.Deduct_period_fromDateTimePicker.Value = New Date(2023, 1, 1, 0, 0, 0, 0)
        '
        'Employee_idComboBox
        '
        Me.Employee_idComboBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee_idComboBox.FormattingEnabled = True
        Me.Employee_idComboBox.Location = New System.Drawing.Point(205, 100)
        Me.Employee_idComboBox.Name = "Employee_idComboBox"
        Me.Employee_idComboBox.Size = New System.Drawing.Size(241, 22)
        Me.Employee_idComboBox.TabIndex = 137
        '
        'IdTextBox
        '
        Me.IdTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(56, 50)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(143, 20)
        Me.IdTextBox.TabIndex = 133
        Me.IdTextBox.Visible = False
        '
        'Deduction_descrComboBox
        '
        Me.Deduction_descrComboBox.DataSource = Me.DeductionlisttblBindingSource
        Me.Deduction_descrComboBox.DisplayMember = "deduction_descr"
        Me.Deduction_descrComboBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deduction_descrComboBox.FormattingEnabled = True
        Me.Deduction_descrComboBox.Location = New System.Drawing.Point(205, 50)
        Me.Deduction_descrComboBox.Name = "Deduction_descrComboBox"
        Me.Deduction_descrComboBox.Size = New System.Drawing.Size(241, 22)
        Me.Deduction_descrComboBox.TabIndex = 135
        Me.Deduction_descrComboBox.ValueMember = "deduction_code"
        '
        'DeductionlisttblBindingSource
        '
        Me.DeductionlisttblBindingSource.DataMember = "deduction_list_tbl"
        Me.DeductionlisttblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'PayrolldbDataSet
        '
        Me.PayrolldbDataSet.DataSetName = "payrolldbDataSet"
        Me.PayrolldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Payroll_deduction_tblDataGridView
        '
        Me.Payroll_deduction_tblDataGridView.AllowUserToAddRows = False
        Me.Payroll_deduction_tblDataGridView.AllowUserToDeleteRows = False
        Me.Payroll_deduction_tblDataGridView.AutoGenerateColumns = False
        Me.Payroll_deduction_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Payroll_deduction_tblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DeductioncodeDataGridViewTextBoxColumn, Me.DeductiondescrDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.DeductperiodfromDataGridViewTextBoxColumn, Me.DeductperiodtoDataGridViewTextBoxColumn, Me.DeductamtDataGridViewTextBoxColumn})
        Me.Payroll_deduction_tblDataGridView.DataSource = Me.PayrolldeductiontblBindingSource
        Me.Payroll_deduction_tblDataGridView.Location = New System.Drawing.Point(6, 74)
        Me.Payroll_deduction_tblDataGridView.Name = "Payroll_deduction_tblDataGridView"
        Me.Payroll_deduction_tblDataGridView.ReadOnly = True
        Me.Payroll_deduction_tblDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Payroll_deduction_tblDataGridView.Size = New System.Drawing.Size(869, 243)
        Me.Payroll_deduction_tblDataGridView.TabIndex = 148
        '
        'PayrolldeductiontblBindingSource
        '
        Me.PayrolldeductiontblBindingSource.DataMember = "payroll_deduction_tbl"
        Me.PayrolldeductiontblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'txtb_search
        '
        Me.txtb_search.AccessibleName = ""
        Me.txtb_search.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_search.Location = New System.Drawing.Point(9, 45)
        Me.txtb_search.Name = "txtb_search"
        Me.txtb_search.Size = New System.Drawing.Size(199, 23)
        Me.txtb_search.TabIndex = 150
        '
        'Deduction_list_tblTableAdapter
        '
        Me.Deduction_list_tblTableAdapter.ClearBeforeFill = True
        '
        'Payroll_deduction_tblTableAdapter
        '
        Me.Payroll_deduction_tblTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Deduction_descrLabel)
        Me.GroupBox1.Controls.Add(Me.Deduction_descrComboBox)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(Employee_idLabel)
        Me.GroupBox1.Controls.Add(Me.Employee_idComboBox)
        Me.GroupBox1.Controls.Add(Deduct_period_fromLabel)
        Me.GroupBox1.Controls.Add(Me.Deduct_period_fromDateTimePicker)
        Me.GroupBox1.Controls.Add(Deduct_period_toLabel)
        Me.GroupBox1.Controls.Add(Me.Deduct_amtTextBox)
        Me.GroupBox1.Controls.Add(Me.Deduct_period_toDateTimePicker)
        Me.GroupBox1.Controls.Add(Deduct_amtLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(881, 133)
        Me.GroupBox1.TabIndex = 151
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deduction Information"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(6, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 20)
        Me.Label14.TabIndex = 151
        Me.Label14.Text = "Search:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.btnCreate)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Payroll_deduction_tblDataGridView)
        Me.GroupBox2.Controls.Add(Me.txtb_search)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(881, 323)
        Me.GroupBox2.TabIndex = 152
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deduction List"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(79, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 14)
        Me.Label13.TabIndex = 153
        Me.Label13.Text = "(First Name or Lastname)"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.ForestGreen
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Location = New System.Drawing.Point(751, 29)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(124, 39)
        Me.btnCreate.TabIndex = 152
        Me.btnCreate.Text = "Create New"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btnupdate)
        Me.Panel1.Controls.Add(Me.btndel)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(0, 471)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 54)
        Me.Panel1.TabIndex = 153
        '
        'btn_save
        '
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_save.Icon = FontAwesome.Sharp.IconChar.CheckCircleO
        Me.btn_save.IconColor = System.Drawing.Color.Black
        Me.btn_save.IconSize = 16
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(523, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_save.Size = New System.Drawing.Size(91, 54)
        Me.btn_save.TabIndex = 135
        Me.btn_save.Text = "Save"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnupdate.Icon = FontAwesome.Sharp.IconChar.Pencil
        Me.btnupdate.IconColor = System.Drawing.Color.Black
        Me.btnupdate.IconSize = 16
        Me.btnupdate.Image = CType(resources.GetObject("btnupdate.Image"), System.Drawing.Image)
        Me.btnupdate.Location = New System.Drawing.Point(614, 0)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnupdate.Size = New System.Drawing.Size(91, 54)
        Me.btnupdate.TabIndex = 134
        Me.btnupdate.Text = "Update"
        Me.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btndel.Icon = FontAwesome.Sharp.IconChar.TrashO
        Me.btndel.IconColor = System.Drawing.Color.Black
        Me.btndel.IconSize = 16
        Me.btndel.Image = CType(resources.GetObject("btndel.Image"), System.Drawing.Image)
        Me.btndel.Location = New System.Drawing.Point(705, 0)
        Me.btndel.Name = "btndel"
        Me.btndel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btndel.Size = New System.Drawing.Size(91, 54)
        Me.btndel.TabIndex = 133
        Me.btndel.Text = "Delete"
        Me.btndel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndel.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Icon = FontAwesome.Sharp.IconChar.Times
        Me.Button2.IconColor = System.Drawing.Color.Black
        Me.Button2.IconSize = 16
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(796, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(91, 54)
        Me.Button2.TabIndex = 132
        Me.Button2.Text = "Cancel"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'DeductioncodeDataGridViewTextBoxColumn
        '
        Me.DeductioncodeDataGridViewTextBoxColumn.DataPropertyName = "deduction_code"
        Me.DeductioncodeDataGridViewTextBoxColumn.HeaderText = "deduction_code"
        Me.DeductioncodeDataGridViewTextBoxColumn.Name = "DeductioncodeDataGridViewTextBoxColumn"
        Me.DeductioncodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeductioncodeDataGridViewTextBoxColumn.Visible = False
        '
        'DeductiondescrDataGridViewTextBoxColumn
        '
        Me.DeductiondescrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DeductiondescrDataGridViewTextBoxColumn.DataPropertyName = "deduction_descr"
        Me.DeductiondescrDataGridViewTextBoxColumn.HeaderText = "Deduction"
        Me.DeductiondescrDataGridViewTextBoxColumn.Name = "DeductiondescrDataGridViewTextBoxColumn"
        Me.DeductiondescrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "ID No"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        Me.EmployeeidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeenameDataGridViewTextBoxColumn
        '
        Me.EmployeenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name"
        Me.EmployeenameDataGridViewTextBoxColumn.HeaderText = "Employee Name"
        Me.EmployeenameDataGridViewTextBoxColumn.Name = "EmployeenameDataGridViewTextBoxColumn"
        Me.EmployeenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeductperiodfromDataGridViewTextBoxColumn
        '
        Me.DeductperiodfromDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DeductperiodfromDataGridViewTextBoxColumn.DataPropertyName = "deduct_period_from"
        Me.DeductperiodfromDataGridViewTextBoxColumn.HeaderText = "Period from"
        Me.DeductperiodfromDataGridViewTextBoxColumn.Name = "DeductperiodfromDataGridViewTextBoxColumn"
        Me.DeductperiodfromDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeductperiodtoDataGridViewTextBoxColumn
        '
        Me.DeductperiodtoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DeductperiodtoDataGridViewTextBoxColumn.DataPropertyName = "deduct_period_to"
        Me.DeductperiodtoDataGridViewTextBoxColumn.HeaderText = "Period to"
        Me.DeductperiodtoDataGridViewTextBoxColumn.Name = "DeductperiodtoDataGridViewTextBoxColumn"
        Me.DeductperiodtoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeductamtDataGridViewTextBoxColumn
        '
        Me.DeductamtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DeductamtDataGridViewTextBoxColumn.DataPropertyName = "deduct_amt"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DeductamtDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DeductamtDataGridViewTextBoxColumn.HeaderText = "Deduct Amount"
        Me.DeductamtDataGridViewTextBoxColumn.Name = "DeductamtDataGridViewTextBoxColumn"
        Me.DeductamtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Deduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(905, 525)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Deduction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deduction"
        CType(Me.DeductionlisttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payroll_deduction_tblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldeductiontblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Deduct_amtTextBox As TextBox
    Friend WithEvents Deduct_period_toDateTimePicker As DateTimePicker
    Friend WithEvents Deduct_period_fromDateTimePicker As DateTimePicker
    Friend WithEvents Employee_idComboBox As ComboBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Deduction_descrComboBox As ComboBox
    Friend WithEvents Payroll_deduction_tblDataGridView As DataGridView
    Friend WithEvents txtb_search As TextBox
    Friend WithEvents PayrolldbDataSet As payrolldbDataSet
    Friend WithEvents DeductionlisttblBindingSource As BindingSource
    Friend WithEvents Deduction_list_tblTableAdapter As payrolldbDataSetTableAdapters.deduction_list_tblTableAdapter
    Friend WithEvents PayrolldeductiontblBindingSource As BindingSource
    Friend WithEvents Payroll_deduction_tblTableAdapter As payrolldbDataSetTableAdapters.payroll_deduction_tblTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_save As FontAwesome.Sharp.IconButton
    Friend WithEvents btnupdate As FontAwesome.Sharp.IconButton
    Friend WithEvents btndel As FontAwesome.Sharp.IconButton
    Friend WithEvents Button2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label13 As Label
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeductioncodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeductiondescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeductperiodfromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeductperiodtoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeductamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
