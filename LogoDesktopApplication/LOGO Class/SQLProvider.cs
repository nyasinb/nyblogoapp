using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoDesktopApplication.LOGO_Class
{
    public class SQLProvider
    {
        public static string ConnString = "Data Source =.; Initial Catalog = LOGODEMODB; Integrated Security = True; MultipleActiveResultSets=True";
        public static SqlConnection con;
        public static SqlCommand cmd;

        public string DataReadCardCodeControl(string query)
        {
            try
            {
                con = new SqlConnection(ConnString);
                con.Open();
                cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string sonuc = dr["CODE"].ToString();
                    return sonuc;
                }
                return "-1";
            }
            catch (Exception ex)
            {
                return "App hata :" + ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    con.Dispose();
                }
            }
        }
    }
}
