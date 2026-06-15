Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmConversion

    Dim dbMain As New cMainDb

    Dim cAddConversion As New cAddConversion



    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click

        '  Check selection FIRST
        If RadDropDownList1.SelectedItem Is Nothing Then
            RadMessageBox.SetThemeName("VisualStudioLight2022")
            MessageBox.Show("Please select a currency.")
            Return
        End If

        Dim currency As String = ""

        If RadDropDownList1.SelectedValue IsNot Nothing Then
            currency = RadDropDownList1.SelectedValue.ToString()
        Else
            currency = RadDropDownList1.SelectedItem.Text
        End If


        Dim conversion As Decimal
        If Not Decimal.TryParse(ccAmt.Text, conversion) Then
            RadMessageBox.SetThemeName("VisualStudioLight2022")
            MessageBox.Show("Invalid conversion value.")
            Return
        End If

        '  Insert
        Dim result As Boolean = cAddConversion.insertConversion(currency, conversion)

        If result Then
            RadMessageBox.SetThemeName("VisualStudioLight2022")
            MessageBox.Show("Conversion inserted successfully.")
            Me.Close()
        Else
            RadMessageBox.SetThemeName("VisualStudioLight2022")
            MessageBox.Show("Insert failed.")
        End If

    End Sub

    Private Sub FrmConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ccAmt.EnableNullValueInput = True
        ccAmt.NullableValue = Nothing
        ccAmt.SpinElement.TextBoxItem.NullText = "0.00"

    End Sub

    Private Sub ccAmt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ccAmt_ValueChanged(sender As Object, e As EventArgs) Handles ccAmt.ValueChanged

    End Sub


End Class
