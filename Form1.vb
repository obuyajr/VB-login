
'db connection
Imports System.Data.SqlClient


Public Class Form1
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'www
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from user_login where username = ' " & txt_uname.Text & " ' and password ='" & txt_pwd.Text & "' and usertype = '" & combo_usertype.SelectedItem & "' ", con)

        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()

        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("you are logged in as" + dt.Rows(0)(2))
            If (combo_usertype.SelectedIndex = 0) Then
                Dim a As New Admin
                a.Show()
                Me.Hide()
            Else
                Dim u As New User
                u.Show()
                Me.Hide()
            End If
        Else
                MessageBox.Show("errorrrrrrrr")
        End If



    End Sub


End Class
