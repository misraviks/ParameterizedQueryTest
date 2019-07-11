using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedQueryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlParameterTest t = new SqlParameterTest();
            t.GetDataTable();
        }
    }
}
