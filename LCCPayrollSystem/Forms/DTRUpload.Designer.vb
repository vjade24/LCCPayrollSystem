<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DTRUpload
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim Employee_idLabel As System.Windows.Forms.Label
        Dim Dtr_dateLabel As System.Windows.Forms.Label
        Dim Time_in_amLabel As System.Windows.Forms.Label
        Dim Time_out_amLabel As System.Windows.Forms.Label
        Dim Time_in_pmLabel As System.Windows.Forms.Label
        Dim Time_out_pmLabel As System.Windows.Forms.Label
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBoxMonth = New System.Windows.Forms.ComboBox()
        Me.ComboBoxYear = New System.Windows.Forms.ComboBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Tse_out_pmDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tse_in_pmDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tse_out_amDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tse_in_amDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Employee_idTextBox = New System.Windows.Forms.TextBox()
        Me.Dtr_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Dtr_conso_tblDataGridView = New System.Windows.Forms.DataGridView()
        Me.Dtr_conso_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrolldbDataSet = New LCCPayrollSystem.payrolldbDataSet()
        Me.Dtr_conso_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.dtr_conso_tblTableAdapter()
        Me.TableAdapterManager = New LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager()
        Me.btnShowGenerate = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Employee_idLabel = New System.Windows.Forms.Label()
        Dtr_dateLabel = New System.Windows.Forms.Label()
        Time_in_amLabel = New System.Windows.Forms.Label()
        Time_out_amLabel = New System.Windows.Forms.Label()
        Time_in_pmLabel = New System.Windows.Forms.Label()
        Time_out_pmLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Dtr_conso_tblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtr_conso_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(131, 6)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(37, 13)
        Label2.TabIndex = 15
        Label2.Text = "Month"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(4, 6)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(29, 13)
        Label1.TabIndex = 13
        Label1.Text = "Year"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(257, 6)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(49, 13)
        Label3.TabIndex = 16
        Label3.Text = "Filename"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(21, 18)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'Employee_idLabel
        '
        Employee_idLabel.AutoSize = True
        Employee_idLabel.Location = New System.Drawing.Point(21, 44)
        Employee_idLabel.Name = "Employee_idLabel"
        Employee_idLabel.Size = New System.Drawing.Size(66, 13)
        Employee_idLabel.TabIndex = 3
        Employee_idLabel.Text = "employee id:"
        '
        'Dtr_dateLabel
        '
        Dtr_dateLabel.AutoSize = True
        Dtr_dateLabel.Location = New System.Drawing.Point(21, 71)
        Dtr_dateLabel.Name = "Dtr_dateLabel"
        Dtr_dateLabel.Size = New System.Drawing.Size(46, 13)
        Dtr_dateLabel.TabIndex = 5
        Dtr_dateLabel.Text = "dtr date:"
        '
        'Time_in_amLabel
        '
        Time_in_amLabel.AutoSize = True
        Time_in_amLabel.Location = New System.Drawing.Point(392, 45)
        Time_in_amLabel.Name = "Time_in_amLabel"
        Time_in_amLabel.Size = New System.Drawing.Size(57, 13)
        Time_in_amLabel.TabIndex = 19
        Time_in_amLabel.Text = "time in am:"
        '
        'Time_out_amLabel
        '
        Time_out_amLabel.AutoSize = True
        Time_out_amLabel.Location = New System.Drawing.Point(385, 71)
        Time_out_amLabel.Name = "Time_out_amLabel"
        Time_out_amLabel.Size = New System.Drawing.Size(64, 13)
        Time_out_amLabel.TabIndex = 20
        Time_out_amLabel.Text = "time out am:"
        '
        'Time_in_pmLabel
        '
        Time_in_pmLabel.AutoSize = True
        Time_in_pmLabel.Location = New System.Drawing.Point(561, 45)
        Time_in_pmLabel.Name = "Time_in_pmLabel"
        Time_in_pmLabel.Size = New System.Drawing.Size(57, 13)
        Time_in_pmLabel.TabIndex = 21
        Time_in_pmLabel.Text = "time in pm:"
        '
        'Time_out_pmLabel
        '
        Time_out_pmLabel.AutoSize = True
        Time_out_pmLabel.Location = New System.Drawing.Point(554, 71)
        Time_out_pmLabel.Name = "Time_out_pmLabel"
        Time_out_pmLabel.Size = New System.Drawing.Size(64, 13)
        Time_out_pmLabel.TabIndex = 22
        Time_out_pmLabel.Text = "time out pm:"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(764, 23)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(103, 50)
        Me.btnUpload.TabIndex = 0
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Location = New System.Drawing.Point(6, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(861, 390)
        Me.DataGridView1.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(260, 23)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(498, 50)
        Me.TextBox1.TabIndex = 2
        '
        'ComboBoxMonth
        '
        Me.ComboBoxMonth.FormattingEnabled = True
        Me.ComboBoxMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBoxMonth.Location = New System.Drawing.Point(133, 22)
        Me.ComboBoxMonth.Name = "ComboBoxMonth"
        Me.ComboBoxMonth.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxMonth.TabIndex = 14
        '
        'ComboBoxYear
        '
        Me.ComboBoxYear.FormattingEnabled = True
        Me.ComboBoxYear.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025"})
        Me.ComboBoxYear.Location = New System.Drawing.Point(6, 22)
        Me.ComboBoxYear.Name = "ComboBoxYear"
        Me.ComboBoxYear.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxYear.TabIndex = 12
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(4, 47)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(250, 26)
        Me.btnLoad.TabIndex = 17
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(881, 486)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.btnLoad)
        Me.TabPage1.Controls.Add(Me.ComboBoxYear)
        Me.TabPage1.Controls.Add(Label3)
        Me.TabPage1.Controls.Add(Me.btnUpload)
        Me.TabPage1.Controls.Add(Label2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.ComboBoxMonth)
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(873, 460)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Information from Biometric"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Tse_out_pmDateTimePicker)
        Me.TabPage2.Controls.Add(Me.Tse_in_pmDateTimePicker)
        Me.TabPage2.Controls.Add(Me.Tse_out_amDateTimePicker)
        Me.TabPage2.Controls.Add(Me.Tse_in_amDateTimePicker)
        Me.TabPage2.Controls.Add(Time_out_pmLabel)
        Me.TabPage2.Controls.Add(Time_in_pmLabel)
        Me.TabPage2.Controls.Add(Time_out_amLabel)
        Me.TabPage2.Controls.Add(Time_in_amLabel)
        Me.TabPage2.Controls.Add(Me.btnSave)
        Me.TabPage2.Controls.Add(IdLabel)
        Me.TabPage2.Controls.Add(Me.IdTextBox)
        Me.TabPage2.Controls.Add(Employee_idLabel)
        Me.TabPage2.Controls.Add(Me.Employee_idTextBox)
        Me.TabPage2.Controls.Add(Dtr_dateLabel)
        Me.TabPage2.Controls.Add(Me.Dtr_dateDateTimePicker)
        Me.TabPage2.Controls.Add(Me.Dtr_conso_tblDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(873, 475)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Daily Time Record"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Tse_out_pmDateTimePicker
        '
        Me.Tse_out_pmDateTimePicker.CustomFormat = "h:mmtt"
        Me.Tse_out_pmDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tse_out_pmDateTimePicker.Location = New System.Drawing.Point(624, 67)
        Me.Tse_out_pmDateTimePicker.Name = "Tse_out_pmDateTimePicker"
        Me.Tse_out_pmDateTimePicker.ShowUpDown = True
        Me.Tse_out_pmDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.Tse_out_pmDateTimePicker.TabIndex = 26
        '
        'Tse_in_pmDateTimePicker
        '
        Me.Tse_in_pmDateTimePicker.CustomFormat = "h:mmtt"
        Me.Tse_in_pmDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tse_in_pmDateTimePicker.Location = New System.Drawing.Point(453, 67)
        Me.Tse_in_pmDateTimePicker.Name = "Tse_in_pmDateTimePicker"
        Me.Tse_in_pmDateTimePicker.ShowUpDown = True
        Me.Tse_in_pmDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.Tse_in_pmDateTimePicker.TabIndex = 25
        '
        'Tse_out_amDateTimePicker
        '
        Me.Tse_out_amDateTimePicker.CustomFormat = "h:mmtt"
        Me.Tse_out_amDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tse_out_amDateTimePicker.Location = New System.Drawing.Point(624, 41)
        Me.Tse_out_amDateTimePicker.Name = "Tse_out_amDateTimePicker"
        Me.Tse_out_amDateTimePicker.ShowUpDown = True
        Me.Tse_out_amDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.Tse_out_amDateTimePicker.TabIndex = 24
        '
        'Tse_in_amDateTimePicker
        '
        Me.Tse_in_amDateTimePicker.CustomFormat = "h:mmtt"
        Me.Tse_in_amDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tse_in_amDateTimePicker.Location = New System.Drawing.Point(453, 41)
        Me.Tse_in_amDateTimePicker.Name = "Tse_in_amDateTimePicker"
        Me.Tse_in_amDateTimePicker.ShowUpDown = True
        Me.Tse_in_amDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.Tse_in_amDateTimePicker.TabIndex = 23
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(739, 37)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 50)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(99, 15)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(280, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'Employee_idTextBox
        '
        Me.Employee_idTextBox.Location = New System.Drawing.Point(99, 41)
        Me.Employee_idTextBox.Name = "Employee_idTextBox"
        Me.Employee_idTextBox.ReadOnly = True
        Me.Employee_idTextBox.Size = New System.Drawing.Size(280, 20)
        Me.Employee_idTextBox.TabIndex = 4
        '
        'Dtr_dateDateTimePicker
        '
        Me.Dtr_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtr_dateDateTimePicker.Location = New System.Drawing.Point(99, 67)
        Me.Dtr_dateDateTimePicker.Name = "Dtr_dateDateTimePicker"
        Me.Dtr_dateDateTimePicker.Size = New System.Drawing.Size(280, 20)
        Me.Dtr_dateDateTimePicker.TabIndex = 6
        '
        'Dtr_conso_tblDataGridView
        '
        Me.Dtr_conso_tblDataGridView.AllowUserToAddRows = False
        Me.Dtr_conso_tblDataGridView.AllowUserToDeleteRows = False
        Me.Dtr_conso_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dtr_conso_tblDataGridView.Location = New System.Drawing.Point(6, 106)
        Me.Dtr_conso_tblDataGridView.Name = "Dtr_conso_tblDataGridView"
        Me.Dtr_conso_tblDataGridView.ReadOnly = True
        Me.Dtr_conso_tblDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.Dtr_conso_tblDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dtr_conso_tblDataGridView.Size = New System.Drawing.Size(861, 363)
        Me.Dtr_conso_tblDataGridView.TabIndex = 0
        '
        'Dtr_conso_tblBindingSource
        '
        Me.Dtr_conso_tblBindingSource.DataMember = "dtr_conso_tbl"
        Me.Dtr_conso_tblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'PayrolldbDataSet
        '
        Me.PayrolldbDataSet.DataSetName = "payrolldbDataSet"
        Me.PayrolldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dtr_conso_tblTableAdapter
        '
        Me.Dtr_conso_tblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.deduction_list_tblTableAdapter = Nothing
        Me.TableAdapterManager.dtr_conso_tblTableAdapter = Me.Dtr_conso_tblTableAdapter
        Me.TableAdapterManager.dtr_tblTableAdapter = Nothing
        Me.TableAdapterManager.employee_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_deduction_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_tblTableAdapter = Nothing
        Me.TableAdapterManager.time_schedule_empl_tblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_tblTableAdapter = Nothing
        '
        'btnShowGenerate
        '
        Me.btnShowGenerate.Location = New System.Drawing.Point(733, 12)
        Me.btnShowGenerate.Name = "btnShowGenerate"
        Me.btnShowGenerate.Size = New System.Drawing.Size(150, 23)
        Me.btnShowGenerate.TabIndex = 19
        Me.btnShowGenerate.Text = "Generate DTR"
        Me.btnShowGenerate.UseVisualStyleBackColor = True
        '
        'DTRUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 525)
        Me.Controls.Add(Me.btnShowGenerate)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DTRUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DTRUpload"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Dtr_conso_tblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtr_conso_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpload As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBoxMonth As ComboBox
    Friend WithEvents ComboBoxYear As ComboBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PayrolldbDataSet As payrolldbDataSet
    Friend WithEvents Dtr_conso_tblDataGridView As DataGridView
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Employee_idTextBox As TextBox
    Friend WithEvents Dtr_dateDateTimePicker As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents Dtr_conso_tblBindingSource As BindingSource
    Friend WithEvents Dtr_conso_tblTableAdapter As payrolldbDataSetTableAdapters.dtr_conso_tblTableAdapter
    Friend WithEvents TableAdapterManager As payrolldbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tse_out_pmDateTimePicker As DateTimePicker
    Friend WithEvents Tse_in_pmDateTimePicker As DateTimePicker
    Friend WithEvents Tse_out_amDateTimePicker As DateTimePicker
    Friend WithEvents Tse_in_amDateTimePicker As DateTimePicker
    Friend WithEvents btnShowGenerate As Button
End Class
