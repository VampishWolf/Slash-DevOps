Imports System.Data.SqlClient
Public Class releasecontrol

	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Panel1.Show()
		Dim connection As New SqlConnection(connectionstring)
		Dim table As New DataTable()
		Dim adapter As New SqlDataAdapter("SELECT * FROM buildrep", connection)

		adapter.Fill(table)

		ComboBox6.DataSource = table
		ComboBox6.DisplayMember = "clientid"
	End Sub

	Private Sub Button7_click(sender As Object, e As EventArgs) Handles Button7.Click
		BunifuCards1.Hide()
		Panel2.Show()
		Dim connection As New SqlConnection(connectionstring)
		Dim table As New DataTable()
		Dim adapter As New SqlDataAdapter("SELECT * FROM clienttable", connection)

		adapter.Fill(table)

		BunifuCustomDataGrid2.DataSource = table
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Panel1.Hide()
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		sql = "insert into clienttable Values ('" & ComboBox6.Text & "','" & BunifuMetroTextbox6.Text & "','" & BunifuMetroTextbox7.Text & "')"
		cmd = New SqlClient.SqlCommand(sql, conn)
		Try
			cmd.ExecuteNonQuery()

		Catch ae As SqlException
			MessageBox.Show(ae.Message.ToString())
		End Try
		NotifyIcon1.BalloonTipText = "Provided detalis were saved."
		NotifyIcon1.BalloonTipTitle = "Client was successfully registered!"
		NotifyIcon1.Visible = True
		NotifyIcon1.ShowBalloonTip(0)
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		ProgressBar1.Value += 5
		If ProgressBar1.Value = 100 Then
			Timer1.Stop()
			Label12.Show()
		End If
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		ProgressBar1.Maximum_Value = 100
		ProgressBar1.Value = 0

		Timer1.Start()


		sql = "insert into releaserep Values ('" & ComboBox1.Text & "','" & DateTimePicker1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox5.Text & "')"
		cmd = New SqlClient.SqlCommand(sql, conn)
		Try
			cmd.ExecuteNonQuery()

		Catch ae As SqlException
			MessageBox.Show(ae.Message.ToString())
		End Try
		NotifyIcon1.BalloonTipText = "We made the node entry."
		NotifyIcon1.BalloonTipTitle = "The build was successfully released!"
		NotifyIcon1.Visible = True
		NotifyIcon1.ShowBalloonTip(0)
	End Sub

	Private Sub releasecontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		DateTimePicker1.MinDate = DateTime.Now
		Dim connection As New SqlConnection(connectionstring)
		Dim table As New DataTable()
		Dim adapter As New SqlDataAdapter("SELECT * FROM buildrep", connection)

		adapter.Fill(table)

		ComboBox1.DataSource = table
		ComboBox1.DisplayMember = "BuildName"

	End Sub

	Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
		Dim connection As New SqlConnection(connectionstring)
		Dim table As New DataTable()
		Dim adapter As New SqlDataAdapter("SELECT * FROM buildrep where BuildName = '"& ComboBox1.Text &"'", connection)

		adapter.Fill(table)

		ComboBox2.DataSource = table
		ComboBox2.DisplayMember = "Version"

		ComboBox3.DataSource = table
		ComboBox3.DisplayMember = "Clientid"

	End Sub



	Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged
		Dim connection As New SqlConnection(connectionstring)
		Dim table As New DataTable()
		Dim adapter As New SqlDataAdapter("SELECT * FROM clienttable where ClientID = '" & ComboBox3.Text & "'", connection)

		adapter.Fill(table)

		ComboBox4.DataSource = table
		ComboBox4.DisplayMember = "ConsignmentID"

		ComboBox5.DataSource = table
		ComboBox5.DisplayMember = "TrackID"
	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		If BunifuCards1.Visible = False Then
			BunifuCards1.Show()
			Dim connection As New SqlConnection(connectionstring)
			Dim table As New DataTable()
			Dim adapter As New SqlDataAdapter("SELECT * FROM releaserep", connection)

			adapter.Fill(table)
			BunifuCustomDataGrid1.Show()
			BunifuCustomDataGrid1.DataSource = table
		ElseIf BunifuCards1.Visible = True Then
			BunifuCards1.Hide()
		End If
	End Sub



	Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
		Panel2.Hide()
		Panel1.Show()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Panel2.Hide()
	End Sub


End Class
