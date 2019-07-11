Imports System.Data.SqlClient

Module Module1

    Sub Main()
        Dim Sql As String = "", ConnectionString As String = "Data Source=DEL1-LHP-N01186;Initial Catalog=frontlineed;User Id=sa;Password=Global@123;"
        Dim cmd As New SqlCommand()
        Dim conn As New SqlConnection(ConnectionString)
        Dim dataAdapter As New SqlDataAdapter
        Dim dataTable As New DataTable
        conn.Open()
        Sql = <sql><![CDATA[  
                SELECT TOP 1 id + id_1 AS 'Value'
                FROM testparam where id = @idVal and id_1 = @idVal
                ]]></sql>.Value
        cmd = New SqlCommand(Sql, conn)
        cmd.Parameters.AddWithValue("@idVal", 1)
        cmd.Parameters.AddWithValue("@Idval", 1)
        Dim i As Integer = cmd.ExecuteScalar()
    End Sub

End Module
