using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YurtKayıtSistemi
{
    public class Sqlbaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-69VK961\SQLEXPRESS;Database=YurtOtomasyonu;Trusted_connection=true");
            baglan.Open();
            return baglan;

        }
    }
}