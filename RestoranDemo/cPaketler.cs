using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Restoran;

namespace RestoranDemo
{
    internal class cPaketler
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _AdditionID;
        private int _ClientId;
        private string _Description;
        private int _State;
        private int _Paytypeid;
        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int AdditionID { get => _AdditionID; set => _AdditionID = value; }
        public int ClientId { get => _ClientId; set => _ClientId = value; }
        public string Description { get => _Description; set => _Description = value; }
        public int State { get => _State; set => _State = value; }
        public int Paytypeid { get => _Paytypeid; set => _Paytypeid = value; } 
        #endregion
        
        //Pkaet Servis Açma

        public bool OrderServiceOpen(cPaketler order)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into paketSiparis(ADISYONID,MUSTERIID,ODEMETURID,ACIKLAMA)values(@ADISYONID,@MUSTERIID,@ODEMETURID,@ACIKLAMA)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ADISYONID", SqlDbType.Int).Value=order._AdditionID;
                cmd.Parameters.Add("@MUSTERIID", SqlDbType.Int).Value = order._ClientId;
                cmd.Parameters.Add("@ODEMETURID", SqlDbType.Int).Value = order._Paytypeid;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = order._Description;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }

        //Paket Servis Kapatma

        public void OrderServiceClose(int AdditionID)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update paketSiparis set paketSiparis.Durum=1 from paketSiparis Inner Join adisyon on paketSiparis.ADISYONID=adisyon.ID where paketSiparis.ADISYONID=@AdditionID", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdditionID", SqlDbType.Int).Value = AdditionID;
                Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }

        // Açılan Adisyon ve Paket Siparişe ait Ön Giirlen Odeme Tur ID
        public int OdemeTurIdGetir(int adisyonId)
        {
            int odemeTurId = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select paketSiparis.ODEMETURID from paketSiparis Inner Join Adisyon on paketSiparis.ADISYONID=Adisyon.ID where adisyon.ID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;
                odemeTurId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return odemeTurId;
        }

        //Sipariş Kontrol için müşteriye ait açık olan en son adisyon no getirme (bir müşteriye ait tek adisyon olur)
        public int musteriSonAdisyonIDGetir(int musteriID)
        {
            int no = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select adisyon.ID from Adisyon Inner Join paketSiparis on paketSiparis.ADISYONID=Adisyon.ID where (adisyon.Durum=0) and (paketSiparis.Durum=0) and paketSiparis.MUSTERIID=@musteriID", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriID", SqlDbType.Int).Value = musteriID;
                no = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }



            return no;
        }

        //Müşteri Arama ekranında adisyonbul - açık mı değil mi kontrol et!
        public bool getCheckOpenAdditionID(int additionID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from adisyon where (Durum=0) and (ID=@additionID)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@additionID", SqlDbType.Int).Value = additionID;
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }


    }
}
