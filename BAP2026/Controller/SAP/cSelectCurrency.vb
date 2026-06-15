Public Class cSelectCurrency

    Dim dbMain As New cSapDb
    Public Function selectCurrency(ByVal currency As String) As DataTable


        Dim dt As DataTable

        GlobalVariables.myParam.Clear()
        dt = dbMain.dbSelect("SELECT Currency, Rate FROM ORTT WHERE CONVERT(DATE,RateDate) = CONVERT(DATE,GETDATE()) AND Currency = '" & currency & "';")

        Return dt

    End Function
End Class
