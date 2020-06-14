Public Class Form1
    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Environment.Exit(0)
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else : Me.WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
