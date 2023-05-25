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
        Dim Label4 As System.Windows.Forms.Label
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBoxMonth = New System.Windows.Forms.ComboBox()
        Me.ComboBoxYear = New System.Windows.Forms.ComboBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnShowGenerate = New System.Windows.Forms.Button()
        Me.Dtr_conso_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrolldbDataSet = New LCCPayrollSystem.payrolldbDataSet()
        Me.Dtr_conso_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.dtr_conso_tblTableAdapter()
        Me.TableAdapterManager = New LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager()
        Me.DtruploadtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtr_upload_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.dtr_upload_tblTableAdapter()
        Me.DtrconsotblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtrconsotblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwdtruploadtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_dtr_upload_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.vw_dtr_upload_tblTableAdapter()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BiodatetimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtr_conso_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtruploadtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtrconsotblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtrconsotblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwdtruploadtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(145, 14)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(37, 13)
        Label2.TabIndex = 15
        Label2.Text = "Month"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(18, 14)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(29, 13)
        Label1.TabIndex = 13
        Label1.Text = "Year"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(272, 14)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(49, 13)
        Label3.TabIndex = 16
        Label3.Text = "Filename"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.ForeColor = System.Drawing.Color.Red
        Label4.Location = New System.Drawing.Point(470, 15)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(125, 13)
        Label4.TabIndex = 20
        Label4.Text = "(Click filename to upload)"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(601, 7)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(90, 46)
        Me.btnUpload.TabIndex = 0
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeidDataGridViewTextBoxColumn, Me.EmployeenameDataGridViewTextBoxColumn, Me.BiodatetimeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VwdtruploadtblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(871, 453)
        Me.DataGridView1.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(275, 31)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(320, 20)
        Me.TextBox1.TabIndex = 2
        '
        'ComboBoxMonth
        '
        Me.ComboBoxMonth.FormattingEnabled = True
        Me.ComboBoxMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBoxMonth.Location = New System.Drawing.Point(148, 30)
        Me.ComboBoxMonth.Name = "ComboBoxMonth"
        Me.ComboBoxMonth.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxMonth.TabIndex = 14
        '
        'ComboBoxYear
        '
        Me.ComboBoxYear.FormattingEnabled = True
        Me.ComboBoxYear.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025"})
        Me.ComboBoxYear.Location = New System.Drawing.Point(21, 30)
        Me.ComboBoxYear.Name = "ComboBoxYear"
        Me.ComboBoxYear.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxYear.TabIndex = 12
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(697, 7)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(90, 46)
        Me.btnLoad.TabIndex = 17
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnShowGenerate
        '
        Me.btnShowGenerate.Location = New System.Drawing.Point(793, 7)
        Me.btnShowGenerate.Name = "btnShowGenerate"
        Me.btnShowGenerate.Size = New System.Drawing.Size(90, 46)
        Me.btnShowGenerate.TabIndex = 19
        Me.btnShowGenerate.Text = "Employee DTR"
        Me.btnShowGenerate.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.dtr_upload_tblTableAdapter = Nothing
        Me.TableAdapterManager.employee_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_deduction_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_tblTableAdapter = Nothing
        Me.TableAdapterManager.time_schedule_empl_tblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_tblTableAdapter = Nothing
        '
        'DtruploadtblBindingSource
        '
        Me.DtruploadtblBindingSource.DataMember = "dtr_upload_tbl"
        Me.DtruploadtblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'Dtr_upload_tblTableAdapter
        '
        Me.Dtr_upload_tblTableAdapter.ClearBeforeFill = True
        '
        'DtrconsotblBindingSource
        '
        Me.DtrconsotblBindingSource.DataMember = "dtr_conso_tbl"
        Me.DtrconsotblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'DtrconsotblBindingSource1
        '
        Me.DtrconsotblBindingSource1.DataMember = "dtr_conso_tbl"
        Me.DtrconsotblBindingSource1.DataSource = Me.PayrolldbDataSet
        '
        'VwdtruploadtblBindingSource
        '
        Me.VwdtruploadtblBindingSource.DataMember = "vw_dtr_upload_tbl"
        Me.VwdtruploadtblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'Vw_dtr_upload_tblTableAdapter
        '
        Me.Vw_dtr_upload_tblTableAdapter.ClearBeforeFill = True
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
        Me.EmployeenameDataGridViewTextBoxColumn.HeaderText = "Employee name"
        Me.EmployeenameDataGridViewTextBoxColumn.Name = "EmployeenameDataGridViewTextBoxColumn"
        Me.EmployeenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BiodatetimeDataGridViewTextBoxColumn
        '
        Me.BiodatetimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BiodatetimeDataGridViewTextBoxColumn.DataPropertyName = "bio_datetime"
        Me.BiodatetimeDataGridViewTextBoxColumn.HeaderText = "Bio Date/Time"
        Me.BiodatetimeDataGridViewTextBoxColumn.Name = "BiodatetimeDataGridViewTextBoxColumn"
        Me.BiodatetimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DTRUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 525)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnShowGenerate)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.ComboBoxYear)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.ComboBoxMonth)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DTRUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DTRUpload"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtr_conso_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtruploadtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtrconsotblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtrconsotblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwdtruploadtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpload As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBoxMonth As ComboBox
    Friend WithEvents ComboBoxYear As ComboBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents PayrolldbDataSet As payrolldbDataSet
    Friend WithEvents Dtr_conso_tblBindingSource As BindingSource
    Friend WithEvents Dtr_conso_tblTableAdapter As payrolldbDataSetTableAdapters.dtr_conso_tblTableAdapter
    Friend WithEvents TableAdapterManager As payrolldbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnShowGenerate As Button
    Friend WithEvents DtruploadtblBindingSource As BindingSource
    Friend WithEvents Dtr_upload_tblTableAdapter As payrolldbDataSetTableAdapters.dtr_upload_tblTableAdapter
    Friend WithEvents DtrconsotblBindingSource1 As BindingSource
    Friend WithEvents DtrconsotblBindingSource As BindingSource
    Friend WithEvents VwdtruploadtblBindingSource As BindingSource
    Friend WithEvents Vw_dtr_upload_tblTableAdapter As payrolldbDataSetTableAdapters.vw_dtr_upload_tblTableAdapter
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BiodatetimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
