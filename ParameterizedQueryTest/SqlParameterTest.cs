using System;
using System.Data;
using System.Data.SqlClient;


namespace ParameterizedQueryTest
{
    class SqlParameterTest
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter dataAdapter;
        String sql = "", ConnectionString = "Data Source=DEL1-LHP-N01186;Initial Catalog=frontlineed;User Id=sa;Password=Global@123;";
        DataTable dataTable = new DataTable();
        public SqlParameterTest()
        {
            conn = new SqlConnection(ConnectionString);
        }

        public int  GetDataTable()
        {
            try
            {
                
                conn.Open();
                sql = "<sql><![CDATA[ " +
                "SELECT TOP 1 id + id_1 AS 'Value'" +
                "FROM testparam where id = @id and id_1 = @id" +
                "]] ></sql>.Value";
                
                

                //sql = "Select id from testparam where id = @id and id_1 = @id";
                // dataAdapter = new SqlDataAdapter(sql, conn);
                // dataAdapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = 1;
                //dataAdapter.Fill(dataTable);
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", 1);
                int i = Convert.ToInt16(cmd.ExecuteScalar());
                return i;
            }
            catch (Exception ex)
            {

                throw;
            }
            return -1;
            
        }


    }
}
