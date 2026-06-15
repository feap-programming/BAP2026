Public Class cSelectItemCode


    Dim dbMain As New cSapDb

    Public Function selectitems() As DataTable
        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dt = dbMain.dbSelect("SELECT" _
            & "(case ItmsGrpCod WHEN '100' THEN 'Finished Goods' " _
            & "WHEN '101' THEN 'Work In Progress' " _
            & "WHEN '102' THEN 'Raw Materials' " _
            & "WHEN '103' THEN 'Spare Parts' " _
            & "WHEN '104' THEN 'Office Supplies' " _
            & "WHEN '105' THEN 'Packaging' " _
            & "WHEN '106' THEN 'Fabrication' " _
            & "WHEN '107' THEN 'Others' " _
            & "WHEN '108' THEN 'Supplies Others' " _
            & "WHEN '109' THEN 'FFC Manufacturing' " _
            & "WHEN '111' THEN 'BSS Manufacturing' " _
            & "End) AS 'Category', " _
            & "ItemCode, ItemName, BuyUnitMsr FROM OITM " _
            & "where " _
            & "(validTo IS NULL OR frozenFrom IS NULL) " _
            & "and ItmsGrpCod not in ('100','101','102')")
        Return dt
    End Function


End Class
