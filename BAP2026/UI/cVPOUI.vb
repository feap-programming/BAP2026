Imports System.Runtime.CompilerServices
Imports System.Windows
Imports System.Windows.Controls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents.Spreadsheet.Expressions.Functions

Public Class cVPOUI





    Public Sub rgvPOLIST(GV As RadGridView)



        ThemeResolutionService.ApplyThemeToControlTree(GV, "VisualStudio2012Light")

        GV.AutoGenerateColumns = False
        GV.Columns.Clear()

        GV.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None

        GV.ReadOnly = True
        GV.AllowDeleteRow = False
        GV.AllowEditRow = False

        GV.AllowAddNewRow = False
        GV.ShowFilteringRow = True
        GV.EnableAlternatingRowColor = True

        GV.EnableFiltering = True

        GV.ShowGroupPanel = False

        GV.SelectionMode = GridViewSelectionMode.FullRowSelect
        GV.TableElement.TextAlignment = ContentAlignment.MiddleCenter
        GV.TableElement.RowHeight = 30

        Dim fldPOIDColumn As New GridViewTextBoxColumn()
        fldPOIDColumn.HeaderText = "ID"
        fldPOIDColumn.FieldName = "fldPOID"
        fldPOIDColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldPOIDColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldPOIDColumn.Width = 100
        GV.Columns.Add(fldPOIDColumn)

        Dim fldIndexColumn As New GridViewTextBoxColumn()
        fldIndexColumn.HeaderText = "Index"
        fldIndexColumn.FieldName = "fldIndex"
        fldIndexColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldIndexColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldIndexColumn.Width = 100
        fldIndexColumn.IsVisible = False
        fldIndexColumn.PinPosition = PinnedColumnPosition.Left
        fldIndexColumn.IsPinned = True
        GV.Columns.Add(fldIndexColumn)

        Dim fldDocNum As New GridViewTextBoxColumn()
        fldDocNum.HeaderText = "PO Number"
        fldDocNum.FieldName = "DocNum"
        fldDocNum.TextAlignment = ContentAlignment.MiddleCenter
        fldDocNum.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldDocNum.IsVisible = True
        fldDocNum.Width = 100
        GV.Columns.Add(fldDocNum)


        'Dim fldPONumberColumn As New GridViewTextBoxColumn()
        'fldPONumberColumn.HeaderText = "PO Number"
        'fldPONumberColumn.FieldName = "PO"
        'fldPONumberColumn.TextAlignment = ContentAlignment.MiddleCenter
        'fldPONumberColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        'fldPOIDColumn.IsVisible = False
        'fldPONumberColumn.Width = 100
        'GV.Columns.Add(fldPONumberColumn)

        Dim fldOBLINE As New GridViewTextBoxColumn()
        fldOBLINE.Name = "OB_LINE"
        fldOBLINE.HeaderText = "OB LINE"
        fldOBLINE.FieldName = "OB_LINE"
        fldOBLINE.TextAlignment = ContentAlignment.MiddleCenter
        fldOBLINE.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldOBLINE.Width = 100
        GV.Columns.Add(fldOBLINE)

        Dim fldVCodeColumn As New GridViewTextBoxColumn()
        fldVCodeColumn.HeaderText = "Vendor Code"
        fldVCodeColumn.FieldName = "fldVCode"
        fldVCodeColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldVCodeColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldVCodeColumn.Width = 100
        GV.Columns.Add(fldVCodeColumn)

        Dim fldSupplierColumn As New GridViewTextBoxColumn()
        fldSupplierColumn.HeaderText = "Supplier"
        fldSupplierColumn.FieldName = "fldSupplier"
        fldSupplierColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldSupplierColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldSupplierColumn.Width = 250
        GV.Columns.Add(fldSupplierColumn)

        Dim fldMOrderColumn As New GridViewTextBoxColumn()
        fldMOrderColumn.HeaderText = "Order Date"
        fldMOrderColumn.FieldName = "fldMOrdered"
        fldMOrderColumn.ReadOnly = True
        fldMOrderColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldMOrderColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldMOrderColumn.Width = 100
        fldMOrderColumn.FormatString = "{0:MMM dd, yyyy}"
        GV.Columns.Add(fldMOrderColumn)

        Dim fldDateColumn As New GridViewDateTimeColumn()
        fldDateColumn.HeaderText = "Delivery Date"
        fldDateColumn.FieldName = "fldDDate"
        fldDateColumn.ReadOnly = True
        fldDateColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldDateColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        GV.Columns.Add(fldDateColumn)

        Dim fldCurrencyColumn As New GridViewTextBoxColumn()
        fldCurrencyColumn.HeaderText = "Currency"
        fldCurrencyColumn.FieldName = "fldCurrency"
        fldCurrencyColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldCurrencyColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldCurrencyColumn.ReadOnly = True
        GV.Columns.Add(fldCurrencyColumn)

        Dim fldStatColumn As New GridViewTextBoxColumn()
        fldStatColumn.HeaderText = "Status"
        fldStatColumn.FieldName = "fldStat"
        fldStatColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldStatColumn.HeaderText = ContentAlignment.MiddleCenter
        fldStatColumn.ReadOnly = True
        fldStatColumn.IsVisible = False
        GV.Columns.Add(fldStatColumn)

        Dim fldTPOColumn As New GridViewDecimalColumn()
        fldTPOColumn.HeaderText = "Total PO Amount"
        fldTPOColumn.FieldName = "fldTPO"
        fldTPOColumn.ReadOnly = True
        fldTPOColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldTPOColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldTPOColumn.FormatString = "{0:N2}"
        GV.Columns.Add(fldTPOColumn)

        Dim OB_POAmtColumn As New GridViewDecimalColumn()
        OB_POAmtColumn.HeaderText = "Total PO With Discount"
        OB_POAmtColumn.FieldName = "OB_POAmt"
        OB_POAmtColumn.ReadOnly = True
        OB_POAmtColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        OB_POAmtColumn.TextAlignment = ContentAlignment.MiddleCenter
        GV.Columns.Add(OB_POAmtColumn)

        Dim columnDiscount As New GridViewDecimalColumn()
        columnDiscount.HeaderText = "%"
        columnDiscount.FieldName = "fldDiscount"
        columnDiscount.ReadOnly = True
        columnDiscount.TextAlignment = ContentAlignment.MiddleCenter
        columnDiscount.HeaderTextAlignment = ContentAlignment.MiddleCenter
        columnDiscount.Width = 100
        columnDiscount.FormatString = "{0:N2}"
        GV.Columns.Add(columnDiscount)

        Dim fldRemarksColumn As New GridViewTextBoxColumn()
        fldRemarksColumn.HeaderText = "REMARKS"
        fldRemarksColumn.FieldName = "fldRemarks"
        fldRemarksColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldRemarksColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldRemarksColumn.Width = 100
        GV.Columns.Add(fldRemarksColumn)

        Dim fldForcePOColumn As New GridViewTextBoxColumn()
        fldForcePOColumn.HeaderText = "FPO"
        fldForcePOColumn.FieldName = "fldForcePO"
        fldForcePOColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldForcePOColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldForcePOColumn.Width = 100
        GV.Columns.Add(fldForcePOColumn)

        Dim SignatureColumn As New GridViewTextBoxColumn()
        SignatureColumn.HeaderText = "SIGNATURE"
        SignatureColumn.FieldName = "fldSignature"
        SignatureColumn.ReadOnly = True
        SignatureColumn.TextAlignment = ContentAlignment.MiddleCenter
        SignatureColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        SignatureColumn.Width = 150
        GV.Columns.Add(SignatureColumn)

        Dim printPO As New GridViewCommandColumn()
        printPO.Name = "PrintPO"
        printPO.HeaderText = "Print PO"
        printPO.DefaultText = "Print"
        printPO.TextAlignment = ContentAlignment.MiddleCenter
        printPO.HeaderTextAlignment = ContentAlignment.MiddleCenter
        printPO.UseDefaultText = True
        printPO.Width = 100
        printPO.IsPinned = True
        printPO.PinPosition = PinnedColumnPosition.Right
        GV.Columns.Add(printPO)


        Dim printCSV As New GridViewCommandColumn()
        printCSV.Name = "PrintCSV"
        printCSV.HeaderText = "Print CSV"
        printCSV.DefaultText = "CSV"
        printCSV.TextAlignment = ContentAlignment.MiddleCenter
        printCSV.HeaderTextAlignment = ContentAlignment.MiddleCenter
        printCSV.UseDefaultText = True
        printCSV.Width = 100
        printCSV.IsPinned = True
        printCSV.PinPosition = PinnedColumnPosition.Right
        GV.Columns.Add(printCSV)



    End Sub

    Public Sub POIGRID(GV As RadGridView)

        ThemeResolutionService.ApplyThemeToControlTree(GV, "VisualStudio2012Light")

        GV.AutoGenerateColumns = False
        GV.Columns.Clear()

        GV.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None

        GV.ReadOnly = True
        GV.AllowDeleteRow = False
        GV.AllowEditRow = False
        GV.AllowAddNewRow = False
        GV.ShowFilteringRow = True
        GV.EnableAlternatingRowColor = True
        GV.EnableFiltering = True
        GV.ShowGroupPanel = False
        GV.SelectionMode = GridViewSelectionMode.FullRowSelect
        GV.TableElement.TextAlignment = ContentAlignment.MiddleCenter
        GV.TableElement.RowHeight = 30

        Dim fldPOIDColumn As New GridViewTextBoxColumn()
        fldPOIDColumn.HeaderText = "ID"
        fldPOIDColumn.FieldName = "fldPOIID"
        fldPOIDColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldPOIDColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldPOIDColumn.Width = 100
        GV.Columns.Add(fldPOIDColumn)

        Dim fldPONumberColumn As New GridViewTextBoxColumn()
        fldPONumberColumn.HeaderText = "PO NUMBER"
        fldPONumberColumn.FieldName = "PO"
        fldPONumberColumn.ReadOnly = True
        fldPONumberColumn.IsVisible = False
        fldPONumberColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldPONumberColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldPONumberColumn.Width = 100
        GV.Columns.Add(fldPONumberColumn)

        Dim fldMOOID As New GridViewTextBoxColumn()
        fldMOOID.HeaderText = "MOIID"
        fldMOOID.FieldName = "fldMOIID"
        fldMOOID.ReadOnly = True
        fldMOOID.TextAlignment = ContentAlignment.MiddleCenter
        fldMOOID.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldMOOID.IsVisible = False
        fldMOOID.Width = True
        fldMOOID.PinPosition = PinnedColumnPosition.Right
        fldMOOID.IsPinned = True
        GV.Columns.Add(fldMOOID)

        Dim fldBudRefNumColumn As New GridViewTextBoxColumn()
        fldBudRefNumColumn.HeaderText = "BUDGET REFERENCE NO "
        fldBudRefNumColumn.FieldName = "fldBudRefNum"
        fldBudRefNumColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldBudRefNumColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldBudRefNumColumn.ReadOnly = True
        fldBudRefNumColumn.Width = 100
        fldBudRefNumColumn.PinPosition = PinnedColumnPosition.Right
        fldBudRefNumColumn.IsPinned = True
        GV.Columns.Add(fldBudRefNumColumn)

        Dim OBLINECOLumn As New GridViewTextBoxColumn()
        OBLINECOLumn.HeaderText = "OB LINE"
        OBLINECOLumn.FieldName = "OB_Line"
        OBLINECOLumn.TextAlignment = ContentAlignment.MiddleCenter
        OBLINECOLumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        OBLINECOLumn.ReadOnly = True
        OBLINECOLumn.Width = 90
        OBLINECOLumn.PinPosition = PinnedColumnPosition.Right
        OBLINECOLumn.IsPinned = True
        GV.Columns.Add(OBLINECOLumn)

        Dim fldIndexColumn As New GridViewTextBoxColumn()
        fldIndexColumn.HeaderText = "INDEX"
        fldIndexColumn.FieldName = "fldIndex"
        fldIndexColumn.ReadOnly = True
        fldIndexColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldIndexColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldIndexColumn.Width = 100
        fldIndexColumn.PinPosition = PinnedColumnPosition.Left
        fldIndexColumn.IsPinned = True
        fldIndexColumn.IsVisible = False
        GV.Columns.Add(fldIndexColumn)

        Dim fldPRNoColumn As New GridViewTextBoxColumn()
        fldPRNoColumn.HeaderText = "PR NUMBER"
        fldPRNoColumn.FieldName = "fldPRNo"
        fldPRNoColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldPRNoColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldPRNoColumn.ReadOnly = True
        fldPRNoColumn.Width = 200
        GV.Columns.Add(fldPRNoColumn)

        Dim fldICodeColumn As New GridViewTextBoxColumn()
        fldICodeColumn.HeaderText = "ITEM CODE"
        fldICodeColumn.FieldName = "fldICode"
        fldICodeColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldICodeColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldICodeColumn.ReadOnly = True
        fldICodeColumn.Width = 210
        GV.Columns.Add(fldICodeColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn()
        fldDescColumn.HeaderText = "ITEM DESCRIPTION"
        fldDescColumn.FieldName = "fldDesc"
        fldDescColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldDescColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldDescColumn.Width = 250
        fldDescColumn.ReadOnly = True
        GV.Columns.Add(fldDescColumn)

        Dim fldQTycolumn As New GridViewDecimalColumn()
        fldQTycolumn.HeaderText = "QTY"
        fldQTycolumn.FieldName = "RQTY"
        fldQTycolumn.TextAlignment = ContentAlignment.MiddleCenter
        fldQTycolumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldQTycolumn.Width = 100
        fldQTycolumn.FormatString = "{0:N2}"
        fldQTycolumn.ReadOnly = True
        GV.Columns.Add(fldQTycolumn)

        Dim UnitColumn As New GridViewDecimalColumn()
        UnitColumn.HeaderText = "UNIT"
        UnitColumn.FieldName = "fldUnit"
        UnitColumn.TextAlignment = ContentAlignment.MiddleCenter
        UnitColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        UnitColumn.Width = 160
        UnitColumn.ReadOnly = True
        UnitColumn.FormatString = "{0:N2}"
        GV.Columns.Add(UnitColumn)

        Dim fldUPriceColumn As New GridViewDecimalColumn()
        fldUPriceColumn.HeaderText = "UNIT PRICE"
        fldUPriceColumn.FieldName = "fldUPrice"
        fldUPriceColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldUPriceColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldUPriceColumn.Width = 185
        fldUPriceColumn.ReadOnly = True
        fldUPriceColumn.FormatString = "{0:N2}"
        GV.Columns.Add(fldUPriceColumn)

        Dim fldRateColumn As New GridViewDecimalColumn()
        fldRateColumn.HeaderText = "RATE"
        fldRateColumn.FieldName = "fldRate"
        fldRateColumn.ReadOnly = True
        fldRateColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldRateColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldRateColumn.FormatString = "{0:N6}"
        fldRateColumn.Width = 180
        GV.Columns.Add(fldRateColumn)

        Dim fldYenSAPCOLUMN As New GridViewDecimalColumn()
        fldYenSAPCOLUMN.HeaderText = "SAP JPY"
        fldYenSAPCOLUMN.FieldName = "fldYenSap"
        fldYenSAPCOLUMN.ReadOnly = True
        fldYenSAPCOLUMN.TextAlignment = ContentAlignment.MiddleCenter
        fldYenSAPCOLUMN.Width = 200
        fldYenSAPCOLUMN.FormatString = "{0:N6}"
        GV.Columns.Add(fldYenSAPCOLUMN)

        Dim fldGRPOQTY As New GridViewDecimalColumn()
        fldGRPOQTY.HeaderText = "GRPO QTY"
        fldGRPOQTY.FieldName = "GRPOQTY"
        fldGRPOQTY.ReadOnly = True
        fldGRPOQTY.TextAlignment = ContentAlignment.MiddleCenter
        fldGRPOQTY.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldGRPOQTY.Width = 100
        fldGRPOQTY.FormatString = "{0:N2}"
        fldGRPOQTY.IsVisible = False
        GV.Columns.Add(fldGRPOQTY)

        Dim fldstatcolumn As New GridViewTextBoxColumn()
        fldstatcolumn.HeaderText = "STATUS"
        fldstatcolumn.FieldName = "STAT"
        fldstatcolumn.HeaderTextAlignment = ContentAlignment.MiddleCenter
        fldstatcolumn.TextAlignment = ContentAlignment.MiddleCenter
        fldstatcolumn.Width = 100
        fldstatcolumn.IsVisible = False
        GV.Columns.Add(fldstatcolumn)


    End Sub



End Class
