<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.txtUsername = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.txtPassword = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.VisualStudio2022LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2022LightTheme()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(160, 72)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.NullText = "Username"
        Me.txtUsername.Size = New System.Drawing.Size(100, 22)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.ThemeName = "VisualStudio2022Light"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(160, 122)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.NullText = "Password"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.ThemeName = "VisualStudio2022Light"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(98, 211)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(209, 21)
        Me.RadLabel3.TabIndex = 10
        Me.RadLabel3.Text = "Furukawa Electric Autoparts Phils."
        Me.RadLabel3.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(143, 27)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(155, 21)
        Me.RadLabel4.TabIndex = 11
        Me.RadLabel4.Text = "Budget Actual Plan 2026"
        Me.RadLabel4.ThemeName = "VisualStudio2022Light"
        '
        'IconButton3
        '
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.IconButton3.IconColor = System.Drawing.Color.DodgerBlue
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 30
        Me.IconButton3.Location = New System.Drawing.Point(212, 150)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(48, 39)
        Me.IconButton3.TabIndex = 12
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.IconButton2.IconColor = System.Drawing.Color.DarkGreen
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 30
        Me.IconButton2.Location = New System.Drawing.Point(319, 223)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(42, 32)
        Me.IconButton2.TabIndex = 6
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.IconButton1.IconColor = System.Drawing.Color.DimGray
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 28
        Me.IconButton1.Location = New System.Drawing.Point(367, 223)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(34, 32)
        Me.IconButton1.TabIndex = 5
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(90, 71)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(68, 21)
        Me.RadLabel1.TabIndex = 13
        Me.RadLabel1.Text = "Username"
        Me.RadLabel1.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(90, 121)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(64, 21)
        Me.RadLabel2.TabIndex = 14
        Me.RadLabel2.Text = "Password"
        Me.RadLabel2.ThemeName = "VisualStudio2022Light"
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.IconButton3
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 267)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ThemeName = "VisualStudio2022Light"
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsername As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents txtPassword As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents VisualStudio2022LightTheme1 As Telerik.WinControls.Themes.VisualStudio2022LightTheme
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
End Class

