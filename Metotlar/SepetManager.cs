using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming Convention
        //Syntax 
        public void Ekle(Urun urun)//**önemli
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : "+urun.UrunAdi);

        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)//Tercih edilmiyor
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : "+urunAdi);
        }
    }
}
