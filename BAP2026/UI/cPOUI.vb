

Imports System.Runtime.CompilerServices
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.ImageEditor.Dialogs

Public Class cPOUI


    Public Sub gvSupplier(gv As RadGridView)

        ThemeResolutionService.ApplyThemeToControlTree(gv, "VisualStudio2012Light")

        gv.AutoGenerateColumns = False
        gv.Columns.Clear()


        gv.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
        gv.MasterTemplate.AllowColumnResize = True

        gv.ReadOnly = True
        gv.AllowAddNewRow = False
        gv.AllowEditRow = False
        gv.AllowDeleteRow = False
        gv.ShowFilteringRow = True
        gv.EnableAlternatingRowColor = True
        gv.SelectionMode = GridViewSelectionMode.FullRowSelect

        gv.EnableFiltering = True
        gv.ShowGroupPanel = False

        gv.TableElement.TextAlignment = ContentAlignment.MiddleCenter
        gv.TableElement.RowHeight = 28


        ' Columns
        Dim sup As New GridViewTextBoxColumn()
        sup.HeaderText = "Supplier"
        sup.FieldName = "CardName"
        sup.TextAlignment = ContentAlignment.MiddleCenter
        sup.HeaderTextAlignment = ContentAlignment.MiddleCenter
        sup.Width = 500
        gv.Columns.Add(sup)


        Dim vendor As New GridViewTextBoxColumn()
        vendor.HeaderText = "Vendor Code"
        vendor.FieldName = "CardCode"
        vendor.TextAlignment = ContentAlignment.MiddleCenter
        vendor.HeaderTextAlignment = ContentAlignment.MiddleCenter
        vendor.Width = 250

        gv.Columns.Add(vendor)

        Dim currency As New GridViewTextBoxColumn()
        currency.HeaderText = "Currency"
        currency.FieldName = "Currency"
        currency.TextAlignment = ContentAlignment.MiddleCenter
        currency.HeaderTextAlignment = ContentAlignment.MiddleCenter
        currency.Width = 200

        gv.Columns.Add(currency)

    End Sub

    Public Sub gvLIST(gvlist As RadGridView)

        ThemeResolutionService.ApplyThemeToControlTree(gvlist, "VisualStudio2012Light")

        gvlist.AutoGenerateColumns = False
        gvlist.Columns.Clear()

        gvlist.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
        gvlist.MasterTemplate.AllowColumnResize = True

        gvlist.ReadOnly = True
        gvlist.AllowDeleteRow = False
        gvlist.AllowEditRow = False
        gvlist.AllowAddNewRow = False
        gvlist.ShowFilteringRow = True
        gvlist.EnableAlternatingRowColor = True

        gvlist.EnableFiltering = True
        gvlist.ShowGroupPanel = False

        gvlist.SelectionMode = GridViewSelectionMode.FullRowSelect
        gvlist.TableElement.TextAlignment = ContentAlignment.MiddleCenter
        gvlist.TableElement.RowHeight = 28

        Dim fldOrder As New GridViewTextBoxColumn()
        fldOrder.HeaderText = "Order ID"
        fldOrder.FieldName = "fldOrderId"
        fldOrder.TextAlignment = ContentAlignment.MiddleCenter
        fldOrder.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldOrder.Width = 80
        fldOrder.IsVisible = False
        gvlist.Columns.Add(fldOrder)

        Dim fldCurrencyColumn As New GridViewTextBoxColumn()
        fldCurrencyColumn.HeaderText = "IO"
        fldCurrencyColumn.FieldName = "fldMOIID"
        fldCurrencyColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldCurrencyColumn.Width = 50
        fldCurrencyColumn.IsVisible = False
        gvlist.Columns.Add(fldCurrencyColumn)

        Dim fldbudrefColumn As New GridViewTextBoxColumn()
        fldbudrefColumn.HeaderText = "Sub Reference No."
        fldbudrefColumn.FieldName = "fldSubRefNo"
        fldbudrefColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldbudrefColumn.IsPinned = PinnedColumnPosition.Left
        fldbudrefColumn.IsPinned = True
        fldbudrefColumn.Width = 200
        gvlist.Columns.Add(fldbudrefColumn)

        Dim fldprNOColumn As New GridViewTextBoxColumn()
        fldprNOColumn.HeaderText = "Purchased Req NO."
        fldprNOColumn.FieldName = "fldPRNo"
        fldprNOColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldprNOColumn.Width = 250
        fldprNOColumn.IsPinned = PinnedColumnPosition.Left
        fldprNOColumn.IsPinned = True
        gvlist.Columns.Add(fldprNOColumn)

        Dim fldICodeColumn As New GridViewTextBoxColumn()
        fldICodeColumn.HeaderText = "Item Code"
        fldICodeColumn.FieldName = "fldICode"
        fldICodeColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldICodeColumn.Width = 180
        gvlist.Columns.Add(fldICodeColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn()
        fldDescColumn.HeaderText = "Description"
        fldDescColumn.FieldName = "fldDesc"
        fldDescColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldDescColumn.Width = 200
        gvlist.Columns.Add(fldDescColumn)

        Dim fldQTYColumn As New GridViewTextBoxColumn()
        fldQTYColumn.HeaderText = "QTY"
        fldQTYColumn.FieldName = "fldQTYEB"
        fldQTYColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldQTYColumn.Width = 120
        gvlist.Columns.Add(fldQTYColumn)

        Dim fldDeptColumn As New GridViewTextBoxColumn()
        fldDeptColumn.HeaderText = "Dept"
        fldDeptColumn.FieldName = "fldOrderDepartment"
        fldDeptColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldDeptColumn.Width = 100
        gvlist.Columns.Add(fldDeptColumn)

        Dim fldBudRefNum As New GridViewTextBoxColumn()
        fldBudRefNum.HeaderText = "Budget Ref No."
        fldBudRefNum.FieldName = "fldBudRefNum"
        fldBudRefNum.TextAlignment = ContentAlignment.MiddleCenter
        fldBudRefNum.Width = 180
        gvlist.Columns.Add(fldBudRefNum)

        Dim fldQTYOUTColumn As New GridViewTextBoxColumn()
        fldQTYOUTColumn.HeaderText = "QTY"
        fldQTYOUTColumn.FieldName = "fldQTYSOUT"
        fldQTYOUTColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldQTYOUTColumn.Width = 80
        fldQTYOUTColumn.IsVisible = False
        gvlist.Columns.Add(fldQTYOUTColumn)

        Dim fldUnitColumn As New GridViewTextBoxColumn()
        fldUnitColumn.HeaderText = "Unit"
        fldUnitColumn.FieldName = "fldUnit"
        fldUnitColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldUnitColumn.Width = 80
        gvlist.Columns.Add(fldUnitColumn)

        Dim fldSignature As New GridViewTextBoxColumn()
        fldSignature.HeaderText = "Signature"
        fldSignature.FieldName = "fldSignature"
        fldSignature.TextAlignment = ContentAlignment.MiddleCenter
        fldSignature.Width = 160
        gvlist.Columns.Add(fldSignature)



    End Sub

    Public Sub gvcreatePO(gvPO As RadGridView)


        ThemeResolutionService.ApplyThemeToControlTree(gvPO, "VisualStudio2012Light")

        gvPO.AutoGenerateColumns = False
        gvPO.Columns.Clear()

        gvPO.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
        gvPO.MasterTemplate.AllowColumnResize = True

        gvPO.ReadOnly = True
        gvPO.AllowDeleteRow = False
        gvPO.AllowEditRow = False
        gvPO.AllowAddNewRow = False
        gvPO.ShowFilteringRow = True
        gvPO.EnableAlternatingRowColor = True

        gvPO.EnableFiltering = True
        gvPO.ShowGroupPanel = False

        gvPO.SelectionMode = GridViewSelectionMode.FullRowSelect
        gvPO.TableElement.TextAlignment = ContentAlignment.MiddleCenter
        gvPO.TableElement.RowHeight = 28


        Dim fldOBLINE As New GridViewTextBoxColumn()

        fldOBLINE.HeaderText = "OB_LINE"
        fldOBLINE.FieldName = "OB_LINE"
        fldOBLINE.TextAlignment = ContentAlignment.MiddleCenter
        fldOBLINE.Width = 80
        gvPO.Columns.Add(fldOBLINE)

        Dim fldDocDate As New GridViewTextBoxColumn()

        fldDocDate.HeaderText = "Month Ordered"
        fldDocDate.FieldName = "MO"
        fldDocDate.TextAlignment = ContentAlignment.MiddleCenter
        fldDocDate.Width = 150
        gvPO.Columns.Add(fldDocDate)

        Dim fldTaxDate As New GridViewTextBoxColumn()

        fldTaxDate.HeaderText = "OB_TaxDate"
        fldTaxDate.FieldName = "TaxDate"
        fldTaxDate.TextAlignment = ContentAlignment.MiddleCenter
        fldTaxDate.Width = 150
        gvPO.Columns.Add(fldTaxDate)

        Dim fldDueDate As New GridViewTextBoxColumn()

        fldDueDate.HeaderText = "Due Date"
        fldDueDate.FieldName = "DDD"
        fldDueDate.Width = 150
        fldDueDate.TextAlignment = ContentAlignment.MiddleCenter
        gvPO.Columns.Add(fldDueDate)

        Dim fldSupppplier As New GridViewTextBoxColumn()
        fldSupppplier.HeaderText = "Supplier"
        fldSupppplier.FieldName = "fldSupplier"
        fldSupppplier.Width = 180
        fldSupppplier.TextAlignment = ContentAlignment.MiddleCenter
        gvPO.Columns.Add(fldSupppplier)


        Dim fldPOAmt As New GridViewTextBoxColumn()
        fldPOAmt.HeaderText = "Total PO Amount"
        fldPOAmt.FieldName = "PO"
        fldPOAmt.Width = 100
        fldPOAmt.TextAlignment = ContentAlignment.MiddleCenter
        gvPO.Columns.Add(fldPOAmt)

        Dim fldRow As New GridViewTextBoxColumn()
        fldRow.HeaderText = "Row"
        fldRow.FieldName = "Row"
        fldRow.Width = 70
        fldRow.TextAlignment = ContentAlignment.MiddleCenter
        fldRow.IsPinned = PinnedColumnPosition.Left
        fldRow.IsPinned = True
        gvPO.Columns.Add(fldRow)

        Dim fldItemCode As New GridViewTextBoxColumn()
        fldItemCode.HeaderText = "Item Code"
        fldItemCode.FieldName = "fldICode"
        fldItemCode.Width = 80
        fldItemCode.TextAlignment = ContentAlignment.MiddleCenter
        fldItemCode.FormatString = "{0:N6}"
        gvPO.Columns.Add(fldItemCode)

        Dim fldQty As New GridViewTextBoxColumn()
        fldQty.HeaderText = "QTY"
        fldQty.FieldName = "fldQTYEB"
        fldQty.Width = 80
        fldQty.TextAlignment = ContentAlignment.MiddleCenter
        fldQty.FormatString = "{0:N6}"
        gvPO.Columns.Add(fldQty)

        Dim fldPrice As New GridViewTextBoxColumn()
        fldPrice.HeaderText = "Price"
        fldPrice.FieldName = "Price"
        fldPrice.Width = 80
        fldPrice.TextAlignment = ContentAlignment.MiddleCenter
        fldPrice.FormatString = "{0:N6}"
        gvPO.Columns.Add(fldPrice)

        Dim fldRemarks As New GridViewTextBoxColumn()
        fldRemarks.HeaderText = "Remarks"
        fldRemarks.FieldName = "Remarks"
        fldRemarks.Width = 180
        fldRemarks.TextAlignment = ContentAlignment.MiddleCenter
        gvPO.Columns.Add(fldRemarks)

        Dim fldDetailID As New GridViewTextBoxColumn()
        fldDetailID.HeaderText = "Detail ID"
        fldDetailID.FieldName = "DetailID"
        fldDetailID.Width = 80
        fldDetailID.TextAlignment = ContentAlignment.MiddleCenter
        gvPO.Columns.Add(fldDetailID)

        Dim fldDept As New GridViewTextBoxColumn()
        fldDept.HeaderText = "Department"
        fldDept.FieldName = "fldOrderDepartment"
        fldDept.Width = 120
        fldDept.TextAlignment = ContentAlignment.MiddleCenter
        gvPO.Columns.Add(fldDept)

        Dim fldBudgetRef As New GridViewTextBoxColumn()
        fldBudgetRef.HeaderText = "Budget Ref No."
        fldBudgetRef.FieldName = "fldSubRefNo"
        fldBudgetRef.Width = 200
        fldBudgetRef.TextAlignment = ContentAlignment.MiddleCenter
        gvPO.Columns.Add(fldBudgetRef)


        Dim fldOrderId As New GridViewTextBoxColumn()
        fldOrderId.HeaderText = "OrderId"
        fldOrderId.FieldName = "fldOrderId"
        fldOrderId.Width = 80
        fldOrderId.TextAlignment = ContentAlignment.MiddleCenter
        fldOrderId.IsVisible = False
        gvPO.Columns.Add(fldOrderId)

        Dim fldQTYSOUT As New GridViewTextBoxColumn()
        fldQTYSOUT.HeaderText = "QTYSOUT"
        fldQTYSOUT.FieldName = "fldQTYSOUT"
        fldQTYSOUT.Width = 90
        fldQTYSOUT.TextAlignment = ContentAlignment.MiddleCenter
        fldQTYSOUT.IsVisible = False
        gvPO.Columns.Add(fldQTYSOUT)

        Dim fldPRNUM As New GridViewTextBoxColumn()
        fldPRNUM.HeaderText = "PR No."
        fldPRNUM.FieldName = "fldPRNO"
        fldPRNUM.Width = 100
        fldPRNUM.TextAlignment = ContentAlignment.MiddleCenter
        fldPRNUM.IsVisible = False
        gvPO.Columns.Add(fldPRNUM)

        Dim fldMOIID As New GridViewTextBoxColumn()
        fldMOIID.HeaderText = "MOIID"
        fldMOIID.FieldName = "fldMOIID"
        fldMOIID.Width = 90
        fldMOIID.TextAlignment = ContentAlignment.MiddleCenter
        fldMOIID.IsVisible = False
        gvPO.Columns.Add(fldMOIID)


    End Sub



End Class