using System;

class Program
{
    static void Main()
    {
        bool programDevam = true;
        while (programDevam)
        {
            Console.WriteLine("Hangi programı çalıştırmak istersiniz?");
            Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
            Console.WriteLine("2 - Hesap Makinesi");
            Console.WriteLine("3 - Ortalama Hesaplama");
            Console.WriteLine("0 - Programı Kapat");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        RastgeleSayiBulmaOyunu();
                        break;
                    case 2:
                        HesapMakinesi();
                        break;
                    case 3:
                        OrtalamaHesaplama();
                        break;
                    case 0:
                        Console.WriteLine("Programdan çıkılıyor...");
                        programDevam = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
            }
        }
    }

    static void RastgeleSayiBulmaOyunu()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int guess;
        int attempts = 5;

        Console.WriteLine("1 ile 100 arasında bir sayı tuttum, tahmin edin!");

        while (attempts > 0)
        {
            Console.WriteLine("Tahmininizi girin:");

            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess == randomNumber)
                {
                    Console.WriteLine("Tebrikler, doğru tahmin!");
                    break;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Daha yüksek bir sayı girin.");
                }
                else
                {
                    Console.WriteLine("Daha düşük bir sayı girin.");
                }

                attempts--;

                if (attempts == 0)
                {
                    Console.WriteLine($"Tahmin hakkınız doldu. Doğru sayı: {randomNumber}");
                    Console.WriteLine("Oyun bitti.");
                }
                else
                {
                    Console.WriteLine($"{attempts} tahmin hakkınız kaldı.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş, lütfen bir sayı girin.");
            }
        }
    }

    static void HesapMakinesi()
    {
        int num1 = SayiGirisi("İlk");
        int num2 = SayiGirisi("İkinci");

        bool islemGecerli = false;
        while (!islemGecerli)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçin (+, -, *, /):");
            char operation = Console.ReadLine()[0];  // İlk karakteri alır.

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Sonuç: {num1 + num2}");
                    islemGecerli = true;
                    break;
                case '-':
                    Console.WriteLine($"Sonuç: {num1 - num2}");
                    islemGecerli = true;
                    break;
                case '*':
                    Console.WriteLine($"Sonuç: {num1 * num2}");
                    islemGecerli = true;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Sonuç: {num1 / num2}");
                        islemGecerli = true;
                    }
                    else
                    {
                        Console.WriteLine("Sıfıra bölme hatası! Lütfen tekrar deneyin.");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçimi. Lütfen +, -, *, / işlemlerinden birini girin.");
                    break;
            }
        }
    }

    static int SayiGirisi(string sira)
    {
        int sayi;
        while (true)
        {
            Console.WriteLine($"{sira} sayıyı girin:");
            if (int.TryParse(Console.ReadLine(), out sayi))
            {
                return sayi;  // Geçerli bir sayı girildiğinde döngüden çık.
            }
            else
            {
                Console.WriteLine("Geçersiz giriş, lütfen geçerli bir sayı girin.");
            }
        }
    }

    static void OrtalamaHesaplama()
    {
        double not1 = NotGirisi("Birinci");
        double not2 = NotGirisi("İkinci");
        double not3 = NotGirisi("Üçüncü");

        double ortalama = (not1 + not2 + not3) / 3;
        Console.WriteLine($"Ortalamanız: {ortalama}");

        if (ortalama >= 90)
            Console.WriteLine("Harf notu: AA");
        else if (ortalama >= 85)
            Console.WriteLine("Harf notu: BA");
        else if (ortalama >= 80)
            Console.WriteLine("Harf notu: BB");
        else if (ortalama >= 75)
            Console.WriteLine("Harf notu: CB");
        else if (ortalama >= 70)
            Console.WriteLine("Harf notu: CC");
        else if (ortalama >= 65)
            Console.WriteLine("Harf notu: DC");
        else if (ortalama >= 60)
            Console.WriteLine("Harf notu: DD");
        else if (ortalama >= 55)
            Console.WriteLine("Harf notu: FD");
        else
            Console.WriteLine("Harf notu: FF");
    }

    static double NotGirisi(string ders)
    {
        double notDegeri;
        do
        {
            Console.WriteLine($"{ders} ders notunu girin (0-100):");
        } while (!double.TryParse(Console.ReadLine(), out notDegeri) || notDegeri < 0 || notDegeri > 100);

        return notDegeri;
    }
}
