Public Class Login
    Inherits System.Windows.Forms.Form

    Dim DB As New DbConnection

    Public Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.connect()
        Call LoginSetup.setUpForm(Me)
        Call LoginSetup.createDynamics(Me)

    End Sub

End Class
