using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeCalismasi.Siniflar
{
    public class RandevuDBEntity : DBEntity
    {
        public void RandevuEkle(Randevu randevu)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Insert Into tblRandevu (IsyeriID, RandevuTarihi, RandevuSaati, OnayDurum, RandevuAlanID) values (@IsyeriID, @RandevuTarihi, @RandevuSaati, @OnayDurum, @RandevuAlanID)", con);
                cmd.Parameters.AddWithValue("IsyeriID", randevu.IsyeriID);
                cmd.Parameters.AddWithValue("RandevuTarihi", randevu.RandevuTarihi);
                cmd.Parameters.AddWithValue("RandevuSaati", randevu.RandevuSaati);
                cmd.Parameters.AddWithValue("OnayDurum", randevu.OnayDurum);
                cmd.Parameters.AddWithValue("RandevuAlanID", randevu.RandevuAlanID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Randevu> IsyerineGelenRandevuListele(int IsyeriID)
        {

            List<Randevu> randevus = new List<Randevu>();

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select RandevuID, RandevuTarihi, RandevuSaati From tblRandevu WHERE IsyeriID="+ @IsyeriID+" AND OnayDurum="+2, con);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new Randevu();
                            entity.RandevuID = reader.GetInt32(0);
                            entity.RandevuTarihi = reader.GetString(1);
                            entity.RandevuSaati = reader.GetInt32(2);
                            

                            randevus.Add(entity);
                        }
                    }
                }

                return randevus;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Randevu> KullaniciOnaylananRandevuListele(int randevuAlanID)
        {

            List<Randevu> randevus = new List<Randevu>();

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select IsyeriID, RandevuTarihi, RandevuSaati From tblRandevu WHERE RandevuAlanID=" + @randevuAlanID+" AND OnayDurum="+1, con);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new Randevu();
                            entity.IsyeriID = reader.GetInt32(0);
                            entity.RandevuTarihi = reader.GetString(1);
                            entity.RandevuSaati = reader.GetInt32(2);


                            randevus.Add(entity);
                        }
                    }
                }

                return randevus;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Randevu> TumRandevulariListele(int IsyeriID)
        {

            List<Randevu> randevus = new List<Randevu>();

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select RandevuID, RandevuTarihi, RandevuSaati From tblRandevu WHERE IsyeriID=" + @IsyeriID, con);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new Randevu();
                            entity.RandevuID = reader.GetInt32(0);
                            entity.RandevuTarihi = reader.GetString(1);
                            entity.RandevuSaati = reader.GetInt32(2);


                            randevus.Add(entity);
                        }
                    }
                }

                return randevus;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    

    public void OnayDurumDuzenle(Randevu randevu)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("UPDATE tblRandevu SET OnayDurum=@OnayDurum WHERE RandevuId=@RandevuID", con);
                cmd.Parameters.AddWithValue("OnayDurum", randevu.OnayDurum);
                cmd.Parameters.AddWithValue("RandevuId", randevu.RandevuID);
            
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Randevu> RetEdilmisRandevulariListele(int IsyeriID)
        {

            List<Randevu> randevus = new List<Randevu>();

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select RandevuID, RandevuTarihi, RandevuSaati From tblRandevu WHERE IsyeriID=" + @IsyeriID + " AND OnayDurum=" + 0, con);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new Randevu();
                            entity.RandevuID = reader.GetInt32(0);
                            entity.RandevuTarihi = reader.GetString(1);
                            entity.RandevuSaati = reader.GetInt32(2);


                            randevus.Add(entity);
                        }
                    }
                }

                return randevus;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
