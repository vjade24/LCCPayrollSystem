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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Deduct_amtTextBox = New System.Windows.Forms.TextBox()
        Me.Deduct_period_toDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Deduct_period_fromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Employee_idComboBox = New System.Windows.Forms.ComboBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Deduction_descrComboBox = New System.Windows.Forms.ComboBox()
        Me.DeductionlisttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrolldbDataSet = New LCCPayrollSystem.payrolldbDataSet()
        Me.Payroll_deduction_tblDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductioncodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductiondescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductperiodfromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductperiodtoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayrolldeductiontblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtb_search = New System.Windows.Forms.TextBox()
        Me.Deduction_list_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.deduction_list_tblTableAdapter()
        Me.Payroll_deduction_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.payroll_deduction_tblTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        Deduct_amtLabel = New System.Windows.Forms.Label()
        Deduct_period_toLabel = New System.Windows.Forms.Label()
        Deduct_period_fromLabel = New System.Windows.Forms.Label()
        Employee_idLabel = New System.Windows.Forms.Label()
        Deduction_descrLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeductionlisttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payroll_deduction_tblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldeductiontblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.ForeColor = System.Drawing.Color.White
        IdLabel.Location = New System.Drawing.Point(11, 23)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(21, 17)
        IdLabel.TabIndex = 132
        IdLabel.Text = "ID"
        IdLabel.Visible = False
        '
        'Deduct_amtLabel
        '
        Deduct_amtLabel.AutoSize = True
        Deduct_amtLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Deduct_amtLabel.ForeColor = System.Drawing.Color.White
        Deduct_amtLabel.Location = New System.Drawing.Point(11, 242)
        Deduct_amtLabel.Name = "Deduct_amtLabel"
        Deduct_amtLabel.Size = New System.Drawing.Size(120, 17)
        Deduct_amtLabel.TabIndex = 142
        Deduct_amtLabel.Text = "Deduct. Amount:"
        '
        'Deduct_period_toLabel
        '
        Deduct_period_toLabel.AutoSize = True
        Deduct_period_toLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Deduct_period_toLabel.ForeColor = System.Drawing.Color.White
        Deduct_period_toLabel.Location = New System.Drawing.Point(133, 182)
        Deduct_period_toLabel.Name = "Deduct_period_toLabel"
        Deduct_period_toLabel.Size = New System.Drawing.Size(67, 17)
        Deduct_period_toLabel.TabIndex = 140
        Deduct_period_toLabel.Text = "Period to"
        '
        'Deduct_period_fromLabel
        '
        Deduct_period_fromLabel.AutoSize = True
        Deduct_period_fromLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Deduct_period_fromLabel.ForeColor = System.Drawing.Color.White
        Deduct_period_fromLabel.Location = New System.Drawing.Point(11, 182)
        Deduct_period_fromLabel.Name = "Deduct_period_fromLabel"
        Deduct_period_fromLabel.Size = New System.Drawing.Size(87, 17)
        Deduct_period_fromLabel.TabIndex = 138
        Deduct_period_fromLabel.Text = "Period from:"
        '
        'Employee_idLabel
        '
        Employee_idLabel.AutoSize = True
        Employee_idLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employee_idLabel.ForeColor = System.Drawing.Color.White
        Employee_idLabel.Location = New System.Drawing.Point(11, 126)
        Employee_idLabel.Name = "Employee_idLabel"
        Employee_idLabel.Size = New System.Drawing.Size(119, 17)
        Employee_idLabel.TabIndex = 136
        Employee_idLabel.Text = "Employee Name:"
        '
        'Deduction_descrLabel
        '
        Deduction_descrLabel.AutoSize = True
        Deduction_descrLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Deduction_descrLabel.ForeColor = System.Drawing.Color.White
        Deduction_descrLabel.Location = New System.Drawing.Point(11, 70)
        Deduction_descrLabel.Name = "Deduction_descrLabel"
        Deduction_descrLabel.Size = New System.Drawing.Size(80, 17)
        Deduction_descrLabel.TabIndex = 134
        Deduction_descrLabel.Text = "Deduction:"
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
        Me.Panel2.Size = New System.Drawing.Size(967, 57)
        Me.Panel2.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(926, 0)
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
        Me.Label1.Size = New System.Drawing.Size(258, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Deductions Information"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageKey = "(none)"
        Me.Button2.Location = New System.Drawing.Point(11, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 35)
        Me.Button2.TabIndex = 147
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Green
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnupdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(11, 315)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(83, 35)
        Me.btnupdate.TabIndex = 146
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.Red
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btndel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.Color.White
        Me.btndel.Location = New System.Drawing.Point(98, 315)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(83, 35)
        Me.btndel.TabIndex = 145
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(98, 356)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(83, 35)
        Me.btn_save.TabIndex = 144
        Me.btn_save.Text = "Create"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Deduct_amtTextBox
        '
        Me.Deduct_amtTextBox.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deduct_amtTextBox.Location = New System.Drawing.Point(11, 266)
        Me.Deduct_amtTextBox.Name = "Deduct_amtTextBox"
        Me.Deduct_amtTextBox.Size = New System.Drawing.Size(147, 31)
        Me.Deduct_amtTextBox.TabIndex = 143
        Me.Deduct_amtTextBox.Text = "0.00"
        Me.Deduct_amtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Deduct_period_toDateTimePicker
        '
        Me.Deduct_period_toDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deduct_period_toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Deduct_period_toDateTimePicker.Location = New System.Drawing.Point(133, 206)
        Me.Deduct_period_toDateTimePicker.Name = "Deduct_period_toDateTimePicker"
        Me.Deduct_period_toDateTimePicker.Size = New System.Drawing.Size(119, 23)
        Me.Deduct_period_toDateTimePicker.TabIndex = 141
        Me.Deduct_period_toDateTimePicker.Value = New Date(2023, 12, 31, 0, 0, 0, 0)
        '
        'Deduct_period_fromDateTimePicker
        '
        Me.Deduct_period_fromDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deduct_period_fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Deduct_period_fromDateTimePicker.Location = New System.Drawing.Point(11, 206)
        Me.Deduct_period_fromDateTimePicker.Name = "Deduct_period_fromDateTimePicker"
        Me.Deduct_period_fromDateTimePicker.Size = New System.Drawing.Size(119, 23)
        Me.Deduct_period_fromDateTimePicker.TabIndex = 139
        Me.Deduct_period_fromDateTimePicker.Value = New Date(2023, 1, 1, 0, 0, 0, 0)
        '
        'Employee_idComboBox
        '
        Me.Employee_idComboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee_idComboBox.FormattingEnabled = True
        Me.Employee_idComboBox.Location = New System.Drawing.Point(11, 150)
        Me.Employee_idComboBox.Name = "Employee_idComboBox"
        Me.Employee_idComboBox.Size = New System.Drawing.Size(241, 25)
        Me.Employee_idComboBox.TabIndex = 137
        '
        'IdTextBox
        '
        Me.IdTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(38, 20)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(143, 23)
        Me.IdTextBox.TabIndex = 133
        Me.IdTextBox.Visible = False
        '
        'Deduction_descrComboBox
        '
        Me.Deduction_descrComboBox.DataSource = Me.DeductionlisttblBindingSource
        Me.Deduction_descrComboBox.DisplayMember = "deduction_descr"
        Me.Deduction_descrComboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deduction_descrComboBox.FormattingEnabled = True
        Me.Deduction_descrComboBox.Location = New System.Drawing.Point(11, 94)
        Me.Deduction_descrComboBox.Name = "Deduction_descrComboBox"
        Me.Deduction_descrComboBox.Size = New System.Drawing.Size(241, 25)
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Payroll_deduction_tblDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.Payroll_deduction_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Payroll_deduction_tblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DeductioncodeDataGridViewTextBoxColumn, Me.DeductiondescrDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.DeductperiodfromDataGridViewTextBoxColumn, Me.DeductperiodtoDataGridViewTextBoxColumn, Me.DeductamtDataGridViewTextBoxColumn})
        Me.Payroll_deduction_tblDataGridView.DataSource = Me.PayrolldeductiontblBindingSource
        Me.Payroll_deduction_tblDataGridView.Location = New System.Drawing.Point(6, 83)
        Me.Payroll_deduction_tblDataGridView.Name = "Payroll_deduction_tblDataGridView"
        Me.Payroll_deduction_tblDataGridView.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Payroll_deduction_tblDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.Payroll_deduction_tblDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Payroll_deduction_tblDataGridView.Size = New System.Drawing.Size(643, 356)
        Me.Payroll_deduction_tblDataGridView.TabIndex = 148
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
        Me.DeductiondescrDataGridViewTextBoxColumn.DataPropertyName = "deduction_descr"
        Me.DeductiondescrDataGridViewTextBoxColumn.HeaderText = "Deduction"
        Me.DeductiondescrDataGridViewTextBoxColumn.Name = "DeductiondescrDataGridViewTextBoxColumn"
        Me.DeductiondescrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "ID No"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        Me.EmployeeidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeenameDataGridViewTextBoxColumn
        '
        Me.EmployeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name"
        Me.EmployeenameDataGridViewTextBoxColumn.HeaderText = "Employee Name"
        Me.EmployeenameDataGridViewTextBoxColumn.Name = "EmployeenameDataGridViewTextBoxColumn"
        Me.EmployeenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeductperiodfromDataGridViewTextBoxColumn
        '
        Me.DeductperiodfromDataGridViewTextBoxColumn.DataPropertyName = "deduct_period_from"
        Me.DeductperiodfromDataGridViewTextBoxColumn.HeaderText = "Period from"
        Me.DeductperiodfromDataGridViewTextBoxColumn.Name = "DeductperiodfromDataGridViewTextBoxColumn"
        Me.DeductperiodfromDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeductperiodtoDataGridViewTextBoxColumn
        '
        Me.DeductperiodtoDataGridViewTextBoxColumn.DataPropertyName = "deduct_period_to"
        Me.DeductperiodtoDataGridViewTextBoxColumn.HeaderText = "Period to"
        Me.DeductperiodtoDataGridViewTextBoxColumn.Name = "DeductperiodtoDataGridViewTextBoxColumn"
        Me.DeductperiodtoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeductamtDataGridViewTextBoxColumn
        '
        Me.DeductamtDataGridViewTextBoxColumn.DataPropertyName = "deduct_amt"
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DeductamtDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.DeductamtDataGridViewTextBoxColumn.HeaderText = "Deduct Amount"
        Me.DeductamtDataGridViewTextBoxColumn.Name = "DeductamtDataGridViewTextBoxColumn"
        Me.DeductamtDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.txtb_search.Location = New System.Drawing.Point(9, 54)
        Me.txtb_search.Name = "txtb_search"
        Me.txtb_search.Size = New System.Drawing.Size(169, 23)
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
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Employee_idLabel)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.btndel)
        Me.GroupBox1.Controls.Add(Me.Employee_idComboBox)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Deduct_period_fromLabel)
        Me.GroupBox1.Controls.Add(Me.Deduct_period_fromDateTimePicker)
        Me.GroupBox1.Controls.Add(Deduct_period_toLabel)
        Me.GroupBox1.Controls.Add(Me.Deduct_amtTextBox)
        Me.GroupBox1.Controls.Add(Me.Deduct_period_toDateTimePicker)
        Me.GroupBox1.Controls.Add(Deduct_amtLabel)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 452)
        Me.GroupBox1.TabIndex = 151
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deduction Information"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(6, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 20)
        Me.Label14.TabIndex = 151
        Me.Label14.Text = "Search :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCreate)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Payroll_deduction_tblDataGridView)
        Me.GroupBox2.Controls.Add(Me.txtb_search)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(285, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 452)
        Me.GroupBox2.TabIndex = 152
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deduction List"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.ForestGreen
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Location = New System.Drawing.Point(523, 34)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(124, 39)
        Me.btnCreate.TabIndex = 152
        Me.btnCreate.Text = "Create New"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'Deduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(953, 535)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Deduction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deduction"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeductionlisttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payroll_deduction_tblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldeductiontblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btn_save As Button
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
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeductioncodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeductiondescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeductperiodfromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeductperiodtoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeductamtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCreate As Button
End Class
