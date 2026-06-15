

Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmAddMajorRef


    Dim cselectdesc As New cSelectAllDesc

    Dim cselectyear As New cSelectYear

    Dim cinsertmajorref As New cInsertMajorRef

    Dim cselectallclassdesc As New cSelectAllDesc

    Public Property SelectedDept As String



    Private selectedClassCode As String = String.Empty



    Private Sub LoadClassDesc()

        Dim dt As DataTable = cselectallclassdesc.SelectAllClassDesc()

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            With RadDropDownList1
                .DataSource = dt
                .ValueMember = "fldClassCode"
                .DisplayMember = "fldClassDesc"
            End With
        Else
            MessageBox.Show("No class data found.")
        End If
    End Sub

    Private Sub FrmAddMajorRef_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadClassDesc()
        LoadOpenYear()

        tbDept.Text = GlobalVariables.SelectedDept

        If RadDropDownList1.Items.Count > 0 Then
            RadDropDownList1.SelectedIndex = 0
        End If

        GenerateMajorRefCode()



    End Sub

    Private Sub LoadOpenYear()
        Dim year As String = cselectyear.SelectOpenYear()
        If year <> String.Empty Then
            txtYear.Text = year
        Else
            MessageBox.Show("No open year found.")
        End If
    End Sub



    Private Sub GenerateMajorRefCode()
        Dim year As String = txtYear.Text.Trim()
        Dim dept As String = tbDept.Text.Trim()
        Dim classCode As String = ""
        Dim classdesc As String = ""

        If RadDropDownList1.SelectedItem IsNot Nothing Then
            Dim datarv As DataRowView = CType(RadDropDownList1.SelectedItem.DataBoundItem, DataRowView)
            classCode = datarv("fldClassCode").ToString()
            classdesc = datarv("fldClassDesc").ToString()
        End If

        If year <> "" AndAlso classCode <> "" AndAlso dept <> "" Then
            tbMajorRefNo.Text = $"{dept}-{year}-{classCode}"
        Else
            tbMajorRefNo.Text = ""
        End If
    End Sub



    Private Sub RadDropDownList1_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles RadDropDownList1.SelectedIndexChanged
        GenerateMajorRefCode()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If RadDropDownList1.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select Class Description")
        End If

        Dim classcode As String = ""


        Dim datarv As DataRowView = CType(RadDropDownList1.SelectedItem.DataBoundItem, DataRowView)
        classcode = datarv("fldClassCode").ToString()

        Dim result As Boolean = cinsertmajorref.InsertMajorRef(
        txtYear.Text.Trim(),
        classcode,
        tbDept.Text.Trim(),
        GlobalVariables.empNo)

        If result Then
            RadMessageBox.Show("Major Reference added successfully.")
            RadMessageBox.SetThemeName("VisualStudio2022LightTheme")
            Me.Close()
        Else
            RadMessageBox.Show("Failed to add Major Reference.")
            RadMessageBox.SetThemeName("VisualStudio2022LightTheme")
        End If
    End Sub
End Class
