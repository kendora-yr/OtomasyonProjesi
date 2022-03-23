using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeCalismasi.Siniflar
{
    public class SoruCevapDBEntity : DBEntity
    {
        public void SoruEkle(SoruCevap soruCevap)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Insert Into tblSoruCevap (IsyeriID, SoranID, Soru, Durum) values (@IsyeriID, @SoranID, @Soru, @Durum)", con);
                cmd.Parameters.AddWithValue("IsyeriID", soruCevap.IsyeriID);
                cmd.Parameters.AddWithValue("SoranID", soruCevap.SoranID);
                cmd.Parameters.AddWithValue("Soru", soruCevap.Soru);
                cmd.Parameters.AddWithValue("Durum", soruCevap.Durum);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CevapEkle(SoruCevap soruCevap)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("UPDATE tblSoruCevap SET Cevap=@Cevap, CevapId=@CevapID, Durum=@Durum WHERE SoruCevapID=@SoruCevapID", con);
                cmd.Parameters.AddWithValue("Cevap", soruCevap.Cevap);
                cmd.Parameters.AddWithValue("CevapId", soruCevap.CevapID);
                cmd.Parameters.AddWithValue("SoruCevapID", soruCevap.SoruCevapID);
                cmd.Parameters.AddWithValue("Durum", soruCevap.Durum);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<SoruCevap> CevaplariListele(int soranID)
        {

            List<SoruCevap> soruCevaps = new List<SoruCevap>();

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select Soru, CevapId, Cevap From tblSoruCevap WHERE SoranId=" + @soranID + "AND Durum=" + 1, con);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new SoruCevap();
                            entity.Soru = reader.GetString(0);
                            entity.CevapID = reader.GetInt32(1);
                            entity.Cevap = reader.GetString(2);


                            soruCevaps.Add(entity);
                        }
                    }
                }

                return soruCevaps;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<SoruCevap> SorulariListele(int isyeriID)
        {

            List<SoruCevap> soruCevaps = new List<SoruCevap>();

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select SoruCevapID, Soru From tblSoruCevap WHERE IsyeriId= " + @isyeriID + " AND Durum=" + 0, con);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new SoruCevap();
                            entity.SoruCevapID = reader.GetInt32(0);
                            entity.Soru = reader.GetString(1);

                            soruCevaps.Add(entity);
                        }
                    }
                }

                return soruCevaps;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<SoruCevap> TumSorulariListele(int isyeriID)
        {

            List<SoruCevap> soruCevaps = new List<SoruCevap>();

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select SoruCevapID, Soru From tblSoruCevap WHERE IsyeriId= " + @isyeriID, con);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new SoruCevap();
                            entity.SoruCevapID = reader.GetInt32(0);
                            entity.Soru = reader.GetString(1);

                            soruCevaps.Add(entity);
                        }
                    }
                }

                return soruCevaps;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
