Public Class Misc

    Public Sub formProperties(form As Form, text As String, name As String, state As FormWindowState)
        With form
            .Name = name
            .Text = text
            .Size = New Size(350, 600)
            .Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (.Height \ 2)
            .Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (.Width \ 2)
            .ControlBox = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = state
        End With
    End Sub

    Public Sub txtProperties(form As Form, txt As TextBox, watermark As String, name As String, x As Integer, y As Integer, passwordChar As String, style As FontStyle)
        With txt
            .Name = name
            .SetWaterMark(watermark)
            .Enabled = True
            .Visible = True
            .Font = New Font("Segoe UI", 12, style)
            .Left = x
            .Top = y
            .Size = New Size(170, 30)
            .ForeColor = Color.Black
            .BackColor = Color.White
            .BorderStyle = BorderStyle.Fixed3D
            .TabStop = False
            .PasswordChar = passwordChar
        End With
        form.Controls.Add(txt)
    End Sub

    Public Sub btnLoginProperties(form As Form, btn As Button, text As String, name As String, x As Integer, y As Integer)
        With btn
            .Name = name
            .Text = text
            .Enabled = True
            .Visible = True
            .FlatStyle = FlatStyle.Flat
            .Font = New Font("Segoe UI", 11.25, FontStyle.Regular)
            .Left = x
            .Top = y
            .Size = New Size(170, 30)
            .ForeColor = Color.Black
            .BackColor = Color.Transparent
            .FlatAppearance.BorderSize = 0.7
            .FlatAppearance.BorderColor = Color.Black
            .Cursor = Cursors.Hand
        End With
        form.Controls.Add(btn)
    End Sub

End Class
