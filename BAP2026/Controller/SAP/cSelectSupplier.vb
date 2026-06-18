Public Class cSelectSupplier

    Dim dbMain As New cSapDb


    Public Function selectSuppliers()

        Dim dt As DataTable
        GlobalVariables.myParamSAP.Clear()

        dt = dbMain.dbSelect("SELECT T0.[CardName], T0.CardCode, T0.Currency " _
                             & "FROM OCRD T0 WHERE T0.[CardType] = 'S' " _
                             & "ORDER BY T0.[CardName] ASC")

        Return dt



    End Function


End Class
