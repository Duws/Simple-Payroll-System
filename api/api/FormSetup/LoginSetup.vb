Imports MySql.Data.MySqlClient

Public Module LoginSetup

    Dim Misc As New Misc
    Dim DB As New DbConnection

    Dim txtUserName As TextBox
    Dim txtPassword As TextBox

    Dim btnGo As Button

    Public Sub setUpForm(form As Form)
        Misc.formProperties(form, "Welcome", "formLogin", FormWindowState.Normal)
    End Sub

    Public Sub createDynamics(form As Form)
        txtUserName = New TextBox
        Misc.txtProperties(form, txtUserName, "UserName", "txtUserName", form.Width / 2 - 85, form.Height / 2 + 35, "", FontStyle.Italic)

        txtPassword = New TextBox
        Misc.txtProperties(form, txtPassword, "Password", "txtPassword", form.Width / 2 - 85, form.Height / 2 + 75, "•", FontStyle.Italic)

        btnGo = New Button
        Dim str As String = Misc.btnProperties(form, btnGo, "Login", "btnLogin", form.Width / 2 - 85, form.Height / 2 + 125)
        AddHandler btnGo.Click, AddressOf btnProperties_Click

    End Sub

    Public Sub btnProperties_Click(ByVal sender As Object, ByVal e As EventArgs)

        'Try
        '    DB.cmd.CommandText = "SELECT username, password FROM users WHERE `username` = @a AND `password` = @b AND deleted_at IS NULL"
        '    DB.cmd.Parameters.AddWithValue("@a", txtUserName.Text)
        '    DB.cmd.Parameters.AddWithValue("@b", txtPassword.Text)
        '    DB.dr = DB.cmd.ExecuteReader()
        '    If DB.dr.Read() Then
        '        DB.dr.Close()
        '        MessageBox.Show("YELLOW")
        '    End If

        '    Try
        '        DB.conn.Open()
        '    Catch ex As Exception
        '    End Try

        Try
            DB.conn.Open()
            Dim cmd As New MySqlCommand(String.Format("SELECT username, password FROM users WHERE `username` = @a AND `password` = @b"))
            cmd.Parameters.AddWithValue("@a", txtUserName.Text)
            cmd.Parameters.AddWithValue("@b", txtPassword.Text)
            cmd.ExecuteNonQuery()
            DB.conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        'While DB.dr.Read()
        '    lbluser.Text = DB.dr("Fname").ToString + " " + DB.dr("Sname").ToString
        '    lblempno.Text = DB.dr("EmpNo").ToString
        '    lblcolon.Text = ":"
        'End While
        'DB.dr.Close()
        'btnokuser.Visible = True

        'If lblempno.Text = "" And txtuser.Text <> "" Or txtuser.Text = "" Then
        '    lblempno.Text = "User Deleted or does not exist"
        '    btnokuser.Visible = False
        'End If

        'lblwelcomeuser.Text = "Welcome, " & lbluser.Text

        'End If
    End Sub

End Module
