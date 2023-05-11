Imports System.Data.SqlClient
Module CommonClasses
    Public expire_date = "2023-05-20"
    'Public connection = "Data Source=DESKTOP-AD3I7I5\SQLEXPRESS;Initial Catalog=payrolldb;Integrated Security=True"

    Public connection = My.Settings.payrolldbConnectionString
    'Public connection = My.Settings.development

    Dim result As Integer
    Public Sub CommonQuery(query, DataGridView)
        Try
            Using conn As SqlConnection = New SqlConnection(connection)
                Using cmd As SqlCommand = New SqlCommand(query, conn)
                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd
                        Using dt As New DataTable()
                            da.Fill(dt)
                            'Return dt
                            DataGridView.DataSource = dt
                        End Using
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Public Sub SelectQuery(query)
        Try
            Using conn As SqlConnection = New SqlConnection(connection)
                Using cmd As SqlCommand = New SqlCommand(query, conn)
                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd
                        Using dt As New DataTable()
                            da.Fill(dt)
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Public Sub DeleteQuery(query)
        Try
            Using conn As SqlConnection = New SqlConnection(connection)
                Using cmd As SqlCommand = New SqlCommand(query, conn)
                    conn.Open()
                    result = cmd.ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("No Data Deleted!", MsgBoxStyle.Critical)
                    Else
                        MsgBox("Successfully Deleted!", MsgBoxStyle.Information)
                    End If
                    conn.Close()
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Public Sub UpdateQuery(query)
        Try
            Using conn As SqlConnection = New SqlConnection(connection)
                Using cmd As SqlCommand = New SqlCommand(query, conn)
                    conn.Open()
                    result = cmd.ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("No Data Updated!", MsgBoxStyle.Critical)
                    Else
                        MsgBox("Successfully Updated!", MsgBoxStyle.Information)
                    End If
                    conn.Close()
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Public Sub InsertQuery(query)
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            result = cmd.ExecuteNonQuery()
            If result = 0 Then
                MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
            Else
                MsgBox("Successfully Inserted!", MsgBoxStyle.Information)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub
    Public Sub ComboboxQuery(query, Combobox, id, text)
        Try
            Using conn As SqlConnection = New SqlConnection(connection)
                Using cmd As SqlCommand = New SqlCommand(query, conn)
                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd
                        Using dt As New DataSet()
                            da.Fill(dt)
                            'Return dt
                            Combobox.DataSource = dt.Tables(0)
                            Combobox.ValueMember = id
                            Combobox.DisplayMember = text
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Public Function checkisdecimal(TextBox)
        Dim retvalue As Boolean = True
        Dim parm As Decimal
        retvalue = Decimal.TryParse(TextBox.Text, parm)
        Return retvalue
    End Function

    Public Function RetrieveData(query)

        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter()
            da.SelectCommand = cmd
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Return vbNull
        End Try
    End Function

End Module
