Imports System.Text.RegularExpressions
Imports Mysqlx.Crud
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmRFQ

    Dim readyGv As New cGvAllEmployees
    Dim readyGvRFQ As New cGvRFQ
    Dim selectApprovers As New cSelectEmp
    Dim selectExpense As New cSelectRFQ
    Dim selectUOM As New cSelectBapUOM
    Dim selectRFQ As New cSelectRFQ

    Dim insertRFQ As New cInsertRFQ

    Dim RFQNoCheck As Int16

    Private lineNo As Integer
    Private lineStat As String

    Private Sub loadEmployee()
        txtEmpNo.Text = GlobalVariables.empNo
        txtName.Text = GlobalVariables.empFirstName & " " & GlobalVariables.empMiddleName & " " & GlobalVariables.empLastName
        txtDept.Text = GlobalVariables.empDept
        txtSection.Text = GlobalVariables.empSection
    End Sub

    Private Sub loadCheckers()
        Dim dt As DataTable
        dt = selectApprovers.SelectRFQUsers()
        If dt.Rows.Count > 0 Then
            mcbCheckedBy.DataSource = dt
            mcbCheckedBy.DisplayMember = "empName"
            mcbCheckedBy.ValueMember = "fldJobTitle"
        End If
    End Sub

    Private Sub loadApprovers()
        Dim dt As DataTable
        dt = selectApprovers.SelectRFQUsers()
        If dt.Rows.Count > 0 Then
            mcbApprovedBy.DataSource = dt
            mcbApprovedBy.DisplayMember = "empName"
            mcbApprovedBy.ValueMember = "fldJobTitle"
        End If
    End Sub

    Private Sub loadTypeOfExpense()
        Dim dt As DataTable
        dt = selectExpense.selectTypeOfExpense()
        If dt.Rows.Count > 0 Then
            ddExpenseType.DataSource = dt
            ddExpenseType.DisplayMember = "fldExpense"
            ddExpenseType.ValueMember = "fldExpense"
            ddExpenseType.SelectedIndex = -1
        End If
    End Sub

    Private Sub loadUOM()
        Dim dt As DataTable
        dt = selectUOM.selectUOM()
        If dt.Rows.Count > 0 Then
            ddUOM.DataSource = dt
            ddUOM.DisplayMember = "fldUOM"
            ddUOM.ValueMember = "fldUOM"
            ddUOM.SelectedIndex = -1
        End If
    End Sub

    Private Sub loadRFQList()
        Dim dt As DataTable
        dt = selectRFQ.selectRFQBySelectedDept(GlobalVariables.SelectedDept)
        If dt.Rows.Count > 0 Then
            gvData.DataSource = dt
        End If
    End Sub

    Private Sub FrmRFQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readyGvRFQ.readyGvRFQItems(gvItems)
        readyGvRFQ.readyGvRFQList(gvData)
        readyGv.readyMcbCheckers(mcbCheckedBy)
        readyGv.readyMcbApprovers(mcbApprovedBy)

        loadRFQList()
        loadEmployee()
        loadTypeOfExpense()
        loadUOM()
        loadCheckers()
        loadApprovers()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If String.IsNullOrEmpty(ddExpenseType.Text) Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("No Type of Expense selected", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf String.IsNullOrEmpty(txtItemDesc.Text) Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("Please input Item Description", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf (seQty.Value = 0) Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("Zero Quantity is not allowed", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddUOM.Text) Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("No Unit of Measurement Selected", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else

            Dim Chemical As Boolean

            If rbChemNo.IsChecked = True Then
                Chemical = 0
            Else
                Chemical = 1
            End If

            Dim PPE As Boolean

            If rbPPENo.IsChecked = True Then
                PPE = 0
            Else
                PPE = 1
            End If

            Dim count As Integer = gvData.Rows.Count

            If count >= 15 Then
                RadMessageBox.SetThemeName("VisualStudio2022Light")
                RadMessageBox.Show("15 Items only per Purchased Requisition", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Else
                gvItems.Rows.Add("", ddExpenseType.SelectedValue, txtItemDesc.Text, seQty.Value, ddUOM.Text, dtDate.Value, txtRemarks.Text, Chemical, PPE)

            End If

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim bInsert As Boolean
        Dim dt As DataTable
        Dim currentRowCheckedBy As GridViewDataRowInfo = CType(mcbCheckedBy.SelectedItem, GridViewDataRowInfo)
        Dim currentRowApprovedBy As GridViewDataRowInfo = CType(mcbApprovedBy.SelectedItem, GridViewDataRowInfo)

        If txtName.Text Is Nothing Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("Please Contact MIS for this problem", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If mcbApprovedBy.SelectedItem.ToString = "" Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("Please input approved by", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If mcbCheckedBy.SelectedItem.ToString = "" Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("Please input checked by", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If
        If txtID.Text = "" Then
            RFQNoCheck = 0
        Else
            RFQNoCheck = Convert.ToInt16(txtID.Text)
        End If
        RadMessageBox.SetThemeName("VisualStudio2022Light")
        If RadMessageBox.Show("Are you sure want to upload the data?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then


            bInsert = insertRFQ.InsertRFQ(RFQNoCheck, dtDate.Value.ToString("yyyy-MM-dd"),
                                          Regex.Replace(Trim(txtName.Text), "\s+", " "), txtDept.Text, txtSection.Text, mcbCheckedBy.Text, mcbApprovedBy.Text,
                                          currentRowCheckedBy.Cells("fldJobTitle").Value.ToString, currentRowApprovedBy.Cells("fldJobTitle").Value.ToString)

            'MsgBox(currentRowCheckedBy.Cells("fldJobTitle").Value.ToString)
            'MsgBox(mcbCheckedBy.Text)

            If bInsert Then

                ''----------------------Insert Section list
                'Zaji.addParameter("Section", ddlSection.Text)
                'Zaji.addParameter("Dept", txtDept.Text);
                'Dim dtInsert As DataTable = Zaji.dbSelect("SP_InsertSectionList")

                ''--------------------insert Checked and Approved logs
                'Zaji.addParameter("Checked", ddlCheckedBy.Text)
                'Zaji.addParameter("Approved", ddlApprovedBy.Text)
                'Zaji.addParameter("Dept", txtDept.Text)
                'Dim dtInsertCALogs As DataTable = Zaji.dbSelect("SP_InsertCALogs")

                dt = selectExpense.selectLastCreatedRFQByDept(txtDept.Text, txtSection.Text)

                If dt.Rows.Count > 0 Then
                    txtRFQNo.Text = Convert.ToString(dt.Rows(0).Item("RFQNo"))
                    txtID.Text = Convert.ToString(dt.Rows(0).Item("fldRFQNo"))
                End If

                bwSave.RunWorkerAsync()

            End If
        End If
    End Sub

    Private Sub bwSave_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwSave.DoWork
        Dim delay As Integer = 20
        Dim bInsert As Boolean
        Dim chemical, ppe As String

        'Zaji.addParameter("RFQNo", txtID.Text)
        'Zaji.dbAED("SP_DeletRFQChildByRFQNo")
        Dim count = 0
        For x As Integer = 0 To gvItems.Rows.Count - 1
            count = count + 1

            chemical = If(gvItems.Rows(x).Cells("fldChemical").Value = True, "YES", "NO")
            ppe = If(gvItems.Rows(x).Cells("fldPPE").Value = True, "YES", "NO")

            'MsgBox("RFQNo: " & RFQNoCheck & vbCrLf &
            '       "Type of Expense: " & gvItems.Rows(x).Cells("fldTypeOfExpense").Value & vbCrLf &
            '       "Description: " & gvItems.Rows(x).Cells("fldDescription").Value & vbCrLf &
            '       "Qty: " & gvItems.Rows(x).Cells("fldQty").Value & vbCrLf &
            '       "UOM: " & gvItems.Rows(x).Cells("fldUOM").Value & vbCrLf &
            '       "Date Needed: " & Convert.ToDateTime(gvItems.Rows(x).Cells("fldDateNeeded").Value).ToString("yyyy-MM-dd") & vbCrLf &
            '       "Remarks: " & gvItems.Rows(x).Cells("fldRemarks").Value & vbCrLf &
            '       "Chemical: " & chemical & vbCrLf &
            '       "PPE: " & ppe)

            bInsert = insertRFQ.InsertRFQChild(txtID.Text, gvItems.Rows(x).Cells("fldTypeOfExpense").Value, gvItems.Rows(x).Cells("fldDescription").Value,
                                               gvItems.Rows(x).Cells("fldQty").Value, gvItems.Rows(x).Cells("fldUOM").Value,
                                               Convert.ToDateTime(gvItems.Rows(x).Cells("fldDateNeeded").Value).ToString("yyyy-MM-dd"), gvItems.Rows(x).Cells("fldRemarks").Value,
                                               chemical, count, ppe)

            'If bInsert Then
            '    lineStat = "OK"
            'Else
            '    lineStat = "NG"
            'End If

            'Dim percent As Double = x / gvItems.Rows.Count * 100

            'lineNo = x
            'pbItems.Text = "Saving..."
            'bwSave.ReportProgress(Convert.ToInt32(percent))
            'Threading.Thread.Sleep(delay)
        Next
    End Sub

    Private Sub bwSave_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwSave.ProgressChanged
        gvItems.CurrentRow = gvItems.Rows(lineNo)
        gvItems.CurrentRow.Cells(0).Value = lineStat
        pbItems.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwSave_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwSave.RunWorkerCompleted
        pbItems.Value1 = 100
        pbItems.Text = "Done"
        RadMessageBox.SetThemeName("VisualStudio2022Light")
        If RadMessageBox.Show("Successfully Saved", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info) = DialogResult.OK Then
            pbItems.Text = String.Empty
            pbItems.Value1 = 0
            loadRFQList()
        End If
    End Sub
End Class
