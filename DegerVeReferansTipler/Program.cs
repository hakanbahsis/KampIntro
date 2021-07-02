using System;
using System.Runtime.InteropServices;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //sayısal veri tipleri(int,decimal,bool,double,bool) değer tiplerdir.
            //değer tip olanlar stack'te saklanır.
            //değer tip sadece değeri kopyalayıp işi bitiriyor. 
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            //array,class,interface referans tiplerdir.
            int[] sayilar1 = new int[] {10, 20, 30};//new Heap'te yeni bir yer oluşturur.
            int[] sayilar2 = new int[] {100, 200, 300};
            sayilar1 = sayilar2;//sayılar1'in referans numarası sayılar2'nin referans numarasına eşittir.(101=102)
            sayilar2[0] = 999;//102[0]=999
            Console.WriteLine(sayilar1[0]);


            Console.ReadLine();
        }
    }
}
