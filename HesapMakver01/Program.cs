using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hangi programı çalıştırmak istersiniz?");
        Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
        Console.WriteLine("2 - Hesap Makinesi");
        Console.WriteLine("3 - Ortalama Hesaplama");
        int choice = Convert.ToInt32(Console.ReadLine());

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
            default:
                Console.WriteLine("Geçersiz seçim.");
                break;
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
            guess = Convert.ToInt32(Console.ReadLine());

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
            }
            else
            {
                Console.WriteLine($"{attempts} tahmin hakkınız kaldı.");
            }
        }
    }

    static void HesapMakinesi()
    {
        Console.WriteLine("İlk sayıyı girin:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("İkinci sayıyı girin:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Yapmak istediğiniz işlemi seçin (+, -, *, /):");
        char operation = Convert.ToChar(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine($"Sonuç: {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"Sonuç: {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"Sonuç: {num1 * num2}");
                break;
            case '/':
                if (num2 != 0)
                {
                    Console.WriteLine($"Sonuç: {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Sıfıra bölme hatası!");
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem seçimi.");
                break;
        }
    }

    static void OrtalamaHesaplama()
    {
        Console.WriteLine("Birinci ders notunu girin (0-100):");
        double not1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("İkinci ders notunu girin (0-100):");
        double not2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Üçüncü ders notunu girin (0-100):");
        double not3 = Convert.ToDouble(Console.ReadLine());

        if (not1 >= 0 && not1 <= 100 && not2 >= 0 && not2 <= 100 && not3 >= 0 && not3 <= 100)
        {
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
        else
        {
            Console.WriteLine("Geçersiz not girdiniz. Lütfen 0 ile 100 arasında bir not girin.");
        }
    }
}
