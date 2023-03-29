
Imports System.IO
Imports System.Data.SqlClient
Public Class EmployeeAddUpdate
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Employee.Show()
    End Sub

    Private Sub btn_Find_Click(sender As Object, e As EventArgs) Handles btn_Find.Click
        Try
            Dim dt As New DataTable()
            Dim query = "select * from employee_tbl where Id = '" + IdTextBox.Text.ToString().Trim() + "'"
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim adp As New SqlDataAdapter()
            adp.SelectCommand = cmd
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                IdTextBox.Text = dt.Rows(0)("Id").ToString()
                Last_nameTextBox.Text = dt.Rows(0)("last_name").ToString()
                First_nameTextBox.Text = dt.Rows(0)("first_name").ToString()
                Middle_nameTextBox.Text = dt.Rows(0)("middle_name").ToString()
                Birth_dateDateTimePicker.Value = dt.Rows(0)("birth_date").ToString()
                AgeNumericUpDown.Value = dt.Rows(0)("age").ToString()
                GenderComboBox.Text = dt.Rows(0)("gender").ToString()
                AddressTextBox.Text = dt.Rows(0)("address").ToString()
                Contact_noTextBox.Text = dt.Rows(0)("contact_no").ToString()
                CitizenshipTextBox.Text = dt.Rows(0)("citizenship").ToString()
                Civil_statusComboBox.Text = dt.Rows(0)("civil_status").ToString()
                ReligionTextBox.Text = dt.Rows(0)("religion").ToString()
                Tin_noTextBox.Text = dt.Rows(0)("tin_no").ToString()
                Sss_noTextBox.Text = dt.Rows(0)("sss_no").ToString()
                Phic_noTextBox.Text = dt.Rows(0)("phic_no").ToString()
                Pag_ibig_noTextBox.Text = dt.Rows(0)("pag_ibig_no").ToString()
                Department_assignedComboBox.Text = dt.Rows(0)("department_assigned").ToString()
                Date_hireDateTimePicker.Value = dt.Rows(0)("date_hire").ToString()
                Father_nameTextBox.Text = dt.Rows(0)("father_name").ToString()
                Mother_nameTextBox.Text = dt.Rows(0)("mother_name").ToString()
                HeightTextBox.Text = dt.Rows(0)("height").ToString()
                WeightTextBox.Text = dt.Rows(0)("weight").ToString()
                Employment_statusComboBox.Text = dt.Rows(0)("employment_status").ToString()
                PositionTextBox.Text = dt.Rows(0)("position").ToString()
                Spouse_nameTextBox.Text = dt.Rows(0)("spouse_name").ToString()
                'User_idComboBox.SelectedValue = dt.Rows(0)("user_id").ToString()
                rate_basis_ComboBox.Text = dt.Rows(0)("rate_basis_descr").ToString()
                Monthly_rateTextBox.Text = dt.Rows(0)("monthly_rate").ToString()
                Daily_rateTextBox.Text = dt.Rows(0)("daily_rate").ToString()
                Hourly_rateTextBox.Text = dt.Rows(0)("hourly_rate").ToString()
                Unit_rateTextBox.Text = dt.Rows(0)("unit_rate").ToString()
                Employee_statusComboBox.Text = dt.Rows(0)("employee_status").ToString()
                Date_resignedDateTimePicker.Value = dt.Rows(0)("date_resigned").ToString()

                Try
                    Dim lb() As Byte = dt.Rows(0)("photo")
                    Dim lstr As New System.IO.MemoryStream(lb)
                    PhotoPictureBox.Image = Image.FromStream(lstr)
                    PhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                Catch ex As Exception
                    PhotoPictureBox.Image = My.Resources.DefaultUserImg
                End Try

                btn_save.Visible = False
                btn_cancel.Visible = False
                btndel.Visible = True
                btnedit.Visible = True
                btn_browse.Visible = True
            Else
                MsgBox("NO DATA FOUND!", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString().Trim(), MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Employee_tblBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Employee_tblBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PayrolldbDataSet)

    End Sub

    Private Sub EmployeeAddUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrolldbDataSet.user_tbl' table. You can move, or remove it, as needed.
        Me.User_tblTableAdapter.Fill(Me.PayrolldbDataSet.user_tbl)
        'TODO: This line of code loads data into the 'PayrolldbDataSet.employee_tbl' table. You can move, or remove it, as needed.
        Me.Employee_tblTableAdapter.Fill(Me.PayrolldbDataSet.employee_tbl)
        clearentry()

        btn_save.Visible = True
        btn_cancel.Visible = True
        btndel.Visible = False
        btnedit.Visible = False
        btn_browse.Visible = False
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        clearentry()
        Dim conn As SqlConnection = New SqlConnection(connection)
        Dim cmd As SqlCommand = New SqlCommand("select top 1 Id from employee_tbl order by Id desc", conn)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        sda.Fill(dt)
        If (dt.Rows.Count < 0) Then
            IdTextBox.Text = "1"
        Else
            Dim next_nbr As Double
            next_nbr = Double.Parse(dt.Rows(0)("Id").ToString()) + 1
            IdTextBox.Text = next_nbr.ToString()
        End If
        btn_save.Visible = True
        btn_cancel.Visible = True
        btndel.Visible = False
        btnedit.Visible = False
        btn_browse.Visible = True
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG Files(*.Jpg)|*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PhotoPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete this Record?", "Delete Record", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("You pressed Cancel, Record will be remain")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then
            Dim query As String = "delete from employee_tbl where id ='" + IdTextBox.Text + "'"
            DeleteQuery(query)
            clearentry()
            btn_save.Visible = True
            btn_cancel.Visible = True
            btndel.Visible = False
            btnedit.Visible = False
            btn_browse.Visible = False
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim ms As New MemoryStream
        PhotoPictureBox.Image.Save(ms, PhotoPictureBox.Image.RawFormat)
        Dim command1 As New SqlCommand("insert into employee_tbl values (@Id,@last_name,@first_name,@middle_name,@birth_date,@age,@gender,@address,@contact_no,@citizenship,@civil_status,@religion,@tin_no,@sss_no,@phic_no,@pag_ibig_no,@department_assigned, @date_hire,@father_name,@mother_name,@height,@weight,@employment_status,@position,@spouse_name,@user_id,@photo,@rate_basis_descr,@monthly_rate,@daily_rate,@hourly_rate,@unit_rate,@employee_status,@date_resigned)", conn)
        command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@last_name", SqlDbType.VarChar).Value = Last_nameTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@first_name", SqlDbType.VarChar).Value = First_nameTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@middle_name", SqlDbType.VarChar).Value = Middle_nameTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@birth_date", SqlDbType.Date).Value = Birth_dateDateTimePicker.Value.ToString().Trim()
        command1.Parameters.Add("@age", SqlDbType.Int).Value = AgeNumericUpDown.Value.ToString().Trim()
        command1.Parameters.Add("@gender", SqlDbType.VarChar).Value = GenderComboBox.Text.ToString().Trim()
        command1.Parameters.Add("@address", SqlDbType.VarChar).Value = AddressTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@contact_no", SqlDbType.VarChar).Value = Contact_noTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@citizenship", SqlDbType.VarChar).Value = CitizenshipTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@civil_status", SqlDbType.VarChar).Value = Civil_statusComboBox.Text.ToString().Trim()
        command1.Parameters.Add("@religion", SqlDbType.VarChar).Value = ReligionTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@tin_no", SqlDbType.VarChar).Value = Tin_noTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@sss_no", SqlDbType.VarChar).Value = Sss_noTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@phic_no", SqlDbType.VarChar).Value = Phic_noTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@pag_ibig_no", SqlDbType.VarChar).Value = Pag_ibig_noTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@department_assigned", SqlDbType.VarChar).Value = Department_assignedComboBox.Text.ToString().Trim()
        command1.Parameters.Add("@date_hire", SqlDbType.Date).Value = Date_hireDateTimePicker.Value.ToString().Trim()
        command1.Parameters.Add("@father_name", SqlDbType.VarChar).Value = Father_nameTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@mother_name", SqlDbType.VarChar).Value = Mother_nameTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@height", SqlDbType.VarChar).Value = HeightTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@weight", SqlDbType.VarChar).Value = WeightTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@employment_status", SqlDbType.VarChar).Value = Employment_statusComboBox.Text.ToString().Trim()
        command1.Parameters.Add("@position", SqlDbType.VarChar).Value = PositionTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@spouse_name", SqlDbType.VarChar).Value = Spouse_nameTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@user_id", SqlDbType.VarChar).Value = User_idComboBox.SelectedValue.ToString().Trim()
        command1.Parameters.Add("@photo", SqlDbType.Image).Value = ms.ToArray
        command1.Parameters.Add("@rate_basis_descr", SqlDbType.VarChar).Value = rate_basis_ComboBox.Text.ToString().Trim()
        command1.Parameters.Add("@monthly_rate", SqlDbType.VarChar).Value = Monthly_rateTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@daily_rate", SqlDbType.VarChar).Value = Daily_rateTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@hourly_rate", SqlDbType.VarChar).Value = Hourly_rateTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@unit_rate", SqlDbType.VarChar).Value = Unit_rateTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@employee_status", SqlDbType.VarChar).Value = Employee_statusComboBox.Text.ToString().Trim()
        command1.Parameters.Add("@date_resigned", SqlDbType.Date).Value = Date_resignedDateTimePicker.Value.ToString().Trim()
        Try
            conn.Open()
            result = command1.ExecuteNonQuery()
            If result = 0 Then
                MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
            Else
                MsgBox("Successfully Inserted!", MsgBoxStyle.Information)
                clearentry()
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Update this Record?", "Update Record", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("You pressed Cancel, Record will be remain")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then
            Dim ms As New MemoryStream
            PhotoPictureBox.Image.Save(ms, PhotoPictureBox.Image.RawFormat)
            Dim command1 As New SqlCommand("update employee_tbl set last_name = @last_name,first_name = @first_name,middle_name= @middle_name,birth_date = @birth_date,age = @age,gender = @gender,address = @address,contact_no = @contact_no,citizenship = @citizenship,civil_status = @civil_status,religion = @religion,tin_no =@tin_no,sss_no = @sss_no,phic_no = @phic_no,pag_ibig_no =@pag_ibig_no,department_assigned =@department_assigned, date_hire =@date_hire,father_name=@father_name,mother_name=@mother_name,height=@height,weight=@weight,employment_status=@employment_status,position=@position,spouse_name=@spouse_name,user_id=@user_id,photo=@photo,rate_basis_descr=@rate_basis_descr,monthly_rate=@monthly_rate,daily_rate=@daily_rate,hourly_rate=@hourly_rate,unit_rate=@unit_rate,employee_status=@employee_status,date_resigned=@date_resigned where Id = @Id", conn)
            command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@last_name", SqlDbType.VarChar).Value = Last_nameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@first_name", SqlDbType.VarChar).Value = First_nameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@middle_name", SqlDbType.VarChar).Value = Middle_nameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@birth_date", SqlDbType.Date).Value = Birth_dateDateTimePicker.Value.ToString().Trim()
            command1.Parameters.Add("@age", SqlDbType.Int).Value = AgeNumericUpDown.Value.ToString().Trim()
            command1.Parameters.Add("@gender", SqlDbType.VarChar).Value = GenderComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@address", SqlDbType.VarChar).Value = AddressTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@contact_no", SqlDbType.VarChar).Value = Contact_noTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@citizenship", SqlDbType.VarChar).Value = CitizenshipTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@civil_status", SqlDbType.VarChar).Value = Civil_statusComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@religion", SqlDbType.VarChar).Value = ReligionTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@tin_no", SqlDbType.VarChar).Value = Tin_noTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@sss_no", SqlDbType.VarChar).Value = Sss_noTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@phic_no", SqlDbType.VarChar).Value = Phic_noTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@pag_ibig_no", SqlDbType.VarChar).Value = Pag_ibig_noTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@department_assigned", SqlDbType.VarChar).Value = Department_assignedComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@date_hire", SqlDbType.Date).Value = Date_hireDateTimePicker.Value.ToString().Trim()
            command1.Parameters.Add("@father_name", SqlDbType.VarChar).Value = Father_nameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@mother_name", SqlDbType.VarChar).Value = Mother_nameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@height", SqlDbType.VarChar).Value = HeightTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@weight", SqlDbType.VarChar).Value = WeightTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@employment_status", SqlDbType.VarChar).Value = Employment_statusComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@position", SqlDbType.VarChar).Value = PositionTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@spouse_name", SqlDbType.VarChar).Value = Spouse_nameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@user_id", SqlDbType.VarChar).Value = User_idComboBox.SelectedValue.ToString().Trim()
            command1.Parameters.Add("@photo", SqlDbType.Image).Value = ms.ToArray
            command1.Parameters.Add("@rate_basis_descr", SqlDbType.VarChar).Value = rate_basis_ComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@monthly_rate", SqlDbType.VarChar).Value = Monthly_rateTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@daily_rate", SqlDbType.VarChar).Value = Daily_rateTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@hourly_rate", SqlDbType.VarChar).Value = Hourly_rateTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@unit_rate", SqlDbType.VarChar).Value = Unit_rateTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@employee_status", SqlDbType.VarChar).Value = Employee_statusComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@date_resigned", SqlDbType.Date).Value = Date_resignedDateTimePicker.Value.ToString().Trim()
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Successfully Updated!", MsgBoxStyle.Information)
                    clearentry()
                End If
                conn.Close()

            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try

            btn_save.Visible = True
            btn_cancel.Visible = True
            btndel.Visible = False
            btnedit.Visible = False
            btn_browse.Visible = False
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        clearentry()
        btndel.Visible = False
        btnedit.Visible = False
        btn_save.Visible = True
        btn_browse.Visible = False
    End Sub
    Public Sub clearentry()
        IdTextBox.Text = ""
        Last_nameTextBox.Text = ""
        First_nameTextBox.Text = ""
        Middle_nameTextBox.Text = ""
        Birth_dateDateTimePicker.Text = ""
        AgeNumericUpDown.Text = ""
        GenderComboBox.Text = "Male"
        AddressTextBox.Text = ""
        Contact_noTextBox.Text = ""
        CitizenshipTextBox.Text = ""
        Civil_statusComboBox.Text = "Single"
        ReligionTextBox.Text = ""
        Tin_noTextBox.Text = ""
        Sss_noTextBox.Text = ""
        Phic_noTextBox.Text = ""
        Pag_ibig_noTextBox.Text = ""
        Department_assignedComboBox.Text = "College"
        Date_hireDateTimePicker.Text = ""
        Father_nameTextBox.Text = ""
        Mother_nameTextBox.Text = ""
        HeightTextBox.Text = ""
        WeightTextBox.Text = ""
        Employment_statusComboBox.Text = ""
        PositionTextBox.Text = ""
        Spouse_nameTextBox.Text = ""
        User_idComboBox.SelectedIndex = 0
        PhotoPictureBox.Image = My.Resources.DefaultUserImg
        PhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        rate_basis_ComboBox.Text = "Monthly"
        Monthly_rateTextBox.Text = ""
        Daily_rateTextBox.Text = ""
        Hourly_rateTextBox.Text = ""
        Unit_rateTextBox.Text = ""
        Employment_statusComboBox.Text = "Full-Time"
        Date_resignedDateTimePicker.Text = ""
        Employee_statusComboBox.Text = "Active"

    End Sub

    Private Sub Birth_dateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Birth_dateDateTimePicker.ValueChanged
        'Dim birthdate As DateAndTime
        'birthdate = DateTime.Parse(Birth_dateDateTimePicker.Value)

        'age = (DateTime.Parse(Birth_dateDateTimePicker.Value) - DateTime.Now.Year)

        Dim age As Integer
        Dim date_from As New DateTime
        Dim date_to As New DateTime

        date_from = DateTime.Parse(Birth_dateDateTimePicker.Text.ToString().Trim())
        date_to = DateTime.Parse(DateTime.Now.ToString())

        age = (date_to.Year - date_from.Year)

        AgeNumericUpDown.Value = age.ToString()
    End Sub
End Class