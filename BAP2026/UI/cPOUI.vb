

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

        gvlist.SelectionMode = GridViewSelectionMode.FullRowSelect
        gvlist.TableElement.TextAlignment = ContentAlignment.MiddleCenter
        gvlist.TableElement.RowHeight = 28

        Dim fldOrder As New GridViewTextBoxColumn()
        fldOrder.HeaderText = "Order ID"
        fldOrder.FieldName = "fldOrderId"
        fldOrder.TextAlignment = ContentAlignment.MiddleCenter
        fldOrder.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldOrder.Width = 50
        gvlist.Columns.Add(fldOrder)

        Dim fldCurrencyColumn As New GridViewTextBoxColumn()
        fldCurrencyColumn.HeaderText = "IO"
        fldCurrencyColumn.FieldName = "fldMOIID"
        fldCurrencyColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldCurrencyColumn.Width = 40
        gvlist.Columns.Add(fldCurrencyColumn)

        Dim fldbudrefColumn As New GridViewTextBoxColumn()
        fldbudrefColumn.HeaderText = "Sub Reference No."
        fldbudrefColumn.FieldName = "fldSubRefNo"
        fldbudrefColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldbudrefColumn.Width = 120
        gvlist.Columns.Add(fldbudrefColumn)

        Dim fldprNOColumn As New GridViewTextBoxColumn()
        fldprNOColumn.HeaderText = "Purchased Req NO."
        fldprNOColumn.FieldName = "fldPRNo"
        fldprNOColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldprNOColumn.Width = 250
        fldprNOColumn.IsPinned = PinnedColumnPosition.Left
        gvlist.Columns.Add(fldprNOColumn)

        Dim fldICodeColumn As New GridViewTextBoxColumn()
        fldICodeColumn.HeaderText = "Item Code"
        fldICodeColumn.FieldName = "fldICode"
        fldICodeColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldICodeColumn.Width = 150
        gvlist.Columns.Add(fldICodeColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn()
        fldDescColumn.HeaderText = "Description"
        fldDescColumn.FieldName = "fldDesc"
        fldDescColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldDescColumn.Width = 150
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

        Dim fldQTYOUTColumn As New GridViewTextBoxColumn()
        fldQTYOUTColumn.HeaderText = "QTY"
        fldQTYOUTColumn.FieldName = "fldQTYSOUT"
        fldQTYOUTColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldQTYOUTColumn.Width = 80
        fldQTYOUTColumn.IsVisible = False
        gvlist.Columns.Add(fldQTYOUTColumn)



    End Sub

End Class
