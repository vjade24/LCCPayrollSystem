<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeductionFixed
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
        Dim DeductionCodeLabel As System.Windows.Forms.Label
        Dim DeductionDescrLabel As System.Windows.Forms.Label
        Dim EmploymentStatusLabel As System.Windows.Forms.Label
        Dim FixedAmountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeductionFixed))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSave = New FontAwesome.Sharp.IconButton()
        Me.BtnDelete = New FontAwesome.Sharp.IconButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Payroll_deduction_tblDataGridView = New System.Windows.Forms.DataGridView()
        Me.PayrolldeductionfixedtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrolldbDataSet = New LCCPayrollSystem.payrolldbDataSet()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.DeductionCodeTextBox = New System.Windows.Forms.TextBox()
        Me.DeductionDescrComboBox = New System.Windows.Forms.ComboBox()
        Me.DeductionlisttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmploymentStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.FixedAmountTextBox = New System.Windows.Forms.TextBox()
        Me.LblAddEditMode = New System.Windows.Forms.Label()
        Me.Payroll_deduction_fixed_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.payroll_deduction_fixed_tblTableAdapter()
        Me.TableAdapterManager = New LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager()
        Me.Deduction_list_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.deduction_list_tblTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductionCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductionDescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmploymentStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FixedAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        DeductionCodeLabel = New System.Windows.Forms.Label()
        DeductionDescrLabel = New System.Windows.Forms.Label()
        EmploymentStatusLabel = New System.Windows.Forms.Label()
        FixedAmountLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Payroll_deduction_tblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldeductionfixedtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DeductionlisttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(109, 58)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 14)
        IdLabel.TabIndex = 141
        IdLabel.Text = "Id:"
        IdLabel.Visible = False
        '
        'DeductionCodeLabel
        '
        DeductionCodeLabel.AutoSize = True
        DeductionCodeLabel.Location = New System.Drawing.Point(531, 58)
        DeductionCodeLabel.Name = "DeductionCodeLabel"
        DeductionCodeLabel.Size = New System.Drawing.Size(86, 14)
        DeductionCodeLabel.TabIndex = 143
        DeductionCodeLabel.Text = "Deduction Code:"
        DeductionCodeLabel.Visible = False
        '
        'DeductionDescrLabel
        '
        DeductionDescrLabel.AutoSize = True
        DeductionDescrLabel.Location = New System.Drawing.Point(236, 58)
        DeductionDescrLabel.Name = "DeductionDescrLabel"
        DeductionDescrLabel.Size = New System.Drawing.Size(90, 14)
        DeductionDescrLabel.TabIndex = 145
        DeductionDescrLabel.Text = "Deduction Descr:"
        '
        'EmploymentStatusLabel
        '
        EmploymentStatusLabel.AutoSize = True
        EmploymentStatusLabel.Location = New System.Drawing.Point(236, 100)
        EmploymentStatusLabel.Name = "EmploymentStatusLabel"
        EmploymentStatusLabel.Size = New System.Drawing.Size(101, 14)
        EmploymentStatusLabel.TabIndex = 147
        EmploymentStatusLabel.Text = "Employment Status:"
        '
        'FixedAmountLabel
        '
        FixedAmountLabel.AutoSize = True
        FixedAmountLabel.Location = New System.Drawing.Point(531, 100)
        FixedAmountLabel.Name = "FixedAmountLabel"
        FixedAmountLabel.Size = New System.Drawing.Size(75, 14)
        FixedAmountLabel.TabIndex = 149
        FixedAmountLabel.Text = "Fixed Amount:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Location = New System.Drawing.Point(6, 469)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 54)
        Me.Panel1.TabIndex = 159
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
        Me.GroupBox2.Location = New System.Drawing.Point(18, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(881, 275)
        Me.GroupBox2.TabIndex = 158
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fixed Deduction List"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(79, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 14)
        Me.Label13.TabIndex = 153
        Me.Label13.Text = "(Last name or First name)"
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
        Me.Payroll_deduction_tblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DeductionCodeDataGridViewTextBoxColumn, Me.DeductionDescrDataGridViewTextBoxColumn, Me.EmploymentStatusDataGridViewTextBoxColumn, Me.FixedAmountDataGridViewTextBoxColumn})
        Me.Payroll_deduction_tblDataGridView.DataSource = Me.PayrolldeductionfixedtblBindingSource
        Me.Payroll_deduction_tblDataGridView.Location = New System.Drawing.Point(6, 74)
        Me.Payroll_deduction_tblDataGridView.Name = "Payroll_deduction_tblDataGridView"
        Me.Payroll_deduction_tblDataGridView.ReadOnly = True
        Me.Payroll_deduction_tblDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Payroll_deduction_tblDataGridView.Size = New System.Drawing.Size(869, 195)
        Me.Payroll_deduction_tblDataGridView.TabIndex = 148
        '
        'PayrolldeductionfixedtblBindingSource
        '
        Me.PayrolldeductionfixedtblBindingSource.DataMember = "payroll_deduction_fixed_tbl"
        Me.PayrolldeductionfixedtblBindingSource.DataSource = Me.PayrolldbDataSet
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
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(DeductionCodeLabel)
        Me.GroupBox1.Controls.Add(Me.DeductionCodeTextBox)
        Me.GroupBox1.Controls.Add(DeductionDescrLabel)
        Me.GroupBox1.Controls.Add(Me.DeductionDescrComboBox)
        Me.GroupBox1.Controls.Add(EmploymentStatusLabel)
        Me.GroupBox1.Controls.Add(Me.EmploymentStatusComboBox)
        Me.GroupBox1.Controls.Add(FixedAmountLabel)
        Me.GroupBox1.Controls.Add(Me.FixedAmountTextBox)
        Me.GroupBox1.Controls.Add(Me.LblAddEditMode)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(18, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(881, 181)
        Me.GroupBox1.TabIndex = 157
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fixed Deduction"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrolldeductionfixedtblBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(112, 75)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IdTextBox.TabIndex = 142
        Me.IdTextBox.Visible = False
        '
        'DeductionCodeTextBox
        '
        Me.DeductionCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrolldeductionfixedtblBindingSource, "DeductionCode", True))
        Me.DeductionCodeTextBox.Location = New System.Drawing.Point(534, 75)
        Me.DeductionCodeTextBox.Name = "DeductionCodeTextBox"
        Me.DeductionCodeTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DeductionCodeTextBox.TabIndex = 144
        Me.DeductionCodeTextBox.Visible = False
        '
        'DeductionDescrComboBox
        '
        Me.DeductionDescrComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrolldeductionfixedtblBindingSource, "DeductionDescr", True))
        Me.DeductionDescrComboBox.DataSource = Me.DeductionlisttblBindingSource
        Me.DeductionDescrComboBox.DisplayMember = "deduction_descr"
        Me.DeductionDescrComboBox.FormattingEnabled = True
        Me.DeductionDescrComboBox.Location = New System.Drawing.Point(239, 75)
        Me.DeductionDescrComboBox.Name = "DeductionDescrComboBox"
        Me.DeductionDescrComboBox.Size = New System.Drawing.Size(286, 22)
        Me.DeductionDescrComboBox.TabIndex = 146
        Me.DeductionDescrComboBox.ValueMember = "deduction_code"
        '
        'DeductionlisttblBindingSource
        '
        Me.DeductionlisttblBindingSource.DataMember = "deduction_list_tbl"
        Me.DeductionlisttblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'EmploymentStatusComboBox
        '
        Me.EmploymentStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrolldeductionfixedtblBindingSource, "EmploymentStatus", True))
        Me.EmploymentStatusComboBox.FormattingEnabled = True
        Me.EmploymentStatusComboBox.Items.AddRange(New Object() {"Full-Time", "Staff", "Part-Time"})
        Me.EmploymentStatusComboBox.Location = New System.Drawing.Point(239, 117)
        Me.EmploymentStatusComboBox.Name = "EmploymentStatusComboBox"
        Me.EmploymentStatusComboBox.Size = New System.Drawing.Size(286, 22)
        Me.EmploymentStatusComboBox.TabIndex = 148
        '
        'FixedAmountTextBox
        '
        Me.FixedAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrolldeductionfixedtblBindingSource, "FixedAmount", True))
        Me.FixedAmountTextBox.Location = New System.Drawing.Point(534, 117)
        Me.FixedAmountTextBox.Name = "FixedAmountTextBox"
        Me.FixedAmountTextBox.Size = New System.Drawing.Size(121, 20)
        Me.FixedAmountTextBox.TabIndex = 150
        Me.FixedAmountTextBox.Text = "0.00"
        Me.FixedAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'Payroll_deduction_fixed_tblTableAdapter
        '
        Me.Payroll_deduction_fixed_tblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.deduction_list_tblTableAdapter = Me.Deduction_list_tblTableAdapter
        Me.TableAdapterManager.dtr_conso_tblTableAdapter = Nothing
        Me.TableAdapterManager.dtr_tblTableAdapter = Nothing
        Me.TableAdapterManager.dtr_upload_tblTableAdapter = Nothing
        Me.TableAdapterManager.employee_tblTableAdapter = Nothing
        Me.TableAdapterManager.holidays_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_deduction_fixed_tblTableAdapter = Me.Payroll_deduction_fixed_tblTableAdapter
        Me.TableAdapterManager.payroll_deduction_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_tblTableAdapter = Nothing
        Me.TableAdapterManager.time_schedule_empl_tblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_tblTableAdapter = Nothing
        '
        'Deduction_list_tblTableAdapter
        '
        Me.Deduction_list_tblTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'DeductionCodeDataGridViewTextBoxColumn
        '
        Me.DeductionCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DeductionCodeDataGridViewTextBoxColumn.DataPropertyName = "DeductionCode"
        Me.DeductionCodeDataGridViewTextBoxColumn.HeaderText = "DeductionCode"
        Me.DeductionCodeDataGridViewTextBoxColumn.Name = "DeductionCodeDataGridViewTextBoxColumn"
        Me.DeductionCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeductionCodeDataGridViewTextBoxColumn.Visible = False
        '
        'DeductionDescrDataGridViewTextBoxColumn
        '
        Me.DeductionDescrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DeductionDescrDataGridViewTextBoxColumn.DataPropertyName = "DeductionDescr"
        Me.DeductionDescrDataGridViewTextBoxColumn.HeaderText = "DeductionDescr"
        Me.DeductionDescrDataGridViewTextBoxColumn.Name = "DeductionDescrDataGridViewTextBoxColumn"
        Me.DeductionDescrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmploymentStatusDataGridViewTextBoxColumn
        '
        Me.EmploymentStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmploymentStatusDataGridViewTextBoxColumn.DataPropertyName = "EmploymentStatus"
        Me.EmploymentStatusDataGridViewTextBoxColumn.HeaderText = "EmploymentStatus"
        Me.EmploymentStatusDataGridViewTextBoxColumn.Name = "EmploymentStatusDataGridViewTextBoxColumn"
        Me.EmploymentStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FixedAmountDataGridViewTextBoxColumn
        '
        Me.FixedAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FixedAmountDataGridViewTextBoxColumn.DataPropertyName = "FixedAmount"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FixedAmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FixedAmountDataGridViewTextBoxColumn.HeaderText = "FixedAmount"
        Me.FixedAmountDataGridViewTextBoxColumn.Name = "FixedAmountDataGridViewTextBoxColumn"
        Me.FixedAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeductionFixed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 525)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DeductionFixed"
        Me.Text = "DeductionFixed"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Payroll_deduction_tblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldeductionfixedtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DeductionlisttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LblAddEditMode As Label
    Friend WithEvents PayrolldbDataSet As payrolldbDataSet
    Friend WithEvents PayrolldeductionfixedtblBindingSource As BindingSource
    Friend WithEvents Payroll_deduction_fixed_tblTableAdapter As payrolldbDataSetTableAdapters.payroll_deduction_fixed_tblTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents DeductionCodeTextBox As TextBox
    Friend WithEvents DeductionDescrComboBox As ComboBox
    Friend WithEvents EmploymentStatusComboBox As ComboBox
    Friend WithEvents FixedAmountTextBox As TextBox
    Friend WithEvents TableAdapterManager As payrolldbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Deduction_list_tblTableAdapter As payrolldbDataSetTableAdapters.deduction_list_tblTableAdapter
    Friend WithEvents DeductionlisttblBindingSource As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeductionCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeductionDescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmploymentStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FixedAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
