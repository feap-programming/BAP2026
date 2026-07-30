Public Class cGetPONO



    Dim dbSAP As New cSapDb

    Public Function SelectOPOR() As DataTable

        Dim dt As DataTable = Nothing

        Try

            dt = dbSAP.dbSelect(
                "SELECT DocNum, U_HeaderID " &
                "FROM OPOR " &
                "WHERE U_HeaderID IS NOT NULL"
            )

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


        Return dt

    End Function

End Class
