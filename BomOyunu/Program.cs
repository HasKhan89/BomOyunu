using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int bomSayisi = 0;

            do
            {

                Console.WriteLine("Lütfen BOM sayısını giriniz.(2-25 arası giriniz.)");
                bomSayisi = int.Parse(Console.ReadLine());

            } while (bomSayisi < 2 || bomSayisi > 25);


            Console.WriteLine();
            Console.WriteLine("Oyun Başlıyor.");
            Console.WriteLine();

            int sayac = 1;

            for (sayac = 1; sayac <= 100; sayac++)
            {
                if (sayac % 2 == 1)
                {
                    // BAŞLA : Bilgisayar oynuyor..

                    if (sayac % bomSayisi == 0)
                        Console.WriteLine("Bilgisayar : BOM");
                    else
                        Console.WriteLine("Bilgisayar : " + sayac);

                    // BİTİŞ : Bilgisayar oynadı..
                }
                else
                {
                    // BAŞLA : Kullanıcı oynuyor..

                    Console.Write("Kullanıcı : ");
                    string deger = Console.ReadLine();

                    if (sayac % bomSayisi == 0)
                    {
                        // BOM sayısında isek..
                        if (deger != "BOM")
                        {
                            Console.WriteLine("Kaybettiniz..");
                            break;
                        }
                    }
                    else
                    {
                        // BOM sayısında değil isek..
                        // int sayi = int.Parse(deger);
                        if (deger != sayac.ToString())
                        {
                            Console.WriteLine("Kaybettiniz.");
                            break;
                        }
                    }

                    // BİTİŞ : Kullanıcı oynadı..
                }
            }

            if (sayac > 100)
                Console.WriteLine("Oyun berabere");


            Console.WriteLine("Oyun bitti");

            Console.ReadKey();
        }
    }
}
