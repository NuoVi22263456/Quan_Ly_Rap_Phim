using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ScreenType_DAO
    {
        public static List<ScreenType_DTO> GetListScreenType()
        {
            List<ScreenType_DTO> screenTypeList = new List<ScreenType_DTO>();
            DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.LoaiManHinh");
            foreach (DataRow item in data.Rows)
            {
                ScreenType_DTO screenType = new ScreenType_DTO(item);
                screenTypeList.Add(screenType);
            }
            return screenTypeList;
        }

        public static DataTable GetScreenType()
        {
            return DataProvider.ExecuteQuery("SELECT id AS [Mã loại màn hình], TenMH as [Tên màn hình] FROM dbo.LoaiManHinh");
        }

        public static DataTable GetScreenTypeByFormatFilm(string screenTypeID)
        {
            return DataProvider.ExecuteQuery("SELECT *  FROM dbo.LoaiManHinh where id = '" + screenTypeID + "'");
        }

        public static bool InsertScreenType(string id, string name)
        {
            int result = DataProvider.ExecuteNonQuery("EXEC USP_InsertScreenType @idScreenType , @ten", new object[] { id, name });
            return result > 0;
        }

        public static bool UpdateScreenType(string id, string name)
        {
            string command = string.Format("UPDATE dbo.LoaiManHinh SET TenMH = N'{0}' WHERE id = '{1}'", name, id);
            int result = DataProvider.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteScreenType(string id)
        {
            DataProvider.ExecuteNonQuery("DELETE dbo.PhongChieu WHERE idManHinh = '" + id + "'");
            DataProvider.ExecuteNonQuery("DELETE dbo.DinhDangPhim WHERE idLoaiManHinh = '" + id + "'");

            int result = DataProvider.ExecuteNonQuery("DELETE dbo.LoaiManHinh WHERE id = '" + id + "'");
            return result > 0;
        }

        public static ScreenType_DTO GetScreenTypeByName(string screenName)
        {
            ScreenType_DTO screenType = null;
            DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.LoaiManHinh WHERE TenMH = N'" + screenName + "'");
            foreach (DataRow item in data.Rows)
            {
                screenType = new ScreenType_DTO(item);
                return screenType;
            }
            return screenType;
        }
    }
}
