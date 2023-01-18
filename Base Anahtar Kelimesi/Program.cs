using System;

namespace Base_Anahtar_Kelimesi
{
    class Program
    {
        static void Main(string[] args)
        {
            bilgisayar bilgisayar = new bilgisayar(5);
            bilgisayar.adi = "Msi";
            bilgisayar.adet = 15;
            bilgisayar.fiyat = 10000;
            bilgisayar.modeli = "C550 XT";
            bilgisayar.ram = 8;
            bilgisayar.ekran = 17;
            bilgisayar.disk = 256;
            bilgisayar.yaz();

        }
    }
    class urun
    {
        public string adi;
        public int adet;
        public int fiyat;
        public void yaz()
        {
            Console.WriteLine("{0},{1},{2}", adi, adet, fiyat);
        }
        public urun()
        {
            Console.WriteLine("Ürün Constator");
        }
        public urun(int a)
        {
            Console.WriteLine("Ürün Constator int ={0}",a);
        }

    }
    class bilgisayar : urun
    {
        public string modeli;
        public int ram;
        public int disk;
        public int ekran;
        public new void yaz()
        {
            base.yaz();
            Console.WriteLine("{0},{1},{2},{3}", modeli, ram, disk, ekran);
        }
        public bilgisayar()
        {
            Console.WriteLine("Bilgisayar Constator");
        }
        public bilgisayar(int a):base(a)
        {
            Console.WriteLine("Bilgisayar Constator int={0}", a);
        }

    }
}
