<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Employee_tblDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblinactive = New System.Windows.Forms.Label()
        Me.lblactive = New System.Windows.Forms.Label()
        Me.lbltotalemployee = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNNEW = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4.SuspendLayout()
        CType(Me.Employee_tblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnPrint)
        Me.GroupBox4.Controls.Add(Me.Employee_tblDataGridView)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtbSearch)
        Me.GroupBox4.Location = New System.Drawing.Point(227, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(666, 501)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(511, 20)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(149, 35)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "Print Employee List"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Employee_tblDataGridView
        '
        Me.Employee_tblDataGridView.AllowUserToAddRows = False
        Me.Employee_tblDataGridView.AllowUserToDeleteRows = False
        Me.Employee_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Employee_tblDataGridView.Location = New System.Drawing.Point(10, 61)
        Me.Employee_tblDataGridView.Name = "Employee_tblDataGridView"
        Me.Employee_tblDataGridView.ReadOnly = True
        Me.Employee_tblDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Employee_tblDataGridView.Size = New System.Drawing.Size(650, 434)
        Me.Employee_tblDataGridView.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(91, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "(First Name or Lastname)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(9, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 20)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Search :"
        '
        'txtbSearch
        '
        Me.txtbSearch.Location = New System.Drawing.Point(10, 35)
        Me.txtbSearch.Name = "txtbSearch"
        Me.txtbSearch.Size = New System.Drawing.Size(230, 20)
        Me.txtbSearch.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblinactive)
        Me.GroupBox3.Controls.Add(Me.lblactive)
        Me.GroupBox3.Controls.Add(Me.lbltotalemployee)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 234)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(209, 279)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Employee Details"
        '
        'lblinactive
        '
        Me.lblinactive.AutoSize = True
        Me.lblinactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinactive.ForeColor = System.Drawing.Color.White
        Me.lblinactive.Location = New System.Drawing.Point(186, 84)
        Me.lblinactive.Name = "lblinactive"
        Me.lblinactive.Size = New System.Drawing.Size(19, 20)
        Me.lblinactive.TabIndex = 6
        Me.lblinactive.Text = "--"
        '
        'lblactive
        '
        Me.lblactive.AutoSize = True
        Me.lblactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblactive.ForeColor = System.Drawing.Color.White
        Me.lblactive.Location = New System.Drawing.Point(186, 56)
        Me.lblactive.Name = "lblactive"
        Me.lblactive.Size = New System.Drawing.Size(19, 20)
        Me.lblactive.TabIndex = 5
        Me.lblactive.Text = "--"
        '
        'lbltotalemployee
        '
        Me.lbltotalemployee.AutoSize = True
        Me.lbltotalemployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalemployee.ForeColor = System.Drawing.Color.White
        Me.lbltotalemployee.Location = New System.Drawing.Point(186, 24)
        Me.lbltotalemployee.Name = "lbltotalemployee"
        Me.lbltotalemployee.Size = New System.Drawing.Size(19, 20)
        Me.lbltotalemployee.TabIndex = 4
        Me.lbltotalemployee.Text = "--"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(5, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Inactive Employee :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total Active Employee :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(50, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Employee :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNNEW)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 85)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'BTNNEW
        '
        Me.BTNNEW.Location = New System.Drawing.Point(7, 20)
        Me.BTNNEW.Name = "BTNNEW"
        Me.BTNNEW.Size = New System.Drawing.Size(195, 47)
        Me.BTNNEW.TabIndex = 0
        Me.BTNNEW.Text = "Create, Remove and Update Employee"
        Me.BTNNEW.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 125)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gray
        Me.Panel7.Controls.Add(Me.lblDate)
        Me.Panel7.Controls.Add(Me.lblTime)
        Me.Panel7.Controls.Add(Me.PictureBox12)
        Me.Panel7.Location = New System.Drawing.Point(-5, 2)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(220, 122)
        Me.Panel7.TabIndex = 18
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(12, 75)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(13, 13)
        Me.lblDate.TabIndex = 24
        Me.lblDate.Text = "--"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(9, 44)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(32, 31)
        Me.lblTime.TabIndex = 24
        Me.lblTime.Text = "--"
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(118, 21)
        Me.PictureBox12.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(93, 84)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 16
        Me.PictureBox12.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(905, 525)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Employee_tblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbSearch As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblinactive As Label
    Friend WithEvents lblactive As Label
    Friend WithEvents lbltotalemployee As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTNNEW As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Employee_tblDataGridView As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnPrint As Button
End Class
