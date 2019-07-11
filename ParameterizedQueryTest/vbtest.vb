Module
Public Class vbtest


    Public Function getdata() As String
        getdata = <sql><![CDATA[ 
                SELECT TOP 1 id + id_1 AS 'Value'
                FROM testparam where id = @id and id_1 = @id
                ]]></sql>.Value
    End Function
End Class