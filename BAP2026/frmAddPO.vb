Imports System.Net
Imports Google.Protobuf.Reflection
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmAddPO




    Private _selectedDept As String

    Dim cgetDeptCode As New cGetAllDeptCode

    Dim dtDeptCode As DataTable

    Dim getsuppliers As New cSelectSupplier

    Dim dtSupplier As DataTable

    Dim suppliergvUI As New cPOUI

    Dim gvListUI As New cPOUI

    Dim gvpoUI As New cPOUI

    Dim cCurrency As New cSelectCurrencyPO

    Dim dtCurrency As New DataTable

    Dim cItemPO As New cGetItemPOByPRNO

    Dim dtItemPO As New DataTable

    Dim cCreatePO As New cCreatePO

    Dim dtCreatepo As New DataTable

    Dim dtCreatePOI As New DataTable

    Dim cCreatePOI As New cAddPOI

    Private Sub FrmAddPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadAllfunction()


    End Sub


    Private Const ValidChars As String = "-.&()@#!%/$\+?"




    Private Sub tbcRemakrs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcRemakrs.KeyPress

        If Char.IsControl(e.KeyChar) Then Exit Sub

        e.Handled = Not (
        Char.IsLetterOrDigit(e.KeyChar) OrElse
        ValidChars.Contains(e.KeyChar))

    End Sub



    Public Function LoadAllfunction()

        getDeptCode()

        GetSupplier()


        'getSuppinfo()  

        gvListUI.gvLIST(gvList)

        suppliergvUI.gvSupplier(gvSupplier)

        gvpoUI.gvcreatePO(gvCreatePO)

        dtpMO.Value = Today

        dtpDD.Value = "01/01/0001"

        tbSignature.Text = GlobalVariables.SelectedDept & "-" & GlobalVariables.empFirstName & GlobalVariables.empMiddleName & "-" & GlobalVariables.empLastName

    End Function
    Public Property SelectedDept As String
        Get
            Return _selectedDept
        End Get
        Set(value As String)
            _selectedDept = value
        End Set

    End Property


    Public Sub CalcRate()


        Dim currency As String = tbCurrency.Text  ' 
        Dim rate As Decimal = 0.0

        If currency = "JPY" OrElse String.IsNullOrEmpty(currency) Then
            rate = 0.0
        Else
            dtCurrency = cCurrency.selectCurrency(currency)
            If dtCurrency IsNot Nothing AndAlso dtCurrency.Rows.Count > 0 Then
                rate = Convert.ToDecimal(dtCurrency.Rows(0)("Rate"))
            Else
                RadMessageBox.Show("No Conversion rate found for " _
                    & currency, "Warning", MessageBoxButtons.OK, RadMessageIcon.Info)
                rate = 0.0  ' 
            End If
        End If

        mebRate.Value = rate

    End Sub
    Public Sub ND()

        If MEBTPO.Value <> 0 Then

            mebTotal.Value = MEBTPO.Value - mebPrice.Text

            mebDISC.Value = (mebPrice.Value / MEBTPO.Value) * 100

        End If

    End Sub

    Private Sub MEBTPO_TextChanged(sender As Object, e As EventArgs) Handles MEBTPO.TextChanged


        ND()


    End Sub





    Private Sub getSuppinfo()


        Supdd.Text = gvSupplier.CurrentRow.Cells("CardName").Value.ToString
        VCdd.Text = gvSupplier.CurrentRow.Cells("CardCode").Value.ToString
        tbCurrency.Text = gvSupplier.CurrentRow.Cells("Currency").Value.ToString


        CalcRate()



    End Sub

    Private Sub fetchbtnSirts(PRNO As String)

        dtItemPO = cItemPO.getItemPObyPRNO(PRNO)

        If dtItemPO IsNot Nothing AndAlso dtItemPO.Rows.Count > 0 Then

            With gvList
                .BeginUpdate()
                .DataSource = dtItemPO
                .EndUpdate()

            End With

        End If

    End Sub


    Private Sub GetSupplier()

        dtSupplier = getsuppliers.selectSuppliers

        If dtSupplier IsNot Nothing AndAlso dtSupplier.Rows.Count > 0 Then

            With gvSupplier
                .BeginUpdate()
                .DataSource = dtSupplier
                .EndUpdate()

            End With

        End If


    End Sub



    Public Sub getDeptCode()


        dtDeptCode = cgetDeptCode.cgetAllDeptCode

        If dtDeptCode IsNot Nothing AndAlso dtDeptCode.Rows.Count > 0 Then

            With DDNote
                .BeginUpdate()
                .DataSource = dtDeptCode
                .DisplayMember = "fldNote"
                .ValueMember = "fldNote"
                .EndUpdate()
                .SelectedIndex = -1

            End With


        End If


    End Sub


    Private Sub mebDISC_Leave(sender As Object, e As EventArgs) Handles mebDISC.Leave

        mebPrice.Text = ((MEBTPO.Text * mebDISC.Value) / 100)


    End Sub

    Private Sub gvSupplier_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles gvSupplier.CellDoubleClick

        getSuppinfo()

    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click

        If gvCreatePO.Rows.Count > 0 Then

            RadMessageBox.SetThemeName("Windows8")

            If RadMessageBox.Show("There are Item(s) to Order. Are you sure you want to close this transaction?", "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                Me.Close()

            End If


        End If

    End Sub

    Private Sub mebDISC_TextChanged(sender As Object, e As EventArgs) Handles mebDISC.TextChanged

        If mebDISC.Value > 100 Then

            mebDISC.Value = 100

            mebPrice.Text = MEBTPO.Text

            mebTotal.Value = MEBTPO.Value - mebPrice.Text

        End If


    End Sub

    Private Sub dtpMO_ValueChanged(sender As Object, e As EventArgs) Handles dtpMO.ValueChanged

        CalcRate()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If String.IsNullOrWhiteSpace(tbSEARCHPR.Text) Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please Enter PR NO.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)


            Exit Sub
        End If


        'If String.IsNullOrWhiteSpace(dtpDD.Value) Then
        '    RadMessageBox.SetThemeName("Windows8")
        '    RadMessageBox.Show("Please Select Delivery Date To Continue. ", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)



        '    Exit Sub

        'End If

        fetchbtnSirts(tbSEARCHPR.Text)

    End Sub

    Private Sub tbSEARCHPR_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSEARCHPR.KeyDown


        If e.KeyCode = Keys.Enter Then

            btnSearch.PerformClick()

            e.SuppressKeyPress = True

        End If

    End Sub

    Private Sub gvList_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles gvList.CellDoubleClick

        ' Check duplicates
        For Each row As Telerik.WinControls.UI.GridViewRowInfo In gvCreatePO.ChildRows
            If row.Cells("fldMOIID").Value IsNot Nothing AndAlso
               gvList.CurrentRow.Cells("fldMOIID").Value IsNot Nothing AndAlso
               row.Cells("fldMOIID").Value.ToString() = gvList.CurrentRow.Cells("fldMOIID").Value.ToString() Then

                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Item Already Added", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                Exit Sub
            End If
        Next

        If dtpDD.Text Is Nothing Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please Select Delivery Date to Continue.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub
        End If

        Dim dt As DataTable



        If gvCreatePO.DataSource IsNot Nothing Then
            dt = CType(gvCreatePO.DataSource, DataTable)
        Else

            dt = New DataTable
            dt.Columns.Add("OB_LINE", GetType(String))
            dt.Columns.Add("MO", GetType(String))
            dt.Columns.Add("TaxDate", GetType(String))
            dt.Columns.Add("DDD", GetType(String))
            dt.Columns.Add("PO", GetType(Decimal))
            dt.Columns.Add("Row", GetType(Decimal))
            dt.Columns.Add("fldICode", GetType(String))
            dt.Columns.Add("fldQTYEB", GetType(Decimal))
            dt.Columns.Add("Price", GetType(Decimal))
            dt.Columns.Add("Remarks", GetType(String))
            dt.Columns.Add("DetailID", GetType(String))
            dt.Columns.Add("fldOrderDepartment", GetType(String))
            dt.Columns.Add("fldSubRefNo", GetType(String))
            dt.Columns.Add("fldOrderId", GetType(Decimal))
            dt.Columns.Add("fldQTYSOUT", GetType(String))
            dt.Columns.Add("fldPRNO", GetType(String))
            dt.Columns.Add("fldMOIID", GetType(String))


        End If

        ' Dates
        Dim OB_DocDate As String = dtpMO.Value.ToString("yyyyMMdd")
        Dim OB_TaxDate As String = dtpMO.Value.ToString("yyyyMMdd")
        Dim OB_DocDuedate As String = dtpDD.Value.ToString("yyyyMMdd")
        Dim OB_ItemCode As String = gvList.CurrentRow.Cells("fldICode").Value.ToString
        Dim OB_Qty As Decimal = If(gvList.CurrentRow.Cells("fldQTYEB").Value Is DBNull.Value, 0D, Convert.ToDecimal _
            (gvList.CurrentRow.Cells("fldQTYEB").Value))
        Dim OB_UnitPrice As Decimal = 0.0
        Dim OB_Remarks As String = tbcRemakrs.Text
        Dim OB_Detail_ID As String = ""
        Dim OB_Dept As String = gvList.CurrentRow.Cells("fldOrderDepartment").Value.ToString
        Dim OB_BudgetRef As String = gvList.CurrentRow.Cells("fldSubRefNo").Value.ToString
        Dim OrdID As Integer = Convert.ToInt32(gvList.CurrentRow.Cells("fldOrderId").Value)
        Dim QTYOUT As String = gvList.CurrentRow.Cells("fldQTYSOUT").Value.ToString
        Dim PRNum As String = gvList.CurrentRow.Cells("fldPRNO").Value.ToString
        Dim MOID As String = gvList.CurrentRow.Cells("fldMOIID").Value.ToString

        ' Row number FIX
        Dim OB_RowNum As Integer = dt.Rows.Count + 1

        ' Create row
        Dim insertRow As DataRow = dt.NewRow()
        insertRow("OB_LINE") = ""
        insertRow("MO") = OB_DocDate
        insertRow("TaxDate") = OB_TaxDate
        insertRow("DDD") = OB_DocDuedate
        insertRow("PO") = 0D
        insertRow("Row") = OB_RowNum
        insertRow("fldICode") = OB_ItemCode
        insertRow("fldQTYEB") = OB_Qty
        insertRow("Price") = OB_UnitPrice
        insertRow("Remarks") = OB_Remarks
        insertRow("DetailID") = OB_Detail_ID
        insertRow("fldOrderDepartment") = OB_Dept
        insertRow("fldSubRefNo") = OB_BudgetRef
        insertRow("fldQTYSOUT") = QTYOUT
        insertRow("fldPRNO") = PRNum
        insertRow("fldMOIID") = MOID

        'insertRow("")

        dt.Rows.Add(insertRow)

        gvCreatePO.DataSource = dt
        gvCreatePO.Refresh()


    End Sub

    Private Sub gvCreatePO_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvCreatePO.CellFormatting

        If (e.CellElement.ColumnInfo.HeaderText = "QTY") Or (e.CellElement.ColumnInfo.HeaderText = "Price") Then
            e.CellElement.DrawFill = True
            e.CellElement.BackColor = System.Drawing.Color.LightSkyBlue

        ElseIf (e.CellElement.ColumnInfo.HeaderText = "Item Code") Then
            e.CellElement.DrawFill = True
            e.CellElement.BackColor = System.Drawing.Color.DarkGray

        Else
            e.CellElement.DrawFill = True
            e.CellElement.BackColor = System.Drawing.Color.Transparent


        End If

    End Sub

    Private Sub mebPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mebPrice.KeyPress

        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e

        If tmp.KeyChar = ChrW(Keys.Enter) Then

            If MEBTPO.Value <> 0 Then

                mebPrice.Text = ((MEBTPO.Text * mebDISC.Text) / 100)


            End If

        End If

    End Sub

    Private Sub mebPrice_TextChanged(sender As Object, e As EventArgs) Handles mebPrice.TextChanged

        If String.IsNullOrWhiteSpace(mebPrice.Text) Then

            ND()

        End If

    End Sub


    Private Function AddPO(pSupplier As String, pVCode As String, pMOrdered As Date, pDDate As Date, pCurrency As String, pDiscount As Decimal, pDAmount As Decimal,
                       pPTO As Decimal, pPOAmt As Decimal, pRemarks As String, pSignature As String, pRate As Decimal) As String
        dtCreatepo = cCreatePO.CreatePo(pSupplier, pVCode, pMOrdered, pDDate, pCurrency, pDiscount, pDAmount, pPTO, pPOAmt, pRemarks, pSignature, pRate)
        Return dtCreatepo.Rows(0).Item("OB_Line").ToString()
    End Function

    Private Function AddPOI(pchk As String, pPRNUM As String, pQTY As Decimal, pMO As Date, pSignature As String, pUP As Decimal, pTC As Decimal,
                        pCurrency As String, pDD As Date, pRate As Decimal, pfldMOID As String, pQTYOUT As Decimal) As String
        dtCreatePOI = cCreatePOI.cAddPOI(pchk, pPRNUM, pQTY, pMO, pSignature, pUP, pTC, pCurrency, pDD, pRate, pfldMOID, pQTYOUT)
        Return dtCreatePOI.Rows(0).Item("OB_Detail_ID").ToString()

    End Function



    Private Sub btnPO_Click(sender As Object, e As EventArgs) Handles btnPO.Click

        Dim venCode As String = VCdd.Text
        Dim remarks As String = tbcRemakrs.Text

        Dim chik As String = AddPO(pSupplier:=Supdd.Text, pVCode:=venCode, pMOrdered:=dtpMO.Value, pDDate:=dtpDD.Value,
        pCurrency:=tbCurrency.Text, pDiscount:=Convert.ToDecimal(mebDISC.Value), pDAmount:=Convert.ToDecimal(mebPrice.Value),
        pPTO:=Convert.ToDecimal(MEBTPO.Value), pPOAmt:=Convert.ToDecimal(mebTotal.Value), pRemarks:=remarks, pSignature:=tbSignature.Text,
        pRate:=Convert.ToDecimal(mebRate.Value))

        For y As Integer = 0 To gvCreatePO.ChildRows.Count - 1
            gvCreatePO.ChildRows(y).Cells("OB_LINE").Value = chik
            gvCreatePO.ChildRows(y).Cells("PO").Value = mebTotal.Value
            gvCreatePO.ChildRows(y).Cells("fldSupplier").Value = venCode
            gvCreatePO.ChildRows(y).Cells("Remarks").Value = remarks
        Next

        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("INSERTED PO", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        '---------------------AddPO---------------------

        '---------------------AddPOI---------------------
        For x As Integer = 0 To gvCreatePO.ChildRows.Count - 1




            Dim UP As Decimal = Convert.ToDecimal(gvCreatePO.ChildRows(x).Cells("Price").Value)
            Dim TC As Decimal = Convert.ToDecimal(gvCreatePO.ChildRows(x).Cells("PO").Value)
            Dim QTY As Integer = Convert.ToInt32(gvCreatePO.ChildRows(x).Cells("fldQTYEB").Value)
            Dim PRNum As String = gvCreatePO.ChildRows(x).Cells("fldPRNo").Value.ToString
            Dim DD As Date = dtpDD.Value
            Dim MO As Date = dtpMO.Value
            Dim fldMOID As String = gvCreatePO.ChildRows(x).Cells("fldMOIID").Value.ToString
            Dim QTYOUT As Integer
            Integer.TryParse(gvCreatePO.ChildRows(x).Cells("fldQTYSOUT").Value?.ToString(), QTYOUT)




            Dim newDetailID As String = AddPOI(
            pchk:=chik,
            pPRNUM:=PRNum,
            pQTY:=QTY,
            pMO:=MO,
            pSignature:=tbSignature.Text,
            pUP:=UP,
            pTC:=TC,
            pCurrency:=tbCurrency.Text,
            pDD:=DD,
            pRate:=Convert.ToDecimal(mebRate.Value),
            pfldMOID:=fldMOID,
            pQTYOUT:=QTYOUT)
            gvCreatePO.ChildRows(x).Cells("DetailID").Value = newDetailID


        Next



        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("INSERTED POI", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)



        Try
            '-------------------'
            '-- EXPORT TO SAP --'
            '-------------------'

            Dim exporter As ExportToCSV = New ExportToCSV(gvCreatePO)
            exporter.FileExtension = "csv"

            Dim Time As String = System.DateTime.Now.ToString("ddMMyyyyHHmmss")
            exporter.SummariesExportOption = SummariesOption.DoNotExport

<<<<<<< HEAD
            'Dim fileName As String = "\\192.168.191.48\Test-Backup$" & "\" & Time & ".csv"
            Dim fileName As String = Application.StartupPath & Time & ".csv"
=======
            Dim fileName As String = "\\192.168.191.48\Test$" & "\" & Time & ".csv"
            'Dim fileName As String = Application.StartupPath & Time & ".csv"
>>>>>>> dd8e9553c8cbff188d3cc22edca5d42994c578ca

            exporter.RunExport(fileName)

            Dim text As String() = System.IO.File.ReadAllLines(fileName)

            For i As Integer = 0 To text.Length - 1
                text(i) = text(i).Replace("""", "")
            Next

            System.IO.File.WriteAllLines(fileName, text)

            '---------'
            '-- END --'
            '---------'

        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Error exporting to SAP: " & ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
        '----------------------------------------------------------------------
        '----------------------------------------------------
        'New Code replace SAP--------------------------
        'For desktop Program Files
        'Try
        '    '-------------------'
        '    '-- EXPORT TO SAP --'
        '    '-------------------'

        '    Dim exporter As ExportToCSV = New ExportToCSV(gvCreatePO)
        '    exporter.FileExtension = "csv"

        '    Dim Time As String = System.DateTime.Now.ToString("ddMMyyyyHHmmss")
        '    exporter.SummariesExportOption = SummariesOption.DoNotExport

        '    Dim fileName As String = Application.StartupPath + "\Test-SAP-INTIGRATION" & "\" & Time & ".csv"

        '    exporter.RunExport(fileName)

        '    Dim text As String() = System.IO.File.ReadAllLines(fileName)

        '    For i As Integer = 0 To text.Length - 1
        '        text(i) = text(i).Replace("""", "")
        '    Next

        '    System.IO.File.WriteAllLines(fileName, text)

        '    '---------'
        '    '-- END --'
        '    '---------'

        'Catch ex As Exception

        'End Try
        '------------------------------------------------


    End Sub


End Class
