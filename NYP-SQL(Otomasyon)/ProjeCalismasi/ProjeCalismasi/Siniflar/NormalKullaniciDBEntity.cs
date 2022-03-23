using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeCalismasi.Siniflar
{
    public class NormalKullaniciDBEntity : DBEntity
    {
        public void Ekle(NormalKullanici normalKullanici)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Insert Into tblNormalKullanici (KullaniciAdi, Sifre, Eposta, AdSoyad, Adres, TelefonNo) values (@KullaniciAdi, @Sifre, @Eposta, @AdSoyad, @Adres, @TelefonNo)",con);
                cmd.Parameters.AddWithValue("KullaniciAdi", normalKullanici.KullaniciAdi);
                cmd.Parameters.AddWithValue("Sifre", normalKullanici.Sifre);
                cmd.Parameters.AddWithValue("AdSoyad", normalKullanici.AdSoyad);
                cmd.Parameters.AddWithValue("Eposta", normalKullanici.Eposta);
                cmd.Parameters.AddWithValue("Adres", normalKullanici.Adres);
                cmd.Parameters.AddWithValue("TelefonNo", normalKullanici.TelefonNo);
   
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void SonGirisZamaniDuzenle(NormalKullanici normalKullanici)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("UPDATE tblNormalKullanici SET SonGirisZamani=@SonGirisZamani WHERE KullaniciID=@KullaniciID", con);
                cmd.Parameters.AddWithValue("SonGirisZamani", normalKullanici.SonGirisZamani);
                cmd.Parameters.AddWithValue("KullaniciID", normalKullanici.KullaniciID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<NormalKullanici> Listele()
        {

            List<NormalKullanici> normalKullanici = new List<NormalKullanici>();

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select * From tblNormalKullanici", con);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new NormalKullanici
                            {
                                KullaniciID = Convert.ToInt32(reader[0].ToString()),
                                KullaniciAdi = reader[1].ToString(),
                                Sifre = reader[2].ToString(),
                                Eposta = reader[3].ToString(),
                                AdSoyad = reader[4].ToString(),
                                Adres = reader[5].ToString(),
                                TelefonNo = reader[6].ToString(),
                                SonGirisZamani = reader[7].ToString(),
                            };

                            normalKullanici.Add(entity);
                        }
                    }
                }

                return normalKullanici;
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
            SqlCommand cmd = new SqlCommand("SELECT KullaniciAdi, Sifre FROM tblNormalKullanici WHERE KullaniciAdi=@ad AND Sifre=@sifre", con);
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

        public bool girisYapmisKullaniciDogrulama()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SonGirisZamani FROM tblNormalKullanici ", con);
            
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
        public int soruSorKullaniciID(string ad)
        {
            int ID=0;

            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT KullaniciID FROM tblNormalKullanici WHERE KullaniciAdi=@ad", con);
            cmd.Parameters.AddWithValue("@ad", ad);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var entity = new NormalKullanici();
                        entity.KullaniciID = reader.GetInt32(0);

                        ID = entity.KullaniciID;
                    }
                }
            }
            return ID;
        }

    }
}
