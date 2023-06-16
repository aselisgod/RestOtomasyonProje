using Restoran;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranDemo
{
    internal class cSiparis
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _AdisyonID;
        private int _UrunId;
        private int _Adet;
        private int _MasaId;
        #endregion

        #region Properties
        public int Id { get => _ID; set => _ID = value; }
        public int AdisyonID { get => _AdisyonID; set => _AdisyonID = value; }
        public int UrunId { get => _UrunId; set => _UrunId = value; }
        public int Adet { get => _Adet; set => _Adet = value; }
        public int MasaId { get => _MasaId; set => _MasaId = value; }
        #endregion

        public void getByOrder(ListView lv, int AdisyonId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select URUNAD, FIYAT, satislar.ID, satislar.URUNID, satislar.ADET from satislar INNER JOIN urunler ON Satislar.URUNID = urunler.ID WHERE ADISYONID = @AdisyonId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["FIYAT"]) * Convert.ToDecimal(dr["ADET"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());

                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }


        public bool setSaveOrder(cSiparis Bilgiler)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into satislar(ADISYONID,URUNID,ADET,MASAID) values(@AdisyonNo,@UrunId,@Adet,@MasaId)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdisyonNo", SqlDbType.Int).Value = Bilgiler._AdisyonID;
                cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = Bilgiler._UrunId;
                cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = Bilgiler._Adet;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = Bilgiler._MasaId;

                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return sonuc;
        }


        public void setDeleteOrder(int satisId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete From satislar Where ID=@SatisID", con);

            cmd.Parameters.Add("@SatisID", SqlDbType.Int).Value = satisId;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close(); 
        }

    }
}
