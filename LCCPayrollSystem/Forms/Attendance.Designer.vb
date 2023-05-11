<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Attendance
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
        Dim Employee_nameLabel As System.Windows.Forms.Label
        Dim Tse_dateLabel As System.Windows.Forms.Label
        Dim Tse_in_amLabel As System.Windows.Forms.Label
        Dim Tse_out_amLabel As System.Windows.Forms.Label
        Dim Tse_in_pmLabel As System.Windows.Forms.Label
        Dim Tse_out_pmLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnRemoveEntry = New System.Windows.Forms.Button()
        Me.Vw_time_schedule_empl_tblDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vw_time_schedule_empl_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrolldbDataSet = New LCCPayrollSystem.payrolldbDataSet()
        Me.btnGenerateSked = New System.Windows.Forms.Button()
        Me.Tse_out_pmDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tse_in_pmDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tse_out_amDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tse_in_amDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSaveSked = New System.Windows.Forms.Button()
        Me.Tse_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Dtr_conso_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Employee_nameComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboBoxYear = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMonth = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Vw_time_schedule_empl_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.vw_time_schedule_empl_tblTableAdapter()
        Me.TableAdapterManager = New LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager()
        Me.Dtr_conso_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.dtr_conso_tblTableAdapter()
        Employee_nameLabel = New System.Windows.Forms.Label()
        Tse_dateLabel = New System.Windows.Forms.Label()
        Tse_in_amLabel = New System.Windows.Forms.Label()
        Tse_out_amLabel = New System.Windows.Forms.Label()
        Tse_in_pmLabel = New System.Windows.Forms.Label()
        Tse_out_pmLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Vw_time_schedule_empl_tblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_time_schedule_empl_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtr_conso_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Employee_nameLabel
        '
        Employee_nameLabel.AutoSize = True
        Employee_nameLabel.Location = New System.Drawing.Point(12, 25)
        Employee_nameLabel.Name = "Employee_nameLabel"
        Employee_nameLabel.Size = New System.Drawing.Size(84, 13)
        Employee_nameLabel.TabIndex = 6
        Employee_nameLabel.Text = "employee name:"
        '
        'Tse_dateLabel
        '
        Tse_dateLabel.AutoSize = True
        Tse_dateLabel.Location = New System.Drawing.Point(164, 46)
        Tse_dateLabel.Name = "Tse_dateLabel"
        Tse_dateLabel.Size = New System.Drawing.Size(48, 13)
        Tse_dateLabel.TabIndex = 1
        Tse_dateLabel.Text = "tse date:"
        '
        'Tse_in_amLabel
        '
        Tse_in_amLabel.AutoSize = True
        Tse_in_amLabel.Location = New System.Drawing.Point(160, 70)
        Tse_in_amLabel.Name = "Tse_in_amLabel"
        Tse_in_amLabel.Size = New System.Drawing.Size(52, 13)
        Tse_in_amLabel.TabIndex = 11
        Tse_in_amLabel.Text = "tse in am:"
        '
        'Tse_out_amLabel
        '
        Tse_out_amLabel.AutoSize = True
        Tse_out_amLabel.Location = New System.Drawing.Point(319, 70)
        Tse_out_amLabel.Name = "Tse_out_amLabel"
        Tse_out_amLabel.Size = New System.Drawing.Size(59, 13)
        Tse_out_amLabel.TabIndex = 12
        Tse_out_amLabel.Text = "tse out am:"
        '
        'Tse_in_pmLabel
        '
        Tse_in_pmLabel.AutoSize = True
        Tse_in_pmLabel.Location = New System.Drawing.Point(160, 96)
        Tse_in_pmLabel.Name = "Tse_in_pmLabel"
        Tse_in_pmLabel.Size = New System.Drawing.Size(52, 13)
        Tse_in_pmLabel.TabIndex = 13
        Tse_in_pmLabel.Text = "tse in pm:"
        '
        'Tse_out_pmLabel
        '
        Tse_out_pmLabel.AutoSize = True
        Tse_out_pmLabel.Location = New System.Drawing.Point(319, 96)
        Tse_out_pmLabel.Name = "Tse_out_pmLabel"
        Tse_out_pmLabel.Size = New System.Drawing.Size(59, 13)
        Tse_out_pmLabel.TabIndex = 14
        Tse_out_pmLabel.Text = "tse out pm:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(309, 25)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(29, 13)
        Label1.TabIndex = 9
        Label1.Text = "Year"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(436, 25)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(37, 13)
        Label2.TabIndex = 11
        Label2.Text = "Month"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(858, 472)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.btnRemoveEntry)
        Me.TabPage1.Controls.Add(Me.Vw_time_schedule_empl_tblDataGridView)
        Me.TabPage1.Controls.Add(Me.btnGenerateSked)
        Me.TabPage1.Controls.Add(Tse_out_pmLabel)
        Me.TabPage1.Controls.Add(Me.Tse_out_pmDateTimePicker)
        Me.TabPage1.Controls.Add(Tse_in_pmLabel)
        Me.TabPage1.Controls.Add(Me.Tse_in_pmDateTimePicker)
        Me.TabPage1.Controls.Add(Tse_out_amLabel)
        Me.TabPage1.Controls.Add(Me.Tse_out_amDateTimePicker)
        Me.TabPage1.Controls.Add(Tse_in_amLabel)
        Me.TabPage1.Controls.Add(Me.Tse_in_amDateTimePicker)
        Me.TabPage1.Controls.Add(Me.btnSaveSked)
        Me.TabPage1.Controls.Add(Tse_dateLabel)
        Me.TabPage1.Controls.Add(Me.Tse_dateDateTimePicker)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(850, 446)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employee Schedule"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnRemoveEntry
        '
        Me.btnRemoveEntry.Location = New System.Drawing.Point(479, 78)
        Me.btnRemoveEntry.Name = "btnRemoveEntry"
        Me.btnRemoveEntry.Size = New System.Drawing.Size(120, 31)
        Me.btnRemoveEntry.TabIndex = 17
        Me.btnRemoveEntry.Text = "Remove Entry"
        Me.btnRemoveEntry.UseVisualStyleBackColor = True
        '
        'Vw_time_schedule_empl_tblDataGridView
        '
        Me.Vw_time_schedule_empl_tblDataGridView.AllowUserToAddRows = False
        Me.Vw_time_schedule_empl_tblDataGridView.AllowUserToDeleteRows = False
        Me.Vw_time_schedule_empl_tblDataGridView.AutoGenerateColumns = False
        Me.Vw_time_schedule_empl_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_time_schedule_empl_tblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.Vw_time_schedule_empl_tblDataGridView.DataSource = Me.Vw_time_schedule_empl_tblBindingSource
        Me.Vw_time_schedule_empl_tblDataGridView.Location = New System.Drawing.Point(37, 118)
        Me.Vw_time_schedule_empl_tblDataGridView.Name = "Vw_time_schedule_empl_tblDataGridView"
        Me.Vw_time_schedule_empl_tblDataGridView.ReadOnly = True
        Me.Vw_time_schedule_empl_tblDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Vw_time_schedule_empl_tblDataGridView.Size = New System.Drawing.Size(643, 257)
        Me.Vw_time_schedule_empl_tblDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "dayname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "dayname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tse_date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "tse_date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "empl_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "empl_id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "employee_name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "employee_name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tse_in_am"
        Me.DataGridViewTextBoxColumn6.HeaderText = "tse_in_am"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tse_out_am"
        Me.DataGridViewTextBoxColumn7.HeaderText = "tse_out_am"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "tse_in_pm"
        Me.DataGridViewTextBoxColumn8.HeaderText = "tse_in_pm"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "tse_out_pm"
        Me.DataGridViewTextBoxColumn9.HeaderText = "tse_out_pm"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "converted_tse_in_am"
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = "----"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn10.HeaderText = "converted_tse_in_am"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "converted_tse_out_am"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = "----"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn11.HeaderText = "converted_tse_out_am"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "converted_tse_in_pm"
        DataGridViewCellStyle3.Format = "t"
        DataGridViewCellStyle3.NullValue = "----"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn12.HeaderText = "converted_tse_in_pm"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "converted_tse_out_pm"
        DataGridViewCellStyle4.Format = "t"
        DataGridViewCellStyle4.NullValue = "----"
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn13.HeaderText = "converted_tse_out_pm"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'Vw_time_schedule_empl_tblBindingSource
        '
        Me.Vw_time_schedule_empl_tblBindingSource.DataMember = "vw_time_schedule_empl_tbl"
        Me.Vw_time_schedule_empl_tblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'PayrolldbDataSet
        '
        Me.PayrolldbDataSet.DataSetName = "payrolldbDataSet"
        Me.PayrolldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnGenerateSked
        '
        Me.btnGenerateSked.Location = New System.Drawing.Point(37, 52)
        Me.btnGenerateSked.Name = "btnGenerateSked"
        Me.btnGenerateSked.Size = New System.Drawing.Size(75, 49)
        Me.btnGenerateSked.TabIndex = 16
        Me.btnGenerateSked.Text = "Generate Schedule"
        Me.btnGenerateSked.UseVisualStyleBackColor = True
        '
        'Tse_out_pmDateTimePicker
        '
        Me.Tse_out_pmDateTimePicker.CustomFormat = "h:mmtt"
        Me.Tse_out_pmDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tse_out_pmDateTimePicker.Location = New System.Drawing.Point(384, 92)
        Me.Tse_out_pmDateTimePicker.Name = "Tse_out_pmDateTimePicker"
        Me.Tse_out_pmDateTimePicker.ShowUpDown = True
        Me.Tse_out_pmDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.Tse_out_pmDateTimePicker.TabIndex = 15
        '
        'Tse_in_pmDateTimePicker
        '
        Me.Tse_in_pmDateTimePicker.CustomFormat = "h:mmtt"
        Me.Tse_in_pmDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tse_in_pmDateTimePicker.Location = New System.Drawing.Point(225, 92)
        Me.Tse_in_pmDateTimePicker.Name = "Tse_in_pmDateTimePicker"
        Me.Tse_in_pmDateTimePicker.ShowUpDown = True
        Me.Tse_in_pmDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.Tse_in_pmDateTimePicker.TabIndex = 14
        '
        'Tse_out_amDateTimePicker
        '
        Me.Tse_out_amDateTimePicker.CustomFormat = "h:mmtt"
        Me.Tse_out_amDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tse_out_amDateTimePicker.Location = New System.Drawing.Point(384, 66)
        Me.Tse_out_amDateTimePicker.Name = "Tse_out_amDateTimePicker"
        Me.Tse_out_amDateTimePicker.ShowUpDown = True
        Me.Tse_out_amDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.Tse_out_amDateTimePicker.TabIndex = 13
        '
        'Tse_in_amDateTimePicker
        '
        Me.Tse_in_amDateTimePicker.CustomFormat = "h:mmtt"
        Me.Tse_in_amDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tse_in_amDateTimePicker.Location = New System.Drawing.Point(225, 66)
        Me.Tse_in_amDateTimePicker.Name = "Tse_in_amDateTimePicker"
        Me.Tse_in_amDateTimePicker.ShowUpDown = True
        Me.Tse_in_amDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.Tse_in_amDateTimePicker.TabIndex = 12
        '
        'btnSaveSked
        '
        Me.btnSaveSked.Location = New System.Drawing.Point(479, 46)
        Me.btnSaveSked.Name = "btnSaveSked"
        Me.btnSaveSked.Size = New System.Drawing.Size(120, 31)
        Me.btnSaveSked.TabIndex = 11
        Me.btnSaveSked.Text = "Save"
        Me.btnSaveSked.UseVisualStyleBackColor = True
        '
        'Tse_dateDateTimePicker
        '
        Me.Tse_dateDateTimePicker.Enabled = False
        Me.Tse_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Tse_dateDateTimePicker.Location = New System.Drawing.Point(225, 40)
        Me.Tse_dateDateTimePicker.Name = "Tse_dateDateTimePicker"
        Me.Tse_dateDateTimePicker.Size = New System.Drawing.Size(248, 20)
        Me.Tse_dateDateTimePicker.TabIndex = 2
        '
        'Dtr_conso_tblBindingSource
        '
        Me.Dtr_conso_tblBindingSource.DataMember = "dtr_conso_tbl"
        Me.Dtr_conso_tblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(850, 446)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Daily time Record"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Employee_nameComboBox
        '
        Me.Employee_nameComboBox.FormattingEnabled = True
        Me.Employee_nameComboBox.Location = New System.Drawing.Point(15, 41)
        Me.Employee_nameComboBox.Name = "Employee_nameComboBox"
        Me.Employee_nameComboBox.Size = New System.Drawing.Size(290, 21)
        Me.Employee_nameComboBox.TabIndex = 7
        '
        'ComboBoxYear
        '
        Me.ComboBoxYear.FormattingEnabled = True
        Me.ComboBoxYear.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025"})
        Me.ComboBoxYear.Location = New System.Drawing.Point(311, 41)
        Me.ComboBoxYear.Name = "ComboBoxYear"
        Me.ComboBoxYear.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxYear.TabIndex = 8
        '
        'ComboBoxMonth
        '
        Me.ComboBoxMonth.FormattingEnabled = True
        Me.ComboBoxMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBoxMonth.Location = New System.Drawing.Point(438, 41)
        Me.ComboBoxMonth.Name = "ComboBoxMonth"
        Me.ComboBoxMonth.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxMonth.TabIndex = 10
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(565, 32)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 37)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Vw_time_schedule_empl_tblTableAdapter
        '
        Me.Vw_time_schedule_empl_tblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.deduction_list_tblTableAdapter = Nothing
        Me.TableAdapterManager.dtr_conso_tblTableAdapter = Nothing
        Me.TableAdapterManager.employee_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_deduction_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_tblTableAdapter = Nothing
        Me.TableAdapterManager.time_schedule_empl_tblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_tblTableAdapter = Nothing
        '
        'Dtr_conso_tblTableAdapter
        '
        Me.Dtr_conso_tblTableAdapter.ClearBeforeFill = True
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 559)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ComboBoxMonth)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ComboBoxYear)
        Me.Controls.Add(Employee_nameLabel)
        Me.Controls.Add(Me.Employee_nameComboBox)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Attendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Vw_time_schedule_empl_tblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_time_schedule_empl_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtr_conso_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Employee_nameComboBox As ComboBox
    Friend WithEvents btnSaveSked As Button
    Friend WithEvents Tse_dateDateTimePicker As DateTimePicker
    Friend WithEvents Tse_out_pmDateTimePicker As DateTimePicker
    Friend WithEvents Tse_in_pmDateTimePicker As DateTimePicker
    Friend WithEvents Tse_out_amDateTimePicker As DateTimePicker
    Friend WithEvents Tse_in_amDateTimePicker As DateTimePicker
    Friend WithEvents ComboBoxYear As ComboBox
    Friend WithEvents ComboBoxMonth As ComboBox
    Friend WithEvents btnGenerateSked As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PayrolldbDataSet As payrolldbDataSet
    Friend WithEvents Vw_time_schedule_empl_tblBindingSource As BindingSource
    Friend WithEvents Vw_time_schedule_empl_tblTableAdapter As payrolldbDataSetTableAdapters.vw_time_schedule_empl_tblTableAdapter
    Friend WithEvents TableAdapterManager As payrolldbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Vw_time_schedule_empl_tblDataGridView As DataGridView
    Friend WithEvents btnRemoveEntry As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents Dtr_conso_tblBindingSource As BindingSource
    Friend WithEvents Dtr_conso_tblTableAdapter As payrolldbDataSetTableAdapters.dtr_conso_tblTableAdapter
End Class
