
Imports System.Data
Imports System.Data.SqlClient
Public Class Payroll
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        'Dashboard.Show()
    End Sub

    Private Sub Payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrolldbDataSet1.vw_payroll_tbl' table. You can move, or remove it, as needed.
        Me.Vw_payroll_tblTableAdapter.Fill(Me.PayrolldbDataSet1.vw_payroll_tbl)
        'TODO: This line of code loads data into the 'PayrolldbDataSet.payroll_tbl' table. You can move, or remove it, as needed.
        Me.Payroll_tblTableAdapter.Fill(Me.PayrolldbDataSet.payroll_tbl)
        'TODO: This line of code loads data into the 'PayrolldbDataSet.vw_payroll_tbl' table. You can move, or remove it, as needed.
        Me.Vw_payroll_tblTableAdapter.Fill(Me.PayrolldbDataSet.vw_payroll_tbl)
        clearentry()
        Dim query As String = "select distinct payroll_no from payroll_tbl"
        ComboboxQuery(query, Payroll_noComboBox, "payroll_no", "payroll_no")

        btn_save.Enabled = False
        btnCancel.Enabled = False
        btnupdate.Enabled = False
        btndel.Enabled = False
    End Sub

    Private Sub calculate_gross()
        Dim gross_pay As Double
        gross_pay = gross_pay + Double.Parse(Regular_wagesTextBox.Text)
        gross_pay = gross_pay + Double.Parse(Overtime_amtTextBox.Text)
        gross_pay = gross_pay + Double.Parse(Allowances_amtTextBox.Text)
        gross_pay = gross_pay + Double.Parse(Adjustments_amtTextBox.Text)
        Gross_payTextBox.Text = gross_pay.ToString("###,##0.00")
    End Sub
    Private Sub calculate_deductions()
        Dim deduction As Double
        deduction = deduction + Double.Parse(Lates_in_amtTextBox.Text)
        deduction = deduction + Double.Parse(Absent_amtTextBox.Text)
        deduction = deduction + Double.Parse(Cash_advance_amtTextBox.Text)
        deduction = deduction + Double.Parse(Sss_med_amtTextBox.Text)
        deduction = deduction + Double.Parse(Sss_loan_amtTextBox.Text)
        deduction = deduction + Double.Parse(Pag_ibig_amtTextBox.Text)
        deduction = deduction + Double.Parse(Phic_amtTextBox.Text)
        deduction = deduction + Double.Parse(Wtax_amtTextBox.Text)
        deduction = deduction + Double.Parse(Other_ded_amtTextBox.Text)
        deduction = deduction + Double.Parse(Other_loans_amtTextBox.Text)
        deduction = deduction + Double.Parse(King_coop_loanTextBox.Text)
        deduction = deduction + Double.Parse(Lbp_loanTextBox.Text)
        total_deduction_TextBox.Text = deduction.ToString("###,##0.00")
    End Sub
    Private Sub calculate_net_pay()
        Dim net_pay As Double
        net_pay = Double.Parse(Gross_payTextBox.Text) - Double.Parse(total_deduction_TextBox.Text)
        Net_payTextBox.Text = net_pay.ToString("###,##0.00")
    End Sub

    Private Sub calculate_wages()
        Dim Regular_wages As Double
        If rate_basis_ComboBox.Text.ToString().Trim() = "Monthly" Then
            Regular_wages = Monthly_rateTextBox.Text
        ElseIf rate_basis_ComboBox.Text.ToString().Trim() = "Daily" Then
            Regular_wages = Double.Parse(Daily_rateTextBox.Text) * Double.Parse(Worked_daysTextBox.Text)
        ElseIf rate_basis_ComboBox.Text.ToString().Trim() = "Hourly" Then
            Regular_wages = Double.Parse(Hourly_rateTextBox.Text) * Double.Parse(Worked_daysTextBox.Text)
        ElseIf rate_basis_ComboBox.Text.ToString().Trim() = "Per Unit" Then
            Regular_wages = Double.Parse(Unit_rateTextBox.Text) * Double.Parse(Worked_daysTextBox.Text)
        End If
        Regular_wagesTextBox.Text = Regular_wages.ToString("###,##0.00")
    End Sub
    Private Sub calculate_all()
        calculate_wages()
        calculate_gross()
        calculate_deductions()
        calculate_net_pay()
    End Sub
    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Dim chk As Boolean
        Monthly_rateTextBox.BackColor = Color.White
        Daily_rateTextBox.BackColor = Color.White
        Hourly_rateTextBox.BackColor = Color.White
        Unit_rateTextBox.BackColor = Color.White

        If checkisdecimal(Monthly_rateTextBox) = False Then
            Monthly_rateTextBox.BackColor = Color.Red
            chk = False
        End If
        If checkisdecimal(Daily_rateTextBox) = False Then
            Daily_rateTextBox.BackColor = Color.Red
            chk = False
        End If
        If checkisdecimal(Hourly_rateTextBox) = False Then
            Hourly_rateTextBox.BackColor = Color.Red
            chk = False
        End If
        If checkisdecimal(Unit_rateTextBox) = False Then
            Unit_rateTextBox.BackColor = Color.Red
            chk = False
        End If

        If chk = False Then
            calculate_all()
        End If

    End Sub
    Private Sub rate_basis_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rate_basis_ComboBox.SelectedIndexChanged

        Worked_daysLabel.Text = "No Rate Basis:"
        Worked_daysTextBox.Enabled = True
        If rate_basis_ComboBox.Text.ToString().Trim() = "Monthly" Then
            Worked_daysTextBox.Enabled = False
            Worked_daysLabel.Text = "Monthly Rate:"
        ElseIf rate_basis_ComboBox.Text.ToString().Trim() = "Daily" Then
            Worked_daysLabel.Text = "Days Rendered:"
        ElseIf rate_basis_ComboBox.Text.ToString().Trim() = "Hourly" Then
            Worked_daysLabel.Text = "Hours Rendered:"
        ElseIf rate_basis_ComboBox.Text.ToString().Trim() = "Per Unit" Then
            Worked_daysLabel.Text = "Unit Rendered:"
        End If
        calculate_all()
    End Sub

    Private Sub Worked_daysTextBox_TextChanged(sender As Object, e As EventArgs) Handles Worked_daysTextBox.TextChanged
        calculate_wages()
    End Sub

    Private Sub Employee_idComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Employee_idComboBox.SelectionChangeCommitted
        If Employee_idComboBox.SelectedValue.ToString().Trim() <> "" Then
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand("select * from employee_tbl where Id='" + Employee_idComboBox.SelectedValue.ToString().Trim() + "'", conn)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            sda.Fill(dt)
            If (dt.Rows.Count > 0) Then
                clearentry()

                Last_nameTextBox.Text = dt.Rows(0)("last_name").ToString()
                First_nameTextBox.Text = dt.Rows(0)("first_name").ToString()
                Middle_nameTextBox.Text = dt.Rows(0)("middle_name").ToString()
                'department_assigned.Text = dt.Rows(0)("department_assigned").ToString()
                rate_basis_ComboBox.Text = dt.Rows(0)("rate_basis_descr").ToString()
                Monthly_rateTextBox.Text = Double.Parse(dt.Rows(0)("monthly_rate").ToString()).ToString("###,##0.00")
                Daily_rateTextBox.Text = Double.Parse(dt.Rows(0)("daily_rate").ToString()).ToString("###,##0.00")
                Hourly_rateTextBox.Text = Double.Parse(dt.Rows(0)("hourly_rate").ToString()).ToString("###,##0.00")
                Unit_rateTextBox.Text = Double.Parse(dt.Rows(0)("unit_rate").ToString()).ToString("###,##0.00")

                Try
                    Dim lb() As Byte = dt.Rows(0)("photo")
                    Dim lstr As New System.IO.MemoryStream(lb)
                    PhotoPictureBox.Image = Image.FromStream(lstr)
                    PhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                Catch ex As Exception
                    PhotoPictureBox.Image = My.Resources.DefaultUserImg
                End Try

                ' ******************************************************************************
                ' **** This portion is to Get the Deduction amount of Individual Employee ******
                ' ******************************************************************************
                Dim dt_cash_advance_amt As New DataTable
                Dim dt_other_ded_amt As New DataTable
                Dim dt_other_loans_amt As New DataTable
                Dim dt_pag_ibig_amt As New DataTable
                Dim dt_phic_amt As New DataTable
                Dim dt_sss_loan_amt As New DataTable
                Dim dt_sss_med_amt As New DataTable
                Dim dt_wtax_amt As New DataTable
                Dim dt_king_coop_loan As New DataTable
                Dim dt_lbp_loan As New DataTable


                Dim query_cash_advance_amt As String
                Dim query_other_ded_amt As String
                Dim query_other_loans_amt As String
                Dim query_pag_ibig_amt As String
                Dim query_phic_amt As String
                Dim query_sss_loan_amt As String
                Dim query_sss_med_amt As String
                Dim query_wtax_amt As String
                Dim query_dt_king_coop_loan As String
                Dim query_lbp_loan As String

                query_cash_advance_amt = "SELECT ISNULL(SUM(deduct_amt),0) AS deduct_amt FROM payroll_deduction_tbl WHERE employee_id = '" + Employee_idComboBox.SelectedValue.ToString.Trim() + "' AND deduction_code = 'cash_advance_amt'	AND (deduct_period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "' OR deduct_period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "')"
                query_other_ded_amt = "SELECT ISNULL(SUM(deduct_amt),0) AS deduct_amt FROM payroll_deduction_tbl WHERE employee_id = '" + Employee_idComboBox.SelectedValue.ToString.Trim() + "' AND deduction_code = 'other_ded_amt'	AND (deduct_period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "' OR deduct_period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "')"
                query_other_loans_amt = "SELECT ISNULL(SUM(deduct_amt),0) AS deduct_amt FROM payroll_deduction_tbl WHERE employee_id = '" + Employee_idComboBox.SelectedValue.ToString.Trim() + "' AND deduction_code = 'other_loans_amt'	AND (deduct_period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "' OR deduct_period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "')"
                query_pag_ibig_amt = "SELECT ISNULL(SUM(deduct_amt),0) AS deduct_amt FROM payroll_deduction_tbl WHERE employee_id = '" + Employee_idComboBox.SelectedValue.ToString.Trim() + "' AND deduction_code = 'pag_ibig_amt'	AND (deduct_period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "' OR deduct_period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "')"
                query_phic_amt = "SELECT ISNULL(SUM(deduct_amt),0) AS deduct_amt FROM payroll_deduction_tbl WHERE employee_id = '" + Employee_idComboBox.SelectedValue.ToString.Trim() + "' AND deduction_code = 'phic_amt'	AND (deduct_period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "' OR deduct_period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "')"
                query_sss_loan_amt = "SELECT ISNULL(SUM(deduct_amt),0) AS deduct_amt FROM payroll_deduction_tbl WHERE employee_id = '" + Employee_idComboBox.SelectedValue.ToString.Trim() + "' AND deduction_code = 'sss_loan_amt'	AND (deduct_period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "' OR deduct_period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "')"
                query_sss_med_amt = "SELECT ISNULL(SUM(deduct_amt),0) AS deduct_amt FROM payroll_deduction_tbl WHERE employee_id = '" + Employee_idComboBox.SelectedValue.ToString.Trim() + "' AND deduction_code = 'sss_med_amt'	AND (deduct_period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "' OR deduct_period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "')"
                query_wtax_amt = "SELECT ISNULL(SUM(deduct_amt),0) AS deduct_amt FROM payroll_deduction_tbl WHERE employee_id = '" + Employee_idComboBox.SelectedValue.ToString.Trim() + "' AND deduction_code = 'wtax_amt'	AND (deduct_period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "' OR deduct_period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "')"
                query_dt_king_coop_loan = "SELECT ISNULL(SUM(deduct_amt),0) AS deduct_amt FROM payroll_deduction_tbl WHERE employee_id = '" + Employee_idComboBox.SelectedValue.ToString.Trim() + "' AND deduction_code = 'king_coop_loan'	AND (deduct_period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "' OR deduct_period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "')"
                query_lbp_loan = "SELECT ISNULL(SUM(deduct_amt),0) AS deduct_amt FROM payroll_deduction_tbl WHERE employee_id = '" + Employee_idComboBox.SelectedValue.ToString.Trim() + "' AND deduction_code = 'lbp_loan'	AND (deduct_period_from BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "' OR deduct_period_to BETWEEN '" + Period_fromDateTimePicker.Value.ToString.Trim + "' AND '" + Period_toDateTimePicker.Value.ToString.Trim + "')"

                dt_cash_advance_amt = RetrieveData(query_cash_advance_amt)
                dt_other_ded_amt = RetrieveData(query_other_ded_amt)
                dt_other_loans_amt = RetrieveData(query_other_loans_amt)
                dt_pag_ibig_amt = RetrieveData(query_pag_ibig_amt)
                dt_phic_amt = RetrieveData(query_phic_amt)
                dt_sss_loan_amt = RetrieveData(query_sss_loan_amt)
                dt_sss_med_amt = RetrieveData(query_sss_med_amt)
                dt_wtax_amt = RetrieveData(query_wtax_amt)
                dt_king_coop_loan = RetrieveData(query_dt_king_coop_loan)
                dt_lbp_loan = RetrieveData(query_lbp_loan)

                Cash_advance_amtTextBox.Text = Double.Parse(dt_cash_advance_amt.Rows(0)("deduct_amt").ToString()).ToString("###,##0.00")
                Other_ded_amtTextBox.Text = Double.Parse(dt_other_ded_amt.Rows(0)("deduct_amt").ToString()).ToString("###,##0.00")
                Other_loans_amtTextBox.Text = Double.Parse(dt_other_loans_amt.Rows(0)("deduct_amt").ToString()).ToString("###,##0.00")
                Pag_ibig_amtTextBox.Text = Double.Parse(dt_pag_ibig_amt.Rows(0)("deduct_amt").ToString()).ToString("###,##0.00")
                Phic_amtTextBox.Text = Double.Parse(dt_phic_amt.Rows(0)("deduct_amt").ToString()).ToString("###,##0.00")
                Sss_loan_amtTextBox.Text = Double.Parse(dt_sss_loan_amt.Rows(0)("deduct_amt").ToString()).ToString("###,##0.00")
                Sss_med_amtTextBox.Text = Double.Parse(dt_sss_med_amt.Rows(0)("deduct_amt").ToString()).ToString("###,##0.00")
                Wtax_amtTextBox.Text = Double.Parse(dt_wtax_amt.Rows(0)("deduct_amt").ToString()).ToString("###,##0.00")
                King_coop_loanTextBox.Text = Double.Parse(dt_king_coop_loan.Rows(0)("deduct_amt").ToString()).ToString("###,##0.00")
                Lbp_loanTextBox.Text = Double.Parse(dt_lbp_loan.Rows(0)("deduct_amt").ToString()).ToString("###,##0.00")

                ' ******************************************************************************
                ' **** This portion is to Get the Deduction amount of Individual Employee ******
                ' ******************************************************************************

                calculate_all()
            Else
                MsgBox("No Employee Found!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    'Private Sub department_assigned_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles department_assigned.SelectionChangeCommitted
    '    clearentry()
    '    Dim query As String = "select Id,concat(last_name,',', first_name,' ', middle_name) as employee_name from employee_tbl where department_assigned = '" + department_assigned.Text.ToString().Trim() + "'"
    '    ComboboxQuery(query, Employee_idComboBox, "Id", "employee_name")

    '    Employee_idComboBox.Text = ""
    'End Sub

    Private Sub clearentry()
        Period_fromDateTimePicker.Value = DateTime.Now.Month.ToString().Trim() + "/01/" + DateTime.Now.Year().ToString().Trim()
        Period_toDateTimePicker.Value = DateTime.Parse(Period_fromDateTimePicker.Value).AddMonths(1).AddDays(-1)

        Last_nameTextBox.Text = ""
        First_nameTextBox.Text = ""
        Middle_nameTextBox.Text = ""
        rate_basis_ComboBox.Text = ""
        Monthly_rateTextBox.Text = "0.00"
        Daily_rateTextBox.Text = "0.00"
        Hourly_rateTextBox.Text = "0.00"
        Unit_rateTextBox.Text = "0.00"

        Regular_wagesTextBox.Text = "0.00"
        Overtime_amtTextBox.Text = "0.00"
        Allowances_amtTextBox.Text = "0.00"
        Adjustments_amtTextBox.Text = "0.00"
        Worked_daysTextBox.Text = "0.00"
        Absent_daysTextBox.Text = "0.00"
        Absent_amtTextBox.Text = "0.00"
        Lates_in_minTextBox.Text = "0.00"
        Lates_in_amtTextBox.Text = "0.00"
        Cash_advance_amtTextBox.Text = "0.00"
        Sss_med_amtTextBox.Text = "0.00"
        Sss_loan_amtTextBox.Text = "0.00"
        Pag_ibig_amtTextBox.Text = "0.00"
        Phic_amtTextBox.Text = "0.00"
        Wtax_amtTextBox.Text = "0.00"
        Other_ded_amtTextBox.Text = "0.00"
        Other_loans_amtTextBox.Text = "0.00"
        King_coop_loanTextBox.Text = "0.00"
        Lbp_loanTextBox.Text = "0.00"
        Gross_payTextBox.Text = "0.00"
        Net_payTextBox.Text = "0.00"
        RemarksTextBox.Text = ""
        IdTextBox.Text = ""
        total_deduction_TextBox.Text = "0.00"

        PhotoPictureBox.Image = My.Resources.DefaultUserImg
    End Sub

    'Private Sub btn_generate_no_Click(sender As Object, e As EventArgs) Handles btn_generate_no.Click
    '    If btn_generate_no.Text = "Generate Payroll No" Then
    '        btn_generate_no.Text = "Select Payroll No"
    '        Payroll_noComboBox.Enabled = False

    '        Dim conn As SqlConnection = New SqlConnection(connection)
    '        Dim cmd As SqlCommand = New SqlCommand("select top 1 payroll_no from payroll_tbl order by id desc", conn)
    '        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
    '        Dim dt As DataTable = New DataTable
    '        sda.Fill(dt)
    '        If (dt.Rows.Count < 0) Then
    '            Payroll_noComboBox.Text = "000001"
    '        Else
    '            Dim payroll_no As Double
    '            payroll_no = Double.Parse(dt.Rows(0)("payroll_no").ToString()) + 1
    '            Payroll_noComboBox.Text = ("00000" + payroll_no.ToString()).PadRight(6)

    '        End If
    '    ElseIf btn_generate_no.Text = "Select Payroll No" Then
    '        btn_generate_no.Text = "Generate Payroll No"
    '        Payroll_noComboBox.Enabled = True
    '        Dim query As String = "select distinct payroll_no from payroll_tbl"
    '        ComboboxQuery(query, Payroll_noComboBox, "payroll_no", "payroll_no")
    '    End If
    'End Sub

    Private Sub department_assigned_SelectedIndexChanged(sender As Object, e As EventArgs) Handles department_assigned.SelectedIndexChanged
        clearentry()
        Dim query As String = "select Id,concat(last_name,',', first_name,' ', middle_name) as employee_name from employee_tbl where department_assigned = '" + department_assigned.Text.ToString().Trim() + "'"
        ComboboxQuery(query, Employee_idComboBox, "Id", "employee_name")
        Employee_idComboBox.Text = ""
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete this Record", "Delete Record?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            Dim command1 As New SqlCommand("delete from payroll_tbl where Id = @Id", conn)
            command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Found!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Successfully Deleted!", MsgBoxStyle.Information)
                    clearentry()
                    'Me.Hide()
                    'Me.Dispose()
                    'PayrollList.Show()

                    Period_fromDateTimePicker.Enabled = True
                    Period_toDateTimePicker.Enabled = True
                    department_assigned.Enabled = True
                    Employee_idComboBox.Enabled = True
                    rate_basis_ComboBox.Enabled = True
                    Monthly_rateTextBox.Enabled = True
                    Daily_rateTextBox.Enabled = True
                    Hourly_rateTextBox.Enabled = True
                    Unit_rateTextBox.Enabled = True

                    'TODO: This line of code loads data into the 'PayrolldbDataSet.vw_payroll_tbl' table. You can move, or remove it, as needed.
                    Me.Vw_payroll_tblTableAdapter.Fill(Me.PayrolldbDataSet.vw_payroll_tbl)


                End If
                conn.Close()

            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        calculate_all()

        If department_assigned.Text = "" Or Employee_idComboBox.Text = "" Then
            MsgBox("Please Select Employee", MsgBoxStyle.Critical)
            Return
        End If

        Dim insert_update_query As String
        insert_update_query = "insert into payroll_tbl values (@payroll_no,@period_from,@period_to,@employee_id,@last_name,@first_name,@middle_name,@department_assigned,@rate_basis_descr,@monthly_rate,@daily_rate,@hourly_rate,@unit_rate,@regular_wages,@overtime_amt,@allowances_amt,@adjustments_amt,@worked_days,@absent_days,@absent_amt,@lates_in_min,@lates_in_amt,@cash_advance_amt,@sss_med_amt,@sss_loan_amt,@pag_ibig_amt,@phic_amt,@wtax_amt,@other_ded_amt,@other_loans_amt,@gross_pay,@net_pay,@remarks,@king_coop_loan,@lbp_loan)"

        Dim command1 As New SqlCommand(insert_update_query, conn)

        command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text
        command1.Parameters.Add("@payroll_no", SqlDbType.VarChar).Value = Payroll_noComboBox.Text
        command1.Parameters.Add("@period_from", SqlDbType.VarChar).Value = Period_fromDateTimePicker.Value
        command1.Parameters.Add("@period_to", SqlDbType.VarChar).Value = Period_toDateTimePicker.Value
        command1.Parameters.Add("@employee_id", SqlDbType.VarChar).Value = Employee_idComboBox.SelectedValue
        command1.Parameters.Add("@last_name", SqlDbType.VarChar).Value = Last_nameTextBox.Text
        command1.Parameters.Add("@first_name", SqlDbType.VarChar).Value = First_nameTextBox.Text
        command1.Parameters.Add("@middle_name", SqlDbType.VarChar).Value = Middle_nameTextBox.Text
        command1.Parameters.Add("@department_assigned", SqlDbType.VarChar).Value = department_assigned.Text
        command1.Parameters.Add("@rate_basis_descr", SqlDbType.VarChar).Value = rate_basis_ComboBox.Text
        command1.Parameters.Add("@monthly_rate", SqlDbType.Money).Value = Monthly_rateTextBox.Text
        command1.Parameters.Add("@daily_rate", SqlDbType.Money).Value = Daily_rateTextBox.Text
        command1.Parameters.Add("@hourly_rate", SqlDbType.Money).Value = Hourly_rateTextBox.Text
        command1.Parameters.Add("@unit_rate", SqlDbType.Money).Value = Unit_rateTextBox.Text
        command1.Parameters.Add("@regular_wages", SqlDbType.Money).Value = Regular_wagesTextBox.Text
        command1.Parameters.Add("@overtime_amt", SqlDbType.Money).Value = Overtime_amtTextBox.Text
        command1.Parameters.Add("@allowances_amt", SqlDbType.Money).Value = Allowances_amtTextBox.Text
        command1.Parameters.Add("@adjustments_amt", SqlDbType.Money).Value = Adjustments_amtTextBox.Text
        command1.Parameters.Add("@worked_days", SqlDbType.Money).Value = Worked_daysTextBox.Text
        command1.Parameters.Add("@absent_days", SqlDbType.Money).Value = Absent_daysTextBox.Text
        command1.Parameters.Add("@absent_amt", SqlDbType.Money).Value = Absent_amtTextBox.Text
        command1.Parameters.Add("@lates_in_min", SqlDbType.Money).Value = Lates_in_minTextBox.Text
        command1.Parameters.Add("@lates_in_amt", SqlDbType.Money).Value = Lates_in_amtTextBox.Text
        command1.Parameters.Add("@cash_advance_amt", SqlDbType.Money).Value = Cash_advance_amtTextBox.Text
        command1.Parameters.Add("@sss_med_amt", SqlDbType.Money).Value = Sss_med_amtTextBox.Text
        command1.Parameters.Add("@sss_loan_amt", SqlDbType.Money).Value = Sss_loan_amtTextBox.Text
        command1.Parameters.Add("@pag_ibig_amt", SqlDbType.Money).Value = Pag_ibig_amtTextBox.Text
        command1.Parameters.Add("@phic_amt", SqlDbType.Money).Value = Phic_amtTextBox.Text
        command1.Parameters.Add("@wtax_amt", SqlDbType.Money).Value = Wtax_amtTextBox.Text
        command1.Parameters.Add("@other_ded_amt", SqlDbType.Money).Value = Other_ded_amtTextBox.Text
        command1.Parameters.Add("@other_loans_amt", SqlDbType.Money).Value = Other_loans_amtTextBox.Text
        command1.Parameters.Add("@gross_pay", SqlDbType.Money).Value = Gross_payTextBox.Text
        command1.Parameters.Add("@net_pay", SqlDbType.Money).Value = Net_payTextBox.Text
        command1.Parameters.Add("@remarks", SqlDbType.VarChar).Value = RemarksTextBox.Text
        command1.Parameters.Add("@king_coop_loan", SqlDbType.VarChar).Value = King_coop_loanTextBox.Text
        command1.Parameters.Add("@lbp_loan", SqlDbType.VarChar).Value = Lbp_loanTextBox.Text
        Try
            conn.Open()
            result = command1.ExecuteNonQuery()
            If result = 0 Then
                MsgBox("No Data Found!", MsgBoxStyle.Critical)
            Else

                MsgBox("Successfully Inserted!", MsgBoxStyle.Information)

                clearentry()
                'Me.Hide()
                'Me.Dispose()
                'PayrollList.Show()

                Period_fromDateTimePicker.Enabled = True
                Period_toDateTimePicker.Enabled = True
                department_assigned.Enabled = True
                Employee_idComboBox.Enabled = True
                rate_basis_ComboBox.Enabled = True
                Monthly_rateTextBox.Enabled = True
                Daily_rateTextBox.Enabled = True
                Hourly_rateTextBox.Enabled = True
                Unit_rateTextBox.Enabled = True

                'TODO: This line of code loads data into the 'PayrolldbDataSet.vw_payroll_tbl' table. You can move, or remove it, as needed.
                Me.Vw_payroll_tblTableAdapter.Fill(Me.PayrolldbDataSet.vw_payroll_tbl)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        calculate_all()
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Update this Record?", "Update Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then
            Dim insert_update_query As String
            insert_update_query = "update payroll_tbl set rate_basis_descr = @rate_basis_descr,monthly_rate = @monthly_rate, daily_rate = @daily_rate,hourly_rate =@hourly_rate,unit_rate = @unit_rate,regular_wages = @regular_wages,overtime_amt = @overtime_amt,allowances_amt = @allowances_amt, adjustments_amt = @adjustments_amt, worked_days = @worked_days, absent_days = @absent_days, absent_amt = @absent_amt, lates_in_min = @lates_in_min, lates_in_amt = @lates_in_amt, cash_advance_amt = @cash_advance_amt, sss_med_amt = @sss_med_amt, sss_loan_amt = @sss_loan_amt, pag_ibig_amt = @pag_ibig_amt, phic_amt = @phic_amt,wtax_amt = @wtax_amt, other_ded_amt = @other_ded_amt, other_loans_amt = @other_loans_amt, gross_pay =@gross_pay,net_pay = @net_pay, remarks = @remarks, king_coop_loan = @king_coop_loan, lbp_loan = @lbp_loan where Id = @Id"
            Dim command1 As New SqlCommand(insert_update_query, conn)
            command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text
            command1.Parameters.Add("@payroll_no", SqlDbType.VarChar).Value = Payroll_noComboBox.Text
            command1.Parameters.Add("@period_from", SqlDbType.VarChar).Value = Period_fromDateTimePicker.Value
            command1.Parameters.Add("@period_to", SqlDbType.VarChar).Value = Period_toDateTimePicker.Value
            command1.Parameters.Add("@employee_id", SqlDbType.VarChar).Value = Employee_idComboBox.SelectedValue
            command1.Parameters.Add("@last_name", SqlDbType.VarChar).Value = Last_nameTextBox.Text
            command1.Parameters.Add("@first_name", SqlDbType.VarChar).Value = First_nameTextBox.Text
            command1.Parameters.Add("@middle_name", SqlDbType.VarChar).Value = Middle_nameTextBox.Text
            command1.Parameters.Add("@department_assigned", SqlDbType.VarChar).Value = department_assigned.Text
            command1.Parameters.Add("@rate_basis_descr", SqlDbType.VarChar).Value = rate_basis_ComboBox.Text
            command1.Parameters.Add("@monthly_rate", SqlDbType.Money).Value = Monthly_rateTextBox.Text
            command1.Parameters.Add("@daily_rate", SqlDbType.Money).Value = Daily_rateTextBox.Text
            command1.Parameters.Add("@hourly_rate", SqlDbType.Money).Value = Hourly_rateTextBox.Text
            command1.Parameters.Add("@unit_rate", SqlDbType.Money).Value = Unit_rateTextBox.Text
            command1.Parameters.Add("@regular_wages", SqlDbType.Money).Value = Regular_wagesTextBox.Text
            command1.Parameters.Add("@overtime_amt", SqlDbType.Money).Value = Overtime_amtTextBox.Text
            command1.Parameters.Add("@allowances_amt", SqlDbType.Money).Value = Allowances_amtTextBox.Text
            command1.Parameters.Add("@adjustments_amt", SqlDbType.Money).Value = Adjustments_amtTextBox.Text
            command1.Parameters.Add("@worked_days", SqlDbType.Money).Value = Worked_daysTextBox.Text
            command1.Parameters.Add("@absent_days", SqlDbType.Money).Value = Absent_daysTextBox.Text
            command1.Parameters.Add("@absent_amt", SqlDbType.Money).Value = Absent_amtTextBox.Text
            command1.Parameters.Add("@lates_in_min", SqlDbType.Money).Value = Lates_in_minTextBox.Text
            command1.Parameters.Add("@lates_in_amt", SqlDbType.Money).Value = Lates_in_amtTextBox.Text
            command1.Parameters.Add("@cash_advance_amt", SqlDbType.Money).Value = Cash_advance_amtTextBox.Text
            command1.Parameters.Add("@sss_med_amt", SqlDbType.Money).Value = Sss_med_amtTextBox.Text
            command1.Parameters.Add("@sss_loan_amt", SqlDbType.Money).Value = Sss_loan_amtTextBox.Text
            command1.Parameters.Add("@pag_ibig_amt", SqlDbType.Money).Value = Pag_ibig_amtTextBox.Text
            command1.Parameters.Add("@phic_amt", SqlDbType.Money).Value = Phic_amtTextBox.Text
            command1.Parameters.Add("@wtax_amt", SqlDbType.Money).Value = Wtax_amtTextBox.Text
            command1.Parameters.Add("@other_ded_amt", SqlDbType.Money).Value = Other_ded_amtTextBox.Text
            command1.Parameters.Add("@other_loans_amt", SqlDbType.Money).Value = Other_loans_amtTextBox.Text
            command1.Parameters.Add("@gross_pay", SqlDbType.Money).Value = Gross_payTextBox.Text
            command1.Parameters.Add("@net_pay", SqlDbType.Money).Value = Net_payTextBox.Text
            command1.Parameters.Add("@remarks", SqlDbType.VarChar).Value = RemarksTextBox.Text
            command1.Parameters.Add("@king_coop_loan", SqlDbType.VarChar).Value = King_coop_loanTextBox.Text
            command1.Parameters.Add("@lbp_loan", SqlDbType.VarChar).Value = Lbp_loanTextBox.Text
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Found!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Successfully Updated!", MsgBoxStyle.Information)
                    clearentry()
                    'Me.Hide()
                    'Me.Dispose()
                    'PayrollList.Show()

                    Period_fromDateTimePicker.Enabled = True
                    Period_toDateTimePicker.Enabled = True
                    department_assigned.Enabled = True
                    Employee_idComboBox.Enabled = True
                    rate_basis_ComboBox.Enabled = True
                    Monthly_rateTextBox.Enabled = True
                    Daily_rateTextBox.Enabled = True
                    Hourly_rateTextBox.Enabled = True
                    Unit_rateTextBox.Enabled = True

                    'TODO: This line of code loads data into the 'PayrolldbDataSet.vw_payroll_tbl' table. You can move, or remove it, as needed.
                    Me.Vw_payroll_tblTableAdapter.Fill(Me.PayrolldbDataSet.vw_payroll_tbl)
                End If
                conn.Close()

            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try
        End If
    End Sub


    Private Sub Vw_payroll_tblDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vw_payroll_tblDataGridView.CellClick

        Dim result As DialogResult = MessageBox.Show("You can Update or Delete this Record", "Update or Delete Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'MessageBox.Show("You pressed No, Record will be remain")
            clearentry()
        ElseIf result = DialogResult.Yes Then
            clearentry()
            Payroll_noComboBox.Text = Vw_payroll_tblDataGridView.CurrentRow.Cells(1).Value.ToString.Trim()
            Period_fromDateTimePicker.Value = Vw_payroll_tblDataGridView.CurrentRow.Cells(2).Value.ToString.Trim()
            Period_toDateTimePicker.Value = Vw_payroll_tblDataGridView.CurrentRow.Cells(3).Value.ToString.Trim()
            department_assigned.Text = Vw_payroll_tblDataGridView.CurrentRow.Cells(9).Value.ToString.Trim()
            'employee_id.Text = Vw_payroll_tblDataGridView.CurrentRow.Cells(4).Value.ToString.Trim()
            Employee_idComboBox.Text = Vw_payroll_tblDataGridView.CurrentRow.Cells(5).Value.ToString.Trim()
            Last_nameTextBox.Text = Vw_payroll_tblDataGridView.CurrentRow.Cells(6).Value.ToString.Trim()
            First_nameTextBox.Text = Vw_payroll_tblDataGridView.CurrentRow.Cells(7).Value.ToString.Trim()
            Middle_nameTextBox.Text = Vw_payroll_tblDataGridView.CurrentRow.Cells(8).Value.ToString.Trim()
            rate_basis_ComboBox.Text = Vw_payroll_tblDataGridView.CurrentRow.Cells(10).Value.ToString.Trim()
            Monthly_rateTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(11).Value.ToString.Trim()).ToString("###,##0.00")
            Daily_rateTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(12).Value.ToString.Trim()).ToString("###,##0.00")
            Hourly_rateTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(13).Value.ToString.Trim()).ToString("###,##0.00")
            Unit_rateTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(14).Value.ToString.Trim()).ToString("###,##0.00")
            Regular_wagesTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(15).Value.ToString.Trim()).ToString("###,##0.00")
            Overtime_amtTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(16).Value.ToString.Trim()).ToString("###,##0.00")
            Allowances_amtTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(17).Value.ToString.Trim()).ToString("###,##0.00")
            Adjustments_amtTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(18).Value.ToString.Trim()).ToString("###,##0.00")
            Worked_daysTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(19).Value.ToString.Trim()).ToString("###,##0.00")
            Absent_daysTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(20).Value.ToString.Trim()).ToString("###,##0.00")
            Absent_amtTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(21).Value.ToString.Trim()).ToString("###,##0.00")
            Lates_in_minTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(22).Value.ToString.Trim()).ToString("###,##0.00")
            Lates_in_amtTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(23).Value.ToString.Trim()).ToString("###,##0.00")
            Cash_advance_amtTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(24).Value.ToString.Trim()).ToString("###,##0.00")
            Sss_med_amtTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(25).Value.ToString.Trim()).ToString("###,##0.00")
            Sss_loan_amtTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(26).Value.ToString.Trim()).ToString("###,##0.00")
            Pag_ibig_amtTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(27).Value.ToString.Trim()).ToString("###,##0.00")
            Phic_amtTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(28).Value.ToString.Trim()).ToString("###,##0.00")
            Wtax_amtTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(29).Value.ToString.Trim()).ToString("###,##0.00")
            Other_ded_amtTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(30).Value.ToString.Trim()).ToString("###,##0.00")
            Other_loans_amtTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(31).Value.ToString.Trim()).ToString("###,##0.00")
            Gross_payTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(32).Value.ToString.Trim()).ToString("###,##0.00")
            Net_payTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(33).Value.ToString.Trim()).ToString("###,##0.00")
            RemarksTextBox.Text = Vw_payroll_tblDataGridView.CurrentRow.Cells(34).Value.ToString.Trim()
            King_coop_loanTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(36).Value.ToString.Trim()).ToString("###,##0.00")
            Lbp_loanTextBox.Text = Double.Parse(Vw_payroll_tblDataGridView.CurrentRow.Cells(37).Value.ToString.Trim()).ToString("###,##0.00")
            IdTextBox.Text = Vw_payroll_tblDataGridView.CurrentRow.Cells(0).Value.ToString.Trim()

            Try
                Dim lb() As Byte = Vw_payroll_tblDataGridView.CurrentRow.Cells(35).Value
                Dim lstr As New System.IO.MemoryStream(lb)
                PhotoPictureBox.Image = Image.FromStream(lstr)
                PhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            Catch ex As Exception
                PhotoPictureBox.Image = My.Resources.DefaultUserImg
            End Try

            calculate_gross()
            calculate_deductions()
            calculate_net_pay()

            btn_save.Enabled = False
            btnCancel.Enabled = True
            btnupdate.Enabled = True
            btndel.Enabled = True

            Period_fromDateTimePicker.Enabled = False
            Period_toDateTimePicker.Enabled = False
            department_assigned.Enabled = False
            Employee_idComboBox.Enabled = False
            rate_basis_ComboBox.Enabled = False
            Monthly_rateTextBox.Enabled = False
            Daily_rateTextBox.Enabled = False
            Hourly_rateTextBox.Enabled = False
            Unit_rateTextBox.Enabled = False

        End If


    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Create New Payroll?", "CREATE NEW PAYROLL", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then
            'MessageBox.Show("Transaction Cancelled!")
            clearentry()
            btn_save.Enabled = True
            btnCancel.Enabled = True
            btnupdate.Enabled = False
            btndel.Enabled = False

            Period_fromDateTimePicker.Enabled = True
            Period_toDateTimePicker.Enabled = True
            department_assigned.Enabled = True
            Employee_idComboBox.Enabled = True
            rate_basis_ComboBox.Enabled = True
            Monthly_rateTextBox.Enabled = True
            Daily_rateTextBox.Enabled = True
            Hourly_rateTextBox.Enabled = True
            Unit_rateTextBox.Enabled = True

            Try
                Dim conn As SqlConnection = New SqlConnection(connection)
                Dim cmd As SqlCommand = New SqlCommand("select top 1 payroll_no from payroll_tbl order by id desc", conn)
                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                sda.Fill(dt)
                If (dt Is Nothing) Then
                    Payroll_noComboBox.Text = "000001"
                Else
                    Dim payroll_no As Double
                    payroll_no = Double.Parse(dt.Rows(0)("payroll_no").ToString()) + 1
                    Payroll_noComboBox.Text = ("00000" + payroll_no.ToString()).PadRight(6)
                End If

            Catch ex As Exception
                Payroll_noComboBox.Text = "000001"
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Cancel transaction?", "Cancel Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then
            MessageBox.Show("Transaction Cancelled!")
            clearentry()
            btn_save.Enabled = False
            btnCancel.Enabled = False
            btnupdate.Enabled = False
            btndel.Enabled = False

            Period_fromDateTimePicker.Enabled = True
            Period_toDateTimePicker.Enabled = True
            department_assigned.Enabled = True
            Employee_idComboBox.Enabled = True
            rate_basis_ComboBox.Enabled = True
            Monthly_rateTextBox.Enabled = True
            Daily_rateTextBox.Enabled = True
            Hourly_rateTextBox.Enabled = True
            Unit_rateTextBox.Enabled = True
        End If
    End Sub

    Private Sub txtbSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbSearch.TextChanged
        Dim query As String
        query = "select * from vw_payroll_tbl WHERE employee_name LIKE '%" + txtbSearch.Text + "%'"
        CommonQuery(query, Vw_payroll_tblDataGridView)
    End Sub

End Class