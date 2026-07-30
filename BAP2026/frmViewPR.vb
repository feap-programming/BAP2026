Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents.Spreadsheet.Expressions.Functions

Public Class FrmNew_Purchase_Requisition


    Dim cGetPRItems As New cGetPRITEMS

    Dim dtPRITEMS As New DataTable

    Dim VIEWPRUI As New cViewPRUI

    Dim cSelectPRNOView As New cSelectPRSEARCH

    Dim dtSelectPRNO As New DataTable

    Dim PRLISTUI As New cViewPRUI

    Dim cgetPRbyDEPT As New cLoadPRDEPT

    Dim dtPRBYDEPT As New DataTable

    Dim cusers As New cselectUsers

    Dim cVPRREMOVE As New cVPRRemove

    Dim dtVPREMOVE As New DataTable

    Private _selectedDept As String


    Public Property SelectedDept As String
        Get
            Return _selectedDept
        End Get
        Set(value As String)
            _selectedDept = value
        End Set

    End Property


    Private Sub FrmNew_Purchase_Requisition_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadAllFields()


    End Sub



    Private Sub LoadAllFields()


        VIEWPRUI.DesigngridPR(gvPRLIST)

        PRLISTUI.DesigngridPRlist(gvLIST)

        'GetPRSEARCH(prno:=tbSearch.Text)

        AddHandler gvPRLIST.CommandCellClick, AddressOf PRCommandCellClick


        dtpFrom.Value = DateTime.Now.AddDays(-7)
        dtpTo.Value = DateTime.Today


        LoadDept()

        'getPRbyDEPT()


    End Sub

    Private Sub PRCommandCellClick(sender As Object, e As GridViewCellEventArgs)

        Select Case gvPRLIST.CurrentColumn.Name

            Case "PRINT PR"

                printPR()


            Case "PRINTSUM"

                PrintSummary()


            Case "REMOVE"

                RemovePR()


        End Select



    End Sub

    Private Sub PrintPR()

        Dim prNo As String =
        gvPRLIST.CurrentRow.Cells("fldPRNo").Value.ToString()


        'your report call here

    End Sub

    Private Sub VPRREMOVE()

        Dim porderID As Integer = gvPRLIST.CurrentRow.Cells("fldOrderID").Value
        Dim pTranscode As String = gvPRLIST.CurrentRow.Cells("fldTransCode").Value
        Dim pPRNO As String = gvPRLIST.CurrentRow.Cells("fldPRNo").Value



        dtVPREMOVE = cVPRREMOVE.removeVPR(pOrderID:=porderID, pTranscode:=pTranscode, pPRNO:=pPRNO)

        'Dim FMONTH As Date = dtpFrom.Value
        'Dim FYEAR As Date = dtpTo.Value
        'Dim Dept As String = cbDept.Text

        ''Dim prno As String = tbSearch.Text.Trim()



        'dtPRBYDEPT = cgetPRbyDEPT.loadPRDEPT(FMONTH:=FMONTH, fyear:=FYEAR, dept:=Dept)


    End Sub

    Private Sub RemovePR()

        Dim orderID As String = gvPRLIST.CurrentRow.Cells("fldOrderID").Value.ToString()

        If gvLIST.CurrentRow.Cells("fldStat").Value = "REMOVED" Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Item is Already Removed!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub

        ElseIf gvLIST.CurrentRow.Cells("fldStat").Value = "CLOSE" Then

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Item is Already Close!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub

        End If

        If gvPRLIST.SelectedRows.Count > 0 Then

            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show(
            "Are you sure you want to remove this PR?",
            "Remove PR",
            MessageBoxButtons.YesNo,
            RadMessageIcon.Question) = DialogResult.Yes Then


                '-----------DELETE FUNCTION -*----------

                VPRREMOVE()


                '-----------DELETE FUNCTION -*----------

                RadMessageBox.Show("Remove Complete")

                getPRbyDEPT()

            End If

            'Create class later:
            'cDeletePR.Remove(orderID)

            'RadMessageBox.Show("Remove Complete")

            'getPRbyDEPT()

        End If


    End Sub

    Private Sub PrintSummary()

        Dim budRef As String =
        gvPRLIST.CurrentRow.Cells("fldBudRefNum").Value.ToString()


        'open summary report

    End Sub

    Public Sub LoadDept()

        Dim dt As DataTable

        dt = cusers.SelectedDepartmentByUser(GlobalVariables.empNo)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

            With cbDept
                .DataSource = dt
                .DisplayMember = "DeptCode"
                .ValueMember = "DeptCode"
            End With

            'Select the saved department
            If Not String.IsNullOrEmpty(GlobalVariables.SelectedDept) Then
                cbDept.SelectedValue = GlobalVariables.SelectedDept
            End If

        Else
            MessageBox.Show("No Departments found for user: " & GlobalVariables.empNo)
        End If

    End Sub


    Public Sub getprItems(Transcode As String)




        dtPRITEMS = cGetPRItems.GetPrItems(Transcode)


    End Sub

    Public Sub GetPRSEARCH(prno As String)

        dtPRITEMS = cSelectPRNOView.getPRSirts(prno)

        gvPRLIST.DataSource = dtPRITEMS

    End Sub

    Public Sub getPRbyDEPT()

        Dim FMONTH As Date = dtpFrom.Value
        Dim FYEAR As Date = dtpTo.Value
        Dim Dept As String = cbDept.Text

        'Dim prno As String = tbSearch.Text.Trim()



        dtPRBYDEPT = cgetPRbyDEPT.loadPRDEPT(FMONTH:=FMONTH, fyear:=FYEAR, dept:=Dept)

        gvPRLIST.DataSource = dtPRBYDEPT

    End Sub
    Public Sub getpritems()

        Dim transcode As String = gvPRLIST.CurrentRow?.Cells("fldTransCode")?.Value?.ToString()

        'getprItems(Transcode:=transcode)

        dtPRITEMS = cGetPRItems.GetPrItems(Transcode:=transcode)
        gvLIST.DataSource = dtPRITEMS

    End Sub


    Public Sub LoadDatafields()

        Dim pangalan As New List(Of String)

        pangalan.Add(GlobalVariables.SelectedDept)
        pangalan.Add(GlobalVariables.empFirstName)

        If Not String.IsNullOrWhiteSpace(GlobalVariables.empMiddleName) Then

            pangalan.Add(GlobalVariables.empMiddleName)

        End If

        pangalan.Add(GlobalVariables.empLastName)


        lblOrderID.Text = gvPRLIST.CurrentRow.Cells("fldOrderID").Value.ToString
            ccbBudgetRef.Text = gvPRLIST.CurrentRow.Cells("fldBudRefNum").Value.ToString
            txtPRNNO.Text = gvPRLIST.CurrentRow.Cells("fldPRNo").Value.ToString
            tbRN.Text = gvPRLIST.CurrentRow.Cells("fldRN").Value.ToString
            tbMoldie.Text = gvPRLIST.CurrentRow.Cells("fldMoldDie").Value.ToString
            dtpMO.Value = gvPRLIST.CurrentRow.Cells("fldMonthOrder").Value.ToString
            TBCDESC.Text = gvPRLIST.CurrentRow.Cells("fldOrderDesc").Value.ToString
            ClassiPIKASYON.Text = gvPRLIST.CurrentRow.Cells("fldClassification").Value.ToString
            cbProcess.Text = gvPRLIST.CurrentRow.Cells("fldProcess").Value.ToString
            QTY.Text = gvPRLIST.CurrentRow.Cells("fldQTY").Value.ToString
            CBUOM.Text = gvPRLIST.CurrentRow.Cells("fldUOM").Value.ToString
            mebRQTY.Text = gvPRLIST.CurrentRow.Cells("RQTY").Value.ToString
            ccbStatus.Text = gvPRLIST.CurrentRow.Cells("fldOrderStatus").Value.ToString
            tbcRison.Text = gvPRLIST.CurrentRow.Cells("fldReason").Value.ToString
            mebAmt.Text = gvPRLIST.CurrentRow.Cells("fldEOA").Value.ToString
            mebEPA.Text = gvPRLIST.CurrentRow.Cells("fldEJPY").Value.ToString
            ddlCurrency.Text = gvPRLIST.CurrentRow.Cells("fldEC").Value.ToString
            mebTOPRA.Text = gvPRLIST.CurrentRow.Cells("fldTOPRA").Value.ToString
            mebTOPDRA.Text = gvPRLIST.CurrentRow.Cells("fldTDOPRA").Value.ToString
            mebRBLPR.Text = gvPRLIST.CurrentRow.Cells("fldRBLPR").Value.ToString
            mebDBLPR.Text = gvPRLIST.CurrentRow.Cells("fldRDBLPR").Value.ToString
            mebBremBUDGET.Text = gvPRLIST.CurrentRow.Cells("fldRB").Value.ToString
            mebRemDeptBUDGET.Text = gvPRLIST.CurrentRow.Cells("fldRDB").Value.ToString
            tbcReamarks.Text = gvPRLIST.CurrentRow.Cells("fldOrderRemarks").Value.ToString
            RadTextBox14.Text = String.Join("-", pangalan)
            'RadTextBox14.Text = GlobalVariables.SelectedDept & "-" & GlobalVariables.empFirstName & "-" & "-" & "-" & GlobalVariables.empLastName


            If ccbStatus.Text = "CLOSE" Then

                ccbBudgetRef.Enabled = False
            'cbDept.Enabled = False

            'mebjpy.enable = false
            ccbStatus.Enabled = False
                'btnsub.enable = true

            Else

                ccbBudgetRef.Enabled = False
                ccbStatus.Enabled = True
                cbDept.Enabled = False

                'mebjpy.enable = true   

                'btnsub.enable = true


            End If


            tbcRison.Enabled = True


    End Sub


    Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click


        'getpritems()

        getPRbyDEPT()


    End Sub

    Private Sub btnSirts_Click(sender As Object, e As EventArgs) Handles btnSirts.Click

        Dim prno As String = tbSearch.Text.Trim()

        'GetPRSEARCH(prno)


        GetPRSEARCH(prno)

    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged



    End Sub

    Private Sub gvPRLIST_CellClick(sender As Object, e As GridViewCellEventArgs) Handles gvPRLIST.CellClick




        If e.Column.Name <> "PRINTPR" AndAlso
           e.Column.Name <> "PRINTSUM" AndAlso
           e.Column.Name <> "REMOVE" Then

            getpritems()
            LoadDatafields()


        End If


    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click


        getPRbyDEPT()


    End Sub
End Class
