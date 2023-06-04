<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Holiday
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Holiday))
        Dim HolidayDateLabel As System.Windows.Forms.Label
        Dim HolidayNameLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSave = New FontAwesome.Sharp.IconButton()
        Me.BtnDelete = New FontAwesome.Sharp.IconButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Payroll_deduction_tblDataGridView = New System.Windows.Forms.DataGridView()
        Me.HolidaystblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrolldbDataSet = New LCCPayrollSystem.payrolldbDataSet()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblAddEditMode = New System.Windows.Forms.Label()
        Me.Holidays_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Holidays_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.holidays_tblTableAdapter()
        Me.TableAdapterManager = New LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager()
        Me.HolidayDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HolidayNameTextBox = New System.Windows.Forms.TextBox()
        Me.IsWithPayCheckBox = New System.Windows.Forms.CheckBox()
        Me.HolidayDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HolidayNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsWithPayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HolidayDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        HolidayDateLabel = New System.Windows.Forms.Label()
        HolidayNameLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Payroll_deduction_tblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidaystblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Holidays_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Location = New System.Drawing.Point(6, 469)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 54)
        Me.Panel1.TabIndex = 156
        '
        'BtnSave
        '
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSave.Icon = FontAwesome.Sharp.IconChar.CheckCircleO
        Me.BtnSave.IconColor = System.Drawing.Color.Black
        Me.BtnSave.IconSize = 16
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(705, 0)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnSave.Size = New System.Drawing.Size(91, 54)
        Me.BtnSave.TabIndex = 135
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnDelete.Icon = FontAwesome.Sharp.IconChar.TrashO
        Me.BtnDelete.IconColor = System.Drawing.Color.Black
        Me.BtnDelete.IconSize = 16
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(796, 0)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnDelete.Size = New System.Drawing.Size(91, 54)
        Me.BtnDelete.TabIndex = 133
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Payroll_deduction_tblDataGridView)
        Me.GroupBox2.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(18, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(881, 323)
        Me.GroupBox2.TabIndex = 155
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Holiday List"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(79, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 14)
        Me.Label13.TabIndex = 153
        Me.Label13.Text = "(Holiday Name or Holiday Date)"
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(751, 29)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(124, 39)
        Me.BtnAdd.TabIndex = 152
        Me.BtnAdd.Text = "Create New"
        Me.BtnAdd.UseVisualStyleBackColor = False
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
        'Payroll_deduction_tblDataGridView
        '
        Me.Payroll_deduction_tblDataGridView.AllowUserToAddRows = False
        Me.Payroll_deduction_tblDataGridView.AllowUserToDeleteRows = False
        Me.Payroll_deduction_tblDataGridView.AutoGenerateColumns = False
        Me.Payroll_deduction_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Payroll_deduction_tblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HolidayDateDataGridViewTextBoxColumn, Me.HolidayNameDataGridViewTextBoxColumn, Me.IsWithPayDataGridViewCheckBoxColumn, Me.HolidayDate})
        Me.Payroll_deduction_tblDataGridView.DataSource = Me.HolidaystblBindingSource
        Me.Payroll_deduction_tblDataGridView.Location = New System.Drawing.Point(6, 74)
        Me.Payroll_deduction_tblDataGridView.Name = "Payroll_deduction_tblDataGridView"
        Me.Payroll_deduction_tblDataGridView.ReadOnly = True
        Me.Payroll_deduction_tblDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Payroll_deduction_tblDataGridView.Size = New System.Drawing.Size(869, 243)
        Me.Payroll_deduction_tblDataGridView.TabIndex = 148
        '
        'HolidaystblBindingSource
        '
        Me.HolidaystblBindingSource.DataMember = "holidays_tbl"
        Me.HolidaystblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'PayrolldbDataSet
        '
        Me.PayrolldbDataSet.DataSetName = "payrolldbDataSet"
        Me.PayrolldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.AccessibleName = ""
        Me.TextBoxSearch.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(9, 45)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(226, 20)
        Me.TextBoxSearch.TabIndex = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(HolidayDateLabel)
        Me.GroupBox1.Controls.Add(Me.HolidayDateDateTimePicker)
        Me.GroupBox1.Controls.Add(HolidayNameLabel)
        Me.GroupBox1.Controls.Add(Me.HolidayNameTextBox)
        Me.GroupBox1.Controls.Add(Me.IsWithPayCheckBox)
        Me.GroupBox1.Controls.Add(Me.LblAddEditMode)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(18, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(881, 152)
        Me.GroupBox1.TabIndex = 154
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Holiday Information"
        '
        'LblAddEditMode
        '
        Me.LblAddEditMode.AutoSize = True
        Me.LblAddEditMode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddEditMode.ForeColor = System.Drawing.Color.Red
        Me.LblAddEditMode.Location = New System.Drawing.Point(236, 32)
        Me.LblAddEditMode.Name = "LblAddEditMode"
        Me.LblAddEditMode.Size = New System.Drawing.Size(15, 14)
        Me.LblAddEditMode.TabIndex = 141
        Me.LblAddEditMode.Text = "--"
        Me.LblAddEditMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Holidays_tblBindingSource
        '
        Me.Holidays_tblBindingSource.DataMember = "holidays_tbl"
        Me.Holidays_tblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'Holidays_tblTableAdapter
        '
        Me.Holidays_tblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.deduction_list_tblTableAdapter = Nothing
        Me.TableAdapterManager.dtr_conso_tblTableAdapter = Nothing
        Me.TableAdapterManager.dtr_tblTableAdapter = Nothing
        Me.TableAdapterManager.dtr_upload_tblTableAdapter = Nothing
        Me.TableAdapterManager.employee_tblTableAdapter = Nothing
        Me.TableAdapterManager.holidays_tblTableAdapter = Me.Holidays_tblTableAdapter
        Me.TableAdapterManager.payroll_deduction_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_tblTableAdapter = Nothing
        Me.TableAdapterManager.time_schedule_empl_tblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_tblTableAdapter = Nothing
        '
        'HolidayDateLabel
        '
        HolidayDateLabel.AutoSize = True
        HolidayDateLabel.Location = New System.Drawing.Point(158, 55)
        HolidayDateLabel.Name = "HolidayDateLabel"
        HolidayDateLabel.Size = New System.Drawing.Size(70, 14)
        HolidayDateLabel.TabIndex = 141
        HolidayDateLabel.Text = "Holiday Date:"
        '
        'HolidayDateDateTimePicker
        '
        Me.HolidayDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Holidays_tblBindingSource, "HolidayDate", True))
        Me.HolidayDateDateTimePicker.Location = New System.Drawing.Point(239, 51)
        Me.HolidayDateDateTimePicker.Name = "HolidayDateDateTimePicker"
        Me.HolidayDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.HolidayDateDateTimePicker.TabIndex = 142
        '
        'HolidayNameLabel
        '
        HolidayNameLabel.AutoSize = True
        HolidayNameLabel.Location = New System.Drawing.Point(158, 80)
        HolidayNameLabel.Name = "HolidayNameLabel"
        HolidayNameLabel.Size = New System.Drawing.Size(75, 14)
        HolidayNameLabel.TabIndex = 143
        HolidayNameLabel.Text = "Holiday Name:"
        '
        'HolidayNameTextBox
        '
        Me.HolidayNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Holidays_tblBindingSource, "HolidayName", True))
        Me.HolidayNameTextBox.Location = New System.Drawing.Point(239, 77)
        Me.HolidayNameTextBox.Multiline = True
        Me.HolidayNameTextBox.Name = "HolidayNameTextBox"
        Me.HolidayNameTextBox.Size = New System.Drawing.Size(410, 47)
        Me.HolidayNameTextBox.TabIndex = 144
        '
        'IsWithPayCheckBox
        '
        Me.IsWithPayCheckBox.Checked = True
        Me.IsWithPayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.IsWithPayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Holidays_tblBindingSource, "IsWithPay", True))
        Me.IsWithPayCheckBox.Location = New System.Drawing.Point(449, 51)
        Me.IsWithPayCheckBox.Name = "IsWithPayCheckBox"
        Me.IsWithPayCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.IsWithPayCheckBox.TabIndex = 146
        Me.IsWithPayCheckBox.Text = "Is WithPay"
        Me.IsWithPayCheckBox.UseVisualStyleBackColor = True
        '
        'HolidayDateDataGridViewTextBoxColumn
        '
        Me.HolidayDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HolidayDateDataGridViewTextBoxColumn.DataPropertyName = "HolidayDate"
        DataGridViewCellStyle3.Format = "D"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.HolidayDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.HolidayDateDataGridViewTextBoxColumn.HeaderText = "HolidayDate"
        Me.HolidayDateDataGridViewTextBoxColumn.Name = "HolidayDateDataGridViewTextBoxColumn"
        Me.HolidayDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HolidayNameDataGridViewTextBoxColumn
        '
        Me.HolidayNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HolidayNameDataGridViewTextBoxColumn.DataPropertyName = "HolidayName"
        Me.HolidayNameDataGridViewTextBoxColumn.HeaderText = "HolidayName"
        Me.HolidayNameDataGridViewTextBoxColumn.Name = "HolidayNameDataGridViewTextBoxColumn"
        Me.HolidayNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IsWithPayDataGridViewCheckBoxColumn
        '
        Me.IsWithPayDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IsWithPayDataGridViewCheckBoxColumn.DataPropertyName = "IsWithPay"
        Me.IsWithPayDataGridViewCheckBoxColumn.HeaderText = "IsWithPay"
        Me.IsWithPayDataGridViewCheckBoxColumn.Name = "IsWithPayDataGridViewCheckBoxColumn"
        Me.IsWithPayDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IsWithPayDataGridViewCheckBoxColumn.Visible = False
        '
        'HolidayDate
        '
        Me.HolidayDate.DataPropertyName = "HolidayDate"
        DataGridViewCellStyle4.Format = "y"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.HolidayDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.HolidayDate.HeaderText = "HolidayMonthYear"
        Me.HolidayDate.Name = "HolidayDate"
        Me.HolidayDate.ReadOnly = True
        '
        'Holiday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 525)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Holiday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Holiday"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Payroll_deduction_tblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidaystblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Holidays_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Payroll_deduction_tblDataGridView As DataGridView
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PayrolldbDataSet As payrolldbDataSet
    Friend WithEvents Holidays_tblBindingSource As BindingSource
    Friend WithEvents Holidays_tblTableAdapter As payrolldbDataSetTableAdapters.holidays_tblTableAdapter
    Friend WithEvents TableAdapterManager As payrolldbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HolidaystblBindingSource As BindingSource
    Friend WithEvents LblAddEditMode As Label
    Friend WithEvents HolidayDateDateTimePicker As DateTimePicker
    Friend WithEvents HolidayNameTextBox As TextBox
    Friend WithEvents IsWithPayCheckBox As CheckBox
    Friend WithEvents HolidayDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HolidayNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsWithPayDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents HolidayDate As DataGridViewTextBoxColumn
End Class
