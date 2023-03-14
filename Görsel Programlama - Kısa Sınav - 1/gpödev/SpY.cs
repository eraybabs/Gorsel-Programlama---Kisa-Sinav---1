using System;

namespace KisaSinav1
{
    class Sorular
    {
        static void Main(string[] args)

        {
            
            memati:

            Console.WriteLine("Cevabı görmek için bir işlem seçin \n\n -------------------- \n\n Soru (1) \n\n Soru (2) \n\n Soru (3) \n");

            int SoruSirasi = Convert.ToInt32(Console.ReadLine());

            if (SoruSirasi == 1)

            {

                int toplam = 1000;

                for (int a = 1; a <= toplam / 3; a++)

                {

                    for (int b = a + 1; b <= toplam / 2; b++)

                    {

                        int c = toplam - a - b;

                        if (a * a + b * b == c * c)

                        {

                            Console.Write("\n1. Sorunun çözümü: \n\na = " + a + "\n\n" + "b = " + b + "\n\n" + "c = " + c + "\n\n");

                            goto memati;


                        }

                    }

                }

            }

            else if (SoruSirasi == 2)

            {

                int pazartesi = 0;

                for (int yil = 1901; yil <= 2000; yil++)

                {

                    for (int ay = 1; ay <= 12; ay++)

                    {

                        if ((new DateTime(yil, ay, 1)).DayOfWeek == DayOfWeek.Monday)

                        {

                            pazartesi += 1;

                        }

                    }

                }

                Console.WriteLine("\n2. Sorunun çözümü:\n\n1901'den 2000'e kadar " + pazartesi + " adet ayın ilk gününe denk gelen pazartesi vardır.\n\n");

                goto memati;

            }

            else if (SoruSirasi == 3)

            {

                int SpY = 0;

                for (int e = 1000; e != 0; e--)

                {

                    if (dairesel(e))

                    {

                        SpY++;

                    }

                }

                Console.WriteLine("3. sorunun çözümü:\n\n1000'den küçük dairesel asal sayıların adedi " + SpY + "'tir.\n\n");

                goto memati;

            }

            else

            {

                Console.WriteLine("Lütfen 1 ile 3 arasında bir sayı giriniz! ");

                goto memati;

            }

        }

        static bool asal(int s)

        {

            if (s <= 1)

                return false;

            if (s <= 3)

                return true;

            if (s % 3 == 0 || s % 2 == 0)

                return false;

            for (int babs = 5; babs * babs <= s; babs = babs + 6)

                if (s % babs == 0 || s % (babs + 2) == 0)

                    return false;

            return true;

        }
        static bool dairesel(int ERAY)

        {

            int geçici = ERAY, say = 0 ;

            while (geçici > 0)

            {

                say++;

                geçici /= 10;

            }

            int num = ERAY;

            while (asal(num))

            {

                int böl = num / 10;

                int mod = num % 10;

                num = (int)((Math.Pow(10, say - 1)) * mod) + böl;

                if (num == ERAY)

                    return true;

            }

            return false;

        }

    }
}