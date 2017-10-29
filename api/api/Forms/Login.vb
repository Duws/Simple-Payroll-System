Public Class Login
    Inherits System.Windows.Forms.Form

    Dim DB As New DbConnection

    Public Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.createConnection()
        Call setUpForm(Me)
        Call createDynamics(Me)
    End Sub

End Class
