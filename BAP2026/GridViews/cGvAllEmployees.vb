Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class cGvAllEmployees

    Public Sub readyGvAllEmployees(ByVal gv As Telerik.WinControls.UI.RadGridView)
        Dim fldId As New GridViewTextBoxColumn()
        fldId.HeaderText = "ID"
        fldId.FieldName = "ID"
        fldId.IsPinned = True
        fldId.PinPosition = PinnedColumnPosition.Left
        fldId.IsVisible = False
        fldId.IsPinned = True
        gv.Columns.Add(fldId)

        Dim fldEmpNo As New GridViewTextBoxColumn("EMP NO.")
        fldEmpNo.FieldName = "fldEmpNo"
        fldEmpNo.ReadOnly = True
        fldEmpNo.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpNo.Width = 90
        gv.Columns.Add(fldEmpNo)

        Dim fldEmpName As New GridViewTextBoxColumn("NAME")
        fldEmpName.FieldName = "fldEmpName"
        fldEmpName.ReadOnly = True
        fldEmpName.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpName.Width = 200
        gv.Columns.Add(fldEmpName)

        Dim fldSelect As New GridViewCommandColumn("SELECT")
        fldSelect.FieldName = "SELECT"
        fldSelect.DefaultText = "SELECT"
        fldSelect.TextAlignment = ContentAlignment.MiddleCenter
        fldSelect.UseDefaultText = True
        fldSelect.Width = 70
        fldSelect.ReadOnly = True
        fldSelect.IsPinned = True
        fldSelect.PinPosition = PinnedColumnPosition.Left
        gv.Columns.Add(fldSelect)
        'AddHandler gv.CommandCellClick, AddressOf editUser


        'gv.ReadOnly = True
        gv.EnableAlternatingRowColor = True
        gv.EnableFiltering = True
        gv.ShowFilteringRow = True
        gv.EnableGrouping = True
        gv.ShowGroupPanel = False

        gv.AllowRowReorder = True
        gv.MultiSelect = False
        gv.AllowRowResize = False
        gv.AllowAddNewRow = False
    End Sub

    Public Sub readyGvAllMembers(ByVal gv As Telerik.WinControls.UI.RadGridView)
        Dim fldId As New GridViewTextBoxColumn()
        fldId.HeaderText = "ID"
        fldId.FieldName = "ID"
        fldId.IsPinned = True
        fldId.PinPosition = PinnedColumnPosition.Left
        fldId.IsVisible = False
        fldId.IsPinned = True
        gv.Columns.Add(fldId)

        Dim fldEmpNo As New GridViewTextBoxColumn("EMP NO.")
        fldEmpNo.FieldName = "fldEmpNo"
        fldEmpNo.ReadOnly = True
        fldEmpNo.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpNo.Width = 90
        gv.Columns.Add(fldEmpNo)

        Dim fldEmpName As New GridViewTextBoxColumn("NAME")
        fldEmpName.FieldName = "fldEmpName"
        fldEmpName.ReadOnly = True
        fldEmpName.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpName.Width = 200
        gv.Columns.Add(fldEmpName)

        'gv.ReadOnly = True
        gv.EnableAlternatingRowColor = True
        gv.EnableFiltering = True
        gv.ShowFilteringRow = True
        gv.EnableGrouping = True
        gv.ShowGroupPanel = False

        gv.AllowRowReorder = True
        gv.MultiSelect = False
        gv.AllowRowResize = False
        gv.AllowAddNewRow = False
    End Sub

    Public Sub readyGvAllGroupMembers(ByVal gv As Telerik.WinControls.UI.RadGridView)
        Dim fldId As New GridViewTextBoxColumn()
        fldId.HeaderText = "ID"
        fldId.FieldName = "fldGMID"
        fldId.IsPinned = True
        fldId.PinPosition = PinnedColumnPosition.Left
        fldId.IsVisible = False
        fldId.IsPinned = True
        gv.Columns.Add(fldId)

        Dim fldEmpNo As New GridViewTextBoxColumn("EMP NO.")
        fldEmpNo.FieldName = "fldEmpNo"
        fldEmpNo.ReadOnly = True
        fldEmpNo.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpNo.Width = 90
        gv.Columns.Add(fldEmpNo)

        Dim fldEmpName As New GridViewTextBoxColumn("NAME")
        fldEmpName.FieldName = "fldEmpName"
        fldEmpName.ReadOnly = True
        fldEmpName.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpName.Width = 200
        gv.Columns.Add(fldEmpName)

        Dim fldSelect As New GridViewCommandColumn("SELECT")
        fldSelect.FieldName = "SELECT"
        fldSelect.DefaultText = "SELECT"
        fldSelect.TextAlignment = ContentAlignment.MiddleCenter
        fldSelect.UseDefaultText = True
        fldSelect.Width = 70
        fldSelect.ReadOnly = True
        fldSelect.IsPinned = True
        fldSelect.PinPosition = PinnedColumnPosition.Left
        gv.Columns.Add(fldSelect)
        'AddHandler gv.CommandCellClick, AddressOf editUser


        'gv.ReadOnly = True
        gv.EnableAlternatingRowColor = True
        gv.EnableFiltering = True
        gv.ShowFilteringRow = True
        gv.EnableGrouping = True
        gv.ShowGroupPanel = False

        gv.AllowRowReorder = True
        gv.MultiSelect = False
        gv.AllowRowResize = False
        gv.AllowAddNewRow = False
    End Sub

    Public Sub readyMcbEmployee(ByVal mcb As Telerik.WinControls.UI.RadMultiColumnComboBox)
        Dim ID As New GridViewTextBoxColumn()
        ID.HeaderText = "ID"
        ID.FieldName = "ID"
        ID.IsVisible = False
        mcb.MultiColumnComboBoxElement.Columns.Add(ID)

        Dim fldEmpNo As New GridViewTextBoxColumn("EMPLOYEE NO.")
        fldEmpNo.FieldName = "fldEmpNo"
        fldEmpNo.ReadOnly = True
        fldEmpNo.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpNo.Width = 200
        fldEmpNo.IsVisible = False
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpNo)

        Dim fldEmpName As New GridViewTextBoxColumn("NAME")
        fldEmpName.FieldName = "fldEmpName"
        fldEmpName.ReadOnly = True
        fldEmpName.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpName.Width = 200
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpName)

        Dim fldEmpFirstName As New GridViewTextBoxColumn("FIRST NAME")
        fldEmpFirstName.FieldName = "fldEmpFirstName"
        fldEmpFirstName.ReadOnly = True
        fldEmpFirstName.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpFirstName.Width = 200
        fldEmpFirstName.IsVisible = False
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpFirstName)

        Dim fldEmpMiddleName As New GridViewTextBoxColumn("MIDDLE NAME")
        fldEmpMiddleName.FieldName = "fldEmpMiddleName"
        fldEmpMiddleName.ReadOnly = True
        fldEmpMiddleName.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpMiddleName.Width = 200
        fldEmpMiddleName.IsVisible = False
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpMiddleName)

        Dim fldEmpLastName As New GridViewTextBoxColumn("LAST NAME")
        fldEmpLastName.FieldName = "fldEmpLastName"
        fldEmpLastName.ReadOnly = True
        fldEmpLastName.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpLastName.Width = 200
        fldEmpLastName.IsVisible = False
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpLastName)

        Dim fldEmpSuffix As New GridViewTextBoxColumn("SUFFIX")
        fldEmpSuffix.FieldName = "fldEmpSuffix"
        fldEmpSuffix.ReadOnly = True
        fldEmpSuffix.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpSuffix.Width = 200
        fldEmpSuffix.IsVisible = False
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpSuffix)

        Dim fldEmpDepartment As New GridViewTextBoxColumn("DEPARTMENT")
        fldEmpDepartment.FieldName = "fldEmpDepartment"
        fldEmpDepartment.ReadOnly = True
        fldEmpDepartment.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpDepartment.Width = 200
        fldEmpDepartment.IsVisible = False
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpDepartment)

        Dim fldEmpSection As New GridViewTextBoxColumn("SECTION")
        fldEmpSection.FieldName = "fldEmpSection"
        fldEmpSection.ReadOnly = True
        fldEmpSection.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpSection.Width = 200
        fldEmpSection.IsVisible = False
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpSection)

        Dim fldEmpGroup As New GridViewTextBoxColumn("GROUP")
        fldEmpGroup.FieldName = "fldEmpGroup"
        fldEmpGroup.ReadOnly = True
        fldEmpGroup.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpGroup.Width = 200
        fldEmpGroup.IsVisible = False
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpGroup)

        Dim fldEmpGender As New GridViewTextBoxColumn("GENDER")
        fldEmpGender.FieldName = "fldEmpGender"
        fldEmpGender.ReadOnly = True
        fldEmpGender.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpGender.Width = 200
        fldEmpGender.IsVisible = False
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpGender)

        Dim fldEmpPassword As New GridViewTextBoxColumn("PASSWORD")
        fldEmpPassword.FieldName = "fldEmpPassword"
        fldEmpPassword.ReadOnly = True
        fldEmpPassword.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpPassword.Width = 200
        fldEmpPassword.IsVisible = False
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpPassword)

        mcb.DisplayMember = "fldEmpName"
        mcb.ValueMember = "fldEmpName"
        mcb.MultiColumnComboBoxElement.AutoSizeMode = RadAutoSizeMode.Auto
        mcb.MultiColumnComboBoxElement.AutoSizeDropDownToBestFit = True
        mcb.AutoFilter = True
        Dim EmpName As FilterDescriptor = New FilterDescriptor()
        EmpName.PropertyName = "fldEmpName"
        EmpName.[Operator] = FilterOperator.Contains
        mcb.EditorControl.MasterTemplate.FilterDescriptors.Add(EmpName)
    End Sub

    Public Sub readyGvAllUsers(ByVal gv As Telerik.WinControls.UI.RadGridView)
        Dim fldId As New GridViewTextBoxColumn()
        fldId.HeaderText = "ID"
        fldId.FieldName = "fldUID"
        fldId.IsPinned = True
        fldId.PinPosition = PinnedColumnPosition.Left
        fldId.IsVisible = False
        fldId.IsPinned = True
        gv.Columns.Add(fldId)

        Dim fldEmpNo As New GridViewTextBoxColumn("EMPLOYEE NO.")
        fldEmpNo.FieldName = "fldEmpNo"
        fldEmpNo.ReadOnly = True
        fldEmpNo.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpNo.Width = 80
        fldEmpNo.IsPinned = True
        gv.Columns.Add(fldEmpNo)

        Dim fldEmpFirstName As New GridViewTextBoxColumn("FIRST NAME")
        fldEmpFirstName.FieldName = "fldEmpFirstName"
        fldEmpFirstName.ReadOnly = True
        fldEmpFirstName.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpFirstName.Width = 100
        fldEmpFirstName.IsVisible = True
        gv.Columns.Add(fldEmpFirstName)

        Dim fldEmpMiddleName As New GridViewTextBoxColumn("MIDDLE NAME")
        fldEmpMiddleName.FieldName = "fldEmpMiddleName"
        fldEmpMiddleName.ReadOnly = True
        fldEmpMiddleName.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpMiddleName.Width = 100
        fldEmpMiddleName.IsVisible = True
        gv.Columns.Add(fldEmpMiddleName)

        Dim fldEmpLastName As New GridViewTextBoxColumn("LAST NAME")
        fldEmpLastName.FieldName = "fldEmpLastName"
        fldEmpLastName.ReadOnly = True
        fldEmpLastName.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpLastName.Width = 100
        fldEmpLastName.IsVisible = True
        gv.Columns.Add(fldEmpLastName)

        Dim fldEmpDepartment As New GridViewTextBoxColumn("DEPARTMENT")
        fldEmpDepartment.FieldName = "fldDepartment"
        fldEmpDepartment.ReadOnly = True
        fldEmpDepartment.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpDepartment.Width = 150
        gv.Columns.Add(fldEmpDepartment)

        Dim fldEmpSection As New GridViewTextBoxColumn("SECTION")
        fldEmpSection.FieldName = "fldSection"
        fldEmpSection.ReadOnly = True
        fldEmpSection.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpSection.Width = 120
        gv.Columns.Add(fldEmpSection)

        Dim fldDeptAll As New GridViewCheckBoxColumn("ALL")
        fldDeptAll.FieldName = "fldDeptAll"
        fldDeptAll.ReadOnly = True
        fldDeptAll.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptAll.Width = 120
        gv.Columns.Add(fldDeptAll)

        Dim fldDeptPresident As New GridViewCheckBoxColumn("{PRESIDENT}")
        fldDeptPresident.FieldName = "fldDeptPresident"
        fldDeptPresident.ReadOnly = True
        fldDeptPresident.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptPresident.Width = 120
        gv.Columns.Add(fldDeptPresident)

        Dim fldHRGA As New GridViewCheckBoxColumn("HRGA")
        fldHRGA.FieldName = "fldDeptHRGA"
        fldHRGA.ReadOnly = True
        fldHRGA.TextAlignment = ContentAlignment.MiddleCenter
        fldHRGA.Width = 120
        gv.Columns.Add(fldHRGA)

        Dim fldDeptAcctg As New GridViewCheckBoxColumn("ACCOUNTING")
        fldDeptAcctg.FieldName = "fldDeptAcctg"
        fldDeptAcctg.ReadOnly = True
        fldDeptAcctg.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptAcctg.Width = 120
        gv.Columns.Add(fldDeptAcctg)

        Dim fldDeptLog As New GridViewCheckBoxColumn("lOG")
        fldDeptLog.FieldName = "fldDeptLog"
        fldDeptLog.ReadOnly = True
        fldDeptLog.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptLog.Width = 120
        gv.Columns.Add(fldDeptLog)


        Dim fldDeptEval As New GridViewCheckBoxColumn("LOG")
        fldDeptEval.FieldName = "fldDeptEval"
        fldDeptEval.ReadOnly = True
        fldDeptEval.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptEval.Width = 120
        gv.Columns.Add(fldDeptEval)


        Dim fldDeptFac As New GridViewCheckBoxColumn("FACILITY")
        fldDeptFac.FieldName = "fldDeptFac"
        fldDeptFac.ReadOnly = True
        fldDeptFac.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptFac.Width = 120
        gv.Columns.Add(fldDeptFac)

        Dim fldDeptEngg As New GridViewCheckBoxColumn("ENGINEER")
        fldDeptEngg.FieldName = "fldDeptEngg"
        fldDeptEngg.ReadOnly = True
        fldDeptEngg.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptEngg.Width = 120
        gv.Columns.Add(fldDeptEngg)

        Dim fldDeptProd As New GridViewCheckBoxColumn("PROD")
        fldDeptProd.FieldName = "fldDeptProd"
        fldDeptProd.ReadOnly = True
        fldDeptProd.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptProd.Width = 120
        gv.Columns.Add(fldDeptProd)

        Dim fldDeptPC As New GridViewCheckBoxColumn("PC")
        fldDeptPC.FieldName = "fldDeptPC"
        fldDeptPC.ReadOnly = True
        fldDeptPC.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptPC.Width = 120
        gv.Columns.Add(fldDeptPC)


        Dim fldDeptQA As New GridViewCheckBoxColumn("QA")
        fldDeptQA.FieldName = "fldDeptQA"
        fldDeptQA.ReadOnly = True
        fldDeptQA.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptQA.Width = 120
        gv.Columns.Add(fldDeptQA)

        Dim fldDeptWH As New GridViewCheckBoxColumn("WH")
        fldDeptWH.FieldName = "fldDeptWH"
        fldDeptWH.ReadOnly = True
        fldDeptWH.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptWH.Width = 120
        gv.Columns.Add(fldDeptWH)


        Dim fldDeptFab As New GridViewCheckBoxColumn("FAB")
        fldDeptFab.FieldName = "fldDeptFab"
        fldDeptFab.ReadOnly = True
        fldDeptFab.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptFab.Width = 120
        gv.Columns.Add(fldDeptFab)

        Dim fldDeptFFC As New GridViewCheckBoxColumn("FFC")
        fldDeptFFC.FieldName = "fldDeptFFC"
        fldDeptFFC.ReadOnly = True
        fldDeptFFC.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptFFC.Width = 120
        gv.Columns.Add(fldDeptFFC)

        Dim fldDeptProject As New GridViewCheckBoxColumn("FFC")
        fldDeptProject.FieldName = "fldDeptProject"
        fldDeptProject.ReadOnly = True
        fldDeptProject.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptProject.Width = 120
        gv.Columns.Add(fldDeptProject)

        Dim fldDeptCommon As New GridViewCheckBoxColumn("COMMON")
        fldDeptCommon.FieldName = "fldDeptCommon"
        fldDeptCommon.ReadOnly = True
        fldDeptCommon.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptCommon.Width = 120
        gv.Columns.Add(fldDeptCommon)

        Dim fldDeptMIS As New GridViewCheckBoxColumn("MIS")
        fldDeptMIS.FieldName = "fldDeptMIS"
        fldDeptMIS.ReadOnly = True
        fldDeptMIS.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptMIS.Width = 120
        gv.Columns.Add(fldDeptMIS)

        Dim fldDeptBSS As New GridViewCheckBoxColumn("BSS")
        fldDeptBSS.FieldName = "fldDeptBSS"
        fldDeptBSS.ReadOnly = True
        fldDeptBSS.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptBSS.Width = 120
        gv.Columns.Add(fldDeptBSS)

        Dim fldDeptQC As New GridViewCheckBoxColumn("QC")
        fldDeptQC.FieldName = "fldDeptQC"
        fldDeptQC.ReadOnly = True
        fldDeptQC.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptQC.Width = 120
        gv.Columns.Add(fldDeptQC)

        Dim fldDeptIVG As New GridViewCheckBoxColumn("IVG")
        fldDeptIVG.FieldName = "fldDeptIVG"
        fldDeptIVG.ReadOnly = True
        fldDeptIVG.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptIVG.Width = 120
        gv.Columns.Add(fldDeptIVG)

        Dim fldDeptKaizen As New GridViewCheckBoxColumn("KAIZEN")
        fldDeptKaizen.FieldName = "fldDeptKaizen"
        fldDeptKaizen.ReadOnly = True
        fldDeptKaizen.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptKaizen.Width = 120
        gv.Columns.Add(fldDeptKaizen)

        Dim fldDeptFGM As New GridViewCheckBoxColumn("FGM")
        fldDeptFGM.FieldName = "fldDeptFGM"
        fldDeptFGM.ReadOnly = True
        fldDeptFGM.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptFGM.Width = 120
        gv.Columns.Add(fldDeptFGM)


        Dim fldDeptTraining As New GridViewCheckBoxColumn("FGM")
        fldDeptTraining.FieldName = "fldDeptTraining"
        fldDeptTraining.ReadOnly = True
        fldDeptTraining.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptTraining.Width = 120
        gv.Columns.Add(fldDeptTraining)


        Dim fldDeptSafety As New GridViewCheckBoxColumn("FGM")
        fldDeptSafety.FieldName = "fldDeptSafety"
        fldDeptSafety.ReadOnly = True
        fldDeptSafety.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptSafety.Width = 120
        gv.Columns.Add(fldDeptSafety)


        Dim fldDeptEnggInj As New GridViewCheckBoxColumn("FGM")
        fldDeptEnggInj.FieldName = "fldDeptEnggInj"
        fldDeptEnggInj.ReadOnly = True
        fldDeptEnggInj.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptEnggInj.Width = 120
        gv.Columns.Add(fldDeptEnggInj)

        Dim fldDeptEnggSRC As New GridViewCheckBoxColumn("FGM")
        fldDeptEnggSRC.FieldName = "fldDeptEnggSRC"
        fldDeptEnggSRC.ReadOnly = True
        fldDeptEnggSRC.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptEnggSRC.Width = 120
        gv.Columns.Add(fldDeptEnggSRC)


        Dim fldDelete As New GridViewCommandColumn("DELETE")
        fldDelete.FieldName = "DELETE"
        fldDelete.DefaultText = "DELETE"
        fldDelete.TextAlignment = ContentAlignment.MiddleCenter
        fldDelete.UseDefaultText = True
        fldDelete.Width = 70
        fldDelete.ReadOnly = True
        fldDelete.IsPinned = True
        fldDelete.PinPosition = PinnedColumnPosition.Right
        gv.Columns.Add(fldDelete)
        'AddHandler gv.CommandCellClick, AddressOf editUser

        'gv.ReadOnly = True
        gv.EnableAlternatingRowColor = True
        gv.EnableFiltering = True
        gv.ShowFilteringRow = True
        gv.EnableGrouping = True
        gv.ShowGroupPanel = False

        gv.AllowRowReorder = True
        gv.MultiSelect = False
        gv.AllowRowResize = False
        gv.AllowAddNewRow = False
    End Sub

End Class
