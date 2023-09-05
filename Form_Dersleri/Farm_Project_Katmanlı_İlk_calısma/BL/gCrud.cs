using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BL
{
    public class gCrud
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("genList", Tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt=new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Add(generation generation)
        {
            SqlCommand sqlCommand = new SqlCommand("genAdd", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@generationName", generation.generationName);
            sqlCommand.Parameters.AddWithValue("@generationYear", generation.generationYear);
            sqlCommand.Parameters.AddWithValue("@generationSeason", generation.generationSeason);
            sqlCommand.Parameters.AddWithValue("@generationPrice", generation.generationPrice);
            sqlCommand.Parameters.AddWithValue("@generationCity", generation.generationCity);
            sqlCommand.Parameters.AddWithValue("@companyID", generation.companyID);
            return Tools.ConnectSet(sqlCommand);
        }
        public static bool Update(generation generation)
        {
            SqlCommand sqlCommand = new SqlCommand("genUpdate", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@generationID", generation.generationID);
            sqlCommand.Parameters.AddWithValue("@generationName", generation.generationName);
            sqlCommand.Parameters.AddWithValue("@generationYear", generation.generationYear);
            sqlCommand.Parameters.AddWithValue("@generationSeason", generation.generationSeason);
            sqlCommand.Parameters.AddWithValue("@generationPrice", generation.generationPrice);
            sqlCommand.Parameters.AddWithValue("@generationCity", generation.generationCity);
            sqlCommand.Parameters.AddWithValue("@companyID", generation.companyID);
            return Tools.ConnectSet(sqlCommand);
        }
        public static bool Delete(generation generation)
        {
            SqlCommand sqlCommand = new SqlCommand("genDelete", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@generationID", generation.generationID);
            return Tools.ConnectSet(sqlCommand);
        }
    }
}
