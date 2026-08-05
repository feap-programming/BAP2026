Imports Telerik.Pdf
Imports Telerik.WinControls

Public Class FrmViewPO


    Dim cusers As New cselectUsers

    Dim cGetPOBYDATE As New cGetPoByDate

    Dim dtPOBYDATE As New DataTable

    Dim cVPOUI As New cVPOUI

    Dim cVPOIUI As New cVPOUI

    Dim cGetPOITEMS As New cGetPOIItems

    Dim dtPOIITEMS As New DataTable

    Dim cPONO As New cGetPONO

    Dim dtPONO As New DataTable

    Dim cCloseOpenPOI As New cUpdateClosePOI

    Dim dtCloseOpenPOI As New DataTable

    Dim cCloseOpenMOI As New cCloseOPenMOI

    Dim dtCloseOPenMoi As New DataTable

    Dim cCloseOpenPO As New cCloseOpenPO

    Dim dtCloseopenpo As New DataTable

    Dim cCancelPOI As New cCancelPOI

    Dim dtcancelpoi As New DataTable

    Dim cCancelMOI As New cCancelMOI

    Dim dtCancelMoi As New DataTable

    Dim cCancelPO As New cCancelPO

    Dim dtcancelPO As New DataTable


    Private _selectedDept As String
    Public Property SelectedDept As String
        Get
            Return _selectedDept
        End Get
        Set(value As String)
            _selectedDept = value
        End Set
    End Property

    Private Sub FrmViewPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadFields()

    End Sub


    Public Sub LoadFields()

        For i As Integer = 1 To 12
            ddMonth.Items.Add(i)
        Next

        For year As Integer = 2015 To Today.Year
            ddYear.Items.Add(year)
        Next


        ddMonth.SelectedIndex = Today.Month - 1
        ddYear.Text = Today.Year.ToString()

        dtMO.Value = Today
        dtDD.Value = Today




        LoadDept()

        cVPOUI.rgvPOLIST(gvPOLIST)
        cVPOIUI.POIGRID(gvPOILIST)

        'selectPONO()

        GetPOByDate(FMONTH:=ddMonth.Text, FYEAR:=ddYear.Text, DEPT:=ddlDept.Text)

        'tbcRemarks.Text = GlobalVariables.SelectedDept

    End Sub

    Public Sub LoadDept()

        Dim dt As DataTable

        dt = cusers.SelectedDepartmentByUser(GlobalVariables.empNo)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

            With ddlDept
                .DataSource = dt
                .DisplayMember = "DeptCode"
                .ValueMember = "DeptCode"
            End With

            'Select the saved department
            If Not String.IsNullOrEmpty(GlobalVariables.SelectedDept) Then
                ddlDept.SelectedValue = GlobalVariables.SelectedDept
            End If

        Else
            MessageBox.Show("No Departments found for user: " & GlobalVariables.empNo)
        End If

    End Sub




    'Public Sub GetPOByDate(FMONTH As Decimal, FYEAR As Decimal, DEPT As String)

    '    Dim dt As DataTable = cGetPOBYDATE.getPObyDate(FMONTH:=ddMonth.Text, FYEAR:=ddYear.Text, DEPT:=ddlDept.Text)

    '    If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

    '        With gvPOLIST


    '            .DataSource = dt


    '        End With

    '    End If

    '    If Not dt.Columns.Contains("PO") Then
    '        dt.Columns.Add("PO")
    '    End If

    '    For Each row As DataRow In dt.Rows
    '        row("PO") = GetPONo(row("OB_Line").ToString())
    '    Next

    '    gvPOLIST.DataSource = dt


    'End Sub

    Public Sub GetPOByDate(FMONTH As Decimal, FYEAR As Decimal, DEPT As String)


        Dim dt As DataTable = cGetPOBYDATE.getPObyDate(
        FMONTH,
        FYEAR,
        DEPT
    )


        If dt Is Nothing Then
            Exit Sub
        End If


        'Create new PO column
        'If Not dt.Columns.Contains("PO") Then
        '    dt.Columns.Add("PO")
        'End If


        ''Match OB_LINE with SAP U_HeaderID
        'For Each row As DataRow In dt.Rows

        '    'row("PO") = GetPONO

        '    row("OB_LINE").ToString()


        'Next


        gvPOLIST.DataSource = dt


    End Sub

    'Public Sub selectPONO()

    '    Dim pono = gvPOLIST.CurrentRow?.Cells("PO")?.Value?.ToString()

    '    dtPONO = cPONO.SelectOPOR()


    '    If dtPONO Is Nothing Then

    '        MessageBox.Show("SAP query returned Nothing")
    '        Exit Sub

    '    End If


    '    MessageBox.Show(
    '    "SAP PO Count: " & dtPONO.Rows.Count
    ')

    'End Sub

    'Public Sub selectPONO()

    '    dtPONO = cPONO.SelectOPOR()

    '    dtPONO = New DataTable()

    '    dtPONO.Columns.Add("DocNum")
    '    dtPONO.Columns.Add("U_HeaderID")


    '    dtPONO.Rows.Add("4500001", "POID59")
    '    dtPONO.Rows.Add("4500002", "POID57")

    '    dtPONO.Rows.Add("4500003", "POID56")
    '    dtPONO.Rows.Add("4500004", "POID55")

    '    dtPONO.Rows.Add("4500005", "POID54")
    '    dtPONO.Rows.Add("4500006", "POID53")

    'End Sub


    Public Sub getPOITEMS()


        Dim dbline = gvPOLIST.CurrentRow?.Cells("OB_LINE")?.Value?.ToString()

        dtPOIITEMS = cGetPOITEMS.getPOITEMS(dbline)
        gvPOILIST.DataSource = dtPOIITEMS


    End Sub



    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click


        GetPOByDate(FMONTH:=ddMonth.Text, FYEAR:=ddYear.Text, DEPT:=ddlDept.Text)


    End Sub


    'Function GetPONO(ByVal OB_Line As String) As String

    '    Try

    '        If dtPONO Is Nothing Then
    '            MessageBox.Show("dtPONO is Nothing")
    '            Return ""
    '        End If


    '        Dim row = dtPONO.AsEnumerable().
    '        FirstOrDefault(Function(r)
    '                           Return r("U_HeaderID").ToString() = OB_Line
    '                       End Function)


    '        If row Is Nothing Then

    '            MessageBox.Show("No SAP PO found for: " & OB_Line)
    '            Return ""

    '        End If


    '        Return row("DocNum").ToString()


    '    Catch ex As Exception

    '        MessageBox.Show(ex.Message)
    '        Return ""

    '    End Try

    'End Function


    Private Sub getPOLIST()


        tbSup.Text = gvPOLIST.CurrentRow.Cells("fldSupplier").Value.ToString
        tbVendor.Text = gvPOLIST.CurrentRow.Cells("fldVCode").Value.ToString
        tbCurrency.Text = gvPOLIST.CurrentRow.Cells("fldCurrency").Value.ToString
        dtMO.Value = (gvPOLIST.CurrentRow.Cells("fldMOrdered").Value)
        dtDD.Value = (gvPOLIST.CurrentRow.Cells("fldDDate").Value)
        MEBTPO.Value = (gvPOLIST.CurrentRow.Cells("fldTPO").Value)
        MEBDISC.Value = (gvPOLIST.CurrentRow.Cells("fldDiscount").Value)
        MEBPrice.Value = (gvPOLIST.CurrentRow.Cells("fldTPO").Value)
        MEBTOTAL.Value = (gvPOLIST.CurrentRow.Cells("OB_POAmt").Value)
        tbcRemarks.Text = gvPOLIST.CurrentRow.Cells("fldRemarks").Value.ToString


    End Sub


    Private Sub gvPOLIST_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles gvPOLIST.CellDoubleClick

        'getPOLIST()
        'getPOITEMS()

    End Sub

    Private Sub gvPOLIST_CellClick(sender As Object, e As UI.GridViewCellEventArgs) Handles gvPOLIST.CellClick


        getPOLIST()
        getPOITEMS()


    End Sub


    Public Sub CloseOPENPOI(POIID As Integer, Index As Integer)



        dtCloseOpenPOI = cCloseOpenPOI.CloseDropPOI(POIID, Index)

    End Sub


    Public Sub CloseOpenMOI(pMoiid As Integer, pSOUT As Decimal)


        dtCloseOPenMoi = cCloseOpenMOI.closeOpenMoi(pMoiid, pSOUT)


    End Sub

    Public Sub CloseOpenPO(pobline As String, pindex As String, pRemarks As String, pCancelSign As String)

        dtCloseopenpo = cCloseOpenPO.CloseOpenPO(pobline, pindex, pRemarks, pCancelSign)

    End Sub


    Public Sub cancelpoi(pPOIID As Integer, pIndex As Integer)

        dtcancelpoi = cCancelPOI.CancelPOI(pPOIID, pIndex)

    End Sub

    Public Sub cancelMOI(pmoiid As Integer, pSOUT As Decimal)


        dtCancelMoi = cCancelMOI.CancelMOI(pmmoid:=pmoiid, pSOUT:=pSOUT)

    End Sub


    Public Sub cancelPO(pobline As String, pindex As String, pRemarks As String, pcancelSign As String)

        dtcancelPO = cCancelPO.CancelPO(pobline:=pobline, pindex:=pindex, pRemarks:=pRemarks, pCancelSign:=pcancelSign)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        RadMessageBox.SetThemeName("Windows8")

        If String.IsNullOrWhiteSpace(tbcCancelClosePO.Text) Then
            RadMessageBox.Show("Please insert remarks for Close/Cancel PO.",
                       "Notification",
                       MessageBoxButtons.OK,
                       RadMessageIcon.Info)
            tbcCancelClosePO.Focus()
            Exit Sub
        End If

        RadMessageBox.SetThemeName("Windows8")

        If RadMessageBox.Show("WARNING. This operation is irreversible. Are you sure you want to close this item(s)?",
                      "Notification",
                      MessageBoxButtons.YesNo,
                      RadMessageIcon.Question,
                      MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim OB_LineUp As String = gvPOLIST.CurrentRow.Cells("OB_Line").Value.ToString()
        Dim IndexPO As Integer = CInt(gvPOLIST.CurrentRow.Cells("fldIndex").Value)

        For x As Integer = 0 To gvPOILIST.ChildRows.Count - 1

            Dim POIID As Integer = CInt(gvPOILIST.ChildRows(x).Cells("fldPOIID").Value)
            Dim Index As Integer = CInt(gvPOILIST.ChildRows(x).Cells("fldIndex").Value)
            Dim SOUT As Decimal = CDec(gvPOILIST.ChildRows(x).Cells("RQTY").Value)
            Dim MOIID As Integer = CInt(gvPOILIST.ChildRows(x).Cells("fldMOIID").Value)


            '---------------------- Close FUNCTION POI ----------------------------------

            CloseOPENPOI(POIID, Index)

            '---------------------- End of Close FUNCTION POI ----------------------------------

            '---------------------- Close FUNCTION MOI ----------------------------------


            CloseOpenMOI(pMoiid:=MOIID, pSOUT:=SOUT)


            '---------------------- End of Close FUNCTION MOI ----------------------------------

        Next


        '---------------------- Close FUNCTION PO ----------------------------------

        CloseOpenPO(
            pobline:=OB_LineUp,
            pindex:=IndexPO,
            pRemarks:=tbcCancelClosePO.Text,
            pCancelSign:=GlobalVariables.SelectedDept & "-" &
                         GlobalVariables.empFirstName &
                         GlobalVariables.empMiddleName & "-" &
                         GlobalVariables.empLastName)

        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("Items Closed Successfully.")


        GetPOByDate(FMONTH:=ddMonth.Text, FYEAR:=ddYear.Text, DEPT:=ddlDept.Text)



        '---------------------- END of Close FUNCTION PO ----------------------------------


    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click


        RadMessageBox.SetThemeName("Windows8")

        If String.IsNullOrWhiteSpace(tbcCancelClosePO.Text) Then
            RadMessageBox.Show("Please insert remarks for Close/Cancel PO.",
                       "Notification",
                       MessageBoxButtons.OK,
                       RadMessageIcon.Info)
            tbcCancelClosePO.Focus()
            Exit Sub
        End If

        RadMessageBox.SetThemeName("Windows8")

        If RadMessageBox.Show("WARNING. This operation is irreversible. Are you sure you want to close this item(s)?",
                      "Notification",
                      MessageBoxButtons.YesNo,
                      RadMessageIcon.Question,
                      MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
            Exit Sub
        End If


        Dim ob_line As String = gvPOLIST.CurrentRow.Cells("OB_Line").Value.ToString()
        Dim indexpo As Integer = CInt(gvPOLIST.CurrentRow.Cells("fldIndex").Value.ToString)

        For x As Integer = 0 To gvPOILIST.ChildRows.Count - 1

            Dim POIID As Integer = CInt(gvPOILIST.ChildRows(x).Cells("fldPOIID").Value)
            Dim index As Integer = CInt(gvPOILIST.ChildRows(x).Cells("fldIndex").Value)
            Dim sout As Integer = CInt(gvPOILIST.ChildRows(x).Cells("RQTY").Value)
            Dim MOIID As Integer = CInt(gvPOILIST.ChildRows(x).Cells("fldMOIID").Value)





            '---------------------- Close FUNCTION POI ----------------------------------


            cancelpoi(pPOIID:=POIID, pIndex:=index)



            '---------------------- End of Close FUNCTION POI ----------------------------------



            '---------------------- Close FUNCTION MOI ----------------------------------


            cancelMOI(pmoiid:=MOIID, pSOUT:=sout)


            '---------------------- End of Close FUNCTION MOI ----------------------------------




        Next

        '---------------------- Close FUNCTION PO ----------------------------------

        cancelPO(pobline:=ob_line, pindex:=indexpo, pRemarks:=tbcCancelClosePO.Text, pcancelSign:=GlobalVariables.SelectedDept & "-" & GlobalVariables.empFirstName & "-" & GlobalVariables.empMiddleName & " " & GlobalVariables.empLastName)


        '---------------------- End of Close FUNCTION PO ----------------------------------



        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("Items Closed Successfully.")


        GetPOByDate(FMONTH:=ddMonth.Text, FYEAR:=ddYear.Text, DEPT:=ddlDept.Text)



    End Sub




End Class



