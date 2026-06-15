<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddMajorRef
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
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.tbMajorRefNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtYear = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.tbDept = New Telerik.WinControls.UI.RadTextBox()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.VisualStudio2022LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2022LightTheme()
        Me.Windows11CompactTheme1 = New Telerik.WinControls.Themes.Windows11CompactTheme()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMajorRefNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(143, 230)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 24)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 21)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(110, 21)
        Me.RadLabel1.TabIndex = 4
        Me.RadLabel1.Text = "Class Description"
        Me.RadLabel1.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(12, 72)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(131, 21)
        Me.RadLabel2.TabIndex = 10
        Me.RadLabel2.Text = "Major Reference No."
        Me.RadLabel2.ThemeName = "VisualStudio2022Light"
        '
        'tbMajorRefNo
        '
        Me.tbMajorRefNo.Enabled = False
        Me.tbMajorRefNo.Location = New System.Drawing.Point(143, 71)
        Me.tbMajorRefNo.Name = "tbMajorRefNo"
        Me.tbMajorRefNo.Size = New System.Drawing.Size(295, 24)
        Me.tbMajorRefNo.TabIndex = 11
        Me.tbMajorRefNo.ThemeName = "Windows11Compact"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(12, 159)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(33, 21)
        Me.RadLabel3.TabIndex = 5
        Me.RadLabel3.Text = "Year"
        Me.RadLabel3.ThemeName = "VisualStudio2022Light"
        '
        'txtYear
        '
        Me.txtYear.Enabled = False
        Me.txtYear.Location = New System.Drawing.Point(143, 158)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(158, 24)
        Me.txtYear.TabIndex = 12
        Me.txtYear.ThemeName = "Windows11Compact"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(12, 115)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(80, 21)
        Me.RadLabel4.TabIndex = 6
        Me.RadLabel4.Text = "Department"
        Me.RadLabel4.ThemeName = "VisualStudio2022Light"
        '
        'tbDept
        '
        Me.tbDept.Enabled = False
        Me.tbDept.Location = New System.Drawing.Point(143, 114)
        Me.tbDept.Name = "tbDept"
        Me.tbDept.Size = New System.Drawing.Size(158, 24)
        Me.tbDept.TabIndex = 13
        Me.tbDept.ThemeName = "Windows11Compact"
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.Location = New System.Drawing.Point(143, 20)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.Size = New System.Drawing.Size(227, 24)
        Me.RadDropDownList1.TabIndex = 15
        Me.RadDropDownList1.ThemeName = "Windows11Compact"
        '
        'FrmAddMajorRef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 278)
        Me.Controls.Add(Me.RadDropDownList1)
        Me.Controls.Add(Me.tbDept)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.tbMajorRefNo)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "FrmAddMajorRef"
        Me.Text = "Add Major Ref"
        Me.ThemeName = "VisualStudio2022Light"
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMajorRefNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbMajorRefNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtYear As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbDept As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents VisualStudio2022LightTheme1 As Telerik.WinControls.Themes.VisualStudio2022LightTheme
    Friend WithEvents Windows11CompactTheme1 As Telerik.WinControls.Themes.Windows11CompactTheme
End Class

