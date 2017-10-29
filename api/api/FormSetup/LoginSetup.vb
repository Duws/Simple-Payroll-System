Imports MySql.Data.MySqlClient

Public Module LoginSetup

    Dim Misc As New Misc
    Dim DB As New DbConnection

    Dim txtUserName As TextBox
    Dim txtPassword As TextBox

    Dim btnGo As Button

    Dim TRIES As Integer = 5

    Public Sub setUpForm(form As Form)
        Misc.formProperties(form, "Welcome", "formLogin", FormWindowState.Normal)
    End Sub

    Public Sub createDynamics(form As Form)
        txtUserName = New TextBox
        Misc.txtProperties(form, txtUserName, "Username", "txtUserName", form.Width / 2 - 85, form.Height / 2 + 35, "", FontStyle.Italic)

        txtPassword = New TextBox
        Misc.txtProperties(form, txtPassword, "Password", "txtPassword", form.Width / 2 - 85, form.Height / 2 + 75, "•", FontStyle.Italic)

        btnGo = New Button
        Misc.btnLoginProperties(form, btnGo, "Login", "btnLogin", form.Width / 2 - 85, form.Height / 2 + 125)
        AddHandler btnGo.Click, AddressOf btnLoginProperties_Click

    End Sub

    Public Sub btnLoginProperties_Click(ByVal sender As Object, ByVal e As EventArgs)
        DB.createConnection()
        Try
            DB.cmd.CommandText = "SELECT username, password, is_admin, deleted_at FROM users WHERE `username` = @a AND `password` = @b AND deleted_at IS NULL"
            DB.cmd.Parameters.AddWithValue("@a", txtUserName.Text)
            DB.cmd.Parameters.AddWithValue("@b", txtPassword.Text)
            DB.dr = DB.cmd.ExecuteReader()
            If DB.dr.Read() Then
                Dim isAdmin As Boolean = DB.dr("is_admin").ToString()
                DB.dr.Close()
                If isAdmin Then
                    MsgBox("YAY")
                Else
                    MsgBox("NAY")
                End If
            Else
                TRIES -= 1
                MsgBox("Incorrect Username/Password" + vbNewLine + "Number of Tries Remaining : " + TRIES.ToString, MessageBoxIcon.Error, "Error")
                If TRIES <= 0 Then
                    Application.Exit()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
