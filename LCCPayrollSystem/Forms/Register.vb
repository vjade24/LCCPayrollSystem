﻿Public Class Register
    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        'Dashboard.Show()
    End Sub
    Public Sub binddata()
        Dim query As String = "select * from user_tbl"
        CommonQuery(query, DataGridView1)
    End Sub
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        binddata()
        'TODO: This line of code loads data into the 'PayrolldbDataSet.user_tbl' table. You can move, or remove it, as needed.
        Me.User_tblTableAdapter.Fill(Me.PayrolldbDataSet.user_tbl)
        ClearEntry()
        btndel.Enabled = False
        btnedit.Enabled = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim result As DialogResult = MessageBox.Show("You can Update or Delete this Record", "Update or Delete Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then
            txtb_id.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            txtb_full_name.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            txtb_user_name.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            txtb_user_password.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            txtb_user_confirm_password.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            txtb_user_type.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            txtb_id.ReadOnly = True
            btndel.Enabled = True
            btnedit.Enabled = True
            btn_save.Enabled = False

        End If


    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtb_user_password.PasswordChar = ""
            txtb_user_confirm_password.PasswordChar = ""
        Else
            txtb_user_password.PasswordChar = "*"
            txtb_user_confirm_password.PasswordChar = "*"
        End If
    End Sub
    Private Sub txtb_search_TextChanged(sender As Object, e As EventArgs) Handles txtb_search.TextChanged
        Dim query As String = "select * from user_tbl where full_name LIKE '%" + txtb_search.Text.ToString().Trim() + "%' OR user_name LIKE '%" + txtb_search.Text.ToString().Trim() + "%' OR user_type LIKE '%" + txtb_search.Text.ToString().Trim() + "%'"
        CommonQuery(query, DataGridView1)
    End Sub

    Private Sub btndel_Click_1(sender As Object, e As EventArgs) Handles btndel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete this Record?", "DELETE RECORD", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then
            Dim query As String = "delete from user_tbl where id ='" + txtb_id.Text.ToString().Trim() + "'"

            DeleteQuery(query)
            binddata()
            ClearEntry()
        End If

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Create this Record?", "CREATE RECORD", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then
            Dim query As String = "insert into user_tbl values ('" + txtb_full_name.Text.ToString().Trim() + "','" + txtb_user_name.Text.ToString().Trim() + "','" + txtb_user_password.Text.ToString().Trim() + "','" + txtb_user_type.Text.ToString().Trim() + "')"
            If txtb_user_password.Text.ToString().Trim() <> txtb_user_confirm_password.Text.ToString().Trim() Then
                MsgBox("Password not matched!", MsgBoxStyle.Exclamation)
            Else
                InsertQuery(query)
                binddata()
                ClearEntry()
            End If
        End If
    End Sub

    Private Sub btnedit_Click_1(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Update this Record?", "UPDATE RECORD", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then
            Dim query As String = "update user_tbl set full_name = '" + txtb_full_name.Text.ToString().Trim() + "',user_name = '" + txtb_user_name.Text.ToString().Trim() + "',user_password ='" + txtb_user_password.Text.ToString().Trim() + "',user_type='" + txtb_user_type.Text.ToString().Trim() + "' where id ='" + txtb_id.Text.ToString().Trim() + "'"
            If txtb_user_password.Text <> txtb_user_confirm_password.Text Then
                MsgBox("Password not matched!", MsgBoxStyle.Exclamation)
            Else
                UpdateQuery(query)
                binddata()
                ClearEntry()

            End If

        End If


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Cancel this transaction?", "CANCEL TRANSACTION", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then
            ClearEntry()
            txtb_id.ReadOnly = False
            btndel.Enabled = False
            btnedit.Enabled = False
            btn_save.Enabled = True
        End If
    End Sub
    Public Sub ClearEntry()
        txtb_id.Text = ""
        txtb_full_name.Text = ""
        txtb_user_name.Text = ""
        txtb_user_password.Text = ""
        txtb_user_confirm_password.Text = ""
        txtb_user_type.SelectedIndex = 0
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Create new Record?", "CREATE NEW", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'MessageBox.Show("You pressed No, Record will be remain")
        ElseIf result = DialogResult.Yes Then
            ClearEntry()
            txtb_id.ReadOnly = False
            btndel.Enabled = False
            btnedit.Enabled = False
            btn_save.Enabled = True
        End If
    End Sub
End Class