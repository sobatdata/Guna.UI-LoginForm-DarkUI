<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnLogin = New Guna.UI.WinForms.GunaPanel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.pnSignup = New Guna.UI.WinForms.GunaPanel()
        Me.GunaTextBox5 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaTextBox3 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTextBox4 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaTransition1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControl2 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.pnLogin.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnSignup.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnLogin
        '
        Me.pnLogin.Controls.Add(Me.GunaButton1)
        Me.pnLogin.Controls.Add(Me.GunaLinkLabel1)
        Me.pnLogin.Controls.Add(Me.GunaGradientButton1)
        Me.pnLogin.Controls.Add(Me.GunaTextBox2)
        Me.pnLogin.Controls.Add(Me.GunaLabel4)
        Me.pnLogin.Controls.Add(Me.GunaTextBox1)
        Me.pnLogin.Controls.Add(Me.GunaLabel3)
        Me.pnLogin.Controls.Add(Me.GunaLabel2)
        Me.pnLogin.Controls.Add(Me.GunaLabel1)
        Me.pnLogin.Controls.Add(Me.GunaPictureBox1)
        Me.GunaTransition1.SetDecoration(Me.pnLogin, Guna.UI.Animation.DecorationType.None)
        Me.pnLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnLogin.Location = New System.Drawing.Point(0, 0)
        Me.pnLogin.Name = "pnLogin"
        Me.pnLogin.Size = New System.Drawing.Size(846, 529)
        Me.pnLogin.TabIndex = 0
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaTransition1.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaButton1.ImageSize = New System.Drawing.Size(22, 22)
        Me.GunaButton1.Location = New System.Drawing.Point(728, 38)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = CType(resources.GetObject("GunaButton1.OnHoverImage"), System.Drawing.Image)
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(94, 32)
        Me.GunaButton1.TabIndex = 9
        Me.GunaButton1.Text = "Sign Up"
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.White
        Me.GunaLinkLabel1.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.GunaLinkLabel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.GunaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(366, 380)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(126, 15)
        Me.GunaLinkLabel1.TabIndex = 8
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "Forget your password?"
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton1.AnimationSpeed = 0.03!
        Me.GunaGradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaTransition1.SetDecoration(Me.GunaGradientButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.Image = Nothing
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(306, 333)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 2
        Me.GunaGradientButton1.Size = New System.Drawing.Size(248, 37)
        Me.GunaGradientButton1.TabIndex = 7
        Me.GunaGradientButton1.Text = "Login"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.GunaTextBox2.BorderSize = 1
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTransition1.SetDecoration(Me.GunaTextBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox2.ForeColor = System.Drawing.Color.White
        Me.GunaTextBox2.Location = New System.Drawing.Point(306, 266)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.Radius = 2
        Me.GunaTextBox2.Size = New System.Drawing.Size(248, 37)
        Me.GunaTextBox2.TabIndex = 6
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.GunaLabel4, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(302, 244)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(67, 19)
        Me.GunaLabel4.TabIndex = 5
        Me.GunaLabel4.Text = "Password"
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.GunaTextBox1.BorderSize = 1
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTransition1.SetDecoration(Me.GunaTextBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox1.ForeColor = System.Drawing.Color.White
        Me.GunaTextBox1.Location = New System.Drawing.Point(306, 191)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Radius = 2
        Me.GunaTextBox1.Size = New System.Drawing.Size(248, 37)
        Me.GunaTextBox1.TabIndex = 4
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.GunaLabel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(302, 169)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(41, 19)
        Me.GunaLabel3.TabIndex = 3
        Me.GunaLabel3.Text = "Email"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.GunaLabel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(303, 140)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(79, 15)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Let's join us :)"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.GunaLabel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(301, 110)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(191, 28)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Here you can login"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTransition1.SetDecoration(Me.GunaPictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 423)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(846, 106)
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'pnSignup
        '
        Me.pnSignup.Controls.Add(Me.GunaTextBox5)
        Me.pnSignup.Controls.Add(Me.GunaLabel9)
        Me.pnSignup.Controls.Add(Me.GunaButton2)
        Me.pnSignup.Controls.Add(Me.GunaGradientButton2)
        Me.pnSignup.Controls.Add(Me.GunaTextBox3)
        Me.pnSignup.Controls.Add(Me.GunaLabel5)
        Me.pnSignup.Controls.Add(Me.GunaTextBox4)
        Me.pnSignup.Controls.Add(Me.GunaLabel6)
        Me.pnSignup.Controls.Add(Me.GunaLabel8)
        Me.pnSignup.Controls.Add(Me.GunaPictureBox2)
        Me.GunaTransition1.SetDecoration(Me.pnSignup, Guna.UI.Animation.DecorationType.None)
        Me.pnSignup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnSignup.Location = New System.Drawing.Point(0, 0)
        Me.pnSignup.Name = "pnSignup"
        Me.pnSignup.Size = New System.Drawing.Size(846, 529)
        Me.pnSignup.TabIndex = 1
        '
        'GunaTextBox5
        '
        Me.GunaTextBox5.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.GunaTextBox5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.GunaTextBox5.BorderSize = 1
        Me.GunaTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTransition1.SetDecoration(Me.GunaTextBox5, Guna.UI.Animation.DecorationType.None)
        Me.GunaTextBox5.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox5.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox5.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox5.ForeColor = System.Drawing.Color.White
        Me.GunaTextBox5.Location = New System.Drawing.Point(306, 304)
        Me.GunaTextBox5.Name = "GunaTextBox5"
        Me.GunaTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox5.Radius = 2
        Me.GunaTextBox5.Size = New System.Drawing.Size(248, 37)
        Me.GunaTextBox5.TabIndex = 11
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.GunaLabel9, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GunaLabel9.Location = New System.Drawing.Point(302, 282)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(67, 19)
        Me.GunaLabel9.TabIndex = 10
        Me.GunaLabel9.Text = "Password"
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaTransition1.SetDecoration(Me.GunaButton2, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaButton2.ImageSize = New System.Drawing.Size(22, 22)
        Me.GunaButton2.Location = New System.Drawing.Point(728, 38)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = CType(resources.GetObject("GunaButton2.OnHoverImage"), System.Drawing.Image)
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(94, 32)
        Me.GunaButton2.TabIndex = 9
        Me.GunaButton2.Text = "Login"
        '
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton2.AnimationSpeed = 0.03!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GunaGradientButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaTransition1.SetDecoration(Me.GunaGradientButton2, Guna.UI.Animation.DecorationType.None)
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.Image = Nothing
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(306, 361)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 2
        Me.GunaGradientButton2.Size = New System.Drawing.Size(248, 37)
        Me.GunaGradientButton2.TabIndex = 7
        Me.GunaGradientButton2.Text = "Sign Up"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaTextBox3
        '
        Me.GunaTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.GunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.GunaTextBox3.BorderSize = 1
        Me.GunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTransition1.SetDecoration(Me.GunaTextBox3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTextBox3.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox3.ForeColor = System.Drawing.Color.White
        Me.GunaTextBox3.Location = New System.Drawing.Point(306, 229)
        Me.GunaTextBox3.Name = "GunaTextBox3"
        Me.GunaTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox3.Radius = 2
        Me.GunaTextBox3.Size = New System.Drawing.Size(248, 37)
        Me.GunaTextBox3.TabIndex = 6
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.GunaLabel5, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(302, 207)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(41, 19)
        Me.GunaLabel5.TabIndex = 5
        Me.GunaLabel5.Text = "Email"
        '
        'GunaTextBox4
        '
        Me.GunaTextBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.GunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.GunaTextBox4.BorderSize = 1
        Me.GunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTransition1.SetDecoration(Me.GunaTextBox4, Guna.UI.Animation.DecorationType.None)
        Me.GunaTextBox4.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox4.ForeColor = System.Drawing.Color.White
        Me.GunaTextBox4.Location = New System.Drawing.Point(306, 154)
        Me.GunaTextBox4.Name = "GunaTextBox4"
        Me.GunaTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox4.Radius = 2
        Me.GunaTextBox4.Size = New System.Drawing.Size(248, 37)
        Me.GunaTextBox4.TabIndex = 4
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.GunaLabel6, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(302, 132)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(45, 19)
        Me.GunaLabel6.TabIndex = 3
        Me.GunaLabel6.Text = "Name"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.GunaLabel8, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel8.ForeColor = System.Drawing.Color.White
        Me.GunaLabel8.Location = New System.Drawing.Point(301, 91)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(154, 28)
        Me.GunaLabel8.TabIndex = 1
        Me.GunaLabel8.Text = "Create account"
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaTransition1.SetDecoration(Me.GunaPictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaPictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(0, 423)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(846, 106)
        Me.GunaPictureBox2.TabIndex = 0
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaTransition1
        '
        Me.GunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.ScaleAndRotate
        Me.GunaTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(30)
        Animation1.RotateCoeff = 0.5!
        Animation1.RotateLimit = 0.2!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.GunaTransition1.DefaultAnimation = Animation1
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.pnLogin
        '
        'GunaDragControl2
        '
        Me.GunaDragControl2.TargetControl = Me.pnSignup
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(846, 529)
        Me.Controls.Add(Me.pnLogin)
        Me.Controls.Add(Me.pnSignup)
        Me.GunaTransition1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnLogin.ResumeLayout(False)
        Me.pnLogin.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnSignup.ResumeLayout(False)
        Me.pnSignup.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnLogin As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaTransition1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents pnSignup As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaTextBox5 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaTextBox3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTextBox4 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl2 As Guna.UI.WinForms.GunaDragControl
End Class
