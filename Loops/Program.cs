using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı ", "Programlamaya başlangıç", "Java", "Python", "C++" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            //in kurslar kursları dolaş demektir
            foreach (string kurs in kurslar) //foreach dizi temelli yapıları tek tek dönmek için kullanılır.dizilere uygulanır
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer ");
        }
    }
}
