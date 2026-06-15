<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreateBudget
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leRecordsCounter = New Telerik.WinControls.UI.RadLabelElement()
        Me.EllipseShape1 = New Telerik.WinControls.EllipseShape()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leAccess = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        Me.CommandBarStripElement3 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.miShowFilter = New Telerik.WinControls.UI.RadMenuItem()
        Me.miShowGrouping = New Telerik.WinControls.UI.RadMenuItem()
        Me.CommandBarDropDownButton1 = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.MaterialBlueGreyTheme1 = New Telerik.WinControls.Themes.MaterialBlueGreyTheme()
        Me.CommandBarRowElement2 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarRowElement3 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarRowElement4 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarRowElement5 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarRowElement6 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.VisualStudio2022LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2022LightTheme()
        Me.Windows11Theme1 = New Telerik.WinControls.Themes.Windows11Theme()
        Me.Windows11CompactTheme1 = New Telerik.WinControls.Themes.Windows11CompactTheme()
        Me.CommandBarButton2 = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarButton3 = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarRowElement7 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement2 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnAddRec = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnAddMajorRef = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnEditMajorRef = New Telerik.WinControls.UI.CommandBarButton()
        Me.btnDeleteMajorRef = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarSeparator6 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarRowElement8 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.BackColor = System.Drawing.Color.Ivory
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leRecordsCounter, Me.RadLabelElement2, Me.leAccess, Me.CommandBarSeparator2})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 388)
        Me.RadStatusStrip1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(972, 27)
        Me.RadStatusStrip1.TabIndex = 0
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Records Found:"
        Me.RadLabelElement1.TextWrap = True
        '
        'leRecordsCounter
        '
        Me.leRecordsCounter.FocusBorderColor = System.Drawing.Color.Gray
        Me.leRecordsCounter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leRecordsCounter.Name = "leRecordsCounter"
        Me.RadStatusStrip1.SetSpring(Me.leRecordsCounter, True)
        Me.leRecordsCounter.Text = "0"
        Me.leRecordsCounter.TextWrap = True
        CType(Me.leRecordsCounter.GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextWrap = True
        CType(Me.leRecordsCounter.GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shape = Me.EllipseShape1
        '
        'RadLabelElement2
        '
        Me.RadLabelElement2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabelElement2.Name = "RadLabelElement2"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement2, False)
        Me.RadLabelElement2.Text = "Access:"
        Me.RadLabelElement2.TextWrap = True
        '
        'leAccess
        '
        Me.leAccess.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leAccess.Name = "leAccess"
        Me.RadStatusStrip1.SetSpring(Me.leAccess, False)
        Me.leAccess.Text = "leAccess"
        Me.leAccess.TextWrap = True
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.AccessibleDescription = "CommandBarSeparator2"
        Me.CommandBarSeparator2.AccessibleName = "CommandBarSeparator2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator2, False)
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'bwOperation
        '
        Me.bwOperation.WorkerReportsProgress = True
        '
        'CommandBarStripElement3
        '
        Me.CommandBarStripElement3.DisplayName = "CommandBarStripElement3"
        Me.CommandBarStripElement3.Name = "CommandBarStripElement3"
        '
        'miShowFilter
        '
        Me.miShowFilter.CheckOnClick = True
        Me.miShowFilter.Image = Nothing
        Me.miShowFilter.Name = "miShowFilter"
        Me.miShowFilter.Text = "Show Filter"
        Me.miShowFilter.UseCompatibleTextRendering = False
        '
        'miShowGrouping
        '
        Me.miShowGrouping.CheckOnClick = True
        Me.miShowGrouping.Image = Nothing
        Me.miShowGrouping.Name = "miShowGrouping"
        Me.miShowGrouping.Text = "Show Grouping"
        Me.miShowGrouping.UseCompatibleTextRendering = False
        '
        'CommandBarDropDownButton1
        '
        Me.CommandBarDropDownButton1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarDropDownButton1.DisplayName = "Options"
        Me.CommandBarDropDownButton1.DrawText = True
        Me.CommandBarDropDownButton1.Image = Nothing
        Me.CommandBarDropDownButton1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miShowFilter, Me.miShowGrouping})
        Me.CommandBarDropDownButton1.Name = "CommandBarDropDownButton1"
        Me.CommandBarDropDownButton1.Text = "Options"
        Me.CommandBarDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CommandBarDropDownButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarDropDownButton1.UseCompatibleTextRendering = False
        '
        'CommandBarRowElement2
        '
        Me.CommandBarRowElement2.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement2.Name = "CommandBarRowElement2"
        '
        'CommandBarRowElement3
        '
        Me.CommandBarRowElement3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement3.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement3.Name = "CommandBarRowElement3"
        Me.CommandBarRowElement3.Text = ""
        Me.CommandBarRowElement3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement3.UseCompatibleTextRendering = False
        '
        'CommandBarRowElement4
        '
        Me.CommandBarRowElement4.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement4.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement4.Name = "CommandBarRowElement4"
        Me.CommandBarRowElement4.Text = ""
        Me.CommandBarRowElement4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement4.UseCompatibleTextRendering = False
        '
        'CommandBarRowElement5
        '
        Me.CommandBarRowElement5.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement5.Name = "CommandBarRowElement5"
        '
        'CommandBarRowElement6
        '
        Me.CommandBarRowElement6.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement6.Name = "CommandBarRowElement6"
        '
        'CommandBarButton2
        '
        Me.CommandBarButton2.Alignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CommandBarButton2.AutoSize = False
        Me.CommandBarButton2.Bounds = New System.Drawing.Rectangle(0, 0, 100, 80)
        Me.CommandBarButton2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarButton2.DisplayName = "Delete Major Ref"
        Me.CommandBarButton2.DrawText = True
        Me.CommandBarButton2.Image = Global.BAP2026.My.Resources.Resources.bin
        Me.CommandBarButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CommandBarButton2.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CommandBarButton2.Name = "CommandBarButton2"
        Me.CommandBarButton2.Text = "Delete Document"
        Me.CommandBarButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CommandBarButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CommandBarButton2.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.CommandBarButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarButton2.UseCompatibleTextRendering = False
        '
        'CommandBarButton3
        '
        Me.CommandBarButton3.Alignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CommandBarButton3.AutoSize = False
        Me.CommandBarButton3.Bounds = New System.Drawing.Rectangle(0, 0, 100, 80)
        Me.CommandBarButton3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarButton3.DisplayName = "Delete Major Ref"
        Me.CommandBarButton3.DrawText = True
        Me.CommandBarButton3.Image = Global.BAP2026.My.Resources.Resources.bin
        Me.CommandBarButton3.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CommandBarButton3.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CommandBarButton3.Name = "CommandBarButton3"
        Me.CommandBarButton3.Text = "Delete Document"
        Me.CommandBarButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CommandBarButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CommandBarButton3.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.CommandBarButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarButton3.UseCompatibleTextRendering = False
        '
        'CommandBarRowElement7
        '
        Me.CommandBarRowElement7.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement7.Name = "CommandBarRowElement7"
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 111)
        Me.gvData.Margin = New System.Windows.Forms.Padding(4)
        '
        '
        '
        Me.gvData.MasterTemplate.AllowAddNewRow = False
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(972, 277)
        Me.gvData.TabIndex = 1
        Me.gvData.ThemeName = "VisualStudio2022Light"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(31, 31)
        Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement2})
        Me.CommandBarRowElement1.Text = ""
        Me.CommandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement1.UseCompatibleTextRendering = False
        '
        'CommandBarStripElement2
        '
        Me.CommandBarStripElement2.AutoSize = False
        Me.CommandBarStripElement2.Bounds = New System.Drawing.Rectangle(0, 0, 700, 80)
        Me.CommandBarStripElement2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement2.DisplayName = "Standard Tool Bar"
        Me.CommandBarStripElement2.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnAddRec, Me.CommandBarSeparator3, Me.btnAddMajorRef, Me.CommandBarSeparator1, Me.btnEditMajorRef, Me.CommandBarSeparator4, Me.btnDeleteMajorRef, Me.CommandBarSeparator5, Me.CommandBarSeparator6})
        Me.CommandBarStripElement2.Name = "CommandBarStripElement2"
        Me.CommandBarStripElement2.OverflowMenuMaxSize = New System.Drawing.Size(338, 0)
        Me.CommandBarStripElement2.OverflowMenuMinSize = New System.Drawing.Size(62, 31)
        Me.CommandBarStripElement2.StretchHorizontally = True
        Me.CommandBarStripElement2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement2.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator3.DisplayName = "CommandBarSeparator3"
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.CommandBarSeparator3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator3.UseCompatibleTextRendering = False
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
        '
        'btnAddRec
        '
        Me.btnAddRec.AccessibleDescription = "Add Credits"
        Me.btnAddRec.AccessibleName = "Add Credits"
        Me.btnAddRec.AutoSize = False
        Me.btnAddRec.Bounds = New System.Drawing.Rectangle(0, 0, 120, 80)
        Me.btnAddRec.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnAddRec.DisplayName = "Add Allowances"
        Me.btnAddRec.DrawText = True
        Me.btnAddRec.Image = Global.BAP2026.My.Resources.Resources.partner
        Me.btnAddRec.Name = "btnAddRec"
        Me.btnAddRec.Text = "Add Document"
        Me.btnAddRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddRec.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnAddRec.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator1.DisplayName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator1.UseCompatibleTextRendering = False
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'btnAddMajorRef
        '
        Me.btnAddMajorRef.Alignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAddMajorRef.AutoSize = False
        Me.btnAddMajorRef.Bounds = New System.Drawing.Rectangle(0, 0, 120, 80)
        Me.btnAddMajorRef.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnAddMajorRef.DisplayName = "Add Major Ref"
        Me.btnAddMajorRef.DrawText = True
        Me.btnAddMajorRef.Image = Global.BAP2026.My.Resources.Resources.partner
        Me.btnAddMajorRef.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAddMajorRef.Name = "btnAddMajorRef"
        Me.btnAddMajorRef.Text = "Add Major Ref"
        Me.btnAddMajorRef.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddMajorRef.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnAddMajorRef.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator4
        '
        Me.CommandBarSeparator4.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator4.DisplayName = "CommandBarSeparator4"
        Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
        Me.CommandBarSeparator4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator4.UseCompatibleTextRendering = False
        Me.CommandBarSeparator4.VisibleInOverflowMenu = False
        '
        'btnEditMajorRef
        '
        Me.btnEditMajorRef.Alignment = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditMajorRef.AutoSize = False
        Me.btnEditMajorRef.Bounds = New System.Drawing.Rectangle(0, 0, 120, 80)
        Me.btnEditMajorRef.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnEditMajorRef.DisplayName = "Edit Document"
        Me.btnEditMajorRef.DrawText = True
        Me.btnEditMajorRef.Image = Global.BAP2026.My.Resources.Resources.bin
        Me.btnEditMajorRef.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEditMajorRef.Name = "btnEditMajorRef"
        Me.btnEditMajorRef.Text = "Edit Document"
        Me.btnEditMajorRef.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEditMajorRef.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEditMajorRef.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.btnEditMajorRef.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnEditMajorRef.UseCompatibleTextRendering = False
        '
        'btnDeleteMajorRef
        '
        Me.btnDeleteMajorRef.Alignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDeleteMajorRef.AutoSize = False
        Me.btnDeleteMajorRef.Bounds = New System.Drawing.Rectangle(0, 0, 120, 80)
        Me.btnDeleteMajorRef.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnDeleteMajorRef.DisplayName = "Delete Major Ref"
        Me.btnDeleteMajorRef.DrawText = True
        Me.btnDeleteMajorRef.Image = Global.BAP2026.My.Resources.Resources.bin
        Me.btnDeleteMajorRef.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDeleteMajorRef.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDeleteMajorRef.Name = "btnDeleteMajorRef"
        Me.btnDeleteMajorRef.Text = "Delete Document"
        Me.btnDeleteMajorRef.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDeleteMajorRef.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteMajorRef.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.btnDeleteMajorRef.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnDeleteMajorRef.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator5
        '
        Me.CommandBarSeparator5.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator5.DisplayName = "CommandBarSeparator5"
        Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
        Me.CommandBarSeparator5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator5.UseCompatibleTextRendering = False
        Me.CommandBarSeparator5.VisibleInOverflowMenu = False
        '
        'CommandBarSeparator6
        '
        Me.CommandBarSeparator6.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator6.DisplayName = "CommandBarSeparator6"
        Me.CommandBarSeparator6.Name = "CommandBarSeparator6"
        Me.CommandBarSeparator6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator6.UseCompatibleTextRendering = False
        Me.CommandBarSeparator6.VisibleInOverflowMenu = False
        '
        'CommandBarRowElement8
        '
        Me.CommandBarRowElement8.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement8.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement8.Name = "CommandBarRowElement8"
        Me.CommandBarRowElement8.Text = ""
        Me.CommandBarRowElement8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement8.UseCompatibleTextRendering = False
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.BackColor = System.Drawing.Color.Ivory
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1, Me.CommandBarRowElement8})
        Me.RadCommandBar1.Size = New System.Drawing.Size(972, 111)
        Me.RadCommandBar1.TabIndex = 0
        '
        'frmCreateBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 415)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCreateBudget"
        Me.Text = "ACCREDITATION"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leRecordsCounter As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leAccess As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents CommandBarStripElement3 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents miShowFilter As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miShowGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents CommandBarDropDownButton1 As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents MaterialBlueGreyTheme1 As Telerik.WinControls.Themes.MaterialBlueGreyTheme
    Friend WithEvents CommandBarRowElement2 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarRowElement3 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarRowElement4 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarRowElement5 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarRowElement6 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents VisualStudio2022LightTheme1 As Telerik.WinControls.Themes.VisualStudio2022LightTheme
    Friend WithEvents Windows11Theme1 As Telerik.WinControls.Themes.Windows11Theme
    Friend WithEvents Windows11CompactTheme1 As Telerik.WinControls.Themes.Windows11CompactTheme
    Friend WithEvents CommandBarButton2 As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarButton3 As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarRowElement7 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents EllipseShape1 As Telerik.WinControls.EllipseShape
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement2 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnAddRec As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents btnAddMajorRef As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents btnEditMajorRef As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents btnDeleteMajorRef As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents CommandBarSeparator6 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents CommandBarRowElement8 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
End Class

