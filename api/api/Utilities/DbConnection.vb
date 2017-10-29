Imports MySql.Data.MySqlClient

Public Class DbConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public adaptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public con As New MySqlConnection

    Public Sub createConnection()
        cmd.Parameters.Clear()
        Try
            con = New MySqlConnection("host=127.0.0.1; database=payroll; uid=root")

            con.Open()
            cmd.Connection = Me.con
            cmd.CommandType = CommandType.Text
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class
