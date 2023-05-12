Public Class Deduction
    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        'Dashboard.Show()
    End Sub
    Private Sub Deduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrolldbDataSet.payroll_deduction_tbl' table. You can move, or remove it, as needed.
        Me.Payroll_deduction_tblTableAdapter.Fill(Me.PayrolldbDataSet.payroll_deduction_tbl)
        'TODO: This line of code loads data into the 'PayrolldbDataSet.deduction_list_tbl' table. You can move, or remove it, as needed.
        Me.Deduction_list_tblTableAdapter.Fill(Me.PayrolldbDataSet.deduction_list_tbl)
        Dim query As String = "select id,concat(last_name,',', first_name,' ', middle_name) as full_name from employee_tbl"
        ComboboxQuery(query, Employee_idComboBox, "id", "full_name")
        binddata()
        clearentry()
    End Sub
    Public Sub binddata()
        Dim query As String = "select * from payroll_deduction_tbl"
        CommonQuery(query, Payroll_deduction_tblDataGridView)
    End Sub

    Public Sub clearentry()
        IdTextBox.Text = ""
        Deduction_descrComboBox.SelectedIndex = 0
        Employee_idComboBox.SelectedIndex = 0
        Deduct_period_fromDateTimePicker.Value = DateTime.Now.Month.ToString().Trim() + "/01/" + DateTime.Now.Year().ToString().Trim()
        Deduct_period_toDateTimePicker.Value = DateTime.Parse(Deduct_period_fromDateTimePicker.Value).AddMonths(1).AddDays(-1)
        Deduct_amtTextBox.Text = "0.00"
        IdTextBox.Enabled = False
    End Sub
    Private Sub Payroll_deduction_tblDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Payroll_deduction_tblDataGridView.CellClick
        Dim result As DialogResult = MessageBox.Show("You can Update or Delete this Record", "Update or Delete Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then

            IdTextBox.Text = Payroll_deduction_tblDataGridView.CurrentRow.Cells(0).Value.ToString()
            Deduction_descrComboBox.SelectedValue = Payroll_deduction_tblDataGridView.CurrentRow.Cells(1).Value.ToString()
            Employee_idComboBox.SelectedValue = Payroll_deduction_tblDataGridView.CurrentRow.Cells(3).Value.ToString().Trim()
            Deduct_period_fromDateTimePicker.Value = Payroll_deduction_tblDataGridView.CurrentRow.Cells(5).Value.ToString().Trim()
            Deduct_period_toDateTimePicker.Value = Payroll_deduction_tblDataGridView.CurrentRow.Cells(6).Value.ToString().Trim()
            Deduct_amtTextBox.Text = Double.Parse(Payroll_deduction_tblDataGridView.CurrentRow.Cells(7).Value.ToString().Trim()).ToString("###,##0.00")

            Deduction_descrComboBox.Enabled = False
            Employee_idComboBox.Enabled = False
            btndel.Enabled = True
            Button2.Enabled = True
            btn_save.Enabled = False
            btnupdate.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        clearentry()

        Deduction_descrComboBox.Enabled = True
        Employee_idComboBox.Enabled = True
        btndel.Enabled = False
        Button2.Enabled = False
        btn_save.Enabled = True
    End Sub

    Private Sub txtb_search_TextChanged(sender As Object, e As EventArgs) Handles txtb_search.TextChanged
        Dim query As String = "select * from payroll_deduction_tbl where employee_name LIKE '%" + txtb_search.Text.ToString().Trim() + "%' OR deduction_descr LIKE '%" + txtb_search.Text.ToString().Trim() + "%' OR deduct_amt LIKE '%" + txtb_search.Text.ToString().Trim() + "%'"
        CommonQuery(query, Payroll_deduction_tblDataGridView)
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Update this Record?", "UPDATE RECORD", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then
            Dim query As String = "update payroll_deduction_tbl set deduct_period_from = '" + Deduct_period_fromDateTimePicker.Value + "' , deduct_period_to = '" + Deduct_period_toDateTimePicker.Value + "', deduct_amt='" + Double.Parse(Deduct_amtTextBox.Text).ToString() + "' where id = '" + IdTextBox.Text + "'"
            UpdateQuery(query)
            binddata()
            clearentry()

            btndel.Enabled = True
            Button2.Enabled = True
            btn_save.Enabled = False
            btnupdate.Enabled = False
        End If

    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs)
        Dim query As String = "insert into payroll_deduction_tbl values ('" + Deduction_descrComboBox.SelectedValue.ToString().Trim() + "','" + Deduction_descrComboBox.Text.ToString().Trim() + "','" + Employee_idComboBox.SelectedValue.ToString().Trim() + "','" + Employee_idComboBox.Text.ToString().Trim() + "','" + DateTime.Parse(Deduct_period_fromDateTimePicker.Value.ToString().Trim()) + "','" + DateTime.Parse(Deduct_period_toDateTimePicker.Value.ToString().Trim()) + "','" + Double.Parse(Deduct_amtTextBox.Text.ToString().Trim()).ToString + "')"
        InsertQuery(query)
        binddata()
        clearentry()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        clearentry()

        Deduction_descrComboBox.Enabled = True
        Employee_idComboBox.Enabled = True
        btndel.Enabled = False
        Button2.Enabled = False
        btn_save.Enabled = True
        btnupdate.Enabled = False
    End Sub

    Private Sub btndel_Click_1(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete this Record?", "DELETE RECORD", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then
            Dim query As String = "delete from payroll_deduction_tbl where id = " + IdTextBox.Text + ""
            DeleteQuery(query)
            binddata()
            clearentry()
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Create New Record?", "CREATE NEW", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            clearentry()

            Deduction_descrComboBox.Enabled = True
            Employee_idComboBox.Enabled = True
            btndel.Enabled = False
            Button2.Enabled = False
            btn_save.Enabled = True
            btnupdate.Enabled = False

        End If

    End Sub

End Class