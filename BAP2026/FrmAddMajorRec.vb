Imports System.Windows
Imports Mysqlx.Crud
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmAddMajorRec


    'API 4 MOVING FORM
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function


    Dim cselectdesc As New cSelectAllDesc
    Dim cselectMajorRef As New cSelectMajorRefByClass
    Dim cselectallclassdesc As New cSelectAllDesc
    Dim cgenerateSubRefNo As New cGenerateSubRefNo
    Dim cinsertrec As New cInsertAddRec

    Dim frmconversion As New FrmConversion

    Dim generateCurrrency As New cGenerateConversion

    Dim updateMajorBudget As New cUpdateMajorBudget

    Private _rateToJPY As Decimal = 1D

    Private _selectedCurrency As String = ""

    'Call grid
    Public Event RecordSaved()

    Private _selectedDept As String
    Public Property SelectedDept As String
        Get
            Return _selectedDept
        End Get
        Set(value As String)
            _selectedDept = value
            UpdateConversionVisibility()
        End Set
    End Property

    Private Sub UpdateConversionVisibility()
        If _selectedDept IsNot Nothing AndAlso _selectedDept.ToLower() = "acctg" Then
            lblAddConversion.Visible = True
        Else
            lblAddConversion.Visible = False
        End If
    End Sub


    Public Property IsEditMode As Boolean = False
    Public Property EditCurrency As String
    Public Property EditQuantity As String
    Public Property EditPrice As String
    Public Property EditDesc1 As String
    Public Property EditDesc2 As String
    Public Property EditProcess As String
    Public Property EditProject As String

    Public Property EditMID As Integer
    Public Property EditMajorRefNo As String


    Private Sub FrmAddRec_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        tbDept.Text = GlobalVariables.SelectedDept

        _selectedDept = GlobalVariables.SelectedDept


        LoadClassDesc()
        LoadCurrencies()

        ClearFields()

        If IsEditMode Then
            If Not String.IsNullOrEmpty(EditProcess) Then ddProccess.SelectedValue = EditProcess
            If Not String.IsNullOrEmpty(EditProject) Then ddProject.SelectedValue = EditProject
        End If

        UpdateConversionVisibility()


        If IsEditMode() Then

            EditMode()

        End If



    End Sub

    Private Sub EditMode()


        ddCurrency.SelectedValue = EditCurrency
        rsQty.Value = If(EditQuantity <> "", CDec(EditQuantity), 0)
        rsPrice.Value = If(EditPrice <> "", CDec(EditPrice), 0)
        tbDesc1.Text = EditDesc1
        tbDesc2.Text = EditDesc2

        'UNABLE

        ddClass.Enabled = False
        ddRefNo.Enabled = False
        tbSubRefNo.Enabled = False
        tbDept.Enabled = False
        RadDateTimePicker1.Enabled = False
        ddProccess.Enabled = False
        ddProject.Enabled = False
        rsPrice.Enabled = False

        'ENABLE
        ddCurrency.Enabled = True
        rsQty.Enabled = True
        tbDesc1.Enabled = True
        tbDesc2.Enabled = True
        btnSave.Enabled = True

        lblAddConversion.Hide()



    End Sub



    Private Sub LoadCurrencies()


        ddCurrency.Items.Clear()

        ddCurrency.Items.Add("PHP")
        ddCurrency.Items.Add("JPY")
        ddCurrency.Items.Add("USD")


        'ddCurrency.Items.Add("PHP-USD")
        'ddCurrency.Items.Add("PHP-JPY")
        'ddCurrency.Items.Add("USD-PHP")
        'ddCurrency.Items.Add("USD-JPY")
        'ddCurrency.Items.Add("JPY-PHP")
        'ddCurrency.Items.Add("JPY-USD") 

    End Sub


    Private Sub ClearFields()

        rsPrice.EnableNullValueInput = True
        rsPrice.NullableValue = Nothing
        rsPrice.SpinElement.TextBoxItem.NullText = "0.00"

        rsQty.EnableNullValueInput = True
        rsQty.NullableValue = Nothing
        rsQty.SpinElement.TextBoxItem.NullText = "0.00"

        rsTotalAmt.EnableNullValueInput = True
        rsTotalAmt.NullableValue = Nothing
        rsTotalAmt.SpinElement.TextBoxItem.NullText = "0.00"


        rsTotalJPY.EnableNullValueInput = True
        rsTotalAmt.NullableValue = Nothing
        rsTotalAmt.SpinElement.TextBoxItem.NullText = "0.00"



        tbDesc1.Text = ""
        tbDesc2.Text = ""

        ddProject.SelectedIndex = -1
        ddProccess.SelectedIndex = -1




    End Sub


    Private Sub rsCurrency_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddCurrency.SelectedIndexChanged

        If ddCurrency.SelectedItem Is Nothing Then Exit Sub

        _selectedCurrency = ddCurrency.SelectedItem.Text  ' Store selected currency

        Dim rate As Decimal = generateCurrrency.GetLatestRate(_selectedCurrency)

        If rate <= 0 Then
            '   MessageBox.Show("No conversion rate found for " & _selectedCurrency)'
            _rateToJPY = 1D
        Else
            _rateToJPY = rate
        End If

        RecalcTotals()

    End Sub


    Private Sub rsQty_ValueChanged(sender As Object, e As EventArgs) _
            Handles rsQty.ValueChanged
        RecalcTotals()
    End Sub

    Private Sub rsPrice_ValueChanged(sender As Object, e As EventArgs) _
            Handles rsPrice.ValueChanged
        RecalcTotals()
    End Sub

    Private Sub RecalcTotals()
        If ddCurrency.SelectedItem Is Nothing Then Exit Sub

        Dim qty As Decimal = rsQty.Value
        Dim price As Decimal = rsPrice.Value

        ' 
        Dim priceInPHP As Decimal

        Select Case _selectedCurrency
            Case "USD"
                '
                Dim rateUSDPHP As Decimal = generateCurrrency.GetLatestRate("USD-PHP")
                priceInPHP = price * rateUSDPHP

            Case "JPY"

                Dim rateJPYPHP As Decimal = generateCurrrency.GetLatestRate("JPY-PHP")
                priceInPHP = price * rateJPYPHP

            Case Else
                ' PHP-USD or PHP-JPY, price is already PHP
                priceInPHP = price

        End Select

        Dim totalamount As Decimal = qty * priceInPHP
        rsTotalAmt.Value = Math.Round(totalamount, 2)

        ' JPY conversion
        Dim totaljpy As Decimal

        Select Case _selectedCurrency.Split("-")(0).ToUpper()
            Case "JPY"
                totaljpy = qty * price  ' already JPY
            Case "PHP"
                Dim ratePHPJPY As Decimal = generateCurrrency.GetLatestRate("PHP-JPY")
                totaljpy = qty * price '* ratePHPJPY'
            Case "USD"
                Dim rateUSDJPY As Decimal = generateCurrrency.GetLatestRate("USD-JPY")
                totaljpy = qty * price '* rateUSDJPY'
        End Select

        rsTotalJPY.Value = Math.Round(totaljpy, 2)

    End Sub

    Private Sub LoadMajorRef(classCode As String, dept As String)
        Dim dt As DataTable = cselectMajorRef.cSelectMajorRef(classCode, dept)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            With ddRefNo
                .DataSource = dt
                .ValueMember = "fldMajorRefNo"
                .DisplayMember = "fldMajorRefNo"
            End With
        Else
            ddRefNo.DataSource = Nothing
        End If
    End Sub

    Private Sub LoadClassDesc()
        Dim dt As DataTable = cselectallclassdesc.SelectAllClassDesc()
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            With ddClass
                .DataSource = dt
                .ValueMember = "fldClassCode"
                .DisplayMember = "fldClassDesc"
            End With
        Else
            MessageBox.Show("No class data found.")
        End If
    End Sub

    Private Sub ddClass_SelectedIndexChanged(sender As Object,
            e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) _
            Handles ddClass.SelectedIndexChanged
        If ddClass.SelectedItem IsNot Nothing Then
            Dim selectedRow As DataRowView = CType(ddClass.SelectedItem.DataBoundItem, DataRowView)
            Dim classCode As String = selectedRow("fldClassCode").ToString()
            LoadMajorRef(classCode, SelectedDept)
        End If
    End Sub

    Private Sub ddRefNo_SelectedIndexChanged(sender As Object,
            e As UI.Data.PositionChangedEventArgs) _
            Handles ddRefNo.SelectedIndexChanged
        If ddRefNo.SelectedItem IsNot Nothing Then
            Dim selectedRow As DataRowView = CType(ddRefNo.SelectedItem.DataBoundItem, DataRowView)
            Dim majorrefno As String = selectedRow("fldMajorRefNo").ToString()
            Dim subrefno As String = cgenerateSubRefNo.GenerateSubRefNo(majorrefno)
            tbSubRefNo.Text = subrefno
        End If
    End Sub


    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'UPDATE' 

        If IsEditMode Then
            Dim success As Boolean = updateMajorBudget.UpdateMajorBudget(
             p_MID:=EditMID,
            p_Desc1:=tbDesc1.Text.Trim(),
            p_Desc2:=tbDesc2.Text.Trim(),
            p_Project:=ddProject.SelectedValue?.ToString(),
            p_Process:=ddProccess.SelectedValue?.ToString(),
            p_Qty:=CInt(rsQty.Value)
    )

            If success Then
                RadMessageBox.Show("Record Updated!", "SUCCESS", MessageBoxButtons.OK, RadMessageIcon.Info)
                RaiseEvent RecordSaved()
                Me.Close()
            Else
                RadMessageBox.Show("Update Failed", "ERROR", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If

            Exit Sub




        End If


        If ddRefNo.SelectedItem Is Nothing Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("Please select a Major Reference No.", " Error")
            Exit Sub
        End If


        If String.IsNullOrWhiteSpace(tbDesc1.Text) OrElse String.IsNullOrWhiteSpace(tbDesc2.Text) Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("Item Description is required.", "Error")

            ' Focus on the first empty field
            If String.IsNullOrWhiteSpace(tbDesc1.Text) Then
                tbDesc1.Focus()
            Else
                tbDesc2.Focus()
            End If

            Exit Sub
        End If


        If ddCurrency.SelectedItem Is Nothing Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("", "Error")
            Exit Sub
        End If

        If rsPrice.Value <= 0 Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("Unit Price must be greater than 0.", "Error")
            rsPrice.Focus()
            Exit Sub
        End If


        If rsQty.Value <= 0 Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("Quantity must be greater than 0.", "Error")
            rsQty.Focus()
            Exit Sub
        End If

        If ddProccess.SelectedItem Is Nothing Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("Select Process", "Error")
        End If

        If ddProject.SelectedItem Is Nothing Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("Select Project.", "Error")
            Exit Sub
        End If


        'INSERT'
        Dim majorrefNo As String = CType(ddRefNo.SelectedItem.DataBoundItem, DataRowView)("fldMajorRefNo").ToString()
        Dim subrefNo As String = tbSubRefNo.Text.Trim()
        Dim desc1 As String = tbDesc1.Text.Trim()
        Dim desc2 As String = tbDesc2.Text.Trim()
        Dim process As String = ddProccess.Text.Trim()
        Dim dept As String = SelectedDept
        Dim project As String = ddProject.Text.Trim()
        Dim monthBudget As Date = RadDateTimePicker1.Value

        ' New fields
        Dim qty As Integer = CInt(rsQty.Value)
        Dim jpyAmount As Decimal = rsTotalJPY.Value
        Dim totalAmount As Decimal = rsTotalAmt.Value



        Dim result As Boolean = cinsertrec.InsertRec(
            majorrefNo, subrefNo, desc1, desc2, process, dept, project, monthBudget,
            jpyAmount, totalAmount, qty)

        If result Then
            MessageBox.Show("Record inserted successfully.")
            RaiseEvent RecordSaved()
            Dim Newsubref As String = cgenerateSubRefNo.GenerateSubRefNo(majorrefNo)
            ClearFields()

            tbSubRefNo.Text = Newsubref
            ' Reset quantity and price
            rsQty.Value = 0
            rsPrice.Value = 0
        Else
            MessageBox.Show("Failed to insert record.")


        End If
    End Sub





    Private Sub lblAddConversion_Click(sender As Object, e As EventArgs) Handles lblAddConversion.Click
        frmconversion.ShowDialog()
    End Sub

    Private Sub RadButton1_Click_1(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Close()
    End Sub

    Private Sub FrmAddRec_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown


        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If

    End Sub

    Private Sub RadPanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles RadPanel1.MouseDown

        If e.Button = MouseButtons.Left Then
            ReleaseCapture()

            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)

        End If



    End Sub


End Class