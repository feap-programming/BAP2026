Public Class cSelectMajorPR

    Dim dbMain As New cMainDb

    Public Function cSelectMajorPR() As DataTable

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()
        dt = dbMain.dbSelect("SP_SelectAllMajorPR")

        Return dt


    End Function

End Class
