<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeAddUpdate
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Middle_nameLabel As System.Windows.Forms.Label
        Dim Birth_dateLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Contact_noLabel As System.Windows.Forms.Label
        Dim CitizenshipLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim Tin_noLabel As System.Windows.Forms.Label
        Dim Sss_noLabel As System.Windows.Forms.Label
        Dim Phic_noLabel As System.Windows.Forms.Label
        Dim Pag_ibig_noLabel As System.Windows.Forms.Label
        Dim Department_assignedLabel As System.Windows.Forms.Label
        Dim Date_hireLabel As System.Windows.Forms.Label
        Dim Father_nameLabel As System.Windows.Forms.Label
        Dim Mother_nameLabel As System.Windows.Forms.Label
        Dim HeightLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim Employment_statusLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim Spouse_nameLabel As System.Windows.Forms.Label
        Dim Rate_basis_descrLabel As System.Windows.Forms.Label
        Dim Monthly_rateLabel As System.Windows.Forms.Label
        Dim Daily_rateLabel As System.Windows.Forms.Label
        Dim Hourly_rateLabel As System.Windows.Forms.Label
        Dim Unit_rateLabel As System.Windows.Forms.Label
        Dim Employee_statusLabel As System.Windows.Forms.Label
        Dim Date_resignedLabel As System.Windows.Forms.Label
        Dim User_idLabel As System.Windows.Forms.Label
        Dim Civil_statusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeAddUpdate))
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Birth_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AgeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_noTextBox = New System.Windows.Forms.TextBox()
        Me.CitizenshipTextBox = New System.Windows.Forms.TextBox()
        Me.ReligionTextBox = New System.Windows.Forms.TextBox()
        Me.Tin_noTextBox = New System.Windows.Forms.TextBox()
        Me.Sss_noTextBox = New System.Windows.Forms.TextBox()
        Me.Phic_noTextBox = New System.Windows.Forms.TextBox()
        Me.Pag_ibig_noTextBox = New System.Windows.Forms.TextBox()
        Me.Date_hireDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Father_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Mother_nameTextBox = New System.Windows.Forms.TextBox()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.Spouse_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Monthly_rateTextBox = New System.Windows.Forms.TextBox()
        Me.Daily_rateTextBox = New System.Windows.Forms.TextBox()
        Me.Hourly_rateTextBox = New System.Windows.Forms.TextBox()
        Me.Unit_rateTextBox = New System.Windows.Forms.TextBox()
        Me.Date_resignedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PhotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.btn_Find = New System.Windows.Forms.Button()
        Me.PayrolldbDataSet = New LCCPayrollSystem.payrolldbDataSet()
        Me.Employee_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employee_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.employee_tblTableAdapter()
        Me.TableAdapterManager = New LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager()
        Me.User_tblTableAdapter = New LCCPayrollSystem.payrolldbDataSetTableAdapters.user_tblTableAdapter()
        Me.User_idComboBox = New System.Windows.Forms.ComboBox()
        Me.UsertblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.rate_basis_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Employment_statusComboBox = New System.Windows.Forms.ComboBox()
        Me.Employee_statusComboBox = New System.Windows.Forms.ComboBox()
        Me.Civil_statusComboBox = New System.Windows.Forms.ComboBox()
        Me.Department_assignedComboBox = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New FontAwesome.Sharp.IconButton()
        Me.btnedit = New FontAwesome.Sharp.IconButton()
        Me.btndel = New FontAwesome.Sharp.IconButton()
        Me.btn_cancel = New FontAwesome.Sharp.IconButton()
        IdLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Middle_nameLabel = New System.Windows.Forms.Label()
        Birth_dateLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Contact_noLabel = New System.Windows.Forms.Label()
        CitizenshipLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        Tin_noLabel = New System.Windows.Forms.Label()
        Sss_noLabel = New System.Windows.Forms.Label()
        Phic_noLabel = New System.Windows.Forms.Label()
        Pag_ibig_noLabel = New System.Windows.Forms.Label()
        Department_assignedLabel = New System.Windows.Forms.Label()
        Date_hireLabel = New System.Windows.Forms.Label()
        Father_nameLabel = New System.Windows.Forms.Label()
        Mother_nameLabel = New System.Windows.Forms.Label()
        HeightLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        Employment_statusLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        Spouse_nameLabel = New System.Windows.Forms.Label()
        Rate_basis_descrLabel = New System.Windows.Forms.Label()
        Monthly_rateLabel = New System.Windows.Forms.Label()
        Daily_rateLabel = New System.Windows.Forms.Label()
        Hourly_rateLabel = New System.Windows.Forms.Label()
        Unit_rateLabel = New System.Windows.Forms.Label()
        Employee_statusLabel = New System.Windows.Forms.Label()
        Date_resignedLabel = New System.Windows.Forms.Label()
        User_idLabel = New System.Windows.Forms.Label()
        Civil_statusLabel = New System.Windows.Forms.Label()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsertblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(620, 22)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(67, 14)
        IdLabel.TabIndex = 34
        IdLabel.Text = "Employee Id:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_nameLabel.Location = New System.Drawing.Point(55, 80)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(60, 14)
        Last_nameLabel.TabIndex = 36
        Last_nameLabel.Text = "Last name:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_nameLabel.Location = New System.Drawing.Point(264, 80)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(60, 14)
        First_nameLabel.TabIndex = 38
        First_nameLabel.Text = "First name:"
        '
        'Middle_nameLabel
        '
        Middle_nameLabel.AutoSize = True
        Middle_nameLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Middle_nameLabel.Location = New System.Drawing.Point(469, 80)
        Middle_nameLabel.Name = "Middle_nameLabel"
        Middle_nameLabel.Size = New System.Drawing.Size(69, 14)
        Middle_nameLabel.TabIndex = 40
        Middle_nameLabel.Text = "Middle name:"
        '
        'Birth_dateLabel
        '
        Birth_dateLabel.AutoSize = True
        Birth_dateLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Birth_dateLabel.Location = New System.Drawing.Point(55, 126)
        Birth_dateLabel.Name = "Birth_dateLabel"
        Birth_dateLabel.Size = New System.Drawing.Size(56, 14)
        Birth_dateLabel.TabIndex = 42
        Birth_dateLabel.Text = "Birth date:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(159, 126)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(30, 14)
        AgeLabel.TabIndex = 44
        AgeLabel.Text = "Age:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(264, 124)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(46, 14)
        GenderLabel.TabIndex = 46
        GenderLabel.Text = "Gender:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(264, 219)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(49, 14)
        AddressLabel.TabIndex = 48
        AddressLabel.Text = "Address"
        '
        'Contact_noLabel
        '
        Contact_noLabel.AutoSize = True
        Contact_noLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contact_noLabel.Location = New System.Drawing.Point(472, 126)
        Contact_noLabel.Name = "Contact_noLabel"
        Contact_noLabel.Size = New System.Drawing.Size(63, 14)
        Contact_noLabel.TabIndex = 50
        Contact_noLabel.Text = "Contact No:"
        '
        'CitizenshipLabel
        '
        CitizenshipLabel.AutoSize = True
        CitizenshipLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CitizenshipLabel.Location = New System.Drawing.Point(264, 173)
        CitizenshipLabel.Name = "CitizenshipLabel"
        CitizenshipLabel.Size = New System.Drawing.Size(62, 14)
        CitizenshipLabel.TabIndex = 52
        CitizenshipLabel.Text = "Citizenship:"
        '
        'ReligionLabel
        '
        ReligionLabel.AutoSize = True
        ReligionLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReligionLabel.Location = New System.Drawing.Point(55, 218)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(47, 14)
        ReligionLabel.TabIndex = 56
        ReligionLabel.Text = "Religion:"
        '
        'Tin_noLabel
        '
        Tin_noLabel.AutoSize = True
        Tin_noLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tin_noLabel.Location = New System.Drawing.Point(237, 113)
        Tin_noLabel.Name = "Tin_noLabel"
        Tin_noLabel.Size = New System.Drawing.Size(40, 14)
        Tin_noLabel.TabIndex = 58
        Tin_noLabel.Text = "Tin No:"
        '
        'Sss_noLabel
        '
        Sss_noLabel.AutoSize = True
        Sss_noLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sss_noLabel.Location = New System.Drawing.Point(446, 113)
        Sss_noLabel.Name = "Sss_noLabel"
        Sss_noLabel.Size = New System.Drawing.Size(47, 14)
        Sss_noLabel.TabIndex = 60
        Sss_noLabel.Text = "SSS No:"
        '
        'Phic_noLabel
        '
        Phic_noLabel.AutoSize = True
        Phic_noLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phic_noLabel.Location = New System.Drawing.Point(446, 160)
        Phic_noLabel.Name = "Phic_noLabel"
        Phic_noLabel.Size = New System.Drawing.Size(48, 14)
        Phic_noLabel.TabIndex = 62
        Phic_noLabel.Text = "PHIC No:"
        '
        'Pag_ibig_noLabel
        '
        Pag_ibig_noLabel.AutoSize = True
        Pag_ibig_noLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pag_ibig_noLabel.Location = New System.Drawing.Point(237, 160)
        Pag_ibig_noLabel.Name = "Pag_ibig_noLabel"
        Pag_ibig_noLabel.Size = New System.Drawing.Size(64, 14)
        Pag_ibig_noLabel.TabIndex = 64
        Pag_ibig_noLabel.Text = "Pag-ibig No:"
        '
        'Department_assignedLabel
        '
        Department_assignedLabel.AutoSize = True
        Department_assignedLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Department_assignedLabel.Location = New System.Drawing.Point(143, 108)
        Department_assignedLabel.Name = "Department_assignedLabel"
        Department_assignedLabel.Size = New System.Drawing.Size(62, 14)
        Department_assignedLabel.TabIndex = 66
        Department_assignedLabel.Text = "Department"
        '
        'Date_hireLabel
        '
        Date_hireLabel.AutoSize = True
        Date_hireLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_hireLabel.Location = New System.Drawing.Point(143, 153)
        Date_hireLabel.Name = "Date_hireLabel"
        Date_hireLabel.Size = New System.Drawing.Size(53, 14)
        Date_hireLabel.TabIndex = 68
        Date_hireLabel.Text = "Date hire:"
        '
        'Father_nameLabel
        '
        Father_nameLabel.AutoSize = True
        Father_nameLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Father_nameLabel.Location = New System.Drawing.Point(218, 96)
        Father_nameLabel.Name = "Father_nameLabel"
        Father_nameLabel.Size = New System.Drawing.Size(78, 14)
        Father_nameLabel.TabIndex = 70
        Father_nameLabel.Text = "Father's name:"
        '
        'Mother_nameLabel
        '
        Mother_nameLabel.AutoSize = True
        Mother_nameLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mother_nameLabel.Location = New System.Drawing.Point(218, 142)
        Mother_nameLabel.Name = "Mother_nameLabel"
        Mother_nameLabel.Size = New System.Drawing.Size(80, 14)
        Mother_nameLabel.TabIndex = 72
        Mother_nameLabel.Text = "Mother's name:"
        '
        'HeightLabel
        '
        HeightLabel.AutoSize = True
        HeightLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HeightLabel.Location = New System.Drawing.Point(55, 172)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New System.Drawing.Size(40, 14)
        HeightLabel.TabIndex = 74
        HeightLabel.Text = "Height:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WeightLabel.Location = New System.Drawing.Point(159, 175)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(43, 14)
        WeightLabel.TabIndex = 76
        WeightLabel.Text = "Weight:"
        '
        'Employment_statusLabel
        '
        Employment_statusLabel.AutoSize = True
        Employment_statusLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employment_statusLabel.Location = New System.Drawing.Point(351, 108)
        Employment_statusLabel.Name = "Employment_statusLabel"
        Employment_statusLabel.Size = New System.Drawing.Size(100, 14)
        Employment_statusLabel.TabIndex = 78
        Employment_statusLabel.Text = "Employment status:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PositionLabel.Location = New System.Drawing.Point(143, 62)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(47, 14)
        PositionLabel.TabIndex = 80
        PositionLabel.Text = "Position:"
        '
        'Spouse_nameLabel
        '
        Spouse_nameLabel.AutoSize = True
        Spouse_nameLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Spouse_nameLabel.Location = New System.Drawing.Point(218, 188)
        Spouse_nameLabel.Name = "Spouse_nameLabel"
        Spouse_nameLabel.Size = New System.Drawing.Size(76, 14)
        Spouse_nameLabel.TabIndex = 82
        Spouse_nameLabel.Text = "Spouse name:"
        '
        'Rate_basis_descrLabel
        '
        Rate_basis_descrLabel.AutoSize = True
        Rate_basis_descrLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rate_basis_descrLabel.Location = New System.Drawing.Point(566, 153)
        Rate_basis_descrLabel.Name = "Rate_basis_descrLabel"
        Rate_basis_descrLabel.Size = New System.Drawing.Size(61, 14)
        Rate_basis_descrLabel.TabIndex = 86
        Rate_basis_descrLabel.Text = "Rate basis:"
        '
        'Monthly_rateLabel
        '
        Monthly_rateLabel.AutoSize = True
        Monthly_rateLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Monthly_rateLabel.Location = New System.Drawing.Point(143, 200)
        Monthly_rateLabel.Name = "Monthly_rateLabel"
        Monthly_rateLabel.Size = New System.Drawing.Size(69, 14)
        Monthly_rateLabel.TabIndex = 88
        Monthly_rateLabel.Text = "Monthly rate:"
        '
        'Daily_rateLabel
        '
        Daily_rateLabel.AutoSize = True
        Daily_rateLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Daily_rateLabel.Location = New System.Drawing.Point(251, 200)
        Daily_rateLabel.Name = "Daily_rateLabel"
        Daily_rateLabel.Size = New System.Drawing.Size(55, 14)
        Daily_rateLabel.TabIndex = 90
        Daily_rateLabel.Text = "Daily rate:"
        '
        'Hourly_rateLabel
        '
        Hourly_rateLabel.AutoSize = True
        Hourly_rateLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Hourly_rateLabel.Location = New System.Drawing.Point(351, 200)
        Hourly_rateLabel.Name = "Hourly_rateLabel"
        Hourly_rateLabel.Size = New System.Drawing.Size(63, 14)
        Hourly_rateLabel.TabIndex = 92
        Hourly_rateLabel.Text = "Hourly rate:"
        '
        'Unit_rateLabel
        '
        Unit_rateLabel.AutoSize = True
        Unit_rateLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Unit_rateLabel.Location = New System.Drawing.Point(460, 200)
        Unit_rateLabel.Name = "Unit_rateLabel"
        Unit_rateLabel.Size = New System.Drawing.Size(50, 14)
        Unit_rateLabel.TabIndex = 94
        Unit_rateLabel.Text = "Unit rate:"
        '
        'Employee_statusLabel
        '
        Employee_statusLabel.AutoSize = True
        Employee_statusLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employee_statusLabel.Location = New System.Drawing.Point(566, 201)
        Employee_statusLabel.Name = "Employee_statusLabel"
        Employee_statusLabel.Size = New System.Drawing.Size(41, 14)
        Employee_statusLabel.TabIndex = 96
        Employee_statusLabel.Text = "Status:"
        '
        'Date_resignedLabel
        '
        Date_resignedLabel.AutoSize = True
        Date_resignedLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_resignedLabel.Location = New System.Drawing.Point(351, 153)
        Date_resignedLabel.Name = "Date_resignedLabel"
        Date_resignedLabel.Size = New System.Drawing.Size(77, 14)
        Date_resignedLabel.TabIndex = 98
        Date_resignedLabel.Text = "Date resigned:"
        '
        'User_idLabel
        '
        User_idLabel.AutoSize = True
        User_idLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_idLabel.Location = New System.Drawing.Point(566, 108)
        User_idLabel.Name = "User_idLabel"
        User_idLabel.Size = New System.Drawing.Size(44, 14)
        User_idLabel.TabIndex = 103
        User_idLabel.Text = "User id:"
        '
        'Civil_statusLabel
        '
        Civil_statusLabel.AutoSize = True
        Civil_statusLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Civil_statusLabel.Location = New System.Drawing.Point(479, 173)
        Civil_statusLabel.Name = "Civil_statusLabel"
        Civil_statusLabel.Size = New System.Drawing.Size(63, 14)
        Civil_statusLabel.TabIndex = 132
        Civil_statusLabel.Text = "Civil Status:"
        '
        'IdTextBox
        '
        Me.IdTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(623, 43)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(124, 20)
        Me.IdTextBox.TabIndex = 35
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(52, 100)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(199, 20)
        Me.Last_nameTextBox.TabIndex = 37
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_nameTextBox.Location = New System.Drawing.Point(264, 100)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(199, 20)
        Me.First_nameTextBox.TabIndex = 39
        '
        'Middle_nameTextBox
        '
        Me.Middle_nameTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle_nameTextBox.Location = New System.Drawing.Point(471, 100)
        Me.Middle_nameTextBox.Name = "Middle_nameTextBox"
        Me.Middle_nameTextBox.Size = New System.Drawing.Size(199, 20)
        Me.Middle_nameTextBox.TabIndex = 41
        '
        'Birth_dateDateTimePicker
        '
        Me.Birth_dateDateTimePicker.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Birth_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Birth_dateDateTimePicker.Location = New System.Drawing.Point(55, 146)
        Me.Birth_dateDateTimePicker.Name = "Birth_dateDateTimePicker"
        Me.Birth_dateDateTimePicker.Size = New System.Drawing.Size(97, 20)
        Me.Birth_dateDateTimePicker.TabIndex = 43
        '
        'AgeNumericUpDown
        '
        Me.AgeNumericUpDown.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeNumericUpDown.Location = New System.Drawing.Point(162, 146)
        Me.AgeNumericUpDown.Name = "AgeNumericUpDown"
        Me.AgeNumericUpDown.Size = New System.Drawing.Size(90, 20)
        Me.AgeNumericUpDown.TabIndex = 45
        Me.AgeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GenderComboBox
        '
        Me.GenderComboBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(264, 146)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(199, 22)
        Me.GenderComboBox.TabIndex = 47
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(264, 237)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(407, 20)
        Me.AddressTextBox.TabIndex = 49
        '
        'Contact_noTextBox
        '
        Me.Contact_noTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact_noTextBox.Location = New System.Drawing.Point(471, 146)
        Me.Contact_noTextBox.Name = "Contact_noTextBox"
        Me.Contact_noTextBox.Size = New System.Drawing.Size(199, 20)
        Me.Contact_noTextBox.TabIndex = 51
        '
        'CitizenshipTextBox
        '
        Me.CitizenshipTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitizenshipTextBox.Location = New System.Drawing.Point(264, 193)
        Me.CitizenshipTextBox.Name = "CitizenshipTextBox"
        Me.CitizenshipTextBox.Size = New System.Drawing.Size(197, 20)
        Me.CitizenshipTextBox.TabIndex = 53
        '
        'ReligionTextBox
        '
        Me.ReligionTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReligionTextBox.Location = New System.Drawing.Point(55, 238)
        Me.ReligionTextBox.Name = "ReligionTextBox"
        Me.ReligionTextBox.Size = New System.Drawing.Size(199, 20)
        Me.ReligionTextBox.TabIndex = 57
        '
        'Tin_noTextBox
        '
        Me.Tin_noTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tin_noTextBox.Location = New System.Drawing.Point(237, 133)
        Me.Tin_noTextBox.Name = "Tin_noTextBox"
        Me.Tin_noTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tin_noTextBox.TabIndex = 59
        '
        'Sss_noTextBox
        '
        Me.Sss_noTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sss_noTextBox.Location = New System.Drawing.Point(446, 133)
        Me.Sss_noTextBox.Name = "Sss_noTextBox"
        Me.Sss_noTextBox.Size = New System.Drawing.Size(194, 20)
        Me.Sss_noTextBox.TabIndex = 61
        '
        'Phic_noTextBox
        '
        Me.Phic_noTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phic_noTextBox.Location = New System.Drawing.Point(446, 179)
        Me.Phic_noTextBox.Name = "Phic_noTextBox"
        Me.Phic_noTextBox.Size = New System.Drawing.Size(194, 20)
        Me.Phic_noTextBox.TabIndex = 63
        '
        'Pag_ibig_noTextBox
        '
        Me.Pag_ibig_noTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pag_ibig_noTextBox.Location = New System.Drawing.Point(237, 179)
        Me.Pag_ibig_noTextBox.Name = "Pag_ibig_noTextBox"
        Me.Pag_ibig_noTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pag_ibig_noTextBox.TabIndex = 65
        '
        'Date_hireDateTimePicker
        '
        Me.Date_hireDateTimePicker.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_hireDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_hireDateTimePicker.Location = New System.Drawing.Point(143, 173)
        Me.Date_hireDateTimePicker.Name = "Date_hireDateTimePicker"
        Me.Date_hireDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_hireDateTimePicker.TabIndex = 69
        '
        'Father_nameTextBox
        '
        Me.Father_nameTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Father_nameTextBox.Location = New System.Drawing.Point(218, 116)
        Me.Father_nameTextBox.Name = "Father_nameTextBox"
        Me.Father_nameTextBox.Size = New System.Drawing.Size(411, 20)
        Me.Father_nameTextBox.TabIndex = 71
        '
        'Mother_nameTextBox
        '
        Me.Mother_nameTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mother_nameTextBox.Location = New System.Drawing.Point(218, 162)
        Me.Mother_nameTextBox.Name = "Mother_nameTextBox"
        Me.Mother_nameTextBox.Size = New System.Drawing.Size(411, 20)
        Me.Mother_nameTextBox.TabIndex = 73
        '
        'HeightTextBox
        '
        Me.HeightTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightTextBox.Location = New System.Drawing.Point(55, 192)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(97, 20)
        Me.HeightTextBox.TabIndex = 75
        '
        'WeightTextBox
        '
        Me.WeightTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTextBox.Location = New System.Drawing.Point(162, 193)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(92, 20)
        Me.WeightTextBox.TabIndex = 77
        '
        'PositionTextBox
        '
        Me.PositionTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionTextBox.Location = New System.Drawing.Point(143, 82)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(622, 20)
        Me.PositionTextBox.TabIndex = 81
        '
        'Spouse_nameTextBox
        '
        Me.Spouse_nameTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spouse_nameTextBox.Location = New System.Drawing.Point(218, 208)
        Me.Spouse_nameTextBox.Name = "Spouse_nameTextBox"
        Me.Spouse_nameTextBox.Size = New System.Drawing.Size(411, 20)
        Me.Spouse_nameTextBox.TabIndex = 83
        '
        'Monthly_rateTextBox
        '
        Me.Monthly_rateTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Monthly_rateTextBox.Location = New System.Drawing.Point(143, 220)
        Me.Monthly_rateTextBox.Name = "Monthly_rateTextBox"
        Me.Monthly_rateTextBox.Size = New System.Drawing.Size(93, 20)
        Me.Monthly_rateTextBox.TabIndex = 89
        Me.Monthly_rateTextBox.Text = "0.00"
        Me.Monthly_rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Daily_rateTextBox
        '
        Me.Daily_rateTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Daily_rateTextBox.Location = New System.Drawing.Point(251, 220)
        Me.Daily_rateTextBox.Name = "Daily_rateTextBox"
        Me.Daily_rateTextBox.Size = New System.Drawing.Size(93, 20)
        Me.Daily_rateTextBox.TabIndex = 91
        Me.Daily_rateTextBox.Text = "0.00"
        Me.Daily_rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Hourly_rateTextBox
        '
        Me.Hourly_rateTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hourly_rateTextBox.Location = New System.Drawing.Point(351, 220)
        Me.Hourly_rateTextBox.Name = "Hourly_rateTextBox"
        Me.Hourly_rateTextBox.Size = New System.Drawing.Size(93, 20)
        Me.Hourly_rateTextBox.TabIndex = 93
        Me.Hourly_rateTextBox.Text = "0.00"
        Me.Hourly_rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Unit_rateTextBox
        '
        Me.Unit_rateTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_rateTextBox.Location = New System.Drawing.Point(460, 220)
        Me.Unit_rateTextBox.Name = "Unit_rateTextBox"
        Me.Unit_rateTextBox.Size = New System.Drawing.Size(93, 20)
        Me.Unit_rateTextBox.TabIndex = 95
        Me.Unit_rateTextBox.Text = "0.00"
        Me.Unit_rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Date_resignedDateTimePicker
        '
        Me.Date_resignedDateTimePicker.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_resignedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_resignedDateTimePicker.Location = New System.Drawing.Point(351, 173)
        Me.Date_resignedDateTimePicker.Name = "Date_resignedDateTimePicker"
        Me.Date_resignedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_resignedDateTimePicker.TabIndex = 99
        '
        'PhotoPictureBox
        '
        Me.PhotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PhotoPictureBox.Location = New System.Drawing.Point(676, 100)
        Me.PhotoPictureBox.Name = "PhotoPictureBox"
        Me.PhotoPictureBox.Size = New System.Drawing.Size(122, 113)
        Me.PhotoPictureBox.TabIndex = 101
        Me.PhotoPictureBox.TabStop = False
        '
        'btn_Find
        '
        Me.btn_Find.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Find.Location = New System.Drawing.Point(753, 13)
        Me.btn_Find.Name = "btn_Find"
        Me.btn_Find.Size = New System.Drawing.Size(119, 23)
        Me.btn_Find.TabIndex = 102
        Me.btn_Find.Text = "Find"
        Me.btn_Find.UseVisualStyleBackColor = True
        '
        'PayrolldbDataSet
        '
        Me.PayrolldbDataSet.DataSetName = "payrolldbDataSet"
        Me.PayrolldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Employee_tblBindingSource
        '
        Me.Employee_tblBindingSource.DataMember = "employee_tbl"
        Me.Employee_tblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'Employee_tblTableAdapter
        '
        Me.Employee_tblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.deduction_list_tblTableAdapter = Nothing
        Me.TableAdapterManager.dtr_conso_tblTableAdapter = Nothing
        Me.TableAdapterManager.employee_tblTableAdapter = Me.Employee_tblTableAdapter
        Me.TableAdapterManager.payroll_deduction_tblTableAdapter = Nothing
        Me.TableAdapterManager.payroll_tblTableAdapter = Nothing
        Me.TableAdapterManager.time_schedule_empl_tblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LCCPayrollSystem.payrolldbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_tblTableAdapter = Me.User_tblTableAdapter
        '
        'User_tblTableAdapter
        '
        Me.User_tblTableAdapter.ClearBeforeFill = True
        '
        'User_idComboBox
        '
        Me.User_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_tblBindingSource, "user_id", True))
        Me.User_idComboBox.DataSource = Me.UsertblBindingSource
        Me.User_idComboBox.DisplayMember = "full_name"
        Me.User_idComboBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_idComboBox.FormattingEnabled = True
        Me.User_idComboBox.Location = New System.Drawing.Point(566, 130)
        Me.User_idComboBox.Name = "User_idComboBox"
        Me.User_idComboBox.Size = New System.Drawing.Size(199, 22)
        Me.User_idComboBox.TabIndex = 104
        Me.User_idComboBox.ValueMember = "Id"
        '
        'UsertblBindingSource
        '
        Me.UsertblBindingSource.DataMember = "user_tbl"
        Me.UsertblBindingSource.DataSource = Me.PayrolldbDataSet
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Location = New System.Drawing.Point(753, 42)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(122, 23)
        Me.btn_new.TabIndex = 105
        Me.btn_new.Text = "Create New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_browse
        '
        Me.btn_browse.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btn_browse.Location = New System.Drawing.Point(676, 234)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(122, 23)
        Me.btn_browse.TabIndex = 132
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'rate_basis_ComboBox
        '
        Me.rate_basis_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_tblBindingSource, "civil_status", True))
        Me.rate_basis_ComboBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rate_basis_ComboBox.FormattingEnabled = True
        Me.rate_basis_ComboBox.Items.AddRange(New Object() {"Monthly", "Daily", "Hourly", "Per Unit"})
        Me.rate_basis_ComboBox.Location = New System.Drawing.Point(566, 173)
        Me.rate_basis_ComboBox.Name = "rate_basis_ComboBox"
        Me.rate_basis_ComboBox.Size = New System.Drawing.Size(199, 22)
        Me.rate_basis_ComboBox.TabIndex = 135
        '
        'Employment_statusComboBox
        '
        Me.Employment_statusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_tblBindingSource, "employment_status", True))
        Me.Employment_statusComboBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employment_statusComboBox.FormattingEnabled = True
        Me.Employment_statusComboBox.Items.AddRange(New Object() {"Full-Time", "Part-Time"})
        Me.Employment_statusComboBox.Location = New System.Drawing.Point(351, 128)
        Me.Employment_statusComboBox.Name = "Employment_statusComboBox"
        Me.Employment_statusComboBox.Size = New System.Drawing.Size(203, 22)
        Me.Employment_statusComboBox.TabIndex = 136
        '
        'Employee_statusComboBox
        '
        Me.Employee_statusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_tblBindingSource, "employee_status", True))
        Me.Employee_statusComboBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee_statusComboBox.FormattingEnabled = True
        Me.Employee_statusComboBox.Items.AddRange(New Object() {"Active", "In-Active"})
        Me.Employee_statusComboBox.Location = New System.Drawing.Point(566, 221)
        Me.Employee_statusComboBox.Name = "Employee_statusComboBox"
        Me.Employee_statusComboBox.Size = New System.Drawing.Size(199, 22)
        Me.Employee_statusComboBox.TabIndex = 137
        '
        'Civil_statusComboBox
        '
        Me.Civil_statusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_tblBindingSource, "civil_status", True))
        Me.Civil_statusComboBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Civil_statusComboBox.FormattingEnabled = True
        Me.Civil_statusComboBox.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Separated"})
        Me.Civil_statusComboBox.Location = New System.Drawing.Point(471, 191)
        Me.Civil_statusComboBox.Name = "Civil_statusComboBox"
        Me.Civil_statusComboBox.Size = New System.Drawing.Size(199, 22)
        Me.Civil_statusComboBox.TabIndex = 138
        '
        'Department_assignedComboBox
        '
        Me.Department_assignedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_tblBindingSource, "department_assigned", True))
        Me.Department_assignedComboBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department_assignedComboBox.FormattingEnabled = True
        Me.Department_assignedComboBox.Items.AddRange(New Object() {"College", "Senior High School", "Junior High School", "Elementary"})
        Me.Department_assignedComboBox.Location = New System.Drawing.Point(143, 128)
        Me.Department_assignedComboBox.Name = "Department_assignedComboBox"
        Me.Department_assignedComboBox.Size = New System.Drawing.Size(200, 22)
        Me.Department_assignedComboBox.TabIndex = 139
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 66)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(864, 399)
        Me.TabControl1.TabIndex = 140
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Last_nameTextBox)
        Me.TabPage1.Controls.Add(Me.btn_browse)
        Me.TabPage1.Controls.Add(Last_nameLabel)
        Me.TabPage1.Controls.Add(Birth_dateLabel)
        Me.TabPage1.Controls.Add(Me.Birth_dateDateTimePicker)
        Me.TabPage1.Controls.Add(AgeLabel)
        Me.TabPage1.Controls.Add(Me.AgeNumericUpDown)
        Me.TabPage1.Controls.Add(Me.PhotoPictureBox)
        Me.TabPage1.Controls.Add(GenderLabel)
        Me.TabPage1.Controls.Add(Me.Middle_nameTextBox)
        Me.TabPage1.Controls.Add(Me.GenderComboBox)
        Me.TabPage1.Controls.Add(AddressLabel)
        Me.TabPage1.Controls.Add(Middle_nameLabel)
        Me.TabPage1.Controls.Add(Me.AddressTextBox)
        Me.TabPage1.Controls.Add(Contact_noLabel)
        Me.TabPage1.Controls.Add(Me.ReligionTextBox)
        Me.TabPage1.Controls.Add(Civil_statusLabel)
        Me.TabPage1.Controls.Add(Me.Contact_noTextBox)
        Me.TabPage1.Controls.Add(Me.First_nameTextBox)
        Me.TabPage1.Controls.Add(CitizenshipLabel)
        Me.TabPage1.Controls.Add(WeightLabel)
        Me.TabPage1.Controls.Add(Me.HeightTextBox)
        Me.TabPage1.Controls.Add(Me.WeightTextBox)
        Me.TabPage1.Controls.Add(HeightLabel)
        Me.TabPage1.Controls.Add(Me.Civil_statusComboBox)
        Me.TabPage1.Controls.Add(First_nameLabel)
        Me.TabPage1.Controls.Add(Me.CitizenshipTextBox)
        Me.TabPage1.Controls.Add(ReligionLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(856, 373)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personnel Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Tin_noLabel)
        Me.TabPage2.Controls.Add(Me.Tin_noTextBox)
        Me.TabPage2.Controls.Add(Sss_noLabel)
        Me.TabPage2.Controls.Add(Me.Sss_noTextBox)
        Me.TabPage2.Controls.Add(Phic_noLabel)
        Me.TabPage2.Controls.Add(Me.Phic_noTextBox)
        Me.TabPage2.Controls.Add(Pag_ibig_noLabel)
        Me.TabPage2.Controls.Add(Me.Pag_ibig_noTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(856, 373)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reference Number"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Father_nameLabel)
        Me.TabPage3.Controls.Add(Me.Father_nameTextBox)
        Me.TabPage3.Controls.Add(Mother_nameLabel)
        Me.TabPage3.Controls.Add(Me.Mother_nameTextBox)
        Me.TabPage3.Controls.Add(Spouse_nameLabel)
        Me.TabPage3.Controls.Add(Me.Spouse_nameTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(856, 373)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Family Background"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(User_idLabel)
        Me.TabPage4.Controls.Add(PositionLabel)
        Me.TabPage4.Controls.Add(Monthly_rateLabel)
        Me.TabPage4.Controls.Add(Department_assignedLabel)
        Me.TabPage4.Controls.Add(Employment_statusLabel)
        Me.TabPage4.Controls.Add(Me.rate_basis_ComboBox)
        Me.TabPage4.Controls.Add(Me.PositionTextBox)
        Me.TabPage4.Controls.Add(Me.Employment_statusComboBox)
        Me.TabPage4.Controls.Add(Rate_basis_descrLabel)
        Me.TabPage4.Controls.Add(Me.Department_assignedComboBox)
        Me.TabPage4.Controls.Add(Date_resignedLabel)
        Me.TabPage4.Controls.Add(Me.Monthly_rateTextBox)
        Me.TabPage4.Controls.Add(Date_hireLabel)
        Me.TabPage4.Controls.Add(Me.Date_hireDateTimePicker)
        Me.TabPage4.Controls.Add(Daily_rateLabel)
        Me.TabPage4.Controls.Add(Me.Date_resignedDateTimePicker)
        Me.TabPage4.Controls.Add(Me.User_idComboBox)
        Me.TabPage4.Controls.Add(Me.Daily_rateTextBox)
        Me.TabPage4.Controls.Add(Me.Unit_rateTextBox)
        Me.TabPage4.Controls.Add(Employee_statusLabel)
        Me.TabPage4.Controls.Add(Hourly_rateLabel)
        Me.TabPage4.Controls.Add(Unit_rateLabel)
        Me.TabPage4.Controls.Add(Me.Employee_statusComboBox)
        Me.TabPage4.Controls.Add(Me.Hourly_rateTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(856, 373)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Other Information"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btnedit)
        Me.Panel1.Controls.Add(Me.btndel)
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 471)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 54)
        Me.Panel1.TabIndex = 141
        '
        'btn_save
        '
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_save.Icon = FontAwesome.Sharp.IconChar.CheckCircleO
        Me.btn_save.IconColor = System.Drawing.Color.Black
        Me.btn_save.IconSize = 16
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(541, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_save.Size = New System.Drawing.Size(91, 54)
        Me.btn_save.TabIndex = 135
        Me.btn_save.Text = "Save"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnedit.Icon = FontAwesome.Sharp.IconChar.Pencil
        Me.btnedit.IconColor = System.Drawing.Color.Black
        Me.btnedit.IconSize = 16
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.Location = New System.Drawing.Point(632, 0)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnedit.Size = New System.Drawing.Size(91, 54)
        Me.btnedit.TabIndex = 134
        Me.btnedit.Text = "Update"
        Me.btnedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btndel.Icon = FontAwesome.Sharp.IconChar.TrashO
        Me.btndel.IconColor = System.Drawing.Color.Black
        Me.btndel.IconSize = 16
        Me.btndel.Image = CType(resources.GetObject("btndel.Image"), System.Drawing.Image)
        Me.btndel.Location = New System.Drawing.Point(723, 0)
        Me.btndel.Name = "btndel"
        Me.btndel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btndel.Size = New System.Drawing.Size(91, 54)
        Me.btndel.TabIndex = 133
        Me.btndel.Text = "Delete"
        Me.btndel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_cancel.Icon = FontAwesome.Sharp.IconChar.Times
        Me.btn_cancel.IconColor = System.Drawing.Color.Black
        Me.btn_cancel.IconSize = 16
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(814, 0)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_cancel.Size = New System.Drawing.Size(91, 54)
        Me.btn_cancel.TabIndex = 132
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'EmployeeAddUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 525)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_Find)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmployeeAddUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeAddUpdate"
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsertblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Last_nameTextBox As TextBox
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents Middle_nameTextBox As TextBox
    Friend WithEvents Birth_dateDateTimePicker As DateTimePicker
    Friend WithEvents AgeNumericUpDown As NumericUpDown
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Contact_noTextBox As TextBox
    Friend WithEvents CitizenshipTextBox As TextBox
    Friend WithEvents ReligionTextBox As TextBox
    Friend WithEvents Tin_noTextBox As TextBox
    Friend WithEvents Sss_noTextBox As TextBox
    Friend WithEvents Phic_noTextBox As TextBox
    Friend WithEvents Pag_ibig_noTextBox As TextBox
    Friend WithEvents Date_hireDateTimePicker As DateTimePicker
    Friend WithEvents Father_nameTextBox As TextBox
    Friend WithEvents Mother_nameTextBox As TextBox
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents Spouse_nameTextBox As TextBox
    Friend WithEvents Monthly_rateTextBox As TextBox
    Friend WithEvents Daily_rateTextBox As TextBox
    Friend WithEvents Hourly_rateTextBox As TextBox
    Friend WithEvents Unit_rateTextBox As TextBox
    Friend WithEvents Date_resignedDateTimePicker As DateTimePicker
    Friend WithEvents PhotoPictureBox As PictureBox
    Friend WithEvents btn_Find As Button
    Friend WithEvents PayrolldbDataSet As payrolldbDataSet
    Friend WithEvents Employee_tblBindingSource As BindingSource
    Friend WithEvents Employee_tblTableAdapter As payrolldbDataSetTableAdapters.employee_tblTableAdapter
    Friend WithEvents TableAdapterManager As payrolldbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents User_idComboBox As ComboBox
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_browse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rate_basis_ComboBox As ComboBox
    Friend WithEvents Employment_statusComboBox As ComboBox
    Friend WithEvents Employee_statusComboBox As ComboBox
    Friend WithEvents Civil_statusComboBox As ComboBox
    Friend WithEvents User_tblTableAdapter As payrolldbDataSetTableAdapters.user_tblTableAdapter
    Friend WithEvents UsertblBindingSource As BindingSource
    Friend WithEvents Department_assignedComboBox As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_cancel As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_save As FontAwesome.Sharp.IconButton
    Friend WithEvents btnedit As FontAwesome.Sharp.IconButton
    Friend WithEvents btndel As FontAwesome.Sharp.IconButton
End Class
