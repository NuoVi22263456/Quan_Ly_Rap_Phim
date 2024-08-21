using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Revenue_DAO
    {
        public static DataTable GetRevenue(string idMovie, DateTime fromDate, DateTime toDate)
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetRevenueByMovieAndDate @idMovie , @fromDate , @toDate", new object[] { idMovie, fromDate, toDate });
        }
    }
}
