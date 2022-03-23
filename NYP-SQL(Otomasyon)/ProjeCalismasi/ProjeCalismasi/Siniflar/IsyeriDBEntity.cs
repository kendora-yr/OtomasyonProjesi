using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeCalismasi.Siniflar
{
    public class IsyeriDBEntity : DBEntity
    {
        public void Ekle(Isyeri isyeri)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Insert Into tblIsyeri(Isim,IsyeriTur,Adres,Telefon)values(@Isim,@IsyeriTur,@Adres,@Telefon)", con);
                cmd.Parameters.AddWithValue("Isim", isyeri.Isim);
                cmd.Parameters.AddWithValue("IsyeriTur", isyeri.IsyeriTur);
                cmd.Parameters.AddWithValue("Adres", isyeri.Adres);
                cmd.Parameters.AddWithValue("Telefon", isyeri.Telefon);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IsyeriYetkilisiniEkle(int isyeriYetkilisiID, int isyeriID)
        {

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("UPDATE tblIsyeri SET IsyeriYetkilisiID=" + @isyeriYetkilisiID + " WHERE IsyeriID=" + @isyeriID, con);
                cmd.Parameters.AddWithValue("IsyeriYetkilisiID", isyeriYetkilisiID);
                cmd.Parameters.AddWithValue("IsyeriID", isyeriID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int YetkilinIsyeriIDTut(string ad)
        {
            int ID = 0;

            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT tblIsyeri.IsyeriID FROM tblIsyeri INNER JOIN tblIsyeriYetkilisi ON tblIsyeri.IsyeriYetkilisiID = tblIsyeriYetkilisi.IsyeriYetkilisiID WHERE tblIsyeriYetkilisi.KullaniciAdi=@ad", con);
            cmd.Parameters.AddWithValue("@ad", ad);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var entity = new Isyeri();
                        entity.IsyeriID = reader.GetInt32(0);

                        ID = entity.IsyeriID;
                    }
                }
            }
            return ID;
        }

        public bool IsyeriYetkilisiDogrulama(int id)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT IsyeriYetkilisiID FROM tblIsyeri WHERE IsyeriYetkilisiID=" + @id, con);
            cmd.Parameters.AddWithValue("@id", id);
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

        public List<Isyeri> Listele(string aranan)
        {
            if (aranan != "")
            {
                aranan = "where " + aranan;
            }
            List<Isyeri> isyeri = new List<Isyeri>();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select * From tblIsyeri " + aranan, con);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new Isyeri
                            {
                                IsyeriID = Convert.ToInt32(reader[0].ToString()),
                                Isim = reader[1].ToString(),
                                IsyeriTur = reader[2].ToString(),
                                Adres = reader[3].ToString(),
                                Telefon = reader[4].ToString(),
                            };
                            isyeri.Add(entity);
                        }
                    }

                }
                return isyeri;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Sil(Isyeri isyeri)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Delete From tblIsyeri Where IsyeriID=" + isyeri.IsyeriID + "", con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void KayitGuncelleme(Isyeri isyeri)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Update tblIsyeri Set Isim=@ad,IsyeriTur=@tur,Adres=@adres,Telefon=@tel Where IsyeriID=@ID", con);
                cmd.Parameters.AddWithValue("@ad", isyeri.Isim);
                cmd.Parameters.AddWithValue("@tur", isyeri.IsyeriTur);
                cmd.Parameters.AddWithValue("@adres", isyeri.Adres);
                cmd.Parameters.AddWithValue("@tel", isyeri.Telefon);
                cmd.Parameters.AddWithValue("@ID", isyeri.IsyeriID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}