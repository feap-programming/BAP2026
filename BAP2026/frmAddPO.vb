Public Class FrmAddPO




    Private _selectedDept As String



    Private Sub FrmAddPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Property SelectedDept As String
        Get
            Return _selectedDept
        End Get
        Set(value As String)
            _selectedDept = value
        End Set

    End Property


    Public Sub ND()

        If MEBTPO.Value <> 0 Then

            mebTotal.Value = MEBTPO.Value - mebPrice.Text

            mebDISC.Value = (mebPrice.Value / MEBTPO.Value) * 100


        End If

    End Sub

    Private Sub MEBTPO_TextChanged(sender As Object, e As EventArgs) Handles MEBTPO.TextChanged


        ND()


    End Sub

    Private Sub mebDISC_Leave(sender As Object, e As EventArgs) Handles mebDISC.Leave

        mebPrice.Text = ((MEBTPO.Text * mebDISC.Value) / 100)


    End Sub
End Class
