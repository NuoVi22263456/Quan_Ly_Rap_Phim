using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class MovieByGenre_DAO
    {
        public static List<Genre_DTO> GetListGenreByMovieID(string id)
        {
            List<Genre_DTO> genreList = new List<Genre_DTO>();
            DataTable data = DataProvider.ExecuteQuery("EXEC USP_GetListGenreByMovie @idPhim", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Genre_DTO genre = new Genre_DTO(item);
                genreList.Add(genre);
            }
            return genreList;
        }

        public static void InsertMovie_Genre(string movieID, List<Genre_DTO> genreList)
        {
            foreach (Genre_DTO item in genreList)
            {
                string command = string.Format("INSERT dbo.PhanLoaiPhim (idPhim, idTheLoai) VALUES  ('{0}','{1}')", movieID, item.ID);
                DataProvider.ExecuteNonQuery(command);
            }
        }

        public static void UpdateMovie_Genre(string movieID, List<Genre_DTO> genreList)
        //Idea : Delete all rows that contain movieID, then re-add all genre that have been chosen from CheckedListBox to 'PhanLoaiPhim' with movieID
        {
            DataProvider.ExecuteNonQuery("DELETE dbo.PhanLoaiPhim WHERE idPhim = '" + movieID + "'");
            foreach (Genre_DTO item in genreList)
            {
                string command = string.Format("INSERT dbo.PhanLoaiPhim (idPhim, idTheLoai) VALUES  ('{0}','{1}')", movieID, item.ID);
                DataProvider.ExecuteNonQuery(command);
            }
        }

        public static void DeleteMovie_GenreByMovieID(string movieID)
        {
            DataProvider.ExecuteNonQuery("DELETE dbo.PhanLoaiPhim WHERE idPhim = '" + movieID + "'");
        }
    }
}
