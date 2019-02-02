<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashb
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashb))
		Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
		Me.Button1 = New Bunifu.Framework.UI.BunifuImageButton()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.ThinButton1 = New Bunifu.Framework.UI.BunifuThinButton2()
		Me.ImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
		Me.ImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
		Me.ImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.SignoutButton5 = New Bunifu.Framework.UI.BunifuImageButton()
		Me.Button4 = New Bunifu.Framework.UI.BunifuImageButton()
		Me.FlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
		Me.FlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
		Me.FlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
		Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
		Me.FlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Monitorcontrol1 = New Slash.monitorcontrol()
		Me.Releasecontrol1 = New Slash.releasecontrol()
		Me.Testcontrol1 = New Slash.testcontrol()
		Me.Buildcontrol1 = New Slash.buildcontrol()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
		CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		CType(Me.ImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SignoutButton5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Button4, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(188, Byte), Integer))
		resources.ApplyResources(Me.Button1, "Button1")
		Me.BunifuTransition1.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
		Me.Button1.ImageActive = Nothing
		Me.Button1.Name = "Button1"
		Me.Button1.TabStop = False
		Me.Button1.Zoom = 10
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(188, Byte), Integer))
		Me.Panel1.Controls.Add(Me.ThinButton1)
		Me.Panel1.Controls.Add(Me.ImageButton1)
		Me.Panel1.Controls.Add(Me.ImageButton2)
		Me.Panel1.Controls.Add(Me.ImageButton3)
		Me.Panel1.Controls.Add(Me.Button1)
		Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
		resources.ApplyResources(Me.Panel1, "Panel1")
		Me.Panel1.Name = "Panel1"
		'
		'ThinButton1
		'
		Me.ThinButton1.ActiveBorderThickness = 1
		Me.ThinButton1.ActiveCornerRadius = 20
		Me.ThinButton1.ActiveFillColor = System.Drawing.Color.Transparent
		Me.ThinButton1.ActiveForecolor = System.Drawing.Color.Transparent
		Me.ThinButton1.ActiveLineColor = System.Drawing.Color.Transparent
		Me.ThinButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(188, Byte), Integer))
		resources.ApplyResources(Me.ThinButton1, "ThinButton1")
		Me.ThinButton1.ButtonText = "Slash Dashboard"
		Me.ThinButton1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.BunifuTransition1.SetDecoration(Me.ThinButton1, BunifuAnimatorNS.DecorationType.None)
		Me.ThinButton1.ForeColor = System.Drawing.Color.Transparent
		Me.ThinButton1.IdleBorderThickness = 1
		Me.ThinButton1.IdleCornerRadius = 20
		Me.ThinButton1.IdleFillColor = System.Drawing.Color.Transparent
		Me.ThinButton1.IdleForecolor = System.Drawing.Color.Transparent
		Me.ThinButton1.IdleLineColor = System.Drawing.Color.Transparent
		Me.ThinButton1.Name = "ThinButton1"
		Me.ThinButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ImageButton1
		'
		resources.ApplyResources(Me.ImageButton1, "ImageButton1")
		Me.ImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(188, Byte), Integer))
		Me.BunifuTransition1.SetDecoration(Me.ImageButton1, BunifuAnimatorNS.DecorationType.None)
		Me.ImageButton1.ImageActive = Nothing
		Me.ImageButton1.Name = "ImageButton1"
		Me.ImageButton1.TabStop = False
		Me.ImageButton1.Zoom = 10
		'
		'ImageButton2
		'
		resources.ApplyResources(Me.ImageButton2, "ImageButton2")
		Me.ImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(188, Byte), Integer))
		Me.BunifuTransition1.SetDecoration(Me.ImageButton2, BunifuAnimatorNS.DecorationType.None)
		Me.ImageButton2.ImageActive = Nothing
		Me.ImageButton2.Name = "ImageButton2"
		Me.ImageButton2.TabStop = False
		Me.ImageButton2.Zoom = 10
		'
		'ImageButton3
		'
		resources.ApplyResources(Me.ImageButton3, "ImageButton3")
		Me.ImageButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(188, Byte), Integer))
		Me.BunifuTransition1.SetDecoration(Me.ImageButton3, BunifuAnimatorNS.DecorationType.None)
		Me.ImageButton3.ImageActive = Nothing
		Me.ImageButton3.Name = "ImageButton3"
		Me.ImageButton3.TabStop = False
		Me.ImageButton3.Zoom = 10
		'
		'FlowLayoutPanel1
		'
		Me.BunifuTransition1.SetDecoration(Me.FlowLayoutPanel1, BunifuAnimatorNS.DecorationType.None)
		resources.ApplyResources(Me.FlowLayoutPanel1, "FlowLayoutPanel1")
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		'
		'PictureBox1
		'
		resources.ApplyResources(Me.PictureBox1, "PictureBox1")
		Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.TabStop = False
		'
		'SignoutButton5
		'
		resources.ApplyResources(Me.SignoutButton5, "SignoutButton5")
		Me.SignoutButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.BunifuTransition1.SetDecoration(Me.SignoutButton5, BunifuAnimatorNS.DecorationType.None)
		Me.SignoutButton5.ImageActive = Nothing
		Me.SignoutButton5.Name = "SignoutButton5"
		Me.SignoutButton5.TabStop = False
		Me.SignoutButton5.Tag = ""
		Me.SignoutButton5.Zoom = 10
		'
		'Button4
		'
		resources.ApplyResources(Me.Button4, "Button4")
		Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.BunifuTransition1.SetDecoration(Me.Button4, BunifuAnimatorNS.DecorationType.None)
		Me.Button4.ImageActive = Nothing
		Me.Button4.Name = "Button4"
		Me.Button4.TabStop = False
		Me.Button4.Zoom = 10
		'
		'FlatButton3
		'
		Me.FlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
		Me.FlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		resources.ApplyResources(Me.FlatButton3, "FlatButton3")
		Me.FlatButton3.BorderRadius = 0
		Me.FlatButton3.ButtonText = "     Release"
		Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
		Me.BunifuTransition1.SetDecoration(Me.FlatButton3, BunifuAnimatorNS.DecorationType.None)
		Me.FlatButton3.DisabledColor = System.Drawing.Color.Gray
		Me.FlatButton3.Iconcolor = System.Drawing.Color.Transparent
		Me.FlatButton3.Iconimage = CType(resources.GetObject("FlatButton3.Iconimage"), System.Drawing.Image)
		Me.FlatButton3.Iconimage_right = Nothing
		Me.FlatButton3.Iconimage_right_Selected = Nothing
		Me.FlatButton3.Iconimage_Selected = Nothing
		Me.FlatButton3.IconMarginLeft = 0
		Me.FlatButton3.IconMarginRight = 0
		Me.FlatButton3.IconRightVisible = True
		Me.FlatButton3.IconRightZoom = 0R
		Me.FlatButton3.IconVisible = True
		Me.FlatButton3.IconZoom = 40.0R
		Me.FlatButton3.IsTab = True
		Me.FlatButton3.Name = "FlatButton3"
		Me.FlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.FlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.FlatButton3.OnHoverTextColor = System.Drawing.Color.RoyalBlue
		Me.FlatButton3.selected = False
		Me.FlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.FlatButton3.Textcolor = System.Drawing.Color.Silver
		Me.FlatButton3.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		'
		'FlatButton4
		'
		Me.FlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
		Me.FlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		resources.ApplyResources(Me.FlatButton4, "FlatButton4")
		Me.FlatButton4.BorderRadius = 0
		Me.FlatButton4.ButtonText = "     Monitor"
		Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
		Me.BunifuTransition1.SetDecoration(Me.FlatButton4, BunifuAnimatorNS.DecorationType.None)
		Me.FlatButton4.DisabledColor = System.Drawing.Color.Gray
		Me.FlatButton4.Iconcolor = System.Drawing.Color.Transparent
		Me.FlatButton4.Iconimage = CType(resources.GetObject("FlatButton4.Iconimage"), System.Drawing.Image)
		Me.FlatButton4.Iconimage_right = Nothing
		Me.FlatButton4.Iconimage_right_Selected = Nothing
		Me.FlatButton4.Iconimage_Selected = Nothing
		Me.FlatButton4.IconMarginLeft = 0
		Me.FlatButton4.IconMarginRight = 0
		Me.FlatButton4.IconRightVisible = True
		Me.FlatButton4.IconRightZoom = 0R
		Me.FlatButton4.IconVisible = True
		Me.FlatButton4.IconZoom = 40.0R
		Me.FlatButton4.IsTab = True
		Me.FlatButton4.Name = "FlatButton4"
		Me.FlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.FlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.FlatButton4.OnHoverTextColor = System.Drawing.Color.RoyalBlue
		Me.FlatButton4.selected = False
		Me.FlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.FlatButton4.Textcolor = System.Drawing.Color.Silver
		Me.FlatButton4.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		'
		'FlatButton2
		'
		Me.FlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
		Me.FlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		resources.ApplyResources(Me.FlatButton2, "FlatButton2")
		Me.FlatButton2.BorderRadius = 0
		Me.FlatButton2.ButtonText = "     Test"
		Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.BunifuTransition1.SetDecoration(Me.FlatButton2, BunifuAnimatorNS.DecorationType.None)
		Me.FlatButton2.DisabledColor = System.Drawing.Color.Gray
		Me.FlatButton2.Iconcolor = System.Drawing.Color.Transparent
		Me.FlatButton2.Iconimage = CType(resources.GetObject("FlatButton2.Iconimage"), System.Drawing.Image)
		Me.FlatButton2.Iconimage_right = Nothing
		Me.FlatButton2.Iconimage_right_Selected = Nothing
		Me.FlatButton2.Iconimage_Selected = Nothing
		Me.FlatButton2.IconMarginLeft = 0
		Me.FlatButton2.IconMarginRight = 0
		Me.FlatButton2.IconRightVisible = True
		Me.FlatButton2.IconRightZoom = 0R
		Me.FlatButton2.IconVisible = True
		Me.FlatButton2.IconZoom = 40.0R
		Me.FlatButton2.IsTab = True
		Me.FlatButton2.Name = "FlatButton2"
		Me.FlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.FlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.FlatButton2.OnHoverTextColor = System.Drawing.Color.RoyalBlue
		Me.FlatButton2.selected = False
		Me.FlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.FlatButton2.Textcolor = System.Drawing.Color.Silver
		Me.FlatButton2.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		'
		'BunifuTransition1
		'
		Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
		Me.BunifuTransition1.Cursor = Nothing
		Animation1.AnimateOnlyDifferences = True
		Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
		Animation1.LeafCoeff = 0!
		Animation1.MaxTime = 1.0!
		Animation1.MinTime = 0!
		Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
		Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
		Animation1.MosaicSize = 0
		Animation1.Padding = New System.Windows.Forms.Padding(0)
		Animation1.RotateCoeff = 0!
		Animation1.RotateLimit = 0!
		Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
		Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
		Animation1.TimeCoeff = 0!
		Animation1.TransparencyCoeff = 0!
		Me.BunifuTransition1.DefaultAnimation = Animation1
		'
		'FlatButton1
		'
		Me.FlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
		resources.ApplyResources(Me.FlatButton1, "FlatButton1")
		Me.FlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
		Me.FlatButton1.BorderRadius = 0
		Me.FlatButton1.ButtonText = "     Build"
		Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.BunifuTransition1.SetDecoration(Me.FlatButton1, BunifuAnimatorNS.DecorationType.None)
		Me.FlatButton1.DisabledColor = System.Drawing.Color.Gray
		Me.FlatButton1.Iconcolor = System.Drawing.Color.Transparent
		Me.FlatButton1.Iconimage = CType(resources.GetObject("FlatButton1.Iconimage"), System.Drawing.Image)
		Me.FlatButton1.Iconimage_right = Nothing
		Me.FlatButton1.Iconimage_right_Selected = Nothing
		Me.FlatButton1.Iconimage_Selected = Nothing
		Me.FlatButton1.IconMarginLeft = 0
		Me.FlatButton1.IconMarginRight = 0
		Me.FlatButton1.IconRightVisible = True
		Me.FlatButton1.IconRightZoom = 0R
		Me.FlatButton1.IconVisible = True
		Me.FlatButton1.IconZoom = 40.0R
		Me.FlatButton1.IsTab = True
		Me.FlatButton1.Name = "FlatButton1"
		Me.FlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.FlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.FlatButton1.OnHoverTextColor = System.Drawing.Color.RoyalBlue
		Me.FlatButton1.selected = True
		Me.FlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.FlatButton1.Textcolor = System.Drawing.Color.Silver
		Me.FlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
		Me.Panel2.Controls.Add(Me.PictureBox1)
		Me.Panel2.Controls.Add(Me.SignoutButton5)
		Me.Panel2.Controls.Add(Me.Button4)
		Me.Panel2.Controls.Add(Me.FlatButton3)
		Me.Panel2.Controls.Add(Me.FlatButton4)
		Me.Panel2.Controls.Add(Me.FlatButton2)
		Me.Panel2.Controls.Add(Me.FlatButton1)
		Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
		resources.ApplyResources(Me.Panel2, "Panel2")
		Me.Panel2.Name = "Panel2"
		'
		'Label1
		'
		resources.ApplyResources(Me.Label1, "Label1")
		Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
		Me.Label1.Name = "Label1"
		'
		'Monitorcontrol1
		'
		resources.ApplyResources(Me.Monitorcontrol1, "Monitorcontrol1")
		Me.BunifuTransition1.SetDecoration(Me.Monitorcontrol1, BunifuAnimatorNS.DecorationType.None)
		Me.Monitorcontrol1.Name = "Monitorcontrol1"
		'
		'Releasecontrol1
		'
		resources.ApplyResources(Me.Releasecontrol1, "Releasecontrol1")
		Me.BunifuTransition1.SetDecoration(Me.Releasecontrol1, BunifuAnimatorNS.DecorationType.None)
		Me.Releasecontrol1.Name = "Releasecontrol1"
		'
		'Testcontrol1
		'
		resources.ApplyResources(Me.Testcontrol1, "Testcontrol1")
		Me.BunifuTransition1.SetDecoration(Me.Testcontrol1, BunifuAnimatorNS.DecorationType.None)
		Me.Testcontrol1.Name = "Testcontrol1"
		'
		'Buildcontrol1
		'
		resources.ApplyResources(Me.Buildcontrol1, "Buildcontrol1")
		Me.BunifuTransition1.SetDecoration(Me.Buildcontrol1, BunifuAnimatorNS.DecorationType.None)
		Me.Buildcontrol1.Name = "Buildcontrol1"
		'
		'Timer1
		'
		Me.Timer1.Interval = 10
		'
		'Timer2
		'
		Me.Timer2.Interval = 10
		'
		'Dashb
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Monitorcontrol1)
		Me.Controls.Add(Me.Releasecontrol1)
		Me.Controls.Add(Me.Testcontrol1)
		Me.Controls.Add(Me.Buildcontrol1)
		Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Dashb"
		CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		CType(Me.ImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SignoutButton5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Button4, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button1 As Bunifu.Framework.UI.BunifuImageButton
	Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
	Friend WithEvents Panel1 As Panel
	Friend WithEvents ThinButton1 As Bunifu.Framework.UI.BunifuThinButton2
	Friend WithEvents ImageButton1 As Bunifu.Framework.UI.BunifuImageButton
	Friend WithEvents ImageButton2 As Bunifu.Framework.UI.BunifuImageButton
	Friend WithEvents ImageButton3 As Bunifu.Framework.UI.BunifuImageButton
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents SignoutButton5 As Bunifu.Framework.UI.BunifuImageButton
	Friend WithEvents Button4 As Bunifu.Framework.UI.BunifuImageButton
	Friend WithEvents FlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
	Friend WithEvents FlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
	Friend WithEvents FlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
	Friend WithEvents FlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Timer1 As Timer
	Friend WithEvents Buildcontrol1 As buildcontrol
	Friend WithEvents Testcontrol1 As testcontrol
	Friend WithEvents Releasecontrol1 As releasecontrol
	Friend WithEvents Monitorcontrol1 As monitorcontrol
	Friend WithEvents Label1 As Label
	Friend WithEvents Timer2 As Timer
End Class
