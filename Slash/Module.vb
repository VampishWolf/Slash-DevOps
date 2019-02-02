Imports System.Data.SqlClient
Module Module1
    Friend connectionstring As String = Nothing
    Public reader As SqlDataReader = Nothing
    Public conn As SqlConnection = Nothing
    Public cmd As SqlCommand = Nothing
    Public sql As String = Nothing

    Public Sub executesqlstmt(ByVal sql As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        connectionstring = “Integrated Security=true;” + ” Initial Catalog = SlashDatabase;” + “ Data source=LAPTOP-370T4VBB;”
        conn.ConnectionString = connectionstring
        conn.Open()
    End Sub

End Module
