using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _12MStokEkstresi
{
    public class SqlBaglanti
    {

        public List<STI> GetAll(string mal_kodu, int bas_tarih, int bit_tarih)
        {
            string connectionString = "server=DESKTOP-MO5HLC4;Database=Test;trusted_connection=true;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                connection.Open();

                SqlCommand command = new SqlCommand("Deneme", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("mal_kodu", mal_kodu);
                command.Parameters.AddWithValue("bas_tarih", bas_tarih);
                command.Parameters.AddWithValue("bit_tarih", bit_tarih);
                List<STI> stoklar = new List<STI>();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    stoklar.Add(new STI
                    {
                        SiraNumarasi = Convert.ToInt32(dataReader[0]),
                        IslemTuru = dataReader[1].ToString(),
                        EvrakNumarasi = dataReader[2].ToString(),
                        Tarihi = dataReader[3].ToString(),
                        GirisAdedi = Convert.ToInt32(dataReader[4]),
                        CikisAdedi = Convert.ToInt32(dataReader[5]),
                        StokAdedi = Convert.ToInt32(dataReader[6])
                    }
                    );


                }

                connection.Close();
                connection.Dispose();
                return stoklar;
            }
        }
    }
}
