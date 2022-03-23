using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeCalismasi.Siniflar
{
    public class RandevuyaKapaliTarihDBEntity : DBEntity
    {
        public void RandevuyaKapaliTarihEkle(RandevuyaKapaliTarih randevuyaKapaliTarih)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Insert Into tblRandevuyaKapaliTarih (IsyeriID, BaslangicSaat, BitisSaat, Gun) values (@IsyeriID, @BaslangicSaat, @BitisSaat, @Gun)", con);
                cmd.Parameters.AddWithValue("IsyeriID", randevuyaKapaliTarih.IsyeriID);
                cmd.Parameters.AddWithValue("BaslangicSaat", randevuyaKapaliTarih.BaslangicSaat);
                cmd.Parameters.AddWithValue("BitisSaat", randevuyaKapaliTarih.BitisSaat);
                cmd.Parameters.AddWithValue("Gun", randevuyaKapaliTarih.Gun);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool RandevuyaKapaliTarihKontrol(int isyeriID)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT KapaliTarihID FROM tblRandevuyaKapaliTarih WHERE IsyeriID=" + @isyeriID, con);
            cmd.Parameters.AddWithValue("@isyeriID", isyeriID);
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

        public int BaslangicSaatTut(int isyeriID)
        {
            int BaslangicSaat = 0;

            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT BaslangicSaat FROM tblRandevuyaKapaliTarih WHERE IsyeriID="+@isyeriID, con);
            cmd.Parameters.AddWithValue("@isyeriID", isyeriID);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var entity = new RandevuyaKapaliTarih();
                        entity.BaslangicSaat = reader.GetInt32(0);

                        BaslangicSaat = entity.BaslangicSaat;
                    }
                }
            }
            return BaslangicSaat;
        }

        public int BitisSaatTut(int isyeriID)
        {
            int BitisSaat = 0;

            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT BitisSaat FROM tblRandevuyaKapaliTarih WHERE IsyeriID=" + @isyeriID, con);
            cmd.Parameters.AddWithValue("@isyeriID", isyeriID);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var entity = new RandevuyaKapaliTarih();
                        entity.BitisSaat = reader.GetInt32(0);

                        BitisSaat = entity.BitisSaat;
                    }
                }
            }
            return BitisSaat;
        }

        public string GunTut(int isyeriID)
        {
            string Gun = "";

            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Gun FROM tblRandevuyaKapaliTarih WHERE IsyeriID=" + @isyeriID, con);
            cmd.Parameters.AddWithValue("@isyeriID", isyeriID);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var entity = new RandevuyaKapaliTarih();
                        entity.Gun = reader.GetString(0);

                        Gun = entity.Gun;
                    }
                }
            }
            return Gun;
        }
    }
}
