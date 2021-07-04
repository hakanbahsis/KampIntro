using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
   public class Product 
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }//KategoryId
        public string ProductName { get; set; }//Adı
        public double UnitPrice { get; set; }//Birim Fiyatı
        public int UnitsInStock { get; set; }//Stok Miktarı

        //CRUD -- Creat - Read -- Updated - Delete
    }
}
