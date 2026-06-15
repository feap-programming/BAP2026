<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class  FrmConversion
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.VisualStudio2022LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2022LightTheme()
        Me.ccAmt = New Telerik.WinControls.UI.RadSpinEditor()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(69, 54)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(61, 21)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Currency"
        Me.RadLabel1.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(53, 89)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(163, 21)
        Me.RadLabel2.TabIndex = 1
        Me.RadLabel2.Text = "Current Currency Amount"
        Me.RadLabel2.ThemeName = "VisualStudio2022Light"
        '
        'RadDropDownList1
        '
        RadListDataItem1.Text = "PHP-USD"
        RadListDataItem2.Text = "PHP-JPY"
        RadListDataItem3.Text = "USD-PHP"
        RadListDataItem4.Text = "USD-JPY"
        RadListDataItem5.Text = "JPY-PHP"
        RadListDataItem6.Text = "JPY-USD"
        Me.RadDropDownList1.Items.Add(RadListDataItem1)
        Me.RadDropDownList1.Items.Add(RadListDataItem2)
        Me.RadDropDownList1.Items.Add(RadListDataItem3)
        Me.RadDropDownList1.Items.Add(RadListDataItem4)
        Me.RadDropDownList1.Items.Add(RadListDataItem5)
        Me.RadDropDownList1.Items.Add(RadListDataItem6)
        Me.RadDropDownList1.Location = New System.Drawing.Point(212, 53)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.Size = New System.Drawing.Size(124, 22)
        Me.RadDropDownList1.TabIndex = 4
        Me.RadDropDownList1.ThemeName = "VisualStudio2022Light"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(129, 161)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(128, 24)
        Me.RadButton1.TabIndex = 5
        Me.RadButton1.Text = "Add"
        Me.RadButton1.ThemeName = "VisualStudio2022Light"
        '
        'ccAmt
        '
        Me.ccAmt.Cursor = System.Windows.Forms.Cursors.Default
        Me.ccAmt.DecimalPlaces = 2
        Me.ccAmt.InterceptArrowKeys = False
        Me.ccAmt.Location = New System.Drawing.Point(212, 86)
        Me.ccAmt.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.ccAmt.Name = "ccAmt"
        Me.ccAmt.ShowUpDownButtons = False
        Me.ccAmt.Size = New System.Drawing.Size(124, 22)
        Me.ccAmt.TabIndex = 7
        Me.ccAmt.ThemeName = "VisualStudio2022Light"
        '
        'FrmConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 204)
        Me.Controls.Add(Me.ccAmt)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadDropDownList1)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmConversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConversion"
        Me.ThemeName = "VisualStudio2022Light"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents VisualStudio2022LightTheme1 As Telerik.WinControls.Themes.VisualStudio2022LightTheme
    Friend WithEvents ccAmt As Telerik.WinControls.UI.RadSpinEditor
End Class

