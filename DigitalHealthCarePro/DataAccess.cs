using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DigitalHealthCarePro
{
    public class DataAccess
    {
        private static SqlConnection sqcon;

        public static SqlConnection Sqcon
        {
            get
            {
                if (sqcon == null)
                {
                    sqcon = new SqlConnection(@"Data Source=RAF-WORKSTATION\SQLEXPRESS;Initial Catalog=DHC;Integrated Security=True");
                }
                else if (sqcon.State != ConnectionState.Open)
                {
                    sqcon.Open();
                }
                return sqcon;
            }
        }

        public static DataSet GetDataSet(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public static DataTable GetDataTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        //this.Dt.Rows[this.Dt.Rows.Count - 1];
        public static DataRow GetLastRow(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1];
            }
            return null;
        }

        public static int ExecuteQuery(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqcon);
            return sqcom.ExecuteNonQuery();
        }

        //Dynamic country list
        public static List<string> GetCountry()
        {
            List<string> cultureList = new List<string>();
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.LCID);
                if (!(cultureList.Contains(region.EnglishName)))
                    cultureList.Add(region.EnglishName);
            }

            cultureList = cultureList.OrderBy(q => q).ToList();
            return cultureList;
        }
    }
}
