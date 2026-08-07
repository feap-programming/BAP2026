<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRFQ
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.VisualStudio2022LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2022LightTheme()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.gvItems = New Telerik.WinControls.UI.RadGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pbItems = New Telerik.WinControls.UI.RadProgressBar()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnCancel = New FontAwesome.Sharp.IconButton()
        Me.txtRemarks = New Telerik.WinControls.UI.RadRichTextEditor()
        Me.txtItemDesc = New Telerik.WinControls.UI.RadRichTextEditor()
        Me.btnAddItem = New FontAwesome.Sharp.IconButton()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.ddUOM = New Telerik.WinControls.UI.RadDropDownList()
        Me.ddExpenseType = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel16 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.rbPPENo = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbPPEYes = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.rbChemNo = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbChemYes = New Telerik.WinControls.UI.RadRadioButton()
        Me.dtDateNeeded = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.seQty = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtSection = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbApprovedBy = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbCheckedBy = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadSeparator2 = New Telerik.WinControls.UI.RadSeparator()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.dtDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.txtRFQNo = New Telerik.WinControls.UI.RadTextBox()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadSeparator1 = New Telerik.WinControls.UI.RadSeparator()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.txtDept = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtEmpNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.bwSave = New System.ComponentModel.BackgroundWorker()
        Me.bwUpdate = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.gvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItems.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.pbItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddExpenseType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.rbPPENo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbPPEYes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.rbChemNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbChemYes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txtSection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbApprovedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbApprovedBy.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbApprovedBy.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCheckedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCheckedBy.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCheckedBy.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRFQNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1430, 308)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.gvItems)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(1018, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(412, 308)
        Me.Panel3.TabIndex = 1
        '
        'gvItems
        '
        Me.gvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvItems.Location = New System.Drawing.Point(0, 0)
        Me.gvItems.Margin = New System.Windows.Forms.Padding(4)
        '
        '
        '
        Me.gvItems.MasterTemplate.AllowAddNewRow = False
        Me.gvItems.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvItems.Name = "gvItems"
        Me.gvItems.Size = New System.Drawing.Size(412, 254)
        Me.gvItems.TabIndex = 3
        Me.gvItems.ThemeName = "VisualStudio2022Light"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.pbItems)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 254)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(412, 54)
        Me.Panel6.TabIndex = 2
        '
        'pbItems
        '
        Me.pbItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbItems.Location = New System.Drawing.Point(6, 7)
        Me.pbItems.Name = "pbItems"
        Me.pbItems.Size = New System.Drawing.Size(403, 39)
        Me.pbItems.TabIndex = 4
        Me.pbItems.ThemeName = "VisualStudio2022Light"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnCancel)
        Me.Panel5.Controls.Add(Me.txtRemarks)
        Me.Panel5.Controls.Add(Me.txtItemDesc)
        Me.Panel5.Controls.Add(Me.btnAddItem)
        Me.Panel5.Controls.Add(Me.btnSave)
        Me.Panel5.Controls.Add(Me.ddUOM)
        Me.Panel5.Controls.Add(Me.ddExpenseType)
        Me.Panel5.Controls.Add(Me.RadLabel16)
        Me.Panel5.Controls.Add(Me.RadLabel15)
        Me.Panel5.Controls.Add(Me.RadLabel14)
        Me.Panel5.Controls.Add(Me.RadGroupBox2)
        Me.Panel5.Controls.Add(Me.RadGroupBox1)
        Me.Panel5.Controls.Add(Me.dtDateNeeded)
        Me.Panel5.Controls.Add(Me.RadLabel13)
        Me.Panel5.Controls.Add(Me.seQty)
        Me.Panel5.Controls.Add(Me.RadLabel12)
        Me.Panel5.Controls.Add(Me.RadLabel11)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(315, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(703, 308)
        Me.Panel5.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.IconChar = FontAwesome.Sharp.IconChar.CircleXmark
        Me.btnCancel.IconColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCancel.IconSize = 30
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(471, 263)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(211, 39)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(471, 11)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(211, 109)
        Me.txtRemarks.TabIndex = 40
        Me.txtRemarks.ThemeName = "VisualStudio2022Light"
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(127, 39)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(211, 109)
        Me.txtItemDesc.TabIndex = 39
        Me.txtItemDesc.ThemeName = "VisualStudio2022Light"
        '
        'btnAddItem
        '
        Me.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAddItem.IconColor = System.Drawing.Color.MidnightBlue
        Me.btnAddItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddItem.IconSize = 16
        Me.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddItem.Location = New System.Drawing.Point(471, 233)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(211, 24)
        Me.btnAddItem.TabIndex = 38
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.btnSave.IconColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.IconSize = 30
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(16, 263)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(444, 39)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ddUOM
        '
        Me.ddUOM.DefaultItemsCountInDropDown = 10
        Me.ddUOM.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddUOM.Location = New System.Drawing.Point(127, 199)
        Me.ddUOM.Name = "ddUOM"
        Me.ddUOM.Size = New System.Drawing.Size(211, 22)
        Me.ddUOM.TabIndex = 37
        Me.ddUOM.ThemeName = "VisualStudio2022Light"
        '
        'ddExpenseType
        '
        Me.ddExpenseType.DefaultItemsCountInDropDown = 10
        Me.ddExpenseType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddExpenseType.Location = New System.Drawing.Point(127, 12)
        Me.ddExpenseType.Name = "ddExpenseType"
        Me.ddExpenseType.Size = New System.Drawing.Size(211, 22)
        Me.ddExpenseType.TabIndex = 36
        Me.ddExpenseType.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel16
        '
        Me.RadLabel16.Location = New System.Drawing.Point(360, 12)
        Me.RadLabel16.Name = "RadLabel16"
        Me.RadLabel16.Size = New System.Drawing.Size(59, 21)
        Me.RadLabel16.TabIndex = 34
        Me.RadLabel16.Text = "Remarks"
        Me.RadLabel16.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel15
        '
        Me.RadLabel15.Location = New System.Drawing.Point(16, 228)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(87, 21)
        Me.RadLabel15.TabIndex = 28
        Me.RadLabel15.Text = "Date Needed"
        Me.RadLabel15.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel14
        '
        Me.RadLabel14.Location = New System.Drawing.Point(16, 182)
        Me.RadLabel14.Name = "RadLabel14"
        Me.RadLabel14.Size = New System.Drawing.Size(90, 39)
        Me.RadLabel14.TabIndex = 33
        Me.RadLabel14.Text = "Unit of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Measurement"
        Me.RadLabel14.ThemeName = "VisualStudio2022Light"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.rbPPENo)
        Me.RadGroupBox2.Controls.Add(Me.rbPPEYes)
        Me.RadGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox2.HeaderText = "PPE"
        Me.RadGroupBox2.Location = New System.Drawing.Point(471, 181)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(211, 49)
        Me.RadGroupBox2.TabIndex = 32
        Me.RadGroupBox2.Text = "PPE"
        Me.RadGroupBox2.ThemeName = "VisualStudio2022Light"
        '
        'rbPPENo
        '
        Me.rbPPENo.Location = New System.Drawing.Point(115, 21)
        Me.rbPPENo.Name = "rbPPENo"
        Me.rbPPENo.Size = New System.Drawing.Size(35, 19)
        Me.rbPPENo.TabIndex = 3
        Me.rbPPENo.Text = "No"
        Me.rbPPENo.ThemeName = "VisualStudio2022Light"
        '
        'rbPPEYes
        '
        Me.rbPPEYes.Location = New System.Drawing.Point(50, 21)
        Me.rbPPEYes.Name = "rbPPEYes"
        Me.rbPPEYes.Size = New System.Drawing.Size(37, 19)
        Me.rbPPEYes.TabIndex = 2
        Me.rbPPEYes.Text = "Yes"
        Me.rbPPEYes.ThemeName = "VisualStudio2022Light"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.rbChemNo)
        Me.RadGroupBox1.Controls.Add(Me.rbChemYes)
        Me.RadGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox1.HeaderText = "Chemical"
        Me.RadGroupBox1.Location = New System.Drawing.Point(471, 126)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(211, 49)
        Me.RadGroupBox1.TabIndex = 31
        Me.RadGroupBox1.Text = "Chemical"
        Me.RadGroupBox1.ThemeName = "VisualStudio2022Light"
        '
        'rbChemNo
        '
        Me.rbChemNo.Location = New System.Drawing.Point(115, 25)
        Me.rbChemNo.Name = "rbChemNo"
        Me.rbChemNo.Size = New System.Drawing.Size(35, 19)
        Me.rbChemNo.TabIndex = 1
        Me.rbChemNo.Text = "No"
        Me.rbChemNo.ThemeName = "VisualStudio2022Light"
        '
        'rbChemYes
        '
        Me.rbChemYes.Location = New System.Drawing.Point(50, 25)
        Me.rbChemYes.Name = "rbChemYes"
        Me.rbChemYes.Size = New System.Drawing.Size(37, 19)
        Me.rbChemYes.TabIndex = 0
        Me.rbChemYes.Text = "Yes"
        Me.rbChemYes.ThemeName = "VisualStudio2022Light"
        '
        'dtDateNeeded
        '
        Me.dtDateNeeded.CustomFormat = "MMMM dd, yyyy"
        Me.dtDateNeeded.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateNeeded.Location = New System.Drawing.Point(127, 227)
        Me.dtDateNeeded.Name = "dtDateNeeded"
        Me.dtDateNeeded.Size = New System.Drawing.Size(211, 22)
        Me.dtDateNeeded.TabIndex = 29
        Me.dtDateNeeded.TabStop = False
        Me.dtDateNeeded.Text = "April 09, 2026"
        Me.dtDateNeeded.ThemeName = "VisualStudio2022Light"
        Me.dtDateNeeded.Value = New Date(2026, 4, 9, 15, 14, 37, 440)
        '
        'RadLabel13
        '
        Me.RadLabel13.Location = New System.Drawing.Point(16, 155)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(59, 21)
        Me.RadLabel13.TabIndex = 27
        Me.RadLabel13.Text = "Quantity"
        Me.RadLabel13.ThemeName = "VisualStudio2022Light"
        '
        'seQty
        '
        Me.seQty.DecimalPlaces = 2
        Me.seQty.Location = New System.Drawing.Point(127, 154)
        Me.seQty.Name = "seQty"
        Me.seQty.Size = New System.Drawing.Size(211, 22)
        Me.seQty.TabIndex = 26
        Me.seQty.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel12
        '
        Me.RadLabel12.Location = New System.Drawing.Point(16, 40)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(107, 21)
        Me.RadLabel12.TabIndex = 24
        Me.RadLabel12.Text = "Item Description"
        Me.RadLabel12.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel11
        '
        Me.RadLabel11.Location = New System.Drawing.Point(16, 12)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(105, 21)
        Me.RadLabel11.TabIndex = 23
        Me.RadLabel11.Text = "Type of Expense"
        Me.RadLabel11.ThemeName = "VisualStudio2022Light"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtSection)
        Me.Panel4.Controls.Add(Me.RadLabel9)
        Me.Panel4.Controls.Add(Me.mcbApprovedBy)
        Me.Panel4.Controls.Add(Me.RadLabel7)
        Me.Panel4.Controls.Add(Me.mcbCheckedBy)
        Me.Panel4.Controls.Add(Me.RadSeparator2)
        Me.Panel4.Controls.Add(Me.RadLabel6)
        Me.Panel4.Controls.Add(Me.dtDate)
        Me.Panel4.Controls.Add(Me.txtRFQNo)
        Me.Panel4.Controls.Add(Me.txtID)
        Me.Panel4.Controls.Add(Me.RadLabel5)
        Me.Panel4.Controls.Add(Me.RadSeparator1)
        Me.Panel4.Controls.Add(Me.RadLabel4)
        Me.Panel4.Controls.Add(Me.txtDept)
        Me.Panel4.Controls.Add(Me.RadLabel3)
        Me.Panel4.Controls.Add(Me.txtName)
        Me.Panel4.Controls.Add(Me.RadLabel1)
        Me.Panel4.Controls.Add(Me.txtEmpNo)
        Me.Panel4.Controls.Add(Me.RadLabel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(315, 308)
        Me.Panel4.TabIndex = 2
        '
        'txtSection
        '
        Me.txtSection.Enabled = False
        Me.txtSection.Location = New System.Drawing.Point(98, 95)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(211, 22)
        Me.txtSection.TabIndex = 22
        Me.txtSection.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel9
        '
        Me.RadLabel9.Location = New System.Drawing.Point(9, 270)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(85, 21)
        Me.RadLabel9.TabIndex = 14
        Me.RadLabel9.Text = "Approved By"
        Me.RadLabel9.ThemeName = "VisualStudio2022Light"
        '
        'mcbApprovedBy
        '
        '
        'mcbApprovedBy.NestedRadGridView
        '
        Me.mcbApprovedBy.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbApprovedBy.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbApprovedBy.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbApprovedBy.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbApprovedBy.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbApprovedBy.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbApprovedBy.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbApprovedBy.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbApprovedBy.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbApprovedBy.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbApprovedBy.EditorControl.Name = "NestedRadGridView"
        Me.mcbApprovedBy.EditorControl.ReadOnly = True
        Me.mcbApprovedBy.EditorControl.ShowGroupPanel = False
        Me.mcbApprovedBy.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbApprovedBy.EditorControl.TabIndex = 0
        Me.mcbApprovedBy.Location = New System.Drawing.Point(95, 269)
        Me.mcbApprovedBy.Name = "mcbApprovedBy"
        Me.mcbApprovedBy.Size = New System.Drawing.Size(211, 22)
        Me.mcbApprovedBy.TabIndex = 13
        Me.mcbApprovedBy.TabStop = False
        Me.mcbApprovedBy.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel7
        '
        Me.RadLabel7.Location = New System.Drawing.Point(9, 242)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(77, 21)
        Me.RadLabel7.TabIndex = 21
        Me.RadLabel7.Text = "Checked By"
        Me.RadLabel7.ThemeName = "VisualStudio2022Light"
        '
        'mcbCheckedBy
        '
        '
        'mcbCheckedBy.NestedRadGridView
        '
        Me.mcbCheckedBy.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbCheckedBy.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbCheckedBy.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbCheckedBy.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbCheckedBy.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbCheckedBy.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbCheckedBy.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbCheckedBy.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbCheckedBy.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbCheckedBy.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.mcbCheckedBy.EditorControl.Name = "NestedRadGridView"
        Me.mcbCheckedBy.EditorControl.ReadOnly = True
        Me.mcbCheckedBy.EditorControl.ShowGroupPanel = False
        Me.mcbCheckedBy.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbCheckedBy.EditorControl.TabIndex = 0
        Me.mcbCheckedBy.Location = New System.Drawing.Point(95, 241)
        Me.mcbCheckedBy.Name = "mcbCheckedBy"
        Me.mcbCheckedBy.Size = New System.Drawing.Size(211, 22)
        Me.mcbCheckedBy.TabIndex = 20
        Me.mcbCheckedBy.TabStop = False
        Me.mcbCheckedBy.ThemeName = "VisualStudio2022Light"
        '
        'RadSeparator2
        '
        Me.RadSeparator2.Location = New System.Drawing.Point(12, 225)
        Me.RadSeparator2.Name = "RadSeparator2"
        Me.RadSeparator2.Size = New System.Drawing.Size(294, 10)
        Me.RadSeparator2.TabIndex = 19
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(12, 183)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(35, 21)
        Me.RadLabel6.TabIndex = 15
        Me.RadLabel6.Text = "Date"
        Me.RadLabel6.ThemeName = "VisualStudio2022Light"
        '
        'dtDate
        '
        Me.dtDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(95, 182)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(214, 22)
        Me.dtDate.TabIndex = 18
        Me.dtDate.TabStop = False
        Me.dtDate.Text = "April 09, 2026"
        Me.dtDate.ThemeName = "VisualStudio2022Light"
        Me.dtDate.Value = New Date(2026, 4, 9, 15, 14, 37, 440)
        '
        'txtRFQNo
        '
        Me.txtRFQNo.Enabled = False
        Me.txtRFQNo.Location = New System.Drawing.Point(144, 154)
        Me.txtRFQNo.Name = "txtRFQNo"
        Me.txtRFQNo.Size = New System.Drawing.Size(165, 22)
        Me.txtRFQNo.TabIndex = 16
        Me.txtRFQNo.ThemeName = "VisualStudio2022Light"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(95, 154)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(43, 22)
        Me.txtID.TabIndex = 15
        Me.txtID.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(12, 155)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(57, 21)
        Me.RadLabel5.TabIndex = 14
        Me.RadLabel5.Text = "RFQ No."
        Me.RadLabel5.ThemeName = "VisualStudio2022Light"
        '
        'RadSeparator1
        '
        Me.RadSeparator1.Location = New System.Drawing.Point(12, 138)
        Me.RadSeparator1.Name = "RadSeparator1"
        Me.RadSeparator1.Size = New System.Drawing.Size(294, 10)
        Me.RadSeparator1.TabIndex = 13
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(12, 96)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(52, 21)
        Me.RadLabel4.TabIndex = 12
        Me.RadLabel4.Text = "Section"
        Me.RadLabel4.ThemeName = "VisualStudio2022Light"
        '
        'txtDept
        '
        Me.txtDept.Enabled = False
        Me.txtDept.Location = New System.Drawing.Point(98, 67)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(211, 22)
        Me.txtDept.TabIndex = 12
        Me.txtDept.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(12, 68)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(80, 21)
        Me.RadLabel3.TabIndex = 11
        Me.RadLabel3.Text = "Department"
        Me.RadLabel3.ThemeName = "VisualStudio2022Light"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(98, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(211, 22)
        Me.txtName.TabIndex = 10
        Me.txtName.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 40)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(43, 21)
        Me.RadLabel1.TabIndex = 9
        Me.RadLabel1.Text = "Name"
        Me.RadLabel1.ThemeName = "VisualStudio2022Light"
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Enabled = False
        Me.txtEmpNo.Location = New System.Drawing.Point(98, 11)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(211, 22)
        Me.txtEmpNo.TabIndex = 8
        Me.txtEmpNo.ThemeName = "VisualStudio2022Light"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(12, 12)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(59, 21)
        Me.RadLabel2.TabIndex = 6
        Me.RadLabel2.Text = "Emp No."
        Me.RadLabel2.ThemeName = "VisualStudio2022Light"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.gvData)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 308)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1430, 419)
        Me.Panel2.TabIndex = 1
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 31)
        Me.gvData.Margin = New System.Windows.Forms.Padding(4)
        '
        '
        '
        Me.gvData.MasterTemplate.AllowAddNewRow = False
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(1430, 388)
        Me.gvData.TabIndex = 2
        Me.gvData.ThemeName = "VisualStudio2022Light"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.IconButton2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1430, 31)
        Me.Panel8.TabIndex = 4
        '
        'IconButton2
        '
        Me.IconButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.IconButton2.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Redo
        Me.IconButton2.IconColor = System.Drawing.Color.MidnightBlue
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 24
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.Location = New System.Drawing.Point(0, 0)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(115, 31)
        Me.IconButton2.TabIndex = 4
        Me.IconButton2.Text = "Refresh"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 727)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1430, 38)
        Me.Panel7.TabIndex = 3
        '
        'bwSave
        '
        Me.bwSave.WorkerReportsProgress = True
        Me.bwSave.WorkerSupportsCancellation = True
        '
        'bwUpdate
        '
        Me.bwUpdate.WorkerReportsProgress = True
        Me.bwUpdate.WorkerSupportsCancellation = True
        '
        'FrmRFQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1430, 765)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRFQ"
        Me.Text = "FrmRFQ"
        Me.ThemeName = "VisualStudio2022Light"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.gvItems.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.pbItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddExpenseType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.rbPPENo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbPPEYes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.rbChemNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbChemYes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.txtSection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbApprovedBy.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbApprovedBy.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbApprovedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCheckedBy.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCheckedBy.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCheckedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRFQNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VisualStudio2022LightTheme1 As Telerik.WinControls.Themes.VisualStudio2022LightTheme
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadSeparator1 As Telerik.WinControls.UI.RadSeparator
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtDept As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtEmpNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtRFQNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadSeparator2 As Telerik.WinControls.UI.RadSeparator
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbApprovedBy As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbCheckedBy As Telerik.WinControls.UI.RadMultiColumnComboBox
    'Friend WithEvents txtItemDesc As Telerik.WinControls.UI.RadRichTextEditor
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seQty As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents rbPPENo As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbPPEYes As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents rbChemNo As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbChemYes As Telerik.WinControls.UI.RadRadioButton
    'Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadRichTextEditor
    Friend WithEvents dtDateNeeded As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents gvItems As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel16 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel14 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents ddExpenseType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtSection As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ddUOM As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnAddItem As FontAwesome.Sharp.IconButton
    Friend WithEvents bwSave As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbItems As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtItemDesc As Telerik.WinControls.UI.RadRichTextEditor
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadRichTextEditor
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents bwUpdate As System.ComponentModel.BackgroundWorker
End Class

