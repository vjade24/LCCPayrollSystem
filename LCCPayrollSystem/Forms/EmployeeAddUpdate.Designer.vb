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
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.rate_basis_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Employment_statusComboBox = New System.Windows.Forms.ComboBox()
        Me.Employee_statusComboBox = New System.Windows.Forms.ComboBox()
        Me.Civil_statusComboBox = New System.Windows.Forms.ComboBox()
        Me.Department_assignedComboBox = New System.Windows.Forms.ComboBox()
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
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(26, 12)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(123, 17)
        IdLabel.TabIndex = 34
        IdLabel.Text = "Enter Employee Id"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_nameLabel.Location = New System.Drawing.Point(30, 63)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(76, 17)
        Last_nameLabel.TabIndex = 36
        Last_nameLabel.Text = "last name:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_nameLabel.Location = New System.Drawing.Point(239, 63)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(75, 17)
        First_nameLabel.TabIndex = 38
        First_nameLabel.Text = "first name:"
        '
        'Middle_nameLabel
        '
        Middle_nameLabel.AutoSize = True
        Middle_nameLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Middle_nameLabel.Location = New System.Drawing.Point(444, 63)
        Middle_nameLabel.Name = "Middle_nameLabel"
        Middle_nameLabel.Size = New System.Drawing.Size(99, 17)
        Middle_nameLabel.TabIndex = 40
        Middle_nameLabel.Text = "middle name:"
        '
        'Birth_dateLabel
        '
        Birth_dateLabel.AutoSize = True
        Birth_dateLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Birth_dateLabel.Location = New System.Drawing.Point(30, 109)
        Birth_dateLabel.Name = "Birth_dateLabel"
        Birth_dateLabel.Size = New System.Drawing.Size(76, 17)
        Birth_dateLabel.TabIndex = 42
        Birth_dateLabel.Text = "birth date:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(134, 109)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(38, 17)
        AgeLabel.TabIndex = 44
        AgeLabel.Text = "age:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(239, 107)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(58, 17)
        GenderLabel.TabIndex = 46
        GenderLabel.Text = "gender:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(239, 202)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(61, 17)
        AddressLabel.TabIndex = 48
        AddressLabel.Text = "address:"
        '
        'Contact_noLabel
        '
        Contact_noLabel.AutoSize = True
        Contact_noLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contact_noLabel.Location = New System.Drawing.Point(447, 109)
        Contact_noLabel.Name = "Contact_noLabel"
        Contact_noLabel.Size = New System.Drawing.Size(85, 17)
        Contact_noLabel.TabIndex = 50
        Contact_noLabel.Text = "contact no:"
        '
        'CitizenshipLabel
        '
        CitizenshipLabel.AutoSize = True
        CitizenshipLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CitizenshipLabel.Location = New System.Drawing.Point(239, 156)
        CitizenshipLabel.Name = "CitizenshipLabel"
        CitizenshipLabel.Size = New System.Drawing.Size(78, 17)
        CitizenshipLabel.TabIndex = 52
        CitizenshipLabel.Text = "citizenship:"
        '
        'ReligionLabel
        '
        ReligionLabel.AutoSize = True
        ReligionLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReligionLabel.Location = New System.Drawing.Point(30, 201)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(59, 17)
        ReligionLabel.TabIndex = 56
        ReligionLabel.Text = "religion:"
        '
        'Tin_noLabel
        '
        Tin_noLabel.AutoSize = True
        Tin_noLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tin_noLabel.Location = New System.Drawing.Point(30, 247)
        Tin_noLabel.Name = "Tin_noLabel"
        Tin_noLabel.Size = New System.Drawing.Size(49, 17)
        Tin_noLabel.TabIndex = 58
        Tin_noLabel.Text = "tin no:"
        '
        'Sss_noLabel
        '
        Sss_noLabel.AutoSize = True
        Sss_noLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sss_noLabel.Location = New System.Drawing.Point(239, 247)
        Sss_noLabel.Name = "Sss_noLabel"
        Sss_noLabel.Size = New System.Drawing.Size(48, 17)
        Sss_noLabel.TabIndex = 60
        Sss_noLabel.Text = "sss no:"
        '
        'Phic_noLabel
        '
        Phic_noLabel.AutoSize = True
        Phic_noLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phic_noLabel.Location = New System.Drawing.Point(239, 294)
        Phic_noLabel.Name = "Phic_noLabel"
        Phic_noLabel.Size = New System.Drawing.Size(61, 17)
        Phic_noLabel.TabIndex = 62
        Phic_noLabel.Text = "phic no:"
        '
        'Pag_ibig_noLabel
        '
        Pag_ibig_noLabel.AutoSize = True
        Pag_ibig_noLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pag_ibig_noLabel.Location = New System.Drawing.Point(30, 294)
        Pag_ibig_noLabel.Name = "Pag_ibig_noLabel"
        Pag_ibig_noLabel.Size = New System.Drawing.Size(88, 17)
        Pag_ibig_noLabel.TabIndex = 64
        Pag_ibig_noLabel.Text = "pag ibig no:"
        '
        'Department_assignedLabel
        '
        Department_assignedLabel.AutoSize = True
        Department_assignedLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Department_assignedLabel.Location = New System.Drawing.Point(27, 385)
        Department_assignedLabel.Name = "Department_assignedLabel"
        Department_assignedLabel.Size = New System.Drawing.Size(150, 17)
        Department_assignedLabel.TabIndex = 66
        Department_assignedLabel.Text = "department assigned:"
        '
        'Date_hireLabel
        '
        Date_hireLabel.AutoSize = True
        Date_hireLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_hireLabel.Location = New System.Drawing.Point(27, 571)
        Date_hireLabel.Name = "Date_hireLabel"
        Date_hireLabel.Size = New System.Drawing.Size(70, 17)
        Date_hireLabel.TabIndex = 68
        Date_hireLabel.Text = "date hire:"
        '
        'Father_nameLabel
        '
        Father_nameLabel.AutoSize = True
        Father_nameLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Father_nameLabel.Location = New System.Drawing.Point(27, 433)
        Father_nameLabel.Name = "Father_nameLabel"
        Father_nameLabel.Size = New System.Drawing.Size(92, 17)
        Father_nameLabel.TabIndex = 70
        Father_nameLabel.Text = "father name:"
        '
        'Mother_nameLabel
        '
        Mother_nameLabel.AutoSize = True
        Mother_nameLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mother_nameLabel.Location = New System.Drawing.Point(27, 479)
        Mother_nameLabel.Name = "Mother_nameLabel"
        Mother_nameLabel.Size = New System.Drawing.Size(101, 17)
        Mother_nameLabel.TabIndex = 72
        Mother_nameLabel.Text = "mother name:"
        '
        'HeightLabel
        '
        HeightLabel.AutoSize = True
        HeightLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HeightLabel.Location = New System.Drawing.Point(30, 155)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New System.Drawing.Size(53, 17)
        HeightLabel.TabIndex = 74
        HeightLabel.Text = "height:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WeightLabel.Location = New System.Drawing.Point(134, 158)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(57, 17)
        WeightLabel.TabIndex = 76
        WeightLabel.Text = "weight:"
        '
        'Employment_statusLabel
        '
        Employment_statusLabel.AutoSize = True
        Employment_statusLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employment_statusLabel.Location = New System.Drawing.Point(238, 385)
        Employment_statusLabel.Name = "Employment_statusLabel"
        Employment_statusLabel.Size = New System.Drawing.Size(135, 17)
        Employment_statusLabel.TabIndex = 78
        Employment_statusLabel.Text = "employment status:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PositionLabel.Location = New System.Drawing.Point(30, 339)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(63, 17)
        PositionLabel.TabIndex = 80
        PositionLabel.Text = "position:"
        '
        'Spouse_nameLabel
        '
        Spouse_nameLabel.AutoSize = True
        Spouse_nameLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Spouse_nameLabel.Location = New System.Drawing.Point(27, 525)
        Spouse_nameLabel.Name = "Spouse_nameLabel"
        Spouse_nameLabel.Size = New System.Drawing.Size(98, 17)
        Spouse_nameLabel.TabIndex = 82
        Spouse_nameLabel.Text = "spouse name:"
        '
        'Rate_basis_descrLabel
        '
        Rate_basis_descrLabel.AutoSize = True
        Rate_basis_descrLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rate_basis_descrLabel.Location = New System.Drawing.Point(447, 339)
        Rate_basis_descrLabel.Name = "Rate_basis_descrLabel"
        Rate_basis_descrLabel.Size = New System.Drawing.Size(111, 17)
        Rate_basis_descrLabel.TabIndex = 86
        Rate_basis_descrLabel.Text = "rate basis descr:"
        '
        'Monthly_rateLabel
        '
        Monthly_rateLabel.AutoSize = True
        Monthly_rateLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Monthly_rateLabel.Location = New System.Drawing.Point(447, 385)
        Monthly_rateLabel.Name = "Monthly_rateLabel"
        Monthly_rateLabel.Size = New System.Drawing.Size(94, 17)
        Monthly_rateLabel.TabIndex = 88
        Monthly_rateLabel.Text = "monthly rate:"
        '
        'Daily_rateLabel
        '
        Daily_rateLabel.AutoSize = True
        Daily_rateLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Daily_rateLabel.Location = New System.Drawing.Point(447, 433)
        Daily_rateLabel.Name = "Daily_rateLabel"
        Daily_rateLabel.Size = New System.Drawing.Size(72, 17)
        Daily_rateLabel.TabIndex = 90
        Daily_rateLabel.Text = "daily rate:"
        '
        'Hourly_rateLabel
        '
        Hourly_rateLabel.AutoSize = True
        Hourly_rateLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Hourly_rateLabel.Location = New System.Drawing.Point(447, 479)
        Hourly_rateLabel.Name = "Hourly_rateLabel"
        Hourly_rateLabel.Size = New System.Drawing.Size(80, 17)
        Hourly_rateLabel.TabIndex = 92
        Hourly_rateLabel.Text = "hourly rate:"
        '
        'Unit_rateLabel
        '
        Unit_rateLabel.AutoSize = True
        Unit_rateLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Unit_rateLabel.Location = New System.Drawing.Point(447, 525)
        Unit_rateLabel.Name = "Unit_rateLabel"
        Unit_rateLabel.Size = New System.Drawing.Size(66, 17)
        Unit_rateLabel.TabIndex = 94
        Unit_rateLabel.Text = "unit rate:"
        '
        'Employee_statusLabel
        '
        Employee_statusLabel.AutoSize = True
        Employee_statusLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employee_statusLabel.Location = New System.Drawing.Point(447, 571)
        Employee_statusLabel.Name = "Employee_statusLabel"
        Employee_statusLabel.Size = New System.Drawing.Size(117, 17)
        Employee_statusLabel.TabIndex = 96
        Employee_statusLabel.Text = "employee status:"
        '
        'Date_resignedLabel
        '
        Date_resignedLabel.AutoSize = True
        Date_resignedLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_resignedLabel.Location = New System.Drawing.Point(238, 571)
        Date_resignedLabel.Name = "Date_resignedLabel"
        Date_resignedLabel.Size = New System.Drawing.Size(101, 17)
        Date_resignedLabel.TabIndex = 98
        Date_resignedLabel.Text = "date resigned:"
        '
        'User_idLabel
        '
        User_idLabel.AutoSize = True
        User_idLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_idLabel.Location = New System.Drawing.Point(447, 294)
        User_idLabel.Name = "User_idLabel"
        User_idLabel.Size = New System.Drawing.Size(53, 17)
        User_idLabel.TabIndex = 103
        User_idLabel.Text = "user id:"
        '
        'Civil_statusLabel
        '
        Civil_statusLabel.AutoSize = True
        Civil_statusLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Civil_statusLabel.Location = New System.Drawing.Point(454, 156)
        Civil_statusLabel.Name = "Civil_statusLabel"
        Civil_statusLabel.Size = New System.Drawing.Size(78, 17)
        Civil_statusLabel.TabIndex = 132
        Civil_statusLabel.Text = "civil status:"
        '
        'IdTextBox
        '
        Me.IdTextBox.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(29, 32)
        Me.IdTextBox.Multiline = True
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 28)
        Me.IdTextBox.TabIndex = 35
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(27, 83)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Last_nameTextBox.TabIndex = 37
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_nameTextBox.Location = New System.Drawing.Point(239, 83)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(200, 23)
        Me.First_nameTextBox.TabIndex = 39
        '
        'Middle_nameTextBox
        '
        Me.Middle_nameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle_nameTextBox.Location = New System.Drawing.Point(446, 83)
        Me.Middle_nameTextBox.Name = "Middle_nameTextBox"
        Me.Middle_nameTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Middle_nameTextBox.TabIndex = 41
        '
        'Birth_dateDateTimePicker
        '
        Me.Birth_dateDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Birth_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Birth_dateDateTimePicker.Location = New System.Drawing.Point(30, 129)
        Me.Birth_dateDateTimePicker.Name = "Birth_dateDateTimePicker"
        Me.Birth_dateDateTimePicker.Size = New System.Drawing.Size(98, 23)
        Me.Birth_dateDateTimePicker.TabIndex = 43
        '
        'AgeNumericUpDown
        '
        Me.AgeNumericUpDown.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeNumericUpDown.Location = New System.Drawing.Point(137, 129)
        Me.AgeNumericUpDown.Name = "AgeNumericUpDown"
        Me.AgeNumericUpDown.Size = New System.Drawing.Size(91, 23)
        Me.AgeNumericUpDown.TabIndex = 45
        Me.AgeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GenderComboBox
        '
        Me.GenderComboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(239, 129)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(200, 25)
        Me.GenderComboBox.TabIndex = 47
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(239, 220)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(408, 23)
        Me.AddressTextBox.TabIndex = 49
        '
        'Contact_noTextBox
        '
        Me.Contact_noTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact_noTextBox.Location = New System.Drawing.Point(446, 129)
        Me.Contact_noTextBox.Name = "Contact_noTextBox"
        Me.Contact_noTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Contact_noTextBox.TabIndex = 51
        '
        'CitizenshipTextBox
        '
        Me.CitizenshipTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitizenshipTextBox.Location = New System.Drawing.Point(239, 176)
        Me.CitizenshipTextBox.Name = "CitizenshipTextBox"
        Me.CitizenshipTextBox.Size = New System.Drawing.Size(198, 23)
        Me.CitizenshipTextBox.TabIndex = 53
        '
        'ReligionTextBox
        '
        Me.ReligionTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReligionTextBox.Location = New System.Drawing.Point(30, 221)
        Me.ReligionTextBox.Name = "ReligionTextBox"
        Me.ReligionTextBox.Size = New System.Drawing.Size(200, 23)
        Me.ReligionTextBox.TabIndex = 57
        '
        'Tin_noTextBox
        '
        Me.Tin_noTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tin_noTextBox.Location = New System.Drawing.Point(30, 267)
        Me.Tin_noTextBox.Name = "Tin_noTextBox"
        Me.Tin_noTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Tin_noTextBox.TabIndex = 59
        '
        'Sss_noTextBox
        '
        Me.Sss_noTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sss_noTextBox.Location = New System.Drawing.Point(239, 267)
        Me.Sss_noTextBox.Name = "Sss_noTextBox"
        Me.Sss_noTextBox.Size = New System.Drawing.Size(194, 23)
        Me.Sss_noTextBox.TabIndex = 61
        '
        'Phic_noTextBox
        '
        Me.Phic_noTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phic_noTextBox.Location = New System.Drawing.Point(239, 313)
        Me.Phic_noTextBox.Name = "Phic_noTextBox"
        Me.Phic_noTextBox.Size = New System.Drawing.Size(194, 23)
        Me.Phic_noTextBox.TabIndex = 63
        '
        'Pag_ibig_noTextBox
        '
        Me.Pag_ibig_noTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pag_ibig_noTextBox.Location = New System.Drawing.Point(30, 313)
        Me.Pag_ibig_noTextBox.Name = "Pag_ibig_noTextBox"
        Me.Pag_ibig_noTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Pag_ibig_noTextBox.TabIndex = 65
        '
        'Date_hireDateTimePicker
        '
        Me.Date_hireDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_hireDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_hireDateTimePicker.Location = New System.Drawing.Point(27, 591)
        Me.Date_hireDateTimePicker.Name = "Date_hireDateTimePicker"
        Me.Date_hireDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.Date_hireDateTimePicker.TabIndex = 69
        '
        'Father_nameTextBox
        '
        Me.Father_nameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Father_nameTextBox.Location = New System.Drawing.Point(27, 453)
        Me.Father_nameTextBox.Name = "Father_nameTextBox"
        Me.Father_nameTextBox.Size = New System.Drawing.Size(411, 23)
        Me.Father_nameTextBox.TabIndex = 71
        '
        'Mother_nameTextBox
        '
        Me.Mother_nameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mother_nameTextBox.Location = New System.Drawing.Point(27, 499)
        Me.Mother_nameTextBox.Name = "Mother_nameTextBox"
        Me.Mother_nameTextBox.Size = New System.Drawing.Size(411, 23)
        Me.Mother_nameTextBox.TabIndex = 73
        '
        'HeightTextBox
        '
        Me.HeightTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightTextBox.Location = New System.Drawing.Point(30, 175)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(98, 23)
        Me.HeightTextBox.TabIndex = 75
        '
        'WeightTextBox
        '
        Me.WeightTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTextBox.Location = New System.Drawing.Point(137, 176)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(93, 23)
        Me.WeightTextBox.TabIndex = 77
        '
        'PositionTextBox
        '
        Me.PositionTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionTextBox.Location = New System.Drawing.Point(30, 359)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(408, 23)
        Me.PositionTextBox.TabIndex = 81
        '
        'Spouse_nameTextBox
        '
        Me.Spouse_nameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spouse_nameTextBox.Location = New System.Drawing.Point(27, 545)
        Me.Spouse_nameTextBox.Name = "Spouse_nameTextBox"
        Me.Spouse_nameTextBox.Size = New System.Drawing.Size(411, 23)
        Me.Spouse_nameTextBox.TabIndex = 83
        '
        'Monthly_rateTextBox
        '
        Me.Monthly_rateTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Monthly_rateTextBox.Location = New System.Drawing.Point(447, 405)
        Me.Monthly_rateTextBox.Name = "Monthly_rateTextBox"
        Me.Monthly_rateTextBox.Size = New System.Drawing.Size(199, 23)
        Me.Monthly_rateTextBox.TabIndex = 89
        Me.Monthly_rateTextBox.Text = "0.00"
        Me.Monthly_rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Daily_rateTextBox
        '
        Me.Daily_rateTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Daily_rateTextBox.Location = New System.Drawing.Point(447, 453)
        Me.Daily_rateTextBox.Name = "Daily_rateTextBox"
        Me.Daily_rateTextBox.Size = New System.Drawing.Size(199, 23)
        Me.Daily_rateTextBox.TabIndex = 91
        Me.Daily_rateTextBox.Text = "0.00"
        Me.Daily_rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Hourly_rateTextBox
        '
        Me.Hourly_rateTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hourly_rateTextBox.Location = New System.Drawing.Point(447, 499)
        Me.Hourly_rateTextBox.Name = "Hourly_rateTextBox"
        Me.Hourly_rateTextBox.Size = New System.Drawing.Size(199, 23)
        Me.Hourly_rateTextBox.TabIndex = 93
        Me.Hourly_rateTextBox.Text = "0.00"
        Me.Hourly_rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Unit_rateTextBox
        '
        Me.Unit_rateTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_rateTextBox.Location = New System.Drawing.Point(447, 545)
        Me.Unit_rateTextBox.Name = "Unit_rateTextBox"
        Me.Unit_rateTextBox.Size = New System.Drawing.Size(199, 23)
        Me.Unit_rateTextBox.TabIndex = 95
        Me.Unit_rateTextBox.Text = "0.00"
        Me.Unit_rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Date_resignedDateTimePicker
        '
        Me.Date_resignedDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_resignedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_resignedDateTimePicker.Location = New System.Drawing.Point(238, 591)
        Me.Date_resignedDateTimePicker.Name = "Date_resignedDateTimePicker"
        Me.Date_resignedDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.Date_resignedDateTimePicker.TabIndex = 99
        '
        'PhotoPictureBox
        '
        Me.PhotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PhotoPictureBox.Location = New System.Drawing.Point(673, 83)
        Me.PhotoPictureBox.Name = "PhotoPictureBox"
        Me.PhotoPictureBox.Size = New System.Drawing.Size(167, 160)
        Me.PhotoPictureBox.TabIndex = 101
        Me.PhotoPictureBox.TabStop = False
        '
        'btn_Find
        '
        Me.btn_Find.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Find.Location = New System.Drawing.Point(237, 32)
        Me.btn_Find.Name = "btn_Find"
        Me.btn_Find.Size = New System.Drawing.Size(75, 23)
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
        Me.User_idComboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_idComboBox.FormattingEnabled = True
        Me.User_idComboBox.Location = New System.Drawing.Point(447, 313)
        Me.User_idComboBox.Name = "User_idComboBox"
        Me.User_idComboBox.Size = New System.Drawing.Size(199, 25)
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
        Me.btn_new.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Location = New System.Drawing.Point(315, 32)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(122, 23)
        Me.btn_new.TabIndex = 105
        Me.btn_new.Text = "Create New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.ImageKey = "(none)"
        Me.btn_cancel.Location = New System.Drawing.Point(668, 580)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(83, 35)
        Me.btn_cancel.TabIndex = 131
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Green
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnedit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(668, 539)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(83, 35)
        Me.btnedit.TabIndex = 130
        Me.btnedit.Text = "Update"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.DarkRed
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btndel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.Color.White
        Me.btndel.Location = New System.Drawing.Point(757, 539)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(83, 35)
        Me.btndel.TabIndex = 129
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(757, 580)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(83, 35)
        Me.btn_save.TabIndex = 128
        Me.btn_save.Text = "Add"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_browse
        '
        Me.btn_browse.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btn_browse.Location = New System.Drawing.Point(673, 249)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(167, 23)
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
        Me.rate_basis_ComboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rate_basis_ComboBox.FormattingEnabled = True
        Me.rate_basis_ComboBox.Items.AddRange(New Object() {"Monthly", "Daily", "Hourly", "Per Unit"})
        Me.rate_basis_ComboBox.Location = New System.Drawing.Point(447, 359)
        Me.rate_basis_ComboBox.Name = "rate_basis_ComboBox"
        Me.rate_basis_ComboBox.Size = New System.Drawing.Size(199, 25)
        Me.rate_basis_ComboBox.TabIndex = 135
        '
        'Employment_statusComboBox
        '
        Me.Employment_statusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_tblBindingSource, "employment_status", True))
        Me.Employment_statusComboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employment_statusComboBox.FormattingEnabled = True
        Me.Employment_statusComboBox.Items.AddRange(New Object() {"Full-Time", "Part-Time"})
        Me.Employment_statusComboBox.Location = New System.Drawing.Point(235, 405)
        Me.Employment_statusComboBox.Name = "Employment_statusComboBox"
        Me.Employment_statusComboBox.Size = New System.Drawing.Size(203, 25)
        Me.Employment_statusComboBox.TabIndex = 136
        '
        'Employee_statusComboBox
        '
        Me.Employee_statusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_tblBindingSource, "employee_status", True))
        Me.Employee_statusComboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee_statusComboBox.FormattingEnabled = True
        Me.Employee_statusComboBox.Items.AddRange(New Object() {"Active", "In-Active"})
        Me.Employee_statusComboBox.Location = New System.Drawing.Point(447, 591)
        Me.Employee_statusComboBox.Name = "Employee_statusComboBox"
        Me.Employee_statusComboBox.Size = New System.Drawing.Size(199, 25)
        Me.Employee_statusComboBox.TabIndex = 137
        '
        'Civil_statusComboBox
        '
        Me.Civil_statusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_tblBindingSource, "civil_status", True))
        Me.Civil_statusComboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Civil_statusComboBox.FormattingEnabled = True
        Me.Civil_statusComboBox.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Separated"})
        Me.Civil_statusComboBox.Location = New System.Drawing.Point(446, 174)
        Me.Civil_statusComboBox.Name = "Civil_statusComboBox"
        Me.Civil_statusComboBox.Size = New System.Drawing.Size(200, 25)
        Me.Civil_statusComboBox.TabIndex = 138
        '
        'Department_assignedComboBox
        '
        Me.Department_assignedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_tblBindingSource, "department_assigned", True))
        Me.Department_assignedComboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department_assignedComboBox.FormattingEnabled = True
        Me.Department_assignedComboBox.Items.AddRange(New Object() {"College", "Senior High School", "Junior High School", "Elementary"})
        Me.Department_assignedComboBox.Location = New System.Drawing.Point(27, 405)
        Me.Department_assignedComboBox.Name = "Department_assignedComboBox"
        Me.Department_assignedComboBox.Size = New System.Drawing.Size(200, 25)
        Me.Department_assignedComboBox.TabIndex = 139
        '
        'EmployeeAddUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 525)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.rate_basis_ComboBox)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_Find)
        Me.Controls.Add(Me.Department_assignedComboBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.PhotoPictureBox)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.ReligionTextBox)
        Me.Controls.Add(Employee_statusLabel)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Date_resignedLabel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Date_resignedDateTimePicker)
        Me.Controls.Add(Me.Employee_statusComboBox)
        Me.Controls.Add(Me.Pag_ibig_noTextBox)
        Me.Controls.Add(Me.Civil_statusComboBox)
        Me.Controls.Add(Pag_ibig_noLabel)
        Me.Controls.Add(Me.Employment_statusComboBox)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(ReligionLabel)
        Me.Controls.Add(Me.Phic_noTextBox)
        Me.Controls.Add(Me.CitizenshipTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(User_idLabel)
        Me.Controls.Add(Phic_noLabel)
        Me.Controls.Add(Me.User_idComboBox)
        Me.Controls.Add(HeightLabel)
        Me.Controls.Add(Me.Unit_rateTextBox)
        Me.Controls.Add(Me.Spouse_nameTextBox)
        Me.Controls.Add(Unit_rateLabel)
        Me.Controls.Add(Me.WeightTextBox)
        Me.Controls.Add(Me.Hourly_rateTextBox)
        Me.Controls.Add(Spouse_nameLabel)
        Me.Controls.Add(Hourly_rateLabel)
        Me.Controls.Add(Me.HeightTextBox)
        Me.Controls.Add(Me.Daily_rateTextBox)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(Daily_rateLabel)
        Me.Controls.Add(WeightLabel)
        Me.Controls.Add(Me.Monthly_rateTextBox)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(CitizenshipLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Me.Contact_noTextBox)
        Me.Controls.Add(Employment_statusLabel)
        Me.Controls.Add(Civil_statusLabel)
        Me.Controls.Add(Me.Sss_noTextBox)
        Me.Controls.Add(Contact_noLabel)
        Me.Controls.Add(Me.Mother_nameTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Middle_nameLabel)
        Me.Controls.Add(Rate_basis_descrLabel)
        Me.Controls.Add(Mother_nameLabel)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Sss_noLabel)
        Me.Controls.Add(Monthly_rateLabel)
        Me.Controls.Add(Me.Father_nameTextBox)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.Middle_nameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Father_nameLabel)
        Me.Controls.Add(Me.AgeNumericUpDown)
        Me.Controls.Add(Me.Tin_noTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.Date_hireDateTimePicker)
        Me.Controls.Add(Me.Birth_dateDateTimePicker)
        Me.Controls.Add(Tin_noLabel)
        Me.Controls.Add(Birth_dateLabel)
        Me.Controls.Add(Date_hireLabel)
        Me.Controls.Add(Department_assignedLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmployeeAddUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeAddUpdate"
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolldbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsertblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_browse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rate_basis_ComboBox As ComboBox
    Friend WithEvents Employment_statusComboBox As ComboBox
    Friend WithEvents Employee_statusComboBox As ComboBox
    Friend WithEvents Civil_statusComboBox As ComboBox
    Friend WithEvents User_tblTableAdapter As payrolldbDataSetTableAdapters.user_tblTableAdapter
    Friend WithEvents UsertblBindingSource As BindingSource
    Friend WithEvents Department_assignedComboBox As ComboBox
End Class
