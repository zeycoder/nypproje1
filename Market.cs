using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nypproje1
{
    class Market
    {
        public int Market_id { get; set; }

        List<Calisan> Calisanlar = new List<Calisan>();
        public void calisanEkle(string ad,int market_id)
        {
            Calisanlar.Add(new Calisan {Ad=ad,Market_id=market_id });
        }
        public List<Calisan> calisanListele()
        {
            return Calisanlar;
        }
    }
}
