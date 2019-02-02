Imports System.Data.SqlClient

Public Class testcontrol

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		ProgressBar1.Maximum_Value = 100
		ProgressBar1.Value = 0
		Label4.Hide()
		Timer1.Start()

		sql = "insert into testrep Values ('" & ComboBox1.Text & "','" & BunifuMetroTextbox1.Text & "','" & BunifuMetroTextbox2.Text & "','" & DateTimePicker1.Text & "','" & BunifuMetroTextbox3.Text & "')"
		cmd = New SqlClient.SqlCommand(sql, conn)
		Try
			cmd.ExecuteNonQuery()

		Catch ae As SqlException
			MessageBox.Show(ae.Message.ToString())
		End Try



	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		ProgressBar1.Value += 5
		If ProgressBar1.Value = 100 Then
			Timer1.Stop()
			Label4.Show()
			NotifyIcon2.BalloonTipText = "Details have been recorded."
			NotifyIcon2.BalloonTipTitle = "Test Completed!"
			NotifyIcon2.Visible = True
			NotifyIcon2.ShowBalloonTip(0)

		End If

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub testcontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim connection As New SqlConnection(connectionstring)
		Dim table As New DataTable()
		Dim adapter As New SqlDataAdapter("SELECT * FROM buildrep", connection)

		adapter.Fill(table)

		ComboBox1.DataSource = table
		ComboBox1.DisplayMember = "BuildName"

		DateTimePicker1.MinDate = DateTime.Now
		DateTimePicker2.MinDate = DateTime.Now
	End Sub

	Private Sub listBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
		BunifuMetroTextbox3.Text = ListBox1.Text
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		Label18.Hide()
		Dim connection As New SqlConnection(connectionstring)
		Dim table As New DataTable()
		Dim adapter As New SqlDataAdapter("SELECT * FROM testrep", connection)
		BunifuCustomDataGrid2.Hide()
		adapter.Fill(table)
		BunifuCustomDataGrid1.Show()
		BunifuCustomDataGrid1.DataSource = table
	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		Label18.Hide()
		Dim connection As New SqlConnection(connectionstring)
		Dim table As New DataTable()
		Dim adapter As New SqlDataAdapter("SELECT * FROM schtest", connection)
		BunifuCustomDataGrid1.Hide()
		adapter.Fill(table)
		BunifuCustomDataGrid2.Show()
		BunifuCustomDataGrid2.DataSource = table
	End Sub

	Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
		BunifuCards1.Show()
		BunifuCards2.Hide()
		Button5.Hide()
		Button6.Hide()


	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		BunifuCards1.Hide()
		BunifuCards2.Show()
		Label18.Show()
		Button5.Show()
		Button6.Show()
		BunifuCustomDataGrid1.Hide()
		BunifuCustomDataGrid2.Hide()
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		sql = "insert into schtest Values ('" & ComboBox1.Text & "','" & BunifuMetroTextbox1.Text & "','" & BunifuMetroTextbox2.Text & "','" & BunifuMetroTextbox3.Text & "','" & DateTimePicker2.Text & "','" & BunifuMetroTextbox4.Text & "','" & BunifuMetroTextbox5.Text & "')"
		cmd = New SqlClient.SqlCommand(sql, conn)
		Try
			cmd.ExecuteNonQuery()

		Catch ae As SqlException
			MessageBox.Show(ae.Message.ToString())
		End Try

		Label17.Show()
		NotifyIcon1.BalloonTipText = "It will be processed at the respective time."
		NotifyIcon1.BalloonTipTitle = "Test has been scheduled!"
		NotifyIcon1.Visible = True
		NotifyIcon1.ShowBalloonTip(0)

	End Sub
End Class
