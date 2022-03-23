using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeCalismasi.Siniflar
{
    public class IsyeriYetkilisiDBEntity : DBEntity
    {
        public void Ekle(IsyeriYetkilisi isyeriYetkilisi)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Insert Into tblIsyeriYetkilisi (KullaniciAdi, Sifre, Eposta, AdSoyad, Adres, TelefonNo, DogumTarihi, TCKimlikNo) values (@KullaniciAdi, @Sifre, @Eposta, @AdSoyad, @Adres, @TelefonNo, @DogumTarihi, @TCKimlikNo)", con);
                cmd.Parameters.AddWithValue("KullaniciAdi", isyeriYetkilisi.KullaniciAdi);
                cmd.Parameters.AddWithValue("Sifre", isyeriYetkilisi.Sifre);
                cmd.Parameters.AddWithValue("AdSoyad", isyeriYetkilisi.AdSoyad);
                cmd.Parameters.AddWithValue("Eposta", isyeriYetkilisi.Eposta);
                cmd.Parameters.AddWithValue("Adres", isyeriYetkilisi.Adres);
                cmd.Parameters.AddWithValue("TelefonNo", isyeriYetkilisi.TelefonNo);
                cmd.Parameters.AddWithValue("DogumTarihi", isyeriYetkilisi.DogumTarihi);
                cmd.Parameters.AddWithValue("TCKimlikNo", isyeriYetkilisi.TCKimlikNo);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<IsyeriYetkilisi> Listele()
        {

            List<IsyeriYetkilisi> isyeriYetkilisis = new List<IsyeriYetkilisi>();

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select * From tblIsyeriYetkilisi", con);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new IsyeriYetkilisi();
                            entity.KullaniciID = reader.GetInt32(0);
                            entity.KullaniciAdi = reader.GetString(1);
                            entity.Sifre = reader.GetString(2);
                            entity.Eposta = reader.GetString(3);
                            entity.AdSoyad = reader.GetString(4);
                            entity.Adres = reader.GetString(5);
                            entity.TelefonNo = reader.GetString(6);
                            entity.DogumTarihi = reader.GetString(7);
                            entity.TCKimlikNo = reader.GetString(8);


                            isyeriYetkilisis.Add(entity);
                        }
                    }
                }

                return isyeriYetkilisis;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool girisDogrulama(string ad, string sifre)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT KullaniciAdi, Sifre FROM tblIsyeriYetkilisi WHERE KullaniciAdi=@ad AND Sifre=@sifre", con);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public int YetkiliIDTut(string ad)
        {
            int ID = 0;

            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT IsyeriYetkilisiID FROM tblIsyeriYetkilisi WHERE KullaniciAdi=@ad", con);
            cmd.Parameters.AddWithValue("@ad", ad);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var entity = new IsyeriYetkilisi();
                        entity.KullaniciID = reader.GetInt32(0);

                        ID = entity.KullaniciID;
                    }
                }
            }
            return ID;
        }

        
    }
}
