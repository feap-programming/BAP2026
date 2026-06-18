Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows
Imports Google.Protobuf.WellKnownTypes
Imports Org.BouncyCastle.Asn1
Imports Org.BouncyCastle.Asn1.Ocsp
Imports Org.BouncyCastle.Crypto
Imports Telerik.Collections.Generic
Imports Telerik.Licensing.Status
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Public Class FrmAddPurchaseReq


    Dim cselectDescription As New cSelectAllDesc

    Dim cselectRefPR As New cSelectAllDesc

    Dim cColumnMajorRef As New cGvAllMajorRef

    Dim cColumnSubRef As New cGvAllMajorRef

    Dim cPRUI As New cPurchaseReqUI

    Dim cSelectAllClassDesc As New cSelectAllDesc

    Dim cSelectSubMajorRefPR As New cSelectAllDesc

    Dim cselectallProcess As New cSelectAllProcess

    Dim cselectAllActivity As New cSelectAllActivityPR

    Dim cselectItem As New cSelectItemCode

    Dim cCurrency As New cSelectCurrency

    Dim cselectFAC As New cSelectFAC

    Dim cselectmodels As New cSelectModels

    Dim cGetTJPY As New cGetTJPY

    Dim cselectUPO As New cGetSummaryTM

    Dim cselectUOM As New cSelectUOM

    Dim cselectInvestment As New cSelectInvestment

    Dim cInsertPRRec As New cInsertPRRecord

    Dim cMPRINTSERT As New cInsertMPR

    Dim cITEMINSERT As New cInsertPRITEMSvb

    Dim cgetUID As New cGetUID

    Dim cInvestmentInsert As New cInsertInvestmentPR

    Dim cInsertRBHistory As New CInsertRemainingBudgetHistory

    Dim CInsertActivityAndModel As New CInsertActivityModelByPR

    Dim cGenerateTCID As New cGenerateTCID

    Dim dtdesc As DataTable

    Dim dtmajor As DataTable

    Dim dtitems As DataTable

    Dim dtCurrency As DataTable

    Dim dtUOM As DataTable

    Dim dtInvestment As DataTable

    Dim dtUPO As DataTable

    Dim dtGetTJPY As DataTable

    Dim dtFAC As DataTable

    Dim dtModelList As DataTable

    Dim dtINSERTPR As DataTable

    Dim dtMPRINSERT As DataTable

    Dim dtITEMINSERT As DataTable

    Dim dtInvestmentInsert As DataTable

    Dim dtRBHistory As DataTable

    Dim dtInsertAAM As DataTable

    Dim dtTCID As DataTable

    Dim dtgetUID As DataTable

    Private UID As String = ""

    Private TCID As String = ""


    Private _selectedDept As String
    Public Property SelectedDept As String
        Get
            Return _selectedDept
        End Get
        Set(value As String)
            _selectedDept = value
        End Set
    End Property

    Private Sub FrmAddPurchaseReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        LoadALLFIELDS()

    End Sub


    Private Sub LoadALLFIELDS()


        getUID()

        LoaddInvestment()

        tbUser.Text = GlobalVariables.SelectedDept & "-" & GlobalVariables.empFirstName & " " & GlobalVariables.empLastName

        tbDept.Text = GlobalVariables.SelectedDept


        cPRUI.designgridPR(gvPR)


        LoadBudgetRefNo(GlobalVariables.SelectedDept)

        'LoadSubBudgetRefNo()


        cColumnMajorRef.colsubrefcb(cbSubRefNo.EditorControl, cbSubRefNo)

        LoadSubClass()

        LoadAllProcess()

        LoadAllActivity()


        'LoadCurrencies("")

        LoadItems()
        'cbitems.SelectedIndex = -1
        'tbItems.Text = ""

        LoadItemName()
        'cbitemname.SelectedIndex = -1
        'tbItemName.Text = ""

        ddStatus.SelectedIndex = 0

        LoadUnitMSR()


        ClearFields()


        LoaddInvestment()

        LoadFAC()

        GenerateTCNO()


        offRRB.IsChecked = True

        NORRB.IsChecked = True



    End Sub



    Private Sub AutoCompleteTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Discards the typed key, blocking text input into modCDD
        e.Handled = True
    End Sub


    Private Sub GetTJPY()
        If CBRefNum.SelectedValue Is Nothing Then
            rsTOPRA.Value = 0
            Exit Sub
        End If

        dtGetTJPY = cGetTJPY.TJPYLinq(CBRefNum.SelectedValue.ToString())

        If dtGetTJPY IsNot Nothing AndAlso dtGetTJPY.Rows.Count > 0 Then
            Dim total As Decimal = dtGetTJPY.AsEnumerable().Sum(Function(r) Convert.ToDecimal(r("fldEJPY")))
            rsTOPRA.Value = total

            'MessageBox.Show("Total: " & total.ToString("fldEJPY"))


        Else
            rsTOPRA.Value = 0
        End If

    End Sub



    Private Sub CalcRBB()


        Dim CalRBB As Decimal = rsTOPRA.Value +
        rsEPAJPY.Value +
        rsUPO.Value +
        rsPO.Value

        rsRBB.Value = rsMBA.Value - CalRBB

    End Sub

    Private Sub GetUPO()


        If CBRefNum.SelectedValue Is Nothing Then
            rsUPO.Value = 0
            Exit Sub
        End If

        dtUPO = cselectUPO.GetSummaryTotalMajor(CBRefNum.SelectedValue.ToString())

        If dtUPO IsNot Nothing AndAlso dtUPO.Rows.Count > 0 Then
            rsUPO.Value = Convert.ToDecimal(dtUPO.Rows(0)("UPO"))

            'MessageBox.Show(dtUPO.Rows(0)("UPO").ToString())
        Else

            rsUPO.Value = 0
        End If

    End Sub



    Private Sub ClearFields()

        cbitems.SelectedIndex = -1
        tbItems.Text = ""

        cbitemname.SelectedIndex = -1
        tbItemName.Text = ""

        CBRefNum.SelectedIndex = -1

        tbcDescription.Text = ""

        cbSubRefNo.SelectedIndex = -1

        ddClass.SelectedIndex = -1

        ddProcess.SelectedIndex = -1

        ddActivity.SelectedIndex = -1




        'unclickable dropdowns

        ddClass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        cbSubRefNo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        cbitemname.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        ddCurrency.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        ddclassfix.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        ddUOM.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        ddTypes.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        DDPEZA.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        ddStatus.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        ddProcess.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        modCDD.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        cbInvestment.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        ddInspection.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        CBRefNum.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        cbitems.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        DDFAC.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        ddActivity.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList



        'Blocks Text input in MODCDD

        AddHandler Me.modCDD.CheckedDropDownListElement.AutoCompleteEditableAreaElement.AutoCompleteTextBox.KeyPress, AddressOf AutoCompleteTextBox_KeyPress

        txtRN.Clear()
        ddInspection.SelectedIndex = -1
        cbInvestment.SelectedIndex = -1
        DDFAC.SelectedIndex = -1
        tbMDN.Clear()
        tbprocdes.Clear()
        tbcReason.Clear()
        tbcDescription.Clear()
        ddCurrency.SelectedIndex = -1
        rsQty.Value = 0
        rsUnitPrice1.Value = 0
        rsUnitPrice2.Value = 0
        ddclassfix.SelectedIndex = -1
        ddUOM.SelectedIndex = -1
        ddTypes.SelectedIndex = -1
        DDPEZA.SelectedIndex = -1
        DPPLNO.CheckedItems.Clear()


        gvPR.Rows.Clear()




    End Sub


    Private Sub CalcOA()

        Dim total As Decimal = 0

        For Each row As GridViewRowInfo In gvPR.Rows

            total += Convert.ToDecimal(row.Cells("Totalcost").Value)

        Next

        rsOA.Value = total

    End Sub


    Private Sub CalcQty()

        Dim Qty As Decimal = 0

        For Each row As GridViewRowInfo In gvPR.Rows


            Qty += Convert.ToDecimal(row.Cells("Qty").Value)


        Next

        rsTotalQTY.Value = Qty


    End Sub

    Private Sub CalcEPAJPY()

        Dim Total As Decimal = 0

        For Each row As GridViewRowInfo In gvPR.Rows

            Total += Convert.ToDecimal(row.Cells("Unitpricejpy").Value)

            'dt.Columns.Add("Totalcost", GetType(Decimal))
            'dt.Columns.Add("Unitpricejpy", GetType(Decimal))
        Next

        rsEPAJPY.Value = Total


    End Sub

    Private Sub GetSummaryTM()


    End Sub

    Private Sub RemainingBalance()

        Dim Tcost, qty As Decimal

        For x As Integer = 0 To gvPR.Rows.Count - 1

            Tcost = Tcost + Convert.ToDecimal(gvPR.Rows(x).Cells("Totalcost").Value)
            qty = qty + Convert.ToDecimal(gvPR.Rows(x).Cells("Qty").Value)

        Next




    End Sub


    Private Sub CalcConversion()


        If ddCurrency.SelectedIndex = -1 OrElse ddCurrency.SelectedItem Is Nothing Then
            rsUnitPrice2.Value = 0
            RadMessageBox.Show("Please select a currency first.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
            Return
        End If

        Dim amount As Decimal = Convert.ToDecimal(rsUnitPrice1.Value)
        Dim currency As String = ddCurrency.SelectedItem.Text

        Dim rate As Decimal = 1D

        ' If JPY, rate to 1
        If currency.ToUpper() = "JPY" Then
            rate = 1D
        Else
            Dim dt As DataTable = cCurrency.selectCurrency(currency)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                rate = Convert.ToDecimal(dt.Rows(0)("Rate"))
            Else
                rate = 0D
            End If
        End If

        'display currency
        rsConversion.Value = rate


        ' Temporarily disable event
        RemoveHandler rsUnitPrice2.ValueChanged, AddressOf RadSpinEditor3_ValueChanged
        rsUnitPrice2.Value = amount * rate
        AddHandler rsUnitPrice2.ValueChanged, AddressOf RadSpinEditor3_ValueChanged


    End Sub

    'Private Sub LoadCurrencies(currency As String)


    '    dtCurrency = cCurrency.selectCurrency(currency)

    '    cbitemname.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList


    '    If dtCurrency IsNot Nothing AndAlso dtCurrency.Rows.Count > 0 Then

    '        With ddCurrency
    '            .DataSource = dtCurrency
    '            .DisplayMember = "Currency"
    '            .ValueMember = "Currency"

    '        End With


    '    End If

    'End Sub


    Private Sub CalcMBA()





    End Sub


    Public Sub LoadModels()


        dtModelList = cselectmodels.selectFAC

        If dtModelList IsNot Nothing AndAlso dtModelList.Rows.Count > 0 Then

            With modCDD
                .BeginUpdate()
                .DataSource = dtModelList
                .DisplayMember = "fldActivity"
                .ValueMember = "fldActivity"
                .EndUpdate()

            End With
        End If



    End Sub

    Private Sub ddActivity_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddActivity.SelectedIndexChanged


        If onRRB.IsChecked = True Then

            LoadModels()

            Dim Activity As String = ddActivity.Text

            Dim query = (From i In dtModelList.AsEnumerable()
                         Where i("fldActivity") = Activity
                         Select i("fldModel")).ToList
            modCDD.DataSource = query


        End If

    End Sub

    Private Sub modCDD_ItemCheckedChanged(sender As Object, e As RadCheckedListDataItemEventArgs) Handles modCDD.ItemCheckedChanged



    End Sub

    Private Sub LoadFacByFAC(FAC As String)

        dtFAC = cselectFAC.selectFACByFAC(FAC)




        If dtFAC IsNot Nothing AndAlso dtFAC.Rows.Count > 0 Then

            With DPPLNO
                .BeginUpdate()
                .DataSource = dtFAC
                .ValueMember = "fldFAControlNo"
                .DisplayMember = "fldFAControlNo"
                .EndUpdate()
            End With

        End If


    End Sub

    Private Sub LoadFAC()

        dtFAC = cselectFAC.selectFAC()

        If dtFAC IsNot Nothing AndAlso dtFAC.Rows.Count > 0 Then

            With _
                 _
                 _
                 _
                 _
                 _
                 _
                 _
                 _
                 DDFAC
                .BeginUpdate()
                .DataSource = dtFAC
                .DisplayMember = "fldFACode"
                .ValueMember = "fldFACode"
                .EndUpdate()
                .SelectedIndex = -1

            End With


        End If

    End Sub


    Private Sub LoadItems()


        dtitems = cselectItem.selectitems()

        '  dtdesc = cselectDescription.SelectAllDesc'
        If dtitems IsNot Nothing AndAlso dtitems.Rows.Count > 0 Then

            With cbitems
                .BeginUpdate()
                .DataSource = dtitems
                .DisplayMember = "ItemCode"
                .ValueMember = "ItemCode"
                .EndUpdate()
            End With

            '    cColumnMajorRef.desgincolumn(CBRefNum.EditorControl, CBRefNum)

            'Else

            '    CBRefNum.DataSource = Nothing

            'End If

        End If
    End Sub

    Private Sub LoadItemName()

        dtitems = cselectItem.selectitems()




        If dtitems IsNot Nothing AndAlso dtitems.Rows.Count > 0 Then

            With cbitemname
                .BeginUpdate()
                .DataSource = dtitems
                .DisplayMember = "ItemName"
                .ValueMember = "ItemName"
                .EndUpdate()

            End With



            '    cColumnMajorRef.desgincolumn(CBRefNum.EditorControl, CBRefNum)

            'Else

            '    CBRefNum.DataSource = Nothing

            'End If
        End If

    End Sub



    Private Sub AddPR()

        If String.IsNullOrWhiteSpace(cbSubRefNo.Text) Then
            RadMessageBox.SetThemeName(VisualStudio2022LightTheme1.ThemeName)
            RadMessageBox.Show("Please select Sub Ref No.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
            cbSubRefNo.Focus()
            Exit Sub
        End If


        If String.IsNullOrWhiteSpace(cbitems.Text) Then
            RadMessageBox.SetThemeName(VisualStudio2022LightTheme1.ThemeName)
            RadMessageBox.Show("Please Select Item", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
            Exit Sub
        End If


        If String.IsNullOrWhiteSpace(cbitemname.Text) Then
            RadMessageBox.SetThemeName(VisualStudio2022LightTheme1.ThemeName)
            RadMessageBox.Show("Please Select Item", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
            Exit Sub
        End If


        If String.IsNullOrWhiteSpace(rsQty.Value) Then
            RadMessageBox.SetThemeName(VisualStudio2022LightTheme1.ThemeName)
            RadMessageBox.Show("Please Input Quantity", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
            Exit Sub
        End If


        If String.IsNullOrWhiteSpace(ddClass.Text) Then
            RadMessageBox.SetThemeName(VisualStudio2022LightTheme1.ThemeName)
            RadMessageBox.Show("Please Select Class", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
            Exit Sub
        End If


        If rsQty.Value <= 0 Then
            RadMessageBox.SetThemeName(VisualStudio2022LightTheme1.ThemeName)
            RadMessageBox.Show("Enter Value", "Error", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub
        End If


        If rsUnitPrice1.Value < 0 Then
            RadMessageBox.SetThemeName(VisualStudio2022LightTheme1.ThemeName)
            RadMessageBox.Show("Enter Value", "Error", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If


        If String.IsNullOrWhiteSpace(DDPEZA.Text) Then

            RadMessageBox.SetThemeName(VisualStudio2022LightTheme1.ThemeName)
            RadMessageBox.Show("Please Classify if Directly used in PEZA Registered Activity or not Before Proceeding.", "Error", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub
        End If


        Dim dt As DataTable

        If gvPR.DataSource IsNot Nothing Then
            dt = CType(gvPR.DataSource, DataTable)
        Else

            ' Create table if none exists
            dt = New DataTable()
            dt.Columns.Add("SubRefNo", GetType(String))
            dt.Columns.Add("NO", GetType(Integer))
            dt.Columns.Add("PRNo", GetType(String))
            dt.Columns.Add("ItemCode", GetType(String))
            dt.Columns.Add("Description", GetType(String))
            dt.Columns.Add("Qty", GetType(Decimal))
            dt.Columns.Add("Classification", GetType(String))
            dt.Columns.Add("Unit", GetType(String))
            dt.Columns.Add("UnitPrice", GetType(Decimal))
            dt.Columns.Add("Totalcost", GetType(Decimal))
            dt.Columns.Add("Unitpricejpy", GetType(Decimal))
            dt.Columns.Add("Totaljpy", GetType(Decimal))
            dt.Columns.Add("PEZA", GetType(String))
            dt.Columns.Add("fixclass", GetType(String))
            dt.Columns.Add("Type", GetType(String))
            dt.Columns.Add("Assembly", GetType(String))



        End If


        ' Limit to 10 rows
        If dt.Rows.Count >= 10 Then
            RadMessageBox.SetThemeName(VisualStudio2022LightTheme1.ThemeName)
            RadMessageBox.Show("10 Items only per Purchase Requisition", "", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub
        End If

        ' Input in gv
        Dim newRow As DataRow = dt.NewRow()
        newRow("SubRefNo") = cbSubRefNo.Text
        newRow("ItemCode") = cbitems.Text
        newRow("PRNo") = DPPLNO.Text
        newRow("Description") = cbitemname.Text
        newRow("Qty") = rsQty.Value
        newRow("Classification") = ddClass.Text
        newRow("Unit") = ddUOM.Text
        newRow("UnitPrice") = rsUnitPrice1.Value
        'newRow("Totalcost") = rsUnitPrice1.Value
        'newRow("Unitpricejpy") = rsUnitPrice2.Value
        newRow("Totaljpy") = rsQty.Value * rsUnitPrice2.Value
        newRow("PEZA") = DDPEZA.Text
        newRow("fixclass") = ddclassfix.Text
        newRow("Type") = ddTypes.Text
        newRow("Assembly") = tbdAsset.Text


        newRow("Totalcost") = rsQty.Value * rsUnitPrice1.Value

        newRow("Unitpricejpy") = rsUnitPrice2.Value * rsQty.Value

        ' Increment NO
        Dim maxNo As Integer = 0
        If dt.Rows.Count > 0 Then
            maxNo = dt.AsEnumerable().Max(Function(row) Convert.ToInt32(row("NO")))
        End If
        newRow("NO") = maxNo + 1




        ' Add row and refresh grid
        dt.Rows.Add(newRow)
        gvPR.DataSource = dt
        gvPR.Refresh()

        currencyDGV()

    End Sub

    Private Sub currencyDGV()


        Dim dt = TryCast(gvPR.DataSource, DataTable)

        ddCurrency.Enabled = (dt Is Nothing OrElse dt.Rows.Count = 0)

    End Sub


    Private Sub LoaddInvestment()


        dtInvestment = cselectInvestment.SelectInvestment()
        If dtInvestment IsNot Nothing AndAlso dtInvestment.Rows.Count > 0 Then
            With cbInvestment
                .DataSource = dtInvestment
                .DisplayMember = "fldInvestmentNo"
                .ValueMember = "fldInvestmentNo"

                cbInvestment.SelectedIndex = -1
                cbInvestment.Text = String.Empty
            End With

            cPRUI.cbInvestment(cbInvestment)

            RemoveHandler cbInvestment.SelectedIndexChanged, AddressOf RadMultiColumnComboBox1_SelectionChanged
            AddHandler cbInvestment.SelectedIndexChanged, AddressOf RadMultiColumnComboBox1_SelectionChanged
        End If

    End Sub


    Private Sub LoadUnitMSR()

        dtUOM = cselectUOM.SelectUOM()


        If dtUOM IsNot Nothing AndAlso dtUOM.Rows.Count > 0 Then

            With ddUOM
                .BeginUpdate()
                .DataSource = dtUOM
                .DisplayMember = "BuyUnitMsr"
                .ValueMember = "BuyUnitMsr"
                .EndUpdate()
            End With

        End If

    End Sub



    Private Sub LoadBudgetRefNo(dept As String)



        dtmajor = cselectDescription.SelectMajorByDept(dept)



        '  dtdesc = cselectDescription.SelectAllDesc'
        If dtmajor IsNot Nothing AndAlso dtmajor.Rows.Count > 0 Then

            With CBRefNum
                .DataSource = Nothing
                .DataSource = dtmajor
                .DisplayMember = "fldMajorRefNo"
                .ValueMember = "fldMajorRefNo"
            End With




            cColumnMajorRef.desgincolumn(CBRefNum.EditorControl, CBRefNum)

        Else

            CBRefNum.DataSource = Nothing

        End If

    End Sub


    Private Sub LoadAllActivity()


        Dim dt As DataTable = cselectAllActivity.selectAllACtivity

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

            With ddActivity
                .DataSource = dt
                .ValueMember = "fldActivity"
                .DisplayMember = "fldActivity"
            End With

        Else

            RadMessageBox.Show("no data found")

        End If

    End Sub

    Private Sub LoadAllProcess()


        Dim dt As DataTable = cselectallProcess.cSElectProcess()

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

            With ddProcess
                .DataSource = dt
                .ValueMember = "fldProcessCode"
                .DisplayMember = "fldProcessCode"


            End With

        Else

            RadMessageBox.Show("No data found")

        End If


    End Sub

    Private Sub LoadTypes()


        ddTypes.Items.Clear()

        If ddclassfix.Text = "Principal" Then
            ddTypes.Items.Add("stand_alone")
            ddTypes.Items.Add("for_assembly")
            ddTypes.Items.Add("new_line_accessories")
        Else
            ddTypes.Items.Add("Modify")
            ddTypes.Items.Add("Repair")
            ddTypes.Items.Add("Other_charges")
            ddTypes.Items.Add("New_Line_Accessories")
        End If





    End Sub


    Private Sub ClassFixAS()

        If ddclassfix.SelectedItem Is Nothing Then Exit Sub

        Select Case ddclassfix.SelectedItem.Text.Trim()

            Case "Principal"
                DPPLNO.Visible = False
                lblPPNO.Visible = false

            Case "Capitalized"
                DPPLNO.Visible = True
                lblPPNO.Visible = True



        End Select



    End Sub

    Private Sub AssetTBC()


        If ddTypes.SelectedItem IsNot Nothing Then
            Select Case ddTypes.SelectedItem.Text
                Case "for_assembly", "new_line_accessories"
                    txtAsset.Visible = True
                    tbdAsset.Visible = True
                Case "stand_alone"
                    txtAsset.Visible = False
                    tbdAsset.Visible = False

                Case Else
                    txtAsset.Visible = False
                    tbdAsset.Visible = False

            End Select
        Else

            txtAsset.Visible = False
            tbdAsset.Visible = False

        End If


    End Sub



    Private Sub LoadSubBudgetRefNo()

        dtdesc = cselectDescription.SelectAllDesc

        If dtdesc IsNot Nothing AndAlso dtdesc.Rows.Count > 0 Then

            With cbSubRefNo
                .DataSource = Nothing
                .DataSource = dtdesc
                .DisplayMember = "fldSubRefNo"
                .ValueMember = "fldSubRefNo"

            End With

            'cColumnMajorRef.colsubrefcb(cbSubRefNo.EditorControl, cbSubRefNo)
        End If


    End Sub



    Private Sub LoadSubClass()

        dtdesc = cSelectAllClassDesc.SelectAllClassDesc


        If dtdesc IsNot Nothing AndAlso dtdesc.Rows.Count > 0 Then

            With ddClass
                .DataSource = Nothing
                .DataSource = dtdesc
                .DisplayMember = "fldClassDesc"
                .ValueMember = "fldClassDesc"

            End With

        End If

    End Sub



    Private Sub tbDept_TextChanged(sender As Object, e As EventArgs) Handles tbDept.TextChanged

    End Sub

    Private Sub RadTextBoxControl1_TextChanged(sender As Object, e As EventArgs) Handles tbcDescription.TextChanged


        If dtdesc Is Nothing OrElse dtdesc.Rows.Count = 0 Then Exit Sub  ' 
        Dim selectedRow As DataRow() = dtdesc.Select("fldClassDesc = '" & tbcDescription.Text & "'")
        If selectedRow.Length > 0 Then
            Dim selectedValue As String = selectedRow(0)("fldClassDesc").ToString()
        End If

    End Sub




    Private Sub CBRefNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBRefNum.SelectedIndexChanged

        If CBRefNum.SelectedValue Is Nothing OrElse dtmajor Is Nothing Then
            cbSubRefNo.SelectedIndex = -1
            cbSubRefNo.DataSource = Nothing
            rsMBA.Value = 0
            rsRBB.Value = 0
            rsUPO.Value = 0

            Exit Sub

        End If

        Dim selectedRef As String = CBRefNum.SelectedValue.ToString()

        Dim selectedRow As DataRow() = dtmajor.Select("fldMajorRefNo = '" & selectedRef & "'")


        If selectedRow.Length > 0 Then

            Dim totalAmount As Object = selectedRow(0)("fldJpyAmount")
            tbcDescription.Text = selectedRow(0)("fldClassDesc").ToString()

            rsMBA.Value = If(totalAmount IsNot DBNull.Value, Convert.ToDecimal(totalAmount), 0)
            rsRBB.Value = If(totalAmount IsNot DBNull.Value, Convert.ToDecimal(totalAmount), 0)

        Else

            tbcDescription.Text = String.Empty
            rsMBA.Value = 0
            rsRBB.Value = 0


        End If


        Dim dtSub As DataTable = cselectRefPR.SelectSubMajorByDeptnRef(tbDept.Text, selectedRef)


        If dtSub IsNot Nothing AndAlso dtSub.Rows.Count > 0 Then
            tbcDescription.Text = dtSub.Rows(0)("fldClassDesc").ToString()

            With cbSubRefNo
                .DataSource = dtSub
                .DisplayMember = "fldSubRefNo"
                .ValueMember = "fldSubRefNo"

            End With

            cColumnSubRef.colsubrefcb(cbSubRefNo.EditorControl, cbSubRefNo)

        End If

        GetUPO()
        GetTJPY()

    End Sub


    Private Sub cbitems_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cbitems.SelectedIndexChanged


        If cbitems.SelectedIndex <> -1 Then

            cbitemname.SelectedIndex = cbitems.SelectedIndex

            If cbitems.SelectedItem IsNot Nothing Then
                tbItems.Text = cbitems.Text


            End If

        End If


    End Sub

    Private Sub cbitemname_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cbitemname.SelectedIndexChanged


        If cbitemname.SelectedIndex <> -1 Then

            cbitems.SelectedIndex = cbitemname.SelectedIndex

            If cbitemname.SelectedItem IsNot Nothing Then
                tbItemName.Text = cbitemname.Text


            End If

        End If

    End Sub

    Private Sub RadSpinEditor1_ValueChanged(sender As Object, e As EventArgs) Handles rsUnitPrice1.ValueChanged
        CalcConversion()
    End Sub

    Private Sub RadSpinEditor3_ValueChanged(sender As Object, e As EventArgs) Handles rsUnitPrice2.ValueChanged
        CalcConversion()
    End Sub

    Private Sub RadMultiColumnComboBox1_SelectionChanged(sender As Object, e As EventArgs)
        If cbInvestment.SelectedIndex = -1 Then
            rsInvestmentBudget.Value = 0
            rsInvestmentBalance.Value = 0
            Exit Sub
        End If

        Dim view As DataRowView = TryCast(cbInvestment.EditorControl.CurrentRow.DataBoundItem, DataRowView)

        If view IsNot Nothing Then

            Dim investmentBudget As Decimal = CDec(If(IsDBNull(view("fldApprovedBudget")), 0, view("fldApprovedBudget")))
            Dim investmentBalance As Decimal = CDec(If(IsDBNull(view("PRAmount")), 0, view("PRAmount")))


            rsInvestmentBudget.Value = investmentBudget
            rsInvestmentBalance.Value = investmentBudget - investmentBalance

        End If
    End Sub


    Private Sub onRRB_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles onRRB.ToggleStateChanged

        Dim ifCheck As Boolean = (args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)



    End Sub

    Private Sub RadCheckBox3_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles ckbInvestment.ToggleStateChanged



        Dim ifcheck As Boolean = (args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)

        rsInvestmentBudget.Enabled = Not ifcheck
        rsInvestmentBalance.Enabled = Not ifcheck


        cbInvestment.Enabled = Not ifcheck
        If ifcheck Then

            cbInvestment.Text = "N/A"
            cbInvestment.Enabled = False
            rsInvestmentBalance.Value = 0
            rsInvestmentBudget.Value = 0



        Else

            cbInvestment.SelectedIndex = -1
            cbInvestment.Text = String.Empty

        End If

    End Sub

    Private Sub cbSubRefNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubRefNo.SelectedIndexChanged

    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click

        AddPR()

        CalcOA()

        CalcQty()

        CalcEPAJPY()
        'RemainingBalance()

        CalcRBB()

        DPPLNO.CheckedItems.Clear()

    End Sub

    Private Sub gvPR_CommandCellClick(sender As Object, e As GridViewCellEventArgs) Handles gvPR.CommandCellClick

        If TypeOf e.Column Is GridViewCommandColumn Then

            If RadMessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then


                Dim dt As DataTable = CType(gvPR.DataSource, DataTable)

                If dt IsNot Nothing Then

                    dt.Rows.RemoveAt(e.Row.Index)

                    CalcOA()
                    CalcQty()
                    CalcEPAJPY()
                    RemainingBalance()
                    CalcRBB()

                    For i As Integer = 0 To dt.Rows.Count - 1
                        dt.Rows(i)("NO") = i + 1
                    Next

                    gvPR.Refresh()

                    currencyDGV()

                End If

            End If

        End If

    End Sub

    Private Sub ddCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddCurrency.SelectedIndexChanged
        CalcConversion()
    End Sub

    Private Sub rsConversion_ValueChanged(sender As Object, e As EventArgs) Handles rsConversion.ValueChanged

    End Sub

    Private Sub CBRefNum_DoubleClick(sender As Object, e As EventArgs) Handles CBRefNum.DoubleClick

        CBRefNum.MultiColumnComboBoxElement.ShowPopup()

    End Sub

    Private Sub cbSubRefNo_DoubleClick(sender As Object, e As EventArgs) Handles cbSubRefNo.DoubleClick

        cbSubRefNo.MultiColumnComboBoxElement.ShowPopup()

    End Sub

    Private Sub cbInvestment_DoubleClick(sender As Object, e As EventArgs) Handles cbInvestment.DoubleClick

        cbInvestment.MultiColumnComboBoxElement.ShowPopup()

    End Sub

    Private Sub modCDD_DoubleClick(sender As Object, e As EventArgs) Handles modCDD.DoubleClick

        modCDD.ShowDropDown()

    End Sub

    Private Sub offRRB_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles offRRB.ToggleStateChanged

        If offRRB.IsChecked = True Then

            rcbModel.Checked = True
            AccountFields()

            DPPLNO.Visible = False
            lblPPNO.Visible = False
        Else

            If onRRB.IsChecked = True Then

                rcbModel.Checked = False

            End If

        End If



    End Sub

    Private Sub AccountFields()

        If rcbModel.Checked = True Then
            modCDD.Enabled = False
            modCDD.Text = "N/A"

            DDFAC.Enabled = False
            DDFAC.Text = "N/A"

            ddclassfix.Enabled = False
            ddclassfix.Text = "N/A"

            ddTypes.Enabled = False
            ddTypes.Text = "N/A"

        Else

            modCDD.Enabled = True
            modCDD.Text = ""

            DDFAC.Enabled = True
            DDFAC.Text = ""

            ddclassfix.Enabled = True
            ddclassfix.Text = ""

            ddTypes.Enabled = True
            ddTypes.Text = ""


        End If

    End Sub





    Private Sub rcbModel_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rcbModel.ToggleStateChanged


        AccountFields()

    End Sub

    Private Sub DDFAC_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles DDFAC.SelectedIndexChanged

        LoadFacByFAC(DDFAC.Text)

    End Sub



    Public Sub PRINSERT(pryear As Integer, TC As String, dept As String)

        dtINSERTPR = cInsertPRRec.InsertPRRecord(pryear, TC, dept)

        'RadMessageBox.SetThemeName("Windows8")
        'If MessageBox.Show("PR INSERT completed !", "Success",
        '                MessageBoxButtons.OK, MessageBoxIcon.Information) Then

        'End If

    End Sub

    Public Sub MPRINSERT(BudRefNum As String,
                     Transcode As String,
                     MonthOrder As Date,
                     OrderDesc As String,
                     Classification As String,
                     OrderDepartment As String,
                     _Process As String,
                     Qty As Decimal,
                     UOM As String,
                     OrderStatus As String,
                     OrderRemarks As String,
                     Signature As String,
                     MO As Date,
                     DN As Date,
                     EC As String,
                     EOA As Decimal,
                     EJPY As Decimal,
                     RN As String,
                     Rate As Decimal,
                     Moldie As String,
                     NReason As String,
                     InsRequirements As String,
                     TOPRA As Decimal,
                     pAccount As String,
                     pFixedAssCategory As String,
                     pExclusive As String,
                     pExclusiveSupplier As String,
                     pExclusiveReason As String
                     )


        dtMPRINSERT = cMPRINTSERT.InsertMPR(
        BudRefNum,
        Transcode,
        MonthOrder,
        OrderDesc,
        Classification,
        OrderDepartment,
        _Process,
        Qty,
        UOM,
        OrderStatus,
        OrderRemarks,
        Signature,
        MO,
        DN,
        EC,
        EOA,
        EJPY,
        TOPRA,
        RN,
        Rate,
        Moldie,
        NReason,
        InsRequirements,
        pAccount,
        pFixedAssCategory,
        pExclusive,
        pExclusiveSupplier,
        pExclusiveReason)


        'RadMessageBox.SetThemeName("Windows8")
        'If MessageBox.Show("MAJOR Insert Completed !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) Then

        'End If


    End Sub

    Private Sub ITEMSINSERT(Transcode As String, BudRef As String, ICode As String, _Desc As String, QTY As Decimal, Unit As String,
                            Signature As String, MO As Date, _Class As String, Dept As String, _Process As String, Rate As Decimal,
                            UnitPrice1 As Decimal, TotalCost As Decimal, SubRefNo As String, UnitPriceJPY As Decimal, TotalCostJPY As Decimal,
                            Peza As String, FAClass As String, FAType As String, AssemblyType As String, pFixedAssCategory As String,
                            ItemNo As Decimal, PrincipalNo As String)


        dtITEMINSERT = cITEMINSERT.InsertPRITEMS(
                Transcode, BudRef, ICode, _Desc, QTY, Unit,
                Signature, MO, _Class, Dept, _Process, Rate,
                UnitPrice1, TotalCost, SubRefNo,
                UnitPriceJPY, TotalCostJPY,
                Peza, FAClass, FAType, AssemblyType,
                pFixedAssCategory, ItemNo, PrincipalNo)

        'RadMessageBox.SetThemeName("Windows8")
        'If RadMessageBox.Show("Item Insert Completed!", "Success", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info) = DialogResult.OK Then


        'End If

    End Sub

    Private Sub InsertRBHistory(TransCode As String, RemBud As String, UPO As String, PO As String, PRNotPO As Decimal, Budget As Decimal)

        dtRBHistory = cInsertRBHistory.InsertRBHistory(TransCode, RemBud, UPO, PO, PRNotPO, Budget)

        'RadMessageBox.SetThemeName("Windows8")
        'If RadMessageBox.Show("Item Insert RBHISTORY Completed !", "Success", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info) = DialogResult.OK Then


        'End If

    End Sub


    Private Sub InsertAAM(Activity As String, Model As String, TransCode As String)


        dtInsertAAM = CInsertActivityModelByPR.InsertAMPR(Activity, Model, TransCode)

        'RadMessageBox.SetThemeName("Windows8")
        'If RadMessageBox.Show("Insert Activity Model By PR", "Sucess", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info) = DialogResult.OK Then


        'End If


    End Sub

    Private Sub InvestmentInsert(BudRefNum As String, TransCode As String, MonthOrder As Date, OrderDesc As String, Classification As String, OrderDepartment As String, _Process As String,
                                 QTY As Decimal, UOM As String, OrderStatus As String, OrderRemarks As String, Signature As String, MO As Date, DN As Date,
                                 EC As String, EOA As Decimal, EJPY As Decimal, TOPRA As Decimal, RN As Decimal, Rate As Decimal, MoldDie As String, InvestmentNo As String)

        dtInvestmentInsert = cInvestmentInsert.InsertInvestmentPR(BudRefNum, TransCode, MonthOrder, OrderDesc, Classification, OrderDepartment, _Process,
                                                                  QTY, UOM, OrderStatus, OrderRemarks, Signature, MO, DN,
                                                                            EC, EOA, EJPY, TOPRA, RN, Rate,
                                                                    MoldDie, InvestmentNo)

        'RadMessageBox.SetThemeName("Windows8")
        'If RadMessageBox.Show("Insert Investment Completed", "Success", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info) Then


        'End If

    End Sub


    Private Sub getUID()

        Dim dt As DataTable = cgetUID.GetUID(GlobalVariables.empNo)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            UID = dt.Rows(0)("fldUID").ToString()
            lblUID.Text = UID
        End If

    End Sub

    Private Sub GenerateTCNO()


        dtTCID = cGenerateTCID.GenerateTCID()

        If dtTCID IsNot Nothing AndAlso dtTCID.Rows.Count > 0 Then
            lblTCID.Text = dtTCID.Rows(0)("ID").ToString()
        End If


    End Sub


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click


        If String.IsNullOrEmpty(CBRefNum.Text) Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please Select Major Budget Reference Number",
                       "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Exit Sub

            If ddStatus.Text = "CLOSE" Then

                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Incomplete Input. Cannot Add Order with CLOSE Status!",
                                   "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                Exit Sub

            End If

        ElseIf String.IsNullOrEmpty(ddProcess.Text) Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Process Selected!",
                           "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Exit Sub

        ElseIf String.IsNullOrEmpty(ddClass.Text) Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Class Selected!",
                           "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Exit Sub

        ElseIf String.IsNullOrEmpty(ddCurrency.Text) Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Currency Selected!",
                           "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)


            Exit Sub


        ElseIf rsOA.Value <= 0 Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Estimated Pr Amount",
                 "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)


            Exit Sub

        ElseIf String.IsNullOrEmpty(tbMDN.Text) Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input.No Mold Die Name!",
                                   "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Exit Sub

        ElseIf String.IsNullOrEmpty(tbcReason.Text) Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Reason(s) for request.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Exit Sub

        ElseIf String.IsNullOrEmpty(tbcDetails.Text) Then

            RadMessageBox.SetThemeName("Wiindows8")
            RadMessageBox.Show("Incomplete Input. No Necessary Reasons Details.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Exit Sub

        ElseIf String.IsNullOrEmpty(ddActivity.Text) Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Activity Selected!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Exit Sub

        ElseIf String.IsNullOrEmpty(DDFAC.Text) Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Asset Category Selected~!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Exit Sub

        ElseIf gvPR.RowCount <= 0 Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. Add Item(s) to Continue.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Exit Sub

        ElseIf YESRRB.IsChecked = True And String.IsNullOrEmpty(tbSUPPLIER.Text) And String.IsNullOrEmpty(tbREASON.Text) Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Exclusive Supplier and Reason. Please click NO if this PR is not exclusive to one supplier",
                "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub
        ElseIf RadMessageBox.Show("Are you sure you want Order this item ?", "Notification", MessageBoxButtons.YesNo,
                RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            If Not (modCDD.Text = "" OrElse modCDD.Text Is Nothing) Then

                Dim your_String As String = modCDD.Text
                Dim my_String As String = Regex.Replace(your_String, ";", ",")
                Dim strgroupids As String = my_String.Remove(my_String.Length - 1)
                GlobalVariables.ModelSearchValue = strgroupids

            End If

        End If




        If RadMessageBox.Show("Order Added", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info) Then
            RadMessageBox.SetThemeName("Windows8")

            Dim Transcode As String


            '-------------PR INSERT----------------



            Transcode = "TC000" + UID + "-" + TCID + "-" + tbDept.Text

            'Transcode = "TC00" + GlobalVariables.UIDemp

            '-------------PR INSERT----------------

            PRINSERT(dtpMO.Value.Year,
                        Transcode, tbDept.Text)

            '-------------PR INSERT----------------

            '-------------MAJOR INSERT----------------'


            Dim activity = ""

            If offRRB.IsChecked = True Then

                activity = "Fixed Asset"

            Else
                activity = "Not Fixed Asset"
            End If


            Dim Exclusive As String

            If YESRRB.IsChecked = True Then


                Exclusive = "YES"

            Else
                NORRB.IsChecked = True


                Exclusive = "NO"

                'tbSUPPLIER.Text = String.Empty


            End If

            MPRINSERT(CBRefNum.Text, Transcode, dtpMO.Value, tbcDescription.Text, ddClass.Text,
            tbDept.Text, ddProcess.Text, rsTotalQTY.Value, ddUOM.Text, ddStatus.Text, tbcReason.Text, tbUser.Text, dtpMO.Value, dtpDN.Value,
            ddCurrency.Text, rsOA.Value, rsEPAJPY.Value, RN:=txtRN.Text, rsConversion.Value, tbMDN.Text, tbcDetails.Text,
            ddInspection.Text, rsTOPRA.Value, activity, DDFAC.Text, Exclusive, pExclusiveSupplier:=tbSUPPLIER.Text, tbREASON.Text)

            '-------------MAJOR INSERT----------------'




            '-------------ITEM INSERT----------------'

            For x As Integer = 0 To gvPR.Rows.Count - 1

                Dim FATypePar = If(String.IsNullOrEmpty(gvPR.Rows(x).Cells("Type").Value), "", gvPR.Rows(x).Cells("Type").Value)


                ITEMSINSERT(
                    Transcode,
                    BudRef:=CBRefNum.Text,
                    ICode:=gvPR.Rows(x).Cells("ItemCode").Value.ToString(),
                    _Desc:=gvPR.Rows(x).Cells("Description").Value.ToString(),
                    QTY:=CDec(gvPR.Rows(x).Cells("QTY").Value),
                    Unit:=gvPR.Rows(x).Cells("Unit").Value.ToString(),
                    Signature:=tbUser.Text,
                    MO:=dtpMO.Value,
                    _Class:=gvPR.Rows(x).Cells("Description").Value.ToString,
                    Dept:=tbDept.Text,
                    _Process:=ddProcess.Text,
                    Rate:=rsConversion.Value,
                    UnitPrice1:=gvPR.Rows(x).Cells("UnitPrice").Value,
                    TotalCost:=gvPR.Rows(x).Cells("Totalcost").Value,
                    SubRefNo:=gvPR.Rows(x).Cells("SubRefNo").Value.ToString,
                    UnitPriceJPY:=gvPR.Rows(x).Cells("Unitpricejpy").Value,
                    TotalCostJPY:=gvPR.Rows(x).Cells("Totalcost").Value,
                    Peza:=gvPR.Rows(x).Cells("PEZA").Value.ToString,
                    FAClass:=gvPR.Rows(x).Cells("fixclass").Value.ToString,
                    FAType:=gvPR.Rows(x).Cells("Type").Value.ToString,
                    AssemblyType:=gvPR.Rows(x).Cells("Assembly").Value.ToString,
                    pFixedAssCategory:=DDFAC.Text,
                    ItemNo:=0,
                    PrincipalNo:=gvPR.Rows(x).Cells("PRNo").Value.ToString
                )

                '-------------ITEM INSERT----------------' 

            Next

            '----------------INSERT INVESTMENT-------------------'

            InvestmentInsert(BudRefNum:=CBRefNum.Text, Transcode, MonthOrder:=dtpMO.Value, OrderDesc:=tbcDescription.Text, Classification:=ddClass.Text, OrderDepartment:=tbDept.Text,
                                                                 _Process:=ddProcess.Text, QTY:=rsQty.Value, UOM:=ddUOM.Text, OrderStatus:=ddStatus.Text, OrderRemarks:=tbcReason.Text, Signature:=tbUser.Text,
                                                                    MO:=dtpMO.Value, DN:=dtpDN.Value, EC:=ddCurrency.Text, EOA:=rsOA.Value, EJPY:=rsEPAJPY.Value, TOPRA:=rsTOPRA.Value,
                                                                        RN:=txtRN.Text, Rate:=rsConversion.Value, MoldDie:=modCDD.Text, InvestmentNo:=cbInvestment.Text)

            '----------------INSERT INVESTMENT-------------------'


            '----------------INSERT REMAINING BUDGET HISTORY-------------------'


            InsertRBHistory(Transcode, RemBud:=rsRBB.Value, UPO:=rsUPO.Value, PO:=rsPO.Value,
                            PRNotPO:=rsTOPRA.Value, Budget:=rsMBA.Value)


            '----------------INSERT REMAINING BUDGET HISTORY-------------------'



            '---------------INSERT  ACTIVITY & MODEL  -------------------'


            InsertAAM(Activity:=ddActivity.Text, Model:=modCDD.Text, Transcode)

            '---------------INSERT  ACTIVITY & MODEL  -------------------'



            'ClearFields()
        End If

    End Sub

    Private Sub NORRB_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles NORRB.ToggleStateChanged

        If NORRB.IsChecked = True Then

            tbSUPPLIER.Enabled = False
            tbSUPPLIER.Text = String.Empty

            tbREASON.Enabled = False
            tbREASON.Text = String.Empty


        Else
            If YESRRB.IsChecked = True Then

                tbSUPPLIER.Enabled = True
                tbSUPPLIER.Text = String.Empty

                tbREASON.Enabled = True
                tbREASON.Text = String.Empty


            End If

        End If

    End Sub

    Private Sub ddTypes_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddTypes.SelectedIndexChanged

        AssetTBC()

    End Sub

    Private Sub ddclassfix_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddclassfix.SelectedIndexChanged

        ClassFixAS()

        LoadTypes()



    End Sub

    Private Sub RadCheckBox3_ToggleStateChanged_1(sender As Object, args As StateChangedEventArgs) Handles RadCheckBox3.ToggleStateChanged



        Dim check As Boolean = (args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
        Dim uncheck As Boolean = (args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off)

        If check Then

            tbMDN.Enabled = False
            tbMDN.Text = "N/A"

        ElseIf uncheck Then


            tbMDN.Enabled = True
            tbMDN.Text = ""

        End If


    End Sub


    Private Sub gvPR_ValueChanged(sender As Object, e As EventArgs) Handles gvPR.ValueChanged

        If gvPR.Rows.Count > 0 Then

            ddCurrency.Enabled = False

        Else

            ddCurrency.Enabled = True

        End If

    End Sub
End Class

