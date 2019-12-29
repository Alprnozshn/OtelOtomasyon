using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Data
{
   public class Baglanti:IDisposable
    {
       public SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
        SqlCommand cmd;
        public void Ac()
        {
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }
        }

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p)
        {
            try
            {
                cmd = new SqlCommand(cmdtext, baglanti);
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                Ac();
                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
        {
            try
            {
                cmd = new SqlCommand(cmdtext, baglanti);
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                Ac();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable GetDataTable(string selectcmdtext)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(selectcmdtext, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Dispose()
        {
            if (baglanti!=null)
            {
                baglanti.Dispose(); 
            }
            if (cmd!=null)
            {
                cmd.Dispose();
            }
        }
    }
}
