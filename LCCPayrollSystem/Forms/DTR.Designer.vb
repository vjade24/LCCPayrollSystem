<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DTR
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
        Dim Dtr_dateLabel As System.Windows.Forms.Label
        Dim Time_in_amLabel As System.Windows.Forms.Label
        Dim Time_out_amLabel As System.Windows.Forms.Label
        Dim Time_in_pmLabel As System.Windows.Forms.Label
        Dim Time_out_pmLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DTR))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.TextBox_employee_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker_PeriodFrom = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_PeriodTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PayrolldbDataSet = New LCCPayrollSystem.payrolldbDataSet()
        Me.Dtr_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtr_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.dtr_tblTableAdapter()
        Me.TableAdapterManager = New LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager()
        Me.Dtr_tblDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Late = New System.Windows.Forms.TextBox()
        Me.TextBox_UnderTime = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Overtime = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_employeename = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_Absent = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Dtr_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tse_in_amDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tse_out_amDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tse_in_pmDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tse_out_pmDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
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
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Dtr_dateLabel = New System.Windows.Forms.Label()
        Time_in_amLabel = New System.Windows.Forms.Label()
        Time_out_amLabel = New System.Windows.Forms.Label()
        Time_in_pmLabel = New System.Windows.Forms.Label()
        Time_out_pmLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtr_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtr_tblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dtr_dateLabel
        '
        Dtr_dateLabel.AutoSize = True
        Dtr_dateLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dtr_dateLabel.Location = New System.Drawing.Point(655, 71)
        Dtr_dateLabel.Name = "Dtr_dateLabel"
        Dtr_dateLabel.Size = New System.Drawing.Size(29, 14)
        Dtr_dateLabel.TabIndex = 160
        Dtr_dateLabel.Text = "Date"
        '
        'Time_in_amLabel
        '
        Time_in_amLabel.AutoSize = True
        Time_in_amLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Time_in_amLabel.Location = New System.Drawing.Point(655, 112)
        Time_in_amLabel.Name = "Time_in_amLabel"
        Time_in_amLabel.Size = New System.Drawing.Size(58, 14)
        Time_in_amLabel.TabIndex = 162
        Time_in_amLabel.Text = "Time in AM"
        '
        'Time_out_amLabel
        '
        Time_out_amLabel.AutoSize = True
        Time_out_amLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Time_out_amLabel.Location = New System.Drawing.Point(656, 151)
        Time_out_amLabel.Name = "Time_out_amLabel"
        Time_out_amLabel.Size = New System.Drawing.Size(57, 14)
        Time_out_amLabel.TabIndex = 163
        Time_out_amLabel.Text = "Time in PM"
        '
        'Time_in_pmLabel
        '
        Time_in_pmLabel.AutoSize = True
        Time_in_pmLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Time_in_pmLabel.Location = New System.Drawing.Point(772, 112)
        Time_in_pmLabel.Name = "Time_in_pmLabel"
        Time_in_pmLabel.Size = New System.Drawing.Size(65, 14)
        Time_in_pmLabel.TabIndex = 164
        Time_in_pmLabel.Text = "Time out AM"
        '
        'Time_out_pmLabel
        '
        Time_out_pmLabel.AutoSize = True
        Time_out_pmLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Time_out_pmLabel.Location = New System.Drawing.Point(773, 151)
        Time_out_pmLabel.Name = "Time_out_pmLabel"
        Time_out_pmLabel.Size = New System.Drawing.Size(64, 14)
        Time_out_pmLabel.TabIndex = 165
        Time_out_pmLabel.Text = "Time out PM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1065, 55)
        Me.Panel2.TabIndex = 143
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 26)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Generate Employee Daily Time Record"
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(464, 89)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(111, 59)
        Me.btnGenerate.TabIndex = 144
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'TextBox_employee_id
        '
        Me.TextBox_employee_id.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_employee_id.Location = New System.Drawing.Point(17, 88)
        Me.TextBox_employee_id.Name = "TextBox_employee_id"
        Me.TextBox_employee_id.Size = New System.Drawing.Size(104, 20)
        Me.TextBox_employee_id.TabIndex = 145
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 14)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Employee ID"
        '
        'DateTimePicker_PeriodFrom
        '
        Me.DateTimePicker_PeriodFrom.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_PeriodFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_PeriodFrom.Location = New System.Drawing.Point(156, 88)
        Me.DateTimePicker_PeriodFrom.Name = "DateTimePicker_PeriodFrom"
        Me.DateTimePicker_PeriodFrom.Size = New System.Drawing.Size(143, 20)
        Me.DateTimePicker_PeriodFrom.TabIndex = 147
        '
        'DateTimePicker_PeriodTo
        '
        Me.DateTimePicker_PeriodTo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_PeriodTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_PeriodTo.Location = New System.Drawing.Point(315, 88)
        Me.DateTimePicker_PeriodTo.Name = "DateTimePicker_PeriodTo"
        Me.DateTimePicker_PeriodTo.Size = New System.Drawing.Size(143, 20)
        Me.DateTimePicker_PeriodTo.TabIndex = 148
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(153, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 14)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Dater from:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 14)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Dater to:"
        '
        'PayrolldbDataSet
        '
        Me.PayrolldbDataSet.DataSetName = "payrolldbDataSet"
        Me.PayrolldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dtr_tblBindingSource
        '
        Me.Dtr_tblBindingSource.DataMember = "dtr_tbl"
        Me.Dtr_tblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'Dtr_tblTableAdapter
        '
        Me.Dtr_tblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.deduction_list_tblTableAdapter = Nothing
        Me.TableAdapterManager.dtr_conso_tblTableAdapter = Nothing
        Me.TableAdapterManager.dtr_tblTableAdapter = Me.Dtr_tblTableAdapter
        Me.TableAdapterManager.dtr_upload_tblTableAdapter = Nothing
        Me.TableAdapterManager.employee_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_deduction_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_tblTableAdapter = Nothing
        Me.TableAdapterManager.time_schedule_empl_tblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_tblTableAdapter = Nothing
        '
        'Dtr_tblDataGridView
        '
        Me.Dtr_tblDataGridView.AllowUserToAddRows = False
        Me.Dtr_tblDataGridView.AllowUserToDeleteRows = False
        Me.Dtr_tblDataGridView.AutoGenerateColumns = False
        Me.Dtr_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtr_tblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewTextBoxColumn13, Me.Edit})
        Me.Dtr_tblDataGridView.DataSource = Me.Dtr_tblBindingSource
        Me.Dtr_tblDataGridView.Location = New System.Drawing.Point(17, 208)
        Me.Dtr_tblDataGridView.Name = "Dtr_tblDataGridView"
        Me.Dtr_tblDataGridView.ReadOnly = True
        Me.Dtr_tblDataGridView.Size = New System.Drawing.Size(1036, 558)
        Me.Dtr_tblDataGridView.TabIndex = 151
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 14)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Late (min)"
        '
        'TextBox_Late
        '
        Me.TextBox_Late.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Late.Location = New System.Drawing.Point(17, 170)
        Me.TextBox_Late.Name = "TextBox_Late"
        Me.TextBox_Late.ReadOnly = True
        Me.TextBox_Late.Size = New System.Drawing.Size(104, 20)
        Me.TextBox_Late.TabIndex = 153
        Me.TextBox_Late.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox_UnderTime
        '
        Me.TextBox_UnderTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_UnderTime.Location = New System.Drawing.Point(129, 170)
        Me.TextBox_UnderTime.Name = "TextBox_UnderTime"
        Me.TextBox_UnderTime.ReadOnly = True
        Me.TextBox_UnderTime.Size = New System.Drawing.Size(104, 20)
        Me.TextBox_UnderTime.TabIndex = 155
        Me.TextBox_UnderTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(126, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 14)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Undertime (min)"
        '
        'TextBox_Overtime
        '
        Me.TextBox_Overtime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Overtime.Location = New System.Drawing.Point(241, 170)
        Me.TextBox_Overtime.Name = "TextBox_Overtime"
        Me.TextBox_Overtime.ReadOnly = True
        Me.TextBox_Overtime.Size = New System.Drawing.Size(104, 20)
        Me.TextBox_Overtime.TabIndex = 157
        Me.TextBox_Overtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(238, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 14)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Overtime (min)"
        '
        'TextBox_employeename
        '
        Me.TextBox_employeename.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_employeename.Location = New System.Drawing.Point(17, 127)
        Me.TextBox_employeename.Name = "TextBox_employeename"
        Me.TextBox_employeename.ReadOnly = True
        Me.TextBox_employeename.Size = New System.Drawing.Size(440, 20)
        Me.TextBox_employeename.TabIndex = 159
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 14)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "Employee name"
        '
        'TextBox_Absent
        '
        Me.TextBox_Absent.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Absent.Location = New System.Drawing.Point(353, 170)
        Me.TextBox_Absent.Name = "TextBox_Absent"
        Me.TextBox_Absent.ReadOnly = True
        Me.TextBox_Absent.Size = New System.Drawing.Size(104, 20)
        Me.TextBox_Absent.TabIndex = 173
        Me.TextBox_Absent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(350, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 14)
        Me.Label9.TabIndex = 172
        Me.Label9.Text = "Absent (day/s)"
        '
        'Dtr_dateDateTimePicker
        '
        Me.Dtr_dateDateTimePicker.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtr_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtr_dateDateTimePicker.Location = New System.Drawing.Point(658, 88)
        Me.Dtr_dateDateTimePicker.Name = "Dtr_dateDateTimePicker"
        Me.Dtr_dateDateTimePicker.Size = New System.Drawing.Size(229, 20)
        Me.Dtr_dateDateTimePicker.TabIndex = 161
        '
        'Tse_in_amDateTimePicker
        '
        Me.Tse_in_amDateTimePicker.CustomFormat = "h:mmtt"
        Me.Tse_in_amDateTimePicker.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tse_in_amDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tse_in_amDateTimePicker.Location = New System.Drawing.Point(658, 128)
        Me.Tse_in_amDateTimePicker.Name = "Tse_in_amDateTimePicker"
        Me.Tse_in_amDateTimePicker.ShowUpDown = True
        Me.Tse_in_amDateTimePicker.Size = New System.Drawing.Size(111, 20)
        Me.Tse_in_amDateTimePicker.TabIndex = 166
        '
        'Tse_out_amDateTimePicker
        '
        Me.Tse_out_amDateTimePicker.CustomFormat = "h:mmtt"
        Me.Tse_out_amDateTimePicker.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tse_out_amDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tse_out_amDateTimePicker.Location = New System.Drawing.Point(775, 128)
        Me.Tse_out_amDateTimePicker.Name = "Tse_out_amDateTimePicker"
        Me.Tse_out_amDateTimePicker.ShowUpDown = True
        Me.Tse_out_amDateTimePicker.Size = New System.Drawing.Size(111, 20)
        Me.Tse_out_amDateTimePicker.TabIndex = 167
        '
        'Tse_in_pmDateTimePicker
        '
        Me.Tse_in_pmDateTimePicker.CustomFormat = "h:mmtt"
        Me.Tse_in_pmDateTimePicker.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tse_in_pmDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tse_in_pmDateTimePicker.Location = New System.Drawing.Point(659, 167)
        Me.Tse_in_pmDateTimePicker.Name = "Tse_in_pmDateTimePicker"
        Me.Tse_in_pmDateTimePicker.ShowUpDown = True
        Me.Tse_in_pmDateTimePicker.Size = New System.Drawing.Size(111, 20)
        Me.Tse_in_pmDateTimePicker.TabIndex = 168
        '
        'Tse_out_pmDateTimePicker
        '
        Me.Tse_out_pmDateTimePicker.CustomFormat = "h:mmtt"
        Me.Tse_out_pmDateTimePicker.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tse_out_pmDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tse_out_pmDateTimePicker.Location = New System.Drawing.Point(776, 167)
        Me.Tse_out_pmDateTimePicker.Name = "Tse_out_pmDateTimePicker"
        Me.Tse_out_pmDateTimePicker.ShowUpDown = True
        Me.Tse_out_pmDateTimePicker.Size = New System.Drawing.Size(111, 20)
        Me.Tse_out_pmDateTimePicker.TabIndex = 169
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(893, 90)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 59)
        Me.btnSave.TabIndex = 170
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.Text = "Update"
        Me.DataGridViewTextBoxColumn1.UseColumnTextForButtonValue = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "employee_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "employee_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "employee_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "employee_name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "dtr_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "dtr_date_day"
        Me.DataGridViewTextBoxColumn5.HeaderText = "dtr_date_day"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "time_in_am"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Time in AM"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "time_out_am"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Time out AM"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "time_in_pm"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Time in PM"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "time_out_pm"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Time out PM"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "late_time_min"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn10.HeaderText = "Late (min)"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "under_time_min"
        DataGridViewCellStyle2.Format = "N0"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn11.HeaderText = "Undertime (min)"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ot_min"
        DataGridViewCellStyle3.Format = "N0"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn12.HeaderText = "Overtime (min)"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "is_absent"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Absent"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "is_leave"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "is_leave"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Visible = False
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "is_holiday"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "is_holiday"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "remarks_details"
        Me.DataGridViewTextBoxColumn13.HeaderText = "remarks_details"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'Edit
        '
        Me.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Edit.HeaderText = "Action"
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Edit.Text = "Update"
        Me.Edit.UseColumnTextForButtonValue = True
        '
        'DTR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 778)
        Me.Controls.Add(Me.TextBox_Absent)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Tse_out_pmDateTimePicker)
        Me.Controls.Add(Me.Tse_in_pmDateTimePicker)
        Me.Controls.Add(Me.Tse_out_amDateTimePicker)
        Me.Controls.Add(Me.Tse_in_amDateTimePicker)
        Me.Controls.Add(Time_out_pmLabel)
        Me.Controls.Add(Time_in_pmLabel)
        Me.Controls.Add(Time_out_amLabel)
        Me.Controls.Add(Time_in_amLabel)
        Me.Controls.Add(Dtr_dateLabel)
        Me.Controls.Add(Me.Dtr_dateDateTimePicker)
        Me.Controls.Add(Me.TextBox_employeename)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox_Overtime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox_UnderTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_Late)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Dtr_tblDataGridView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker_PeriodTo)
        Me.Controls.Add(Me.DateTimePicker_PeriodFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_employee_id)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DTR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtr_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtr_tblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents TextBox_employee_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker_PeriodFrom As DateTimePicker
    Friend WithEvents DateTimePicker_PeriodTo As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PayrolldbDataSet As payrolldbDataSet
    Friend WithEvents Dtr_tblBindingSource As BindingSource
    Friend WithEvents Dtr_tblTableAdapter As payrolldbDataSetTableAdapters.dtr_tblTableAdapter
    Friend WithEvents TableAdapterManager As payrolldbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Dtr_tblDataGridView As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_Late As TextBox
    Friend WithEvents TextBox_UnderTime As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_Overtime As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_employeename As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_Absent As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Dtr_dateDateTimePicker As DateTimePicker
    Friend WithEvents Tse_in_amDateTimePicker As DateTimePicker
    Friend WithEvents Tse_out_amDateTimePicker As DateTimePicker
    Friend WithEvents Tse_in_pmDateTimePicker As DateTimePicker
    Friend WithEvents Tse_out_pmDateTimePicker As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewButtonColumn
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
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
End Class
