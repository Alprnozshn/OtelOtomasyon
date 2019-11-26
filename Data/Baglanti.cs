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
            cmd = new SqlCommand(cmdtext, baglanti);
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            Ac();
            int sonuc = cmd.ExecuteNonQuery();
            return sonuc;
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
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

        public void Dispose()
        {
            baglanti.Dispose();
            cmd.Dispose();
        }
    }
}
