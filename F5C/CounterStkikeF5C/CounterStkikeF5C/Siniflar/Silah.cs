using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStkikeF5C
{
    public abstract class Silah
    {
        public int ToplamMermi { get; private set; } //progres barın valuesi
        public int SuankiMemri { get; set; }
        public string SilahAd { get; private set; }
        public string SilahGorselPath { get; private set; }
        public string AtesSesiPath { get; private set; }
        public string DoldurmaSesiPath { get; private set; }
        // public int HasarMiktari { get; private set; }

        public Silah(int mermiSayisi, string silahİsmi, string silahGorselDizin, string SilahAtesSes, string SilahDoldurmaSes)
        {
            ToplamMermi = mermiSayisi;
            SuankiMemri = ToplamMermi; //
            SilahAd = silahİsmi;
            SilahGorselPath = silahGorselDizin;
            AtesSesiPath = SilahAtesSes;
            DoldurmaSesiPath = SilahDoldurmaSes;
        }


        public virtual bool atesEt()
        { //bu kod çalışmazsa düzeltcem -1 i kadlrısam duzelır heralde not: bunu sil :D
            if (SuankiMemri - 1 >= 0) //-1 dememın sebebı sıfır olunca -1 e düşmesin diye. yani suankımermı(1)-1=0 oldugunda else e düş 
            {
                SuankiMemri--;
                return true;
            }
            return false;
        }

        public virtual void doldur()
        {
            SuankiMemri = ToplamMermi;
        }
    }
}
