Public Class monitorcontrol_in
	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Label10.Visible = True
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Process.Start("cmd", "/k ping -n 5 """ & Textbox1.Text & """")
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Process.Start("cmd", "/k nslookup """ & Textbox1.Text & """")
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Process.Start("cmd", "/k netstat -o")
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		Process.Start("cmd", "/k netstat -e -t 3")
	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		Process.Start("cmd", "/k tasklist")
	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		Process.Start("cmd", "/k tracert """ & Textbox1.Text & """")
	End Sub
End Class
