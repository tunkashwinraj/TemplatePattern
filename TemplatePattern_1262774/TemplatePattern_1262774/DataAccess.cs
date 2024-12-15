using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern_1262774
{
    class DataAccess
    {
        static string connStr = "server=DESKTOP-SBHVA7M\\SQLEXPRESS;integrated security=true;database=XYZDB_1262774";
        public static object GetSingleAnswer(string sql)
        {
            object res = null;
            
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                res = cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return res;
        }
        public static DataTable GetDataTable(string sql)
        {
            DataTable res = new DataTable();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(res);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return res;
        }
        public static int InsertOrUpdateOrDelete(string sql)
        {
            int res = 0;
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return res;
        }
    }
}
