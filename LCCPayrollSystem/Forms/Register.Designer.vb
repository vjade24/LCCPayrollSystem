<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtb_user_confirm_password = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtb_user_type = New System.Windows.Forms.ComboBox()
        Me.txtb_user_password = New System.Windows.Forms.TextBox()
        Me.txtb_user_name = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtb_full_name = New System.Windows.Forms.TextBox()
        Me.txtb_id = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtb_search = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PayrolldbDataSet = New LCCPayrollSystem.payrolldbDataSet()
        Me.UsertblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.user_tblTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserpasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsertblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(157, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Registry User"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.ImageKey = "(none)"
        Me.btn_cancel.Location = New System.Drawing.Point(81, 441)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(83, 35)
        Me.btn_cancel.TabIndex = 127
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Green
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(81, 400)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(83, 35)
        Me.btnedit.TabIndex = 126
        Me.btnedit.Text = "Update"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.DarkRed
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.Color.White
        Me.btndel.Location = New System.Drawing.Point(170, 400)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(83, 35)
        Me.btndel.TabIndex = 125
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(170, 441)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(83, 35)
        Me.btn_save.TabIndex = 124
        Me.btn_save.Text = "Add"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.DarkGray
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(21, 278)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(127, 21)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'txtb_user_confirm_password
        '
        Me.txtb_user_confirm_password.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_user_confirm_password.Location = New System.Drawing.Point(21, 246)
        Me.txtb_user_confirm_password.Name = "txtb_user_confirm_password"
        Me.txtb_user_confirm_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtb_user_confirm_password.Size = New System.Drawing.Size(290, 23)
        Me.txtb_user_confirm_password.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(208, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "ID :"
        Me.Label7.Visible = False
        '
        'txtb_user_type
        '
        Me.txtb_user_type.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_user_type.FormattingEnabled = True
        Me.txtb_user_type.Items.AddRange(New Object() {"Admin", "Staff", "Employee"})
        Me.txtb_user_type.Location = New System.Drawing.Point(21, 341)
        Me.txtb_user_type.Name = "txtb_user_type"
        Me.txtb_user_type.Size = New System.Drawing.Size(290, 25)
        Me.txtb_user_type.TabIndex = 8
        '
        'txtb_user_password
        '
        Me.txtb_user_password.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_user_password.Location = New System.Drawing.Point(21, 192)
        Me.txtb_user_password.Name = "txtb_user_password"
        Me.txtb_user_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtb_user_password.Size = New System.Drawing.Size(290, 23)
        Me.txtb_user_password.TabIndex = 6
        '
        'txtb_user_name
        '
        Me.txtb_user_name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_user_name.Location = New System.Drawing.Point(22, 141)
        Me.txtb_user_name.Name = "txtb_user_name"
        Me.txtb_user_name.Size = New System.Drawing.Size(290, 23)
        Me.txtb_user_name.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 311)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 17)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "User  Type :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 222)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Confirm Password :"
        '
        'txtb_full_name
        '
        Me.txtb_full_name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_full_name.Location = New System.Drawing.Point(21, 81)
        Me.txtb_full_name.Name = "txtb_full_name"
        Me.txtb_full_name.Size = New System.Drawing.Size(290, 23)
        Me.txtb_full_name.TabIndex = 2
        '
        'txtb_id
        '
        Me.txtb_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_id.Location = New System.Drawing.Point(249, 22)
        Me.txtb_id.Name = "txtb_id"
        Me.txtb_id.Size = New System.Drawing.Size(62, 23)
        Me.txtb_id.TabIndex = 0
        Me.txtb_id.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 168)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 17)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Password :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 117)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 17)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Username :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(17, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 17)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(146, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Search"
        '
        'txtb_search
        '
        Me.txtb_search.AccessibleName = ""
        Me.txtb_search.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_search.Location = New System.Drawing.Point(216, 22)
        Me.txtb_search.Name = "txtb_search"
        Me.txtb_search.Size = New System.Drawing.Size(188, 23)
        Me.txtb_search.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GrayText
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.UserpasswordDataGridViewTextBoxColumn, Me.UsertypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UsertblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.Size = New System.Drawing.Size(378, 440)
        Me.DataGridView1.TabIndex = 11
        '
        'PayrolldbDataSet
        '
        Me.PayrolldbDataSet.DataSetName = "payrolldbDataSet"
        Me.PayrolldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsertblBindingSource
        '
        Me.UsertblBindingSource.DataMember = "user_tbl"
        Me.UsertblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'User_tblTableAdapter
        '
        Me.User_tblTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 43
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "Full Name"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        Me.FullnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FullnameDataGridViewTextBoxColumn.Width = 79
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "user_name"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "User Name"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameDataGridViewTextBoxColumn.Width = 85
        '
        'UserpasswordDataGridViewTextBoxColumn
        '
        Me.UserpasswordDataGridViewTextBoxColumn.DataPropertyName = "user_password"
        Me.UserpasswordDataGridViewTextBoxColumn.HeaderText = "user_password"
        Me.UserpasswordDataGridViewTextBoxColumn.Name = "UserpasswordDataGridViewTextBoxColumn"
        Me.UserpasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserpasswordDataGridViewTextBoxColumn.Visible = False
        '
        'UsertypeDataGridViewTextBoxColumn
        '
        Me.UsertypeDataGridViewTextBoxColumn.DataPropertyName = "user_type"
        Me.UsertypeDataGridViewTextBoxColumn.HeaderText = "User Type"
        Me.UsertypeDataGridViewTextBoxColumn.Name = "UsertypeDataGridViewTextBoxColumn"
        Me.UsertypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsertypeDataGridViewTextBoxColumn.Width = 81
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtb_full_name)
        Me.GroupBox1.Controls.Add(Me.btnedit)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtb_id)
        Me.GroupBox1.Controls.Add(Me.btndel)
        Me.GroupBox1.Controls.Add(Me.txtb_user_name)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.txtb_user_type)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtb_user_confirm_password)
        Me.GroupBox1.Controls.Add(Me.txtb_user_password)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 510)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.txtb_search)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(364, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 510)
        Me.GroupBox2.TabIndex = 129
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of Users"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 604)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsertblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtb_user_confirm_password As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtb_user_type As ComboBox
    Friend WithEvents txtb_user_password As TextBox
    Friend WithEvents txtb_user_name As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtb_full_name As TextBox
    Friend WithEvents txtb_id As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtb_search As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PayrolldbDataSet As payrolldbDataSet
    Friend WithEvents UsertblBindingSource As BindingSource
    Friend WithEvents User_tblTableAdapter As payrolldbDataSetTableAdapters.user_tblTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserpasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsertypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
