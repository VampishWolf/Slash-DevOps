Public Class monitorcontrol
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.SendToBack()

        Me.AutoScroll = False
        Monitorcontrol_in1.Show()
    End Sub
End Class
