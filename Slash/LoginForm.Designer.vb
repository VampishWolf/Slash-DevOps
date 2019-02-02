<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.TextBox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
		Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
		Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Checkbox1 = New Bunifu.Framework.UI.BunifuCheckbox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
		Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
		Me.Panel1.Controls.Add(Me.PictureBox1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(379, 420)
		Me.Panel1.TabIndex = 0
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(-17, 97)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(415, 237)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.White
		Me.TextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
		Me.TextBox1.ForeColor = System.Drawing.Color.Black
		Me.TextBox1.HintForeColor = System.Drawing.Color.Empty
		Me.TextBox1.HintText = "Username"
		Me.TextBox1.isPassword = False
		Me.TextBox1.LineFocusedColor = System.Drawing.Color.LightSkyBlue
		Me.TextBox1.LineIdleColor = System.Drawing.Color.DodgerBlue
		Me.TextBox1.LineMouseHoverColor = System.Drawing.Color.LightSkyBlue
		Me.TextBox1.LineThickness = 3
		Me.TextBox1.Location = New System.Drawing.Point(404, 129)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(193, 31)
		Me.TextBox1.TabIndex = 0
		Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		'
		'BunifuImageButton1
		'
		Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
		Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
		Me.BunifuImageButton1.ImageActive = Nothing
		Me.BunifuImageButton1.Location = New System.Drawing.Point(615, 4)
		Me.BunifuImageButton1.Name = "BunifuImageButton1"
		Me.BunifuImageButton1.Size = New System.Drawing.Size(17, 21)
		Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.BunifuImageButton1.TabIndex = 4
		Me.BunifuImageButton1.TabStop = False
		Me.BunifuImageButton1.Zoom = 10
		'
		'BunifuElipse1
		'
		Me.BunifuElipse1.ElipseRadius = 20
		Me.BunifuElipse1.TargetControl = Me
		'
		'Button1
		'
		Me.Button1.AutoEllipsis = True
		Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.White
		Me.Button1.Location = New System.Drawing.Point(404, 300)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(193, 34)
		Me.Button1.TabIndex = 3
		Me.Button1.Text = "Login"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Checkbox1
		'
		Me.Checkbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
		Me.Checkbox1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
		Me.Checkbox1.Checked = False
		Me.Checkbox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
		Me.Checkbox1.ForeColor = System.Drawing.Color.White
		Me.Checkbox1.Location = New System.Drawing.Point(405, 264)
		Me.Checkbox1.Name = "Checkbox1"
		Me.Checkbox1.Size = New System.Drawing.Size(20, 20)
		Me.Checkbox1.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(427, 271)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(170, 13)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "I agree to the terms and conditions"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(400, 73)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(65, 25)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Login"
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.Color.White
		Me.TextBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
		Me.TextBox2.ForeColor = System.Drawing.Color.Black
		Me.TextBox2.HintForeColor = System.Drawing.Color.Empty
		Me.TextBox2.HintText = "Password"
		Me.TextBox2.isPassword = False
		Me.TextBox2.LineFocusedColor = System.Drawing.Color.LightSkyBlue
		Me.TextBox2.LineIdleColor = System.Drawing.Color.DodgerBlue
		Me.TextBox2.LineMouseHoverColor = System.Drawing.Color.LightSkyBlue
		Me.TextBox2.LineThickness = 3
		Me.TextBox2.Location = New System.Drawing.Point(404, 186)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(193, 31)
		Me.TextBox2.TabIndex = 1
		Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		'
		'NotifyIcon1
		'
		Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
		Me.NotifyIcon1.Text = "NotifyIcon1"
		Me.NotifyIcon1.Visible = True
		'
		'LoginForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(638, 420)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Checkbox1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.BunifuImageButton1)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "LoginForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		Me.Panel1.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Checkbox1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
	Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
