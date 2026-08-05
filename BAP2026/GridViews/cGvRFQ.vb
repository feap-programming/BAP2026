Imports Telerik.WinControls.UI

Public Class cGvRFQ

    Public Sub readyGvRFQItems(ByVal gv As Telerik.WinControls.UI.RadGridView)
        'Dim fldId As New GridViewTextBoxColumn()
        'fldId.HeaderText = "ID"
        'fldId.FieldName = "fldUID"
        'fldId.IsPinned = True
        'fldId.PinPosition = PinnedColumnPosition.Left
        'fldId.IsVisible = False
        'fldId.IsPinned = True
        'gv.Columns.Add(fldId)

        Dim fldStatus As New GridViewTextBoxColumn("STATUS")
        fldStatus.FieldName = "fldStatus"
        fldStatus.ReadOnly = True
        fldStatus.TextAlignment = ContentAlignment.MiddleCenter
        fldStatus.Width = 80
        fldStatus.IsPinned = True
        gv.Columns.Add(fldStatus)

        Dim fldTypeOfExpense As New GridViewTextBoxColumn("TYPE OF EXPENSE")
        fldTypeOfExpense.FieldName = "fldTypeOfExpense"
        fldTypeOfExpense.ReadOnly = True
        fldTypeOfExpense.TextAlignment = ContentAlignment.MiddleCenter
        fldTypeOfExpense.Width = 150
        fldTypeOfExpense.IsVisible = True
        gv.Columns.Add(fldTypeOfExpense)

        Dim fldDescription As New GridViewTextBoxColumn("DESCRIPTION")
        fldDescription.FieldName = "fldDescription"
        fldDescription.ReadOnly = True
        fldDescription.TextAlignment = ContentAlignment.MiddleCenter
        fldDescription.Width = 300
        fldDescription.IsVisible = True
        gv.Columns.Add(fldDescription)

        Dim fldQty As New GridViewTextBoxColumn("QTY")
        fldQty.FieldName = "fldQty"
        fldQty.ReadOnly = True
        fldQty.TextAlignment = ContentAlignment.MiddleCenter
        fldQty.Width = 80
        fldQty.IsVisible = True
        gv.Columns.Add(fldQty)

        Dim fldUOM As New GridViewTextBoxColumn("MEASUREMENT UNIT")
        fldUOM.FieldName = "fldUOM"
        fldUOM.ReadOnly = True
        fldUOM.TextAlignment = ContentAlignment.MiddleCenter
        fldUOM.Width = 150
        gv.Columns.Add(fldUOM)

        Dim fldDateNeeded As New GridViewDateTimeColumn("DATE NEEDED")
        fldDateNeeded.FieldName = "fldDateNeeded"
        fldDateNeeded.Width = 100
        fldDateNeeded.Format = DateTimePickerFormat.Custom
        fldDateNeeded.CustomFormat = "MMM dd, yyyy"
        fldDateNeeded.TextAlignment = ContentAlignment.MiddleCenter
        fldDateNeeded.WrapText = True
        fldDateNeeded.ReadOnly = True
        'fldDateNeeded.IsPinned = True
        gv.Columns.Add(fldDateNeeded)
        gv.Columns("fldDateNeeded").FormatString = "{0:MMM dd, yyyy}"

        Dim fldRemarks As New GridViewTextBoxColumn("REMARKS")
        fldRemarks.FieldName = "fldRemarks"
        fldRemarks.ReadOnly = True
        fldRemarks.TextAlignment = ContentAlignment.MiddleCenter
        fldRemarks.Width = 120
        gv.Columns.Add(fldRemarks)

        Dim fldChemical As New GridViewCheckBoxColumn("CHEMICAL")
        fldChemical.FieldName = "fldChemical"
        fldChemical.ReadOnly = True
        fldChemical.TextAlignment = ContentAlignment.MiddleCenter
        fldChemical.Width = 120
        gv.Columns.Add(fldChemical)

        Dim fldPPE As New GridViewCheckBoxColumn("PPE")
        fldPPE.FieldName = "fldPPE"
        fldPPE.ReadOnly = True
        fldPPE.TextAlignment = ContentAlignment.MiddleCenter
        fldPPE.Width = 120
        gv.Columns.Add(fldPPE)

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

    Public Sub readyGvRFQList(ByVal gv As Telerik.WinControls.UI.RadGridView)

        Dim fldRFQNo As New GridViewTextBoxColumn("RFQ NO.")
        fldRFQNo.FieldName = "RFQNo"
        fldRFQNo.ReadOnly = True
        fldRFQNo.TextAlignment = ContentAlignment.MiddleCenter
        fldRFQNo.Width = 150
        fldRFQNo.IsVisible = True
        gv.Columns.Add(fldRFQNo)

        Dim fldDateRequest As New GridViewDateTimeColumn("DATE REQUEST")
        fldDateRequest.FieldName = "fldDateRequest"
        fldDateRequest.Width = 100
        fldDateRequest.Format = DateTimePickerFormat.Custom
        fldDateRequest.CustomFormat = "MMM dd, yyyy"
        fldDateRequest.TextAlignment = ContentAlignment.MiddleCenter
        fldDateRequest.WrapText = True
        fldDateRequest.ReadOnly = True
        'fldDateRequest.IsPinned = True
        gv.Columns.Add(fldDateRequest)
        gv.Columns("fldDateRequest").FormatString = "{0:MMM dd, yyyy}"

        Dim fldEmpName As New GridViewTextBoxColumn("NAME")
        fldEmpName.FieldName = "fldEmpName"
        fldEmpName.ReadOnly = True
        fldEmpName.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpName.Width = 300
        fldEmpName.IsVisible = True
        gv.Columns.Add(fldEmpName)

        Dim fldDept As New GridViewTextBoxColumn("DEPARTMENT")
        fldDept.FieldName = "fldDept"
        fldDept.ReadOnly = True
        fldDept.TextAlignment = ContentAlignment.MiddleCenter
        fldDept.Width = 300
        gv.Columns.Add(fldDept)

        Dim fldSection As New GridViewTextBoxColumn("SECTION")
        fldSection.FieldName = "fldSection"
        fldSection.ReadOnly = True
        fldSection.TextAlignment = ContentAlignment.MiddleCenter
        fldSection.Width = 300
        gv.Columns.Add(fldSection)

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
