using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //Ürün ile ilgili operasyonlar içerir CRUD İşlemleri
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " EKlendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }

    }
}
