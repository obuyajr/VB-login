
Imports System.Data.SqlClient

Public Class Form1
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim connectionString As String = "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True"

        Using con As SqlConnection = New SqlConnection(connectionString)
            con.Open()

            Dim query As String = "SELECT * FROM user_login WHERE username = @username AND password = @password AND usertype = @usertype"
            Dim cmd As SqlCommand = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", txt_uname.Text)
            cmd.Parameters.AddWithValue("@password", txt_pwd.Text)
            cmd.Parameters.AddWithValue("@usertype", combo_usertype.SelectedItem)

            Dim dt As DataTable = New DataTable()
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            sda.Fill(dt)

            If dt.Rows.Count > 0 Then
                MessageBox.Show("You are logged in as " & dt.Rows(0)("usertype").ToString())

                If combo_usertype.SelectedIndex = 0 Then
                    Dim adminForm As New Admin()
                    adminForm.Show()
                Else
                    Dim userForm As New User()
                    userForm.Show()
                End If

                Me.Hide()
            Else
                MessageBox.Show("Invalid username, password, or user type.")
            End If
        End Using
    End Sub
End Class

