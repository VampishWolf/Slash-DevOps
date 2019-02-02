Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class LoginForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sql = "select * from LoginTable where Username ='" & TextBox1.Text & "' AND Password = '" & TextBox2.Text & "'"
        cmd = New SqlCommand(sql, conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader


		If TextBox1.Text.Count <= 0 Then
			MessageBox.Show("Please enter the Username!")
			Exit Sub
		ElseIf TextBox2.Text = "" Then
			MessageBox.Show("Please enter the Password!")
			Exit Sub
		ElseIf Checkbox1.Checked = False Then
			MessageBox.Show("Please accept the terms and conditions!")
			Exit Sub
		End If


			Try
            If dr.Read = False Then
                MessageBox.Show(“Invalid User or Password!”)
            Else
                Me.Hide()

				NotifyIcon1.BalloonTipText = "Welcome to SLASH Dashboard."
				NotifyIcon1.BalloonTipTitle = "You've been logged in!"
				NotifyIcon1.Visible = True
				NotifyIcon1.ShowBalloonTip(0)
				Dashb.Show()
			End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr.Close()

    End Sub

	Private Sub TextBox2_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox2.OnValueChanged
		TextBox2.isPassword = True
	End Sub
End Class
