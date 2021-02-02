using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya Elması";

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product product in urunler)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("------------Metotlar------------");

            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


        }
    }
}
