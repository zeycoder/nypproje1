using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nypproje1
{
    class Uygulama
    {
        private Uygulama() { }
        private static List<Market> markets;
        public static List<Market> Markets
        {
            get
            {
                if(markets==null)
                {
                    markets = new List<Market>();
                }
                return markets;
            }
           
        }

    }
}
