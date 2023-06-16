using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restoran;

namespace RestoranDemo
{
    internal class cRezervasyon
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _TableId;
        private int _ClientId;
        private DateTime _Date;
        private int _ClientCount;
        private string _Description;
        private int _AdditionId;
        #endregion

        #region Properties
        public int ID { get => ID; set => ID = value; }
        public int TableId { get => TableId; set => TableId = value; }
        public int ClientId { get => ClientId; set => ClientId = value; }
        public DateTime Date { get => Date; set => Date = value; }
        public int ClientCount { get => ClientCount; set => ClientCount = value; }
        public string Description { get => Description; set => Description = value; }
        public int AdditionId { get => AdditionId; set => AdditionId = value; } 
        #endregion


        public int getByClientIdFromRezervasyon(int tableId)
        {
            int clientId = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 MUSTERIID from Rezervasyon where MASAID=@masaid order by MUSTERIID Desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("masaid", SqlDbType.Int).Value = tableId;
                clientId = Convert.ToInt32(cmd.ExecuteScalar());
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



            return clientId;
        }

        public bool rezervationClose(int adisyonID)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Rezervasyon set Durum = 0 where ADISYONID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("adisyonId", SqlDbType.Int).Value = adisyonID;
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
