using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Kitaplik_Test
{
    internal class KitapDB
    {
        OleDbConnection baglanti=new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Karadag\Desktop\Kitaplikk.mdb");
        public List<kitap> Liste()
        {
            List<kitap> ktp=new List<kitap>();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar", baglanti);
            OleDbDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                kitap kp=new kitap();
                kp.ID = Convert.ToInt16(dr[0].ToString());
                kp.ADI = dr[1].ToString();
                kp.YAZAR = dr[2].ToString();

                ktp.Add(kp);
            }
            baglanti.Close();
            return ktp;
        }
        public void KitapEk(kitap kt)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into kitaplar (KitapAd,Yazar) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1",kt.ADI);
            komut.Parameters.AddWithValue("@p2", kt.YAZAR);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
        }
    }
}
