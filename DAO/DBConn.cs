using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class DBConn
    {
        protected SqlConnection _conn = new SqlConnection("Data Source = LAPTOP-QP22JGJN; Initial Catalog = QLRP1; Integrated Security = True");
        public string connectionSTR => connectionSTR;
    }
}
