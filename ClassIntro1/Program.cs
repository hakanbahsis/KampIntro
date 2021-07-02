using System;

namespace ClassIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunId = 1;
            product1.UrunAdi = "Klavye";
            product1.UrunMarkasi = "Logitech";
            product1.UrunAdeti = 8;
            product1.UrunFiyati = 85;

            Product product2 = new Product();
            product2.UrunId = 2;
            product2.UrunAdi = "Mouse";
            product2.UrunMarkasi = "Asus";
            product2.UrunAdeti = 15;
            product2.UrunFiyati = 75;

            Product[] products = new Product[] {product1, product2};

            foreach (var product in products)
            {
                Console.WriteLine("Ürün id : "+product.UrunId+" "+
                                  "Ürün Adı : "+product.UrunAdi+" "+
                                  "Ürün Markası : "+product.UrunMarkasi+" "+
                                  "Ürün Adeti : "+product.UrunAdeti+" "+
                                  "Ürün Fiyatı : "+product.UrunFiyati);
            }

            Console.WriteLine("************************************************");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün id : " + products[i].UrunId + " " +
                                  "Ürün Adı : " + products[i].UrunAdi + " " +
                                  "Ürün Markası : " + products[i].UrunMarkasi + " " +
                                  "Ürün Adeti : " + products[i].UrunAdeti + " " +
                                  "Ürün Fiyatı : " + products[i].UrunFiyati);
            }

            Console.WriteLine("****************************************************");

            int a = 0;
            while (products.Length>a)
            {
                Console.WriteLine("Ürün id : " + products[a].UrunId + " " +
                                  "Ürün Adı : " + products[a].UrunAdi + " " +
                                  "Ürün Markası : " + products[a].UrunMarkasi + " " +
                                  "Ürün Adeti : " + products[a].UrunAdeti + " " +
                                  "Ürün Fiyatı : " + products[a].UrunFiyati);
                a++;
            }

            Console.ReadLine();
        }
    }

    class Product
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string UrunMarkasi { get; set; }
        public int UrunAdeti { get; set; }
        public int UrunFiyati { get; set; }
    }
}
