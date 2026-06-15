<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHome
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
        Me.txtName = New Telerik.WinControls.UI.RadLabel()
        Me.txtempNo = New Telerik.WinControls.UI.RadLabel()
        Me.txtSection = New Telerik.WinControls.UI.RadLabel()
        Me.VisualStudio2022LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2022LightTheme()
        Me.txtdate = New Telerik.WinControls.UI.RadLabel()
        Me.txtDept = New Telerik.WinControls.UI.RadLabel()
        Me.txtgroup = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtempNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(173, 185)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(45, 21)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "NAME"
        Me.txtName.ThemeName = "VisualStudio2022Light"
        '
        'txtempNo
        '
        Me.txtempNo.Location = New System.Drawing.Point(184, 238)
        Me.txtempNo.Name = "txtempNo"
        Me.txtempNo.Size = New System.Drawing.Size(56, 21)
        Me.txtempNo.TabIndex = 1
        Me.txtempNo.Text = "Emp No"
        Me.txtempNo.ThemeName = "VisualStudio2022Light"
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(204, 88)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(52, 21)
        Me.txtSection.TabIndex = 2
        Me.txtSection.Text = "Section"
        Me.txtSection.ThemeName = "VisualStudio2022Light"
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(163, 121)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(93, 21)
        Me.txtdate.TabIndex = 3
        Me.txtdate.Text = "MM/DD/YEAR"
        Me.txtdate.ThemeName = "VisualStudio2022Light"
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(163, 61)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(80, 21)
        Me.txtDept.TabIndex = 3
        Me.txtDept.Text = "Department"
        Me.txtDept.ThemeName = "VisualStudio2022Light"
        '
        'txtgroup
        '
        Me.txtgroup.Location = New System.Drawing.Point(184, 158)
        Me.txtgroup.Name = "txtgroup"
        Me.txtgroup.Size = New System.Drawing.Size(45, 21)
        Me.txtgroup.TabIndex = 4
        Me.txtgroup.Text = "Group"
        Me.txtgroup.ThemeName = "VisualStudio2022Light"
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.Location = New System.Drawing.Point(78, 368)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.Size = New System.Drawing.Size(165, 22)
        Me.RadDropDownList1.TabIndex = 6
        Me.RadDropDownList1.Text = "RadDropDownList1"
        Me.RadDropDownList1.ThemeName = "VisualStudio2022Light"
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.RadDropDownList1)
        Me.RadPanel2.Controls.Add(Me.txtDept)
        Me.RadPanel2.Controls.Add(Me.txtSection)
        Me.RadPanel2.Controls.Add(Me.txtgroup)
        Me.RadPanel2.Controls.Add(Me.txtdate)
        Me.RadPanel2.Controls.Add(Me.txtName)
        Me.RadPanel2.Controls.Add(Me.txtempNo)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadPanel2.Location = New System.Drawing.Point(122, 0)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(695, 560)
        Me.RadPanel2.TabIndex = 8
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 560)
        Me.Controls.Add(Me.RadPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmHome"
        Me.Text = "FrmHome"
        Me.ThemeName = "VisualStudio2022Light"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtempNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        Me.RadPanel2.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtempNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtSection As Telerik.WinControls.UI.RadLabel
    Friend WithEvents VisualStudio2022LightTheme1 As Telerik.WinControls.Themes.VisualStudio2022LightTheme
    Friend WithEvents txtdate As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtDept As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtgroup As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
End Class

