Imports MySql.Data.MySqlClient

Public Class DbConnection
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public adaptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public con As New MySqlConnection

    Public Sub connect()
        Dim DatabaseName As String = "payroll"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

End Class
