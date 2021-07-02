using System;

namespace Metotlar
{
    //Metotlar kodları tekrar kullanmamızı sağlayan yapıladır
    //Dont repeat yourself - DRY --Kendini Tekrar Etme!
    //Clean Code - Temiz kod
    //Best Practice
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 10;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            //Type-Safe -- Tip Güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Id : "+urun.Id+"\n"+
                                  "Ürün Adı : "+urun.UrunAdi+"\n"+
                                  "Ürün Fiyatı : "+urun.Fiyati+"TL"+"\n"+
                                  "Ürün Açıklamsı : "+urun.Aciklama+"\n"+
                                  "------------------------------------");
            }

            Console.WriteLine("---------------------Metotlar-------------------------");
            //instance - Örnek oluşturma
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
           
            sepetManager.Ekle2("Armut","Yeşil Armut",12,50);
            sepetManager.Ekle2("Elma","Yeşil Elma",15,35);
            sepetManager.Ekle2("Karpuz","Diyarbakır Karpuzu",15,60);
            Console.ReadLine();
        }
    }

}
