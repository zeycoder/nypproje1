using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace nypproje1
{
    class DataCek
    {
        Connection connection = new Connection();
        private List<Market> markets;
        public DataCek(List<Market> Markets)
        {
            markets = Markets;
        }
        public void marketEklke()
        {
            connection.connect.Open();
            connection.cmd.Connection = connection.connect;
            connection.cmd.CommandText = "Select * from MarketTbl";

            SqlDataReader dr = connection.cmd.ExecuteReader();
            while(dr.Read())
            {
                markets.Add(new Market {Market_id=Convert.ToInt32( dr["Market_id"]) });
            }
            connection.connect.Close();
        }
    }
}
