Imports System.Text.RegularExpressions
Imports FontAwesome.Sharp
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

    Dim deleteRfq As New cDeleteRFQ

    Dim insertRFQ As New cInsertRFQ

    Dim RFQNoCheck As Int16

    Private lineNo As Integer
    Private lineStat As String

    Dim rfqStatus As String = "NEW"

    Private Sub disableFields()
        dtDate.Enabled = False
        mcbCheckedBy.Enabled = False
        mcbApprovedBy.Enabled = False
        ddExpenseType.Enabled = False
        txtItemDesc.Enabled = False
        seQty.Enabled = False
        ddUOM.Enabled = False
        dtDateNeeded.Enabled = False
        txtRemarks.Enabled = False
        rbChemYes.Enabled = False
        rbChemNo.Enabled = False
        rbPPEYes.Enabled = False
        rbPPENo.Enabled = False
    End Sub

    Private Sub clearFields()
        dtDate.Enabled = True
        mcbCheckedBy.Enabled = True
        mcbApprovedBy.Enabled = True
        ddExpenseType.Enabled = True
        txtItemDesc.Enabled = True
        seQty.Enabled = True
        ddUOM.Enabled = True
        dtDateNeeded.Enabled = True
        txtRemarks.Enabled = True
        rbChemYes.Enabled = True
        rbChemNo.Enabled = True
        rbPPEYes.Enabled = True
        rbPPENo.Enabled = True

        dtDate.Value = DateTime.Now
        mcbCheckedBy.SelectedIndex = -1
        mcbApprovedBy.SelectedIndex = -1
        ddExpenseType.SelectedIndex = -1
        txtItemDesc.Text = String.Empty
        seQty.Value = 0
        ddUOM.SelectedIndex = -1
        dtDateNeeded.Value = DateTime.Now
        txtRemarks.Text = String.Empty
        rbChemYes.CheckState = CheckState.Unchecked
        rbChemNo.CheckState = CheckState.Unchecked
        rbPPEYes.CheckState = CheckState.Unchecked
        rbPPENo.CheckState = CheckState.Unchecked
    End Sub

    Private Sub EditCustomerClaim()

        rfqStatus = "EDIT"
        clearFields()
        Dim dt As DataTable

        btnCancel.Visible = True

        txtRFQNo.Text = Convert.ToString(gvData.CurrentRow.Cells("RFQNo").Value)
        txtID.Text = Convert.ToString(gvData.CurrentRow.Cells("fldRFQNo").Value)

        dt = selectRFQ.selectRFQChildByRFQNo(gvData.CurrentRow.Cells("fldRFQNo").Value)
        If gvItems.Rows.Count > 0 Then
            gvItems.DataSource = Nothing
        End If
        If dt.Rows.Count > 0 Then
            gvItems.DataSource = dt
        End If
    End Sub

    Private Sub DeleteCustomerClaim()
        Dim bDelete, bDeleteChild As Boolean
        RadMessageBox.SetThemeName("Windows11")
        If RadMessageBox.Show("Are you sure you want to delete this?", "Delete Confirmation",
                           MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            bDelete = deleteRfq.DeleteRFQ(gvData.CurrentRow.Cells("fldRFQNo").Value)
            If bDelete Then

                bDeleteChild = deleteRfq.DeleteRFQChild(gvData.CurrentRow.Cells("fldRFQNo").Value)

                If bDeleteChild Then

                    RadMessageBox.SetThemeName("Windows11")
                    RadMessageBox.Show("Data deleted.", "Delete Data",
                                       MessageBoxButtons.OK, RadMessageIcon.Info)

                End If

            End If
        Else
            Exit Sub
        End If
    End Sub
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

        dtDate.Value = DateTime.Now : dtDateNeeded.Value = DateTime.Now
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


        If rfqStatus = "NEW" Then

            RadMessageBox.SetThemeName("VisualStudio2022Light")
            If RadMessageBox.Show("Are you sure want to upload the data?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then


                bInsert = insertRFQ.InsertRFQ(RFQNoCheck, dtDate.Value.ToString("yyyy-MM-dd"),
                                              Regex.Replace(Trim(txtName.Text), "\s+", " "), txtDept.Text, txtSection.Text, mcbCheckedBy.Text, mcbApprovedBy.Text,
                                              currentRowCheckedBy.Cells("fldJobTitle").Value.ToString, currentRowApprovedBy.Cells("fldJobTitle").Value.ToString)

                If bInsert Then

                    dt = selectExpense.selectLastCreatedRFQByDept(txtDept.Text, txtSection.Text)

                    If dt.Rows.Count > 0 Then
                        txtRFQNo.Text = Convert.ToString(dt.Rows(0).Item("RFQNo"))
                        txtID.Text = Convert.ToString(dt.Rows(0).Item("fldRFQNo"))
                    End If

                    bwSave.RunWorkerAsync()

                End If
            End If

        ElseIf rfqStatus = "EDIT" Then
            Dim bDelete As Boolean
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            If RadMessageBox.Show("Are you sure want to update the data?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If gvItems.Rows.Count > 0 Then
                    bDelete = deleteRfq.DeleteRFQChild(txtID.Text)

                    If bDelete Then
                        bwUpdate.RunWorkerAsync()
                    End If
                End If
                'bInsert = insertRFQ.UpdateRFQ(RFQNoCheck, dtDate.Value.ToString("yyyy-MM-dd"),
                '                              Regex.Replace(Trim(txtName.Text), "\s+", " "), txtDept.Text, txtSection.Text, mcbCheckedBy.Text, mcbApprovedBy.Text,
                '                              currentRowCheckedBy.Cells("fldJobTitle").Value.ToString, currentRowApprovedBy.Cells("fldJobTitle").Value.ToString)
                'If bInsert Then
                '    dt = selectExpense.selectLastCreatedRFQByDept(txtDept.Text, txtSection.Text)
                '    If dt.Rows.Count > 0 Then
                '        txtRFQNo.Text = Convert.ToString(dt.Rows(0).Item("RFQNo"))
                '        txtID.Text = Convert.ToString(dt.Rows(0).Item("fldRFQNo"))
                '    End If
                '    bwSave.RunWorkerAsync()
                'End If
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

            bInsert = insertRFQ.InsertRFQChild(txtID.Text, gvItems.Rows(x).Cells("fldTypeExpense").Value, gvItems.Rows(x).Cells("fldDesc").Value,
                                               gvItems.Rows(x).Cells("fldQTY").Value, gvItems.Rows(x).Cells("fldUOM").Value,
                                               Convert.ToDateTime(gvItems.Rows(x).Cells("fldDateNeeded").Value).ToString("yyyy-MM-dd"), gvItems.Rows(x).Cells("fldRemarks").Value,
                                               chemical, count, ppe)

            If bInsert Then
                lineStat = "OK"
            Else
                lineStat = "NG"
            End If

            Dim percent As Double = x / gvItems.Rows.Count * 100

            lineNo = x
            pbItems.Text = "Saving..."
            bwSave.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)
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
            gvItems.DataSource = Nothing
        End If
    End Sub

    Private Sub gvItems_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles gvItems.CellEndEdit
        If e.Column.HeaderText = "DELETE" Then
            gvItems.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvData.CellFormatting
        ' Ensure we are dealing with a data row and the correct column
        If e.Column IsNot Nothing AndAlso e.Column.Name = "ACTION" AndAlso TypeOf e.Row Is GridViewDataRowInfo Then
            ' Check if the buttons are already added
            If e.CellElement.Children.Count = 0 Then
                e.CellElement.Children.Clear()
                ' Create a panel to hold the buttons
                Dim panel As New StackLayoutElement()
                panel.Orientation = Orientation.Horizontal
                panel.StretchHorizontally = False
                panel.StretchVertically = False
                panel.FitToSizeMode = RadFitToSizeMode.FitToParentContent

                '' View Button
                'Dim viewBtn As New RadButtonElement()
                'viewBtn.DisplayStyle = DisplayStyle.Image
                'viewBtn.Image = IconChar.Eye.ToBitmap(Color.DarkBlue, 26)
                'AddHandler viewBtn.Click, Sub(s, args)
                '                              ViewFile()
                '                          End Sub

                ' Edit Button
                Dim editBtn As New RadButtonElement()
                editBtn.DisplayStyle = DisplayStyle.Image
                editBtn.Image = IconChar.Edit.ToBitmap(Color.DarkBlue, 26)
                AddHandler editBtn.Click, Sub(s, args)
                                              EditCustomerClaim()
                                          End Sub

                ' Delete Button
                Dim deleteBtn As New RadButtonElement()
                deleteBtn.DisplayStyle = DisplayStyle.Image
                deleteBtn.Image = IconChar.Trash.ToBitmap(Color.DarkRed, 26)
                AddHandler deleteBtn.Click, Sub(s, args)
                                                DeleteCustomerClaim()
                                            End Sub

                ' Add buttons to the panel
                panel.Children.Add(editBtn)
                panel.Children.Add(deleteBtn)

                ' Clear existing elements and add the panel
                e.CellElement.Children.Add(panel)
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
            End If
        End If
    End Sub

    Private Sub bwUpdate_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwUpdate.DoWork
        Dim delay As Integer = 20
        Dim bInsert As Boolean
        Dim chemical As String = "NO"
        Dim ppe As String = "NO"

        'Zaji.addParameter("RFQNo", txtID.Text)
        'Zaji.dbAED("SP_DeletRFQChildByRFQNo")
        Dim count = 0

        For x As Integer = 0 To gvItems.Rows.Count - 1
            count = count + 1

            'chemical = If(gvItems.Rows(x).Cells("fldChemical").Value = True, "YES", "NO")
            'ppe = If(gvItems.Rows(x).Cells("fldPPE").Value = True, "YES", "NO")

            Dim chemicalType = gvItems.Rows(x).Cells("fldChemical").Value

            If TypeOf chemicalType Is String Then
                If gvItems.Rows(x).Cells("fldChemical").Value.ToString = "YES" Then
                    chemical = "YES"
                ElseIf gvItems.Rows(x).Cells("fldChemical").Value.ToString = "NO" Then
                    chemical = "NO"
                End If
            ElseIf TypeOf chemicalType Is Boolean Then
                If gvItems.Rows(x).Cells("fldChemical").Value = True Then
                    chemical = "YES"
                ElseIf gvItems.Rows(x).Cells("fldChemical").Value = False Then
                    chemical = "NO"
                End If
            End If

            Dim ppeType = gvItems.Rows(x).Cells("fldPPE").Value

            If TypeOf ppeType Is String Then
                If gvItems.Rows(x).Cells("fldPPE").Value.ToString = "YES" Then
                    ppe = "YES"
                ElseIf gvItems.Rows(x).Cells("fldPPE").Value.ToString = "NO" Then
                    ppe = "NO"
                End If
            ElseIf TypeOf ppeType Is Boolean Then
                If gvItems.Rows(x).Cells("fldPPE").Value = True Then
                    ppe = "YES"
                ElseIf gvItems.Rows(x).Cells("fldPPE").Value = False Then
                    ppe = "NO"
                End If
            End If

            bInsert = insertRFQ.InsertRFQChild(txtID.Text, gvItems.Rows(x).Cells("fldTypeExpense").Value, gvItems.Rows(x).Cells("fldDesc").Value,
                                               gvItems.Rows(x).Cells("fldQTY").Value, gvItems.Rows(x).Cells("fldUOM").Value,
                                               Convert.ToDateTime(gvItems.Rows(x).Cells("fldDateNeeded").Value).ToString("yyyy-MM-dd"), gvItems.Rows(x).Cells("fldRemarks").Value,
                                               chemical, count, ppe)

            If bInsert Then
                lineStat = "OK"
            Else
                lineStat = "NG"
            End If

            Dim percent As Double = x / gvItems.Rows.Count * 100

            lineNo = x
            pbItems.Text = "Saving..."
            bwUpdate.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)
        Next
    End Sub

    Private Sub bwUpdate_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwUpdate.ProgressChanged
        gvItems.CurrentRow = gvItems.Rows(lineNo)
        gvItems.CurrentRow.Cells(0).Value = lineStat
        pbItems.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwUpdate_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwUpdate.RunWorkerCompleted
        pbItems.Value1 = 100
        pbItems.Text = "Done"
        RadMessageBox.SetThemeName("VisualStudio2022Light")
        If RadMessageBox.Show("Successfully Saved", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info) = DialogResult.OK Then
            pbItems.Text = String.Empty
            pbItems.Value1 = 0
            loadRFQList()
            gvItems.DataSource = Nothing
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearFields()

        rfqStatus = "NEW"

        If gvItems.Rows.Count > 0 Then
            gvItems.DataSource = Nothing
        End If
        btnCancel.Visible = False
    End Sub
End Class
