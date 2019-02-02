Public Class Dashb
    Private Sub ImageButton3_Click(sender As Object, e As EventArgs) Handles ImageButton3.Click
        End
		Me.Hide()
		LoginForm.Show()
		MsgBox("You have been signed out!")
	End Sub

    Private Sub ImageButton2_Click(sender As Object, e As EventArgs) Handles ImageButton2.Click
        If (WindowState = FormWindowState.Normal) Then
			Me.WindowState = FormWindowState.Maximized

		Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ImageButton1_Click(sender As Object, e As EventArgs) Handles ImageButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SignoutButton5_Click(sender As Object, e As EventArgs) Handles SignoutButton5.Click
        Me.Hide()
        LoginForm.Show()
        MsgBox("You have been signed out!")
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Label1.Hide()
        Testcontrol1.Hide()
        Releasecontrol1.Hide()
        Monitorcontrol1.Hide()
        Buildcontrol1.Show()
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Label1.Hide()
        Buildcontrol1.Hide()
        Releasecontrol1.Hide()
        Monitorcontrol1.Hide()
        Testcontrol1.Show()
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Label1.Hide()
        Buildcontrol1.Hide()
        Monitorcontrol1.Hide()
        Testcontrol1.Hide()
        Releasecontrol1.Show()
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        Label1.Hide()
        Buildcontrol1.Hide()
        Testcontrol1.Hide()
        Releasecontrol1.Hide()
        Monitorcontrol1.Show()
    End Sub

    Private Sub ThinButton1_Click(sender As Object, e As EventArgs) Handles ThinButton1.Click
        Buildcontrol1.Hide()
        Testcontrol1.Hide()
        Releasecontrol1.Hide()
        Monitorcontrol1.Hide()
        Label1.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        If Me.WindowState = FormWindowState.Maximized Then
            Panel2.Height = 1100
        End If

    End Sub

    Private Sub Button1_Hide(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover

        Timer1.Enabled = True
        Timer2.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Panel2.Width > 51 Then
            Panel2.Width -= 12
        ElseIf Panel2.Width = 51 Then
            Timer2.Enabled = False
        End If

    End Sub


    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Panel2.Width < 267 Then
            Panel2.Width += 12
        ElseIf Panel2.Width = 267 Then
            Timer2.Enabled = False
        End If
    End Sub
End Class