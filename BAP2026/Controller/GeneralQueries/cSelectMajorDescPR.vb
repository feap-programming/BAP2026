Public Class cSelectMajorDescPR

    Dim dbmain As New cMainDb
    Public Function selectMajorDescPR() As DataTable

        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dt = dbmain.dbSelect("SP_SelectMajorDescription")

        Return dt

    End Function


End Class
