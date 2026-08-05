Imports System.Windows.Controls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Themes
Imports Telerik.WinControls

Public Class cViewPRUI




    Public Sub DesigngridPR(gv As RadGridView)



        'ThemeResolutionService.ApplyThemeToControlTree(gv, "VisualStudio2012Light")

        gv.BeginUpdate()

        gv.AutoGenerateColumns = False
        gv.Columns.Clear()

        gv.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
        gv.ReadOnly = True
        gv.AllowAddNewRow = False
        gv.AllowDeleteRow = True
        gv.ShowFilteringRow = True
        gv.MasterTemplate.ShowRowHeaderColumn = False
        gv.EnableAlternatingRowColor = True
        gv.EnableHotTracking = True
        gv.SelectionMode = GridViewSelectionMode.FullRowSelect
        gv.MultiSelect = False
        gv.MasterTemplate.AllowAddNewRow = False
        gv.MasterTemplate.AllowDeleteRow = True
        gv.MasterTemplate.AllowEditRow = False


        Dim Print As New GridViewCommandColumn()
        Print.Name = "PRINTPR"
        Print.HeaderText = "Print PR"
        Print.DefaultText = "PRINT PR"
        Print.UseDefaultText = True
        Print.TextAlignment = ContentAlignment.MiddleCenter
        Print.HeaderTextAlignment = ContentAlignment.MiddleCenter
        Print.Width = 90
        gv.Columns.Add(Print)


        Dim colOIDColumn As New GridViewDecimalColumn()
        colOIDColumn.HeaderText = "ID"
        colOIDColumn.FieldName = "fldOrderID"
        colOIDColumn.ReadOnly = True
        colOIDColumn.TextAlignment = ContentAlignment.MiddleCenter
        colOIDColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colOIDColumn.IsVisible = True
        colOIDColumn.Width = 40
        gv.Columns.Add(colOIDColumn)

        Dim colTranscode As New GridViewDecimalColumn()
        colTranscode.HeaderText = "Transcode"
        colTranscode.FieldName = "fldTransCode"
        colTranscode.ReadOnly = True
        colTranscode.TextAlignment = ContentAlignment.MiddleCenter
        colTranscode.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colTranscode.Width = 125
        colTranscode.IsVisible = True
        gv.Columns.Add(colTranscode)

        Dim colBudReColumn As New GridViewTextBoxColumn()
        colBudReColumn.HeaderText = "Budget Referenece No."
        colBudReColumn.FieldName = "fldBudRefNum"
        colBudReColumn.TextAlignment = ContentAlignment.MiddleCenter
        colBudReColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colBudReColumn.Width = 180
        colBudReColumn.IsVisible = True
        gv.Columns.Add(colBudReColumn)

        Dim colPRNUM As New GridViewTextBoxColumn()
        colPRNUM.Name = "fldPRNo"
        colPRNUM.FieldName = "fldPRNo"
        colPRNUM.HeaderText = "PR NUMBER"
        colPRNUM.TextAlignment = ContentAlignment.MiddleCenter
        colPRNUM.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colPRNUM.Width = 150
        gv.Columns.Add(colPRNUM)

        Dim colMOrder As New GridViewDateTimeColumn()
        colMOrder.HeaderText = "MONTH ORDERED"
        colMOrder.FieldName = "fldMonthOrder"
        colMOrder.TextAlignment = ContentAlignment.MiddleCenter
        colMOrder.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colMOrder.ReadOnly = True
        colMOrder.Width = 110
        colMOrder.FormatString = "{0:MMM dd, yyyy}"
        gv.Columns.Add(colMOrder)

        Dim colDescription As New GridViewTextBoxColumn()
        colDescription.HeaderText = "DESCRIPTION"
        colDescription.FieldName = "fldOrderDesc"
        colDescription.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colDescription.TextAlignment = ContentAlignment.MiddleCenter
        colDescription.Width = 220
        gv.Columns.Add(colDescription)

        Dim colClassCOlumn As New GridViewTextBoxColumn()
        colClassCOlumn.HeaderText = "CLASSIFICATION"
        colClassCOlumn.FieldName = "fldClassification"
        colClassCOlumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colClassCOlumn.TextAlignment = ContentAlignment.MiddleCenter
        colClassCOlumn.Width = 200
        colClassCOlumn.IsVisible = True
        gv.Columns.Add(colClassCOlumn)

        Dim colDept As New GridViewTextBoxColumn()
        colDept.HeaderText = "DEPARTMENT"
        colDept.FieldName = "fldOrderDepartment"
        colDept.TextAlignment = ContentAlignment.MiddleCenter
        colDept.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colDept.Width = 100
        colDept.IsVisible = True
        gv.Columns.Add(colDept)

        Dim colProcess As New GridViewTextBoxColumn(rptName)
        colProcess.HeaderText = "PROCESS"
        colProcess.FieldName = "fldProcess"
        colProcess.TextAlignment = ContentAlignment.MiddleCenter
        colProcess.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colProcess.IsVisible = True
        colProcess.Width = 130
        gv.Columns.Add(colProcess)

        Dim colQTY As New GridViewTextBoxColumn()
        colQTY.HeaderText = "QUANTITY"
        colQTY.FieldName = "fldQTY"
        colQTY.TextAlignment = ContentAlignment.MiddleCenter
        colQTY.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colQTY.IsVisible = True
        colQTY.Width = 100
        gv.Columns.Add(colQTY)

        Dim colRQTY As New GridViewTextBoxColumn()
        colRQTY.HeaderText = "REMAINING QUANTITY"
        colRQTY.FieldName = "RQTY"
        colRQTY.IsVisible = True
        colRQTY.TextAlignment = ContentAlignment.MiddleCenter
        colRQTY.HeaderTextAlignment = ContentAlignment.MiddleCenter
        gv.Columns.Add(colRQTY)

        Dim colUOM As New GridViewComboBoxColumn
        colUOM.HeaderText = "MEASUREMENT OF UNIT"
        colUOM.FieldName = "fldUOM"
        colUOM.IsVisible = True
        colUOM.TextAlignment = ContentAlignment.MiddleCenter
        colUOM.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colUOM.Width = 150
        gv.Columns.Add(colUOM)


        Dim colmDel As New GridViewDateTimeColumn()
        colmDel.HeaderText = "MONTH DELIVERY"
        colmDel.FieldName = "fldMonthDelivery"
        colmDel.TextAlignment = ContentAlignment.MiddleCenter
        colmDel.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colmDel.ReadOnly = True
        colmDel.Width = 120
        colmDel.FormatString = "{0:MMM dd, yyyy}"
        colmDel.IsVisible = True
        gv.Columns.Add(colmDel)

        Dim ColStatus As New GridViewComboBoxColumn()
        ColStatus.HeaderText = "fldOrderStatus"
        ColStatus.FieldName = "fldOrderStatus"
        ColStatus.TextAlignment = ContentAlignment.MiddleCenter
        ColStatus.HeaderTextAlignment = ContentAlignment.MiddleCenter
        ColStatus.Width = 80
        ColStatus.ReadOnly = True
        ColStatus.IsVisible = True
        gv.Columns.Add(ColStatus)

        Dim colRemarks As New GridViewTextBoxColumn()
        colRemarks.HeaderText = "REMARKS"
        colRemarks.FieldName = "fldOrderRemarks"
        colRemarks.TextAlignment = ContentAlignment.MiddleCenter
        colRemarks.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colRemarks.ReadOnly = True
        colRemarks.Width = 120
        colRemarks.IsVisible = True
        gv.Columns.Add(colRemarks)

        Dim colRison As New GridViewTextBoxColumn()
        colRison.HeaderText = "REASON"
        colRison.FieldName = "fldReason"
        colRison.TextAlignment = ContentAlignment.MiddleCenter
        colRison.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colRison.Width = 100
        colRison.IsVisible = False
        gv.Columns.Add(colRison)

        Dim colEOA As New GridViewDecimalColumn()
        colEOA.HeaderText = "ESTIMATED PR AMOUNT"
        colEOA.FieldName = "fldEOA"
        colEOA.TextAlignment = ContentAlignment.MiddleCenter
        colEOA.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colEOA.ReadOnly = True
        colEOA.Width = 120
        colEOA.IsVisible = True
        gv.Columns.Add(colEOA)

        Dim colECC As New GridViewTextBoxColumn()
        colECC.HeaderText = "CURRENCY"
        colECC.FieldName = "fldEC"
        colECC.TextAlignment = ContentAlignment.MiddleCenter
        colECC.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colECC.ReadOnly = True
        colECC.Width = 75
        colECC.IsVisible = True
        gv.Columns.Add(colECC)

        Dim colEJPY As New GridViewDecimalColumn()
        colEJPY.HeaderText = "ESTIMATED PR AMOUNT (JPY)"
        colEJPY.FieldName = "fldEJPY"
        colEJPY.TextAlignment = ContentAlignment.MiddleCenter
        colEJPY.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colEJPY.ReadOnly = True
        colEJPY.Width = 180
        colEJPY.IsVisible = True
        colEJPY.FormatString = "{0:N6}"
        gv.Columns.Add(colEJPY)

        Dim colTOPRA As New GridViewDecimalColumn()
        colTOPRA.HeaderText = "OPEN PR AMOUNT"
        colTOPRA.FieldName = "fldTOPRA"
        colTOPRA.TextAlignment = ContentAlignment.MiddleCenter
        colTOPRA.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colTOPRA.ReadOnly = True
        colTOPRA.Width = 180
        colTOPRA.IsVisible = True
        colTOPRA.FormatString = "{0:N6}"
        gv.Columns.Add(colTOPRA)

        Dim colTDOPRA As New GridViewDecimalColumn()
        colTDOPRA.HeaderText = "OPEN DEPT. PR AMOUNT"
        colTDOPRA.FieldName = "fldTDOPRA"
        colTDOPRA.TextAlignment = ContentAlignment.MiddleCenter
        colTDOPRA.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colTDOPRA.ReadOnly = True
        colTDOPRA.Width = 180
        colTDOPRA.IsVisible = True
        colTDOPRA.FormatString = "{0:N6}"
        gv.Columns.Add(colTDOPRA)

        Dim colRBLPR As New GridViewDecimalColumn()
        colRBLPR.HeaderText = "RBLPR"
        colRBLPR.FieldName = "fldRBLPR"
        colRBLPR.TextAlignment = ContentAlignment.MiddleCenter
        colRBLPR.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colRBLPR.ReadOnly = True
        colRBLPR.Width = 180
        colRBLPR.IsVisible = True
        colRBLPR.FormatString = "{0:N6}"
        gv.Columns.Add(colRBLPR)

        Dim colRDBLPR As New GridViewDecimalColumn()
        colRDBLPR.HeaderText = "RDBLPR"
        colRDBLPR.FieldName = "fldRDBLPR"
        colRDBLPR.TextAlignment = ContentAlignment.MiddleCenter
        colRDBLPR.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colRDBLPR.ReadOnly = True
        colRDBLPR.Width = 180
        colRDBLPR.IsVisible = True
        colRDBLPR.FormatString = "{0:N6}"
        gv.Columns.Add(colRDBLPR)

        Dim colRB As New GridViewDecimalColumn()
        colRB.HeaderText = "RB"
        colRB.FieldName = "fldRB"
        colRB.TextAlignment = ContentAlignment.MiddleCenter
        colRB.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colRB.ReadOnly = True
        colRB.Width = 180
        colRB.IsVisible = True
        colRB.FormatString = "{0:N6}"
        gv.Columns.Add(colRB)

        Dim colRDB As New GridViewDecimalColumn()
        colRDB.HeaderText = "RDB"
        colRDB.FieldName = "fldRDB"
        colRDB.TextAlignment = ContentAlignment.MiddleCenter
        colRDB.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colRDB.ReadOnly = True
        colRDB.Width = 180
        colRDB.IsVisible = True
        colRDB.FormatString = "{0:N6}"
        gv.Columns.Add(colRDB)

        Dim colTPRO As New GridViewDecimalColumn()
        colTPRO.HeaderText = "Total PRO"
        colTPRO.FieldName = "TPRO"
        colTPRO.TextAlignment = ContentAlignment.MiddleCenter
        colTPRO.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colTPRO.ReadOnly = True
        colTPRO.Width = 180
        colTPRO.IsVisible = True
        colTPRO.FormatString = "{0:N6}"
        gv.Columns.Add(colTPRO)

        Dim colRN As New GridViewTextBoxColumn()
        colRN.HeaderText = "REIMBURSEMENT NO."
        colRN.FieldName = "fldRN"
        colRN.TextAlignment = ContentAlignment.MiddleCenter
        colRN.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colRN.ReadOnly = True
        colRN.Width = 180
        colRN.IsVisible = True
        colRN.FormatString = "{0:N6}"
        gv.Columns.Add(colRN)

        Dim colSignature As New GridViewTextBoxColumn()
        colSignature.HeaderText = "SIGNATURE"
        colSignature.FieldName = "fldSignature"
        colSignature.TextAlignment = ContentAlignment.MiddleCenter
        colSignature.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colSignature.ReadOnly = True
        colSignature.Width = 180
        colSignature.IsVisible = True
        gv.Columns.Add(colSignature)

        Dim colPrint As New GridViewTextBoxColumn()
        colPrint.HeaderText = "PRINT"
        colPrint.FieldName = "fldPRINT"
        colPrint.TextAlignment = ContentAlignment.MiddleCenter
        colPrint.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colPrint.ReadOnly = True
        colPrint.Width = 180
        colPrint.IsVisible = True
        gv.Columns.Add(colPrint)

        Dim PrintSum As New GridViewCommandColumn()
        PrintSum.Name = "PRINTSUM"
        PrintSum.HeaderText = "Print Sum"
        PrintSum.DefaultText = "SUMMARY"
        PrintSum.UseDefaultText = True
        PrintSum.TextAlignment = ContentAlignment.MiddleCenter
        PrintSum.HeaderTextAlignment = ContentAlignment.MiddleCenter
        PrintSum.Width = 120
        gv.Columns.Add(PrintSum)

        Dim colDelete As New GridViewCommandColumn()
        colDelete.Name = "REMOVE"
        colDelete.HeaderText = "REMOVE"
        colDelete.DefaultText = "REMOVE"
        colDelete.UseDefaultText = True
        colDelete.Width = 120
        colDelete.TextAlignment = ContentAlignment.MiddleCenter
        colDelete.HeaderTextAlignment = ContentAlignment.MiddleCenter
        gv.Columns.Add(colDelete)

        Dim colPOCount As New GridViewTextBoxColumn()
        colPOCount.HeaderText = "POCOUNT"
        colPOCount.FieldName = "POCOUNT"
        colPOCount.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colPOCount.TextAlignment = ContentAlignment.MiddleCenter
        colPOCount.IsVisible = True
        colPOCount.ReadOnly = True
        gv.Columns.Add(colPOCount)

        Dim colMoldie As New GridViewTextBoxColumn()
        colMoldie.HeaderText = "Mold Die Name"
        colMoldie.FieldName = "fldMoldDie"
        colMoldie.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colMoldie.TextAlignment = ContentAlignment.MiddleCenter
        colMoldie.IsVisible = True
        colMoldie.Width = 100
        gv.Columns.Add(colMoldie)


        gv.Columns("PRINTPR").IsPinned = True
        gv.Columns("PRINTPR").PinPosition = PinnedColumnPosition.Left

        gv.Columns("fldPRNo").IsPinned = True
        gv.Columns("fldPRNo").PinPosition = PinnedColumnPosition.Left

        gv.Columns("REMOVE").IsPinned = True
        gv.Columns("REMOVE").PinPosition = PinnedColumnPosition.Right

        gv.Columns("PRINTSUM").IsPinned = True
        gv.Columns("PRINTSUM").PinPosition = PinnedColumnPosition.Right

        gv.EndUpdate()

    End Sub


    Public Sub DesigngridPRlist(gv As RadGridView)



        'ThemeResolutionService.ApplyThemeToControlTree(gv, "VisualStudio2012Light")

        'gv.BeginUpdate()

        gv.AutoGenerateColumns = False
        gv.Columns.Clear()

        gv.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
        gv.ReadOnly = True
        gv.AllowAddNewRow = False
        gv.AllowDeleteRow = True
        gv.ShowFilteringRow = True
        gv.MasterTemplate.ShowRowHeaderColumn = False
        gv.EnableAlternatingRowColor = True
        gv.EnableHotTracking = True
        gv.SelectionMode = GridViewSelectionMode.FullRowSelect
        gv.MultiSelect = False
        gv.MasterTemplate.AllowAddNewRow = False
        gv.MasterTemplate.AllowDeleteRow = True
        gv.MasterTemplate.AllowEditRow = False




        Dim colOIDColumn As New GridViewDecimalColumn()
        colOIDColumn.HeaderText = "UC4S"
        colOIDColumn.FieldName = "fldUC4S"
        colOIDColumn.ReadOnly = True
        colOIDColumn.TextAlignment = ContentAlignment.MiddleCenter
        colOIDColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colOIDColumn.IsVisible = False
        colOIDColumn.Width = 150
        gv.Columns.Add(colOIDColumn)

        Dim colMOIID As New GridViewTextBoxColumn()
        colMOIID.HeaderText = "MOIID"
        colMOIID.FieldName = "fldMOIID"
        colMOIID.ReadOnly = True
        colMOIID.TextAlignment = ContentAlignment.MiddleCenter
        colMOIID.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colMOIID.IsVisible = False
        colMOIID.Width = 150
        gv.Columns.Add(colMOIID)

        Dim colTransCode As New GridViewTextBoxColumn()
        colTransCode.HeaderText = "TransCode"
        colTransCode.FieldName = "fldTransCode"
        colTransCode.ReadOnly = True
        colTransCode.TextAlignment = ContentAlignment.MiddleCenter
        colTransCode.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colTransCode.IsVisible = False
        colTransCode.Width = 150
        gv.Columns.Add(colTransCode)

        Dim colBudrefNum As New GridViewTextBoxColumn()
        colBudrefNum.HeaderText = "BUDGET REF NO."
        colBudrefNum.FieldName = "fldBudRefNum"
        colBudrefNum.ReadOnly = True
        colBudrefNum.TextAlignment = ContentAlignment.MiddleCenter
        colBudrefNum.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colBudrefNum.IsVisible = True
        colBudrefNum.Width = 150
        gv.Columns.Add(colBudrefNum)

        Dim colItemCode As New GridViewTextBoxColumn()
        colItemCode.HeaderText = "ITEM CODE"
        colItemCode.FieldName = "fldICode"
        colItemCode.ReadOnly = True
        colItemCode.TextAlignment = ContentAlignment.MiddleCenter
        colItemCode.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colItemCode.IsVisible = False
        colItemCode.Width = 150
        gv.Columns.Add(colItemCode)

        Dim colDesc As New GridViewTextBoxColumn()
        colDesc.HeaderText = "DESCRIPTION"
        colDesc.FieldName = "fldDesc"
        colDesc.ReadOnly = True
        colDesc.TextAlignment = ContentAlignment.MiddleCenter
        colDesc.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colDesc.IsVisible = True
        colDesc.Width = 260
        gv.Columns.Add(colDesc)

        Dim colQTY As New GridViewTextBoxColumn()
        colQTY.HeaderText = "PR QTY"
        colQTY.FieldName = "fldQTY"
        colQTY.ReadOnly = True
        colQTY.TextAlignment = ContentAlignment.MiddleCenter
        colQTY.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colQTY.IsVisible = True
        colQTY.Width = 100
        gv.Columns.Add(colQTY)

        Dim colQTYEB As New GridViewTextBoxColumn()
        colQTYEB.HeaderText = "REMAINING QTY"
        colQTYEB.FieldName = "fldQTYEB"
        colQTYEB.ReadOnly = True
        colQTYEB.TextAlignment = ContentAlignment.MiddleCenter
        colQTYEB.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colQTYEB.IsVisible = True
        colQTYEB.Width = 150
        gv.Columns.Add(colQTYEB)

        Dim colQTYSOUT As New GridViewTextBoxColumn()
        colQTYSOUT.HeaderText = "PO QTY"
        colQTYSOUT.FieldName = "fldQTYSOUT"
        colQTYSOUT.ReadOnly = True
        colQTYSOUT.TextAlignment = ContentAlignment.MiddleCenter
        colQTYSOUT.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colQTYSOUT.IsVisible = True
        colQTYSOUT.Width = 150
        gv.Columns.Add(colQTYSOUT)

        Dim colunit As New GridViewTextBoxColumn()
        colunit.HeaderText = "UNIT"
        colunit.FieldName = "fldUnit"
        colunit.ReadOnly = True
        colunit.TextAlignment = ContentAlignment.MiddleCenter
        colunit.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colunit.IsVisible = True
        colunit.Width = 100
        gv.Columns.Add(colunit)

        Dim colStat As New GridViewTextBoxColumn()
        colStat.HeaderText = "STATUS"
        colStat.FieldName = "fldStat"
        colStat.ReadOnly = True
        colStat.TextAlignment = ContentAlignment.MiddleCenter
        colStat.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colStat.PinPosition = PinnedColumnPosition.Right
        colStat.IsPinned = True
        colStat.IsVisible = True
        colStat.Width = 100
        gv.Columns.Add(colStat)

        'Dim colRS As New GridViewTextBoxColumn()
        'colRS.HeaderText = "STATUS"
        'colRS.FieldName = "fldStat"
        'colRS.HeaderTextAlignment = ContentAlignment.MiddleCenter
        'colRS.ReadOnly = True
        'colRS.TextAlignment = ContentAlignment.MiddleCenter
        'colRS.PinPosition = PinnedColumnPosition.Right
        'colRS.IsPinned = True
        'colRS.IsVisible = True
        'colRS.Width = 100
        'gv.Columns.Add(colRS)

        Dim colRemarks As New GridViewTextBoxColumn()
        colRemarks.HeaderText = "REMARKS"
        colRemarks.FieldName = "fldRS"
        colRemarks.HeaderTextAlignment = ContentAlignment.MiddleCenter
        colRemarks.TextAlignment = ContentAlignment.MiddleCenter
        colRemarks.ReadOnly = True
        colRemarks.IsVisible = True
        colRemarks.Width = 150
        gv.Columns.Add(colRemarks)

        'gv.EndUpdate()

    End Sub



End Class
