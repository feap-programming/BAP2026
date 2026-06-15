Imports System.ComponentModel
Imports Mysqlx.Resultset
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class frmCreateBudget


    Dim cselectMajorBudget As New cSelectAllMajorBudget

    Dim cgvmajorref As New cGvAllMajorRef

    Dim cDelete As New cDeleteMajorRef

    Public Property SelectedDept As String


    Private Sub btnAddRec_Click(sender As Object, e As EventArgs) Handles btnAddRec.Click


        Dim frm As New FrmAddMajorRec
        frm.SelectedDept = Me.SelectedDept   ' pass it forward
        AddHandler frm.RecordSaved, Sub() LoadMajorBudget() 'pass load grid view
        frm.Show()



    End Sub




    Private Sub cbbDeleteDocs_Click(sender As Object, e As EventArgs) Handles btnAddMajorRef.Click

        Dim frm As New FrmAddMajorRef
        frm.SelectedDept = Me.SelectedDept
        frm.Show()

    End Sub

    Private Sub LoadMajorBudget()

        Dim dt As DataTable = cselectMajorBudget.cSelectAllMajorBudget(GlobalVariables.SelectedDept)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            gvData.DataSource = dt
            leRecordsCounter.Text = dt.Rows.Count.ToString()
        Else
            gvData.DataSource = Nothing
            leRecordsCounter.Text = "0"
        End If

    End Sub

    Private Sub frmCreateBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadMajorBudget()

        cgvmajorref.DesignGrid(gvData)

        btnEditMajorRef.Text = "Edit Major Reference"

        cgvmajorref.DesignGrid(gvData)


        leAccess.Text = GlobalVariables.SelectedDept



        ' datagridtheme()


    End Sub




    Private Sub gvData_DoubleClick(sender As Object, e As EventArgs) Handles gvData.DoubleClick


    End Sub


    Private Sub btnDeleteMajorRef_Click(sender As Object, e As EventArgs) Handles btnDeleteMajorRef.Click


        If gvData.SelectedRows.Count = 0 Then
            RadMessageBox.SetThemeName("VisualStudioLight2022")
            RadMessageBox.Show("Please Select A Record To Delete.", "No Selection", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub
        End If

        RadMessageBox.SetThemeName("VisualStudio2022Light")
        Dim confirm As DialogResult = RadMessageBox.Show(
        "Are you sure you want to delete this record?",
        "Delete Confirmation",
        MessageBoxButtons.YesNo,
        RadMessageIcon.Question)

        If confirm = DialogResult.Yes Then
            Dim selectedRow As GridViewRowInfo = gvData.SelectedRows(0)
            Dim mid As Integer = CInt(selectedRow.Cells("fldMID").Value)

            Dim success As Boolean = cDelete.DeleteMajorRef(mid)

            If success Then
                RadMessageBox.SetThemeName("VisualStudioLight2022")
                RadMessageBox.Show("Record deleted successfully.", "SUCCESS", MessageBoxButtons.OK, RadMessageIcon.Info)
                LoadMajorBudget()
            Else
                RadMessageBox.SetThemeName("VisualStudioLight2022")
                RadMessageBox.Show("Failed to delete record.", "ERROR", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If
        End If

    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.CellFormatting

        'If e.Column.FieldName = "fldMajorRefNo" AndAlso e.Column.IsPinned Then
        '    e.CellElement.DrawFill = True
        '    e.CellElement.BackColor = Color.Wheat



        'Else
        '    e.CellElement.ResetValue(LightVisualElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local)
        '    e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)


        'End If


    End Sub

    Private Sub btnEditMajorRef_Click(sender As Object, e As EventArgs) Handles btnEditMajorRef.Click


        If gvData.SelectedRows.Count = 0 Then
            RadMessageBox.SetThemeName("VisualStudioLight2022")
            RadMessageBox.Show("Please Select A Record To Edit.", "No Selection", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub
        End If


        Dim selectedRow As GridViewRowInfo = gvData.SelectedRows(0)



        Dim frm As New FrmAddMajorRec
        frm.SelectedDept = Me.SelectedDept
        frm.IsEditMode = True
        frm.EditMID = CInt(selectedRow.Cells("fldMID").Value)
        frm.EditDesc1 = selectedRow.Cells("fldDesc1").Value?.ToString()
        frm.EditDesc2 = selectedRow.Cells("fldDesc2").Value?.ToString()
        frm.EditProcess = selectedRow.Cells("fldProcess").Value?.ToString()
        frm.EditProject = selectedRow.Cells("fldProject").Value?.ToString()
        frm.EditQuantity = selectedRow.Cells("fldQty").Value?.ToString()
        AddHandler frm.RecordSaved, Sub() LoadMajorBudget()
        frm.Show()


    End Sub





    'Private Sub gvData_ViewCellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.ViewCellFormatting

    '    If Not e.Row.IsSelected Then

    '        e.CellElement.DrawFill = True
    '        e.CellElement.BackColor = Color.LightBlue


    '    End If

    'End Sub


    'Public Sub datagridtheme()

    '    gvData.TableElement.BackColor = Color.LightBlue
    '    gvData.TableElement.DrawFill = True
    '    gvData.TableElement.AlternatingRowColor = Color.AliceBlue



    'End Sub


End Class

