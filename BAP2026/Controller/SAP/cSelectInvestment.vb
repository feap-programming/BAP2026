Public Class cSelectInvestment

    Dim dbMain As New cMainDb

    Public Function SelectInvestment()

        Dim dt As DataTable


        GlobalVariables.myParam.Clear()


        dt = dbMain.dbSelect("SP_SelectInvestment")



        Return dt

    End Function

End Class


