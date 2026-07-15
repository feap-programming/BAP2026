<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.txtUsername = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.txtPassword = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.VisualStudio2022LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2022LightTheme()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.MaterialBlueGreyTheme1 = New Telerik.WinControls.Themes.MaterialBlueGreyTheme()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadPictureBox1 = New Telerik.WinControls.UI.RadPictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(69, 113)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.NullText = "Username"
        Me.txtUsername.Size = New System.Drawing.Size(363, 36)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.ThemeName = "MaterialBlueGrey"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(69, 155)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.NullText = "Password"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(363, 36)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.ThemeName = "MaterialBlueGrey"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Eras Demi ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(135, 242)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(189, 16)
        Me.RadLabel3.TabIndex = 10
        Me.RadLabel3.Text = "Furukawa Electric Autoparts Phils."
        Me.RadLabel3.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Eras Demi ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(69, 85)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(191, 22)
        Me.RadLabel4.TabIndex = 11
        Me.RadLabel4.Text = "Budget Actual Program"
        Me.RadLabel4.ThemeName = "VisualStudio2022Light"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadPictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 383)
        Me.Panel1.TabIndex = 102
        '
        'RadPictureBox1
        '
        Me.RadPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPictureBox1.Image = Global.BAP2026.My.Resources.Resources.BAP_2026_2
        Me.RadPictureBox1.ImageLayout = Telerik.WinControls.UI.RadImageLayout.Stretch
        Me.RadPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.RadPictureBox1.Name = "RadPictureBox1"
        Me.RadPictureBox1.Size = New System.Drawing.Size(296, 383)
        Me.RadPictureBox1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadLabel4)
        Me.Panel2.Controls.Add(Me.IconButton3)
        Me.Panel2.Controls.Add(Me.IconButton2)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Controls.Add(Me.IconButton1)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.RadLabel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(296, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(519, 383)
        Me.Panel2.TabIndex = 103
        '
        'IconButton3
        '
        Me.IconButton3.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.IconButton3.IconColor = System.Drawing.Color.MidnightBlue
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 30
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton3.Location = New System.Drawing.Point(69, 197)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(363, 39)
        Me.IconButton3.TabIndex = 1
        Me.IconButton3.Text = "Log-in"
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.IconButton2.IconColor = System.Drawing.Color.Silver
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 30
        Me.IconButton2.Location = New System.Drawing.Point(350, 242)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(42, 32)
        Me.IconButton2.TabIndex = 100
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.IconButton1.IconColor = System.Drawing.Color.RosyBrown
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 28
        Me.IconButton1.Location = New System.Drawing.Point(398, 242)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(34, 32)
        Me.IconButton1.TabIndex = 101
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.IconButton3
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 383)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ThemeName = "VisualStudio2022Light"
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.RadPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUsername As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents txtPassword As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents VisualStudio2022LightTheme1 As Telerik.WinControls.Themes.VisualStudio2022LightTheme
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents MaterialBlueGreyTheme1 As Telerik.WinControls.Themes.MaterialBlueGreyTheme
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadPictureBox1 As Telerik.WinControls.UI.RadPictureBox
    Friend WithEvents Panel2 As Panel
End Class

