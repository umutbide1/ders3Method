using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3Method
{
    internal class MarketManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi:"+urun.Adi);


        }
        public void cıkar(Urun urun)
        {
            Console.WriteLine("Sepetten silindi:"+urun.Adi);
        }
        
    }
}
