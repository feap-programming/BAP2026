Imports Google.Protobuf.Reflection
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmAddPO




    Private _selectedDept As String

    Dim cgetDeptCode As New cGetAllDeptCode

    Dim dtDeptCode As DataTable

    Dim getsuppliers As New cSelectSupplier

    Dim dtSupplier As DataTable

    Dim suppliergvUI As New cPOUI

    Dim gvListUI As New cPOUI

    Dim cCurrency As New cSelectCurrencyPO

    Dim dtCurrency As New DataTable

    Private Sub FrmAddPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadAllfunction()


    End Sub



    Public Function LoadAllfunction()

        getDeptCode()
        GetSupplier()


        'getSuppinfo()

        gvListUI.gvLIST(gvList)

        suppliergvUI.gvSupplier(gvSupplier)

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


        Dim currency As String = mebRate.Text


        Dim rate As Decimal = 0.0


        If currency = "JPY" OrElse String.IsNullOrEmpty(currency) Then

            rate = 0.0

        Else


            dtCurrency = cCurrency.selectCurrency(currency)

            If dtCurrency IsNot Nothing AndAlso dtCurrency.Rows.Count > 0 Then

                rate = Convert.ToDecimal(dtCurrency.Rows(0)("Rate"))

            Else

                RadMessageBox.Show("No Convertsion rate found for " _
                    & currency, "Warning", MessageBoxButtons.OK, RadMessageIcon.Info)
                rate = 0D

            End If
        End If

        'mebRate.Value = rate

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
End Class
