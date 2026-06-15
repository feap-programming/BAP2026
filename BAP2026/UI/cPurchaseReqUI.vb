Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Themes
Imports Telerik.WinControls
Public Class cPurchaseReqUI



    Public Sub cbInvestment(combobox As RadMultiColumnComboBox)




        combobox.MultiColumnComboBoxElement.DropDownWidth = 600

        For Each col As GridViewDataColumn In combobox.EditorControl.Columns
            Select Case col.FieldName
                Case "fldInvestmentNo", "fldApprovedBudget", "PRAmount"
                    col.IsVisible = True
                Case Else
                    col.IsVisible = False
            End Select
        Next

        ' Set friendly column headers
        If combobox.EditorControl.Columns("fldInvestmentNo") IsNot Nothing Then
            combobox.EditorControl.Columns("fldInvestmentNo").HeaderText = "Investment No."
            combobox.EditorControl.Columns("fldInvestmentNo").Width = 175
        End If
        If combobox.EditorControl.Columns("fldApprovedBudget") IsNot Nothing Then
            combobox.EditorControl.Columns("fldApprovedBudget").HeaderText = "Approved Budget"
            combobox.EditorControl.Columns("fldApprovedBudget").Width = 233
        End If
        If combobox.EditorControl.Columns("PRAmount") IsNot Nothing Then
            combobox.EditorControl.Columns("PRAmount").HeaderText = "PR Amount"
            combobox.EditorControl.Columns("PRAmount").Width = 170
        End If

    End Sub


    Public Sub designgridPR(gv As RadGridView)

        ThemeResolutionService.ApplyThemeToControlTree(gv, "VisualStudio2012Light")

        gv.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
        gv.ReadOnly = True
        gv.AllowAddNewRow = False
        gv.AllowDeleteRow = True
        gv.ShowFilteringRow = True
        gv.MasterTemplate.ShowRowHeaderColumn = False
        gv.EnableAlternatingRowColor = True
        gv.TableElement.DrawFill = True
        gv.EnableHotTracking = True
        gv.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.FullRowSelect
        gv.MultiSelect = False
        gv.MasterTemplate.AllowAddNewRow = False
        gv.MasterTemplate.AllowDeleteRow = True
        gv.MasterTemplate.AllowEditRow = False
        gv.SelectionMode = GridViewSelectionMode.FullRowSelect


        gv.MasterTemplate.EnableAlternatingRowColor = True

        Dim colNo As New GridViewTextBoxColumn()
        colNo.HeaderText = "NO"
        colNo.FieldName = "NO"
        colNo.Width = 50
        colNo.PinPosition = PinnedColumnPosition.Left
        colNo.TextAlignment = ContentAlignment.MiddleCenter
        colNo.IsVisible = True


        Dim colPRNO As New GridViewTextBoxColumn()
        colPRNO.FieldName = "PRNo"
        colPRNO.HeaderText = "Principal No"
        colPRNO.Width = 80
        colPRNO.IsVisible = True
        colPRNO.TextAlignment = ContentAlignment.MiddleCenter

        Dim colSubRefNo As New GridViewTextBoxColumn()
        colSubRefNo.FieldName = "SubRefNo"
        colSubRefNo.Width = 170
        colSubRefNo.TextAlignment = ContentAlignment.MiddleCenter
        colSubRefNo.HeaderText = "Sub Ref No"
        colSubRefNo.IsVisible = True

        Dim colItemCode As New GridViewTextBoxColumn()
        colItemCode.Width = 180
        colItemCode.TextAlignment = ContentAlignment.MiddleCenter
        colItemCode.FieldName = "ItemCode"
        colItemCode.HeaderText = "Item Code"
        colItemCode.IsVisible = True

        Dim colDesc As New GridViewTextBoxColumn()
        colDesc.FieldName = "Description"
        colDesc.HeaderText = "Description"
        colDesc.IsVisible = True
        colDesc.TextAlignment = ContentAlignment.MiddleCenter
        colDesc.Width = 320

        Dim colQty As New GridViewTextBoxColumn()
        colQty.FieldName = "Qty"
        colQty.HeaderText = "Quantity"
        colQty.IsVisible = True
        colQty.TextAlignment = ContentAlignment.MiddleCenter
        colQty.Width = 190

        Dim colClassification As New GridViewTextBoxColumn()
        colClassification.FieldName = "Classification"
        colClassification.HeaderText = "Classification"
        colClassification.IsVisible = True
        colClassification.TextAlignment = ContentAlignment.MiddleCenter
        colClassification.Width = 180

        Dim colUnit As New GridViewTextBoxColumn()
        colUnit.FieldName = "Unit"
        colUnit.HeaderText = "Unit"
        colUnit.IsVisible = True
        colUnit.TextAlignment = ContentAlignment.MiddleCenter
        colUnit.Width = 150

        Dim colUnitprice As New GridViewTextBoxColumn()
        colUnitprice.FieldName = "UnitPrice"
        colUnitprice.HeaderText = "Unit Price"
        colUnitprice.IsVisible = True
        colUnitprice.TextAlignment = ContentAlignment.MiddleCenter
        colUnitprice.Width = 190

        Dim colTotalcost As New GridViewTextBoxColumn()
        colTotalcost.FieldName = "Totalcost"
        colTotalcost.HeaderText = "Total Cost"
        colTotalcost.IsVisible = True
        colTotalcost.TextAlignment = ContentAlignment.MiddleCenter
        colTotalcost.Width = 190


        Dim colunitpricejpy As New GridViewTextBoxColumn()
        colunitpricejpy.FieldName = "Unitpricejpy"
        colunitpricejpy.HeaderText = "Unit Price JPY"
        colunitpricejpy.IsVisible = True
        colunitpricejpy.TextAlignment = ContentAlignment.MiddleCenter
        colunitpricejpy.Width = 150

        Dim colTotalJPY As New GridViewTextBoxColumn()
        colTotalJPY.FieldName = "Totaljpy"
        colTotalJPY.HeaderText = "Total Cost JPY"
        colTotalJPY.IsVisible = True
        colTotalJPY.TextAlignment = ContentAlignment.MiddleCenter
        colTotalJPY.Width = 150

        Dim colPEZA As New GridViewTextBoxColumn()
        colPEZA.FieldName = "PEZA"
        colPEZA.HeaderText = "PEZA"
        colPEZA.IsVisible = True
        colPEZA.TextAlignment = ContentAlignment.MiddleCenter
        colPEZA.Width = 150


        Dim colFixClass As New GridViewTextBoxColumn()
        colFixClass.FieldName = "fixclass"
        colFixClass.HeaderText = "Fixed Class"
        colFixClass.IsVisible = True
        colFixClass.TextAlignment = ContentAlignment.MiddleCenter
        colFixClass.Width = 120

        Dim colType As New GridViewTextBoxColumn()
        colType.FieldName = "Type"
        colType.HeaderText = "Type"
        colType.IsVisible = True
        colType.TextAlignment = ContentAlignment.MiddleCenter
        colType.Width = 150

        Dim colAssembly As New GridViewTextBoxColumn()
        colAssembly.FieldName = "Assembly"
        colAssembly.HeaderText = "Assembly Type"
        colAssembly.IsVisible = True
        colAssembly.TextAlignment = ContentAlignment.MiddleCenter
        colAssembly.Width = 150

        Dim colDelete As New GridViewCommandColumn()
        colDelete.FieldName = "Delete"
        colDelete.TextAlignment = ContentAlignment.MiddleCenter
        colDelete.IsVisible = True
        colDelete.PinPosition = PinnedColumnPosition.Right
        colDelete.UseDefaultText = True
        colDelete.DefaultText = "Delete"


        gv.Columns.Add(colNo)
        gv.Columns.Add(colPRNO)
        gv.Columns.Add(colSubRefNo)
        gv.Columns.Add(colItemCode)
        gv.Columns.Add(colDesc)
        gv.Columns.Add(colQty)
        gv.Columns.Add(colClassification)
        gv.Columns.Add(colUnit)
        gv.Columns.Add(colUnitprice)
        gv.Columns.Add(colTotalcost)
        gv.Columns.Add(colunitpricejpy)
        gv.Columns.Add(colTotalJPY)
        gv.Columns.Add(colPEZA)
        gv.Columns.Add(colFixClass)
        gv.Columns.Add(colType)
        gv.Columns.Add(colAssembly)
        gv.Columns.Add(colDelete)





    End Sub



End Class
