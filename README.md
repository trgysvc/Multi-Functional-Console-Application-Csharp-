Multi-Functional Console Application
This project is a multi-functional console application written in C#, designed to enhance basic programming skills. The program combines three different functions in one:

Random Number Guessing Game: Try to guess a random number between 1 and 100.
Calculator: A simple calculator where you can perform addition, subtraction, multiplication, and division.
Average Grade Calculator: Calculates your average from three grades and shows your letter grade.
Installation and Running
Download or clone this project from GitHub:

bash
Kodu kopyala
git clone https://github.com/username/MultiFunctionalConsoleApplicationCsharp.git
Open the project in a C# IDE (e.g., Visual Studio).

Run the Program.cs file to start the application.

Usage
Once the program starts, users are presented with three options. You can choose which function to use and proceed with the corresponding task.

Functions
Random Number Guessing Game: Lets the user guess a number between 1 and 100, providing feedback to help them find the correct number.
Calculator: Allows the user to input two numbers and perform arithmetic operations (addition, subtraction, multiplication, division).
Average Grade Calculator: Users input three grades, and the program calculates the average and assigns a corresponding letter grade.
Contributing
The project is open for development. If you'd like to contribute, feel free to create a pull request or open an issue to provide feedback.

Future Improvements
1. More Advanced Calculator Functions
Enhancement: More advanced mathematical operations such as percentage calculation, exponentiation, and square root calculation can be added to the calculator.
Benefit: It allows users to perform a wider range of mathematical operations.
2. Difficulty Levels of the Random Number Guessing Game
Enhancement: Three difficulty levels can be added to the game: easy, medium, and hard. For example, the guess range can be between 1-50 in the easy level, and 1-1000 in the hard level.
Benefit: Users can play the game according to their own level and remain interested for a longer period of time.
3. Average Calculation Improvements
Enhancement: More courses can be added to the average calculation section, and a weighted grade point average calculation feature can be added with a credit system.
Benefit: It becomes a more comprehensive grade calculation tool for university or high school students.
4. Adding a User Interface (GUI)
Enhancement: The project can be removed from the console application and converted into a simple graphical interface with Windows Forms or WPF.
Benefit: The application becomes more user-friendly and visually appealing.
5. Save Results Feature
Enhancement: Users' actions (for example, calculation results or guessing game scores) can be saved to a file and restored later.
Benefit: Users can track their progress and review their results.
6. Multi-Language Support
Enhancement: The application can be made available in more than one language. For example, the ability to choose between English and Turkish can be added.
Benefit: The application becomes more suitable for international use.
7. Adding Unit Tests
Enhancement: Unit tests can be written for the methods and functions used in the project.
Benefit: Increases the accuracy and reliability of the code, minimizes errors in future changes.
8. Adding a Timer
Enhancement: A timer can be added for the random number guessing game, allowing the player to guess within a certain time.
Benefit: Increases the excitement of the game and adds an element of challenge to the players.
9. More Complex Games
Development: The number of mini-games can be increased, such as the random number guessing game, or the existing game can be made more complex.
Benefit: It makes the project usable not only for educational purposes but also for entertainment purposes.

New Features and Improvements
+Improved Input Validation for Calculator:
+Now, if the user enters an invalid character or symbol instead of numbers or operations, the program will prompt the user to re-enter the input without restarting the program.
Seamless Error Handling for Invalid Number Inputs:
+The program now handles incorrect number inputs (such as non-numeric characters) by prompting the user to input a valid number again instead of terminating or going back to the main menu.
Enhanced Operator Input Handling:
+If an invalid operation (such as a character other than +, -, *, /) is entered, the user is asked to re-enter the correct operator without restarting the program.
Re-attempt Mechanism for Invalid Scores in Average Calculation:
+When calculating the average, if a non-numeric or out-of-range score is entered, the program will request the user to enter a valid score without interrupting the process for other inputs.
Structured and User-Friendly Output:
+The messages prompting the user for input and error messages are now more descriptive and user-friendly, making the overall experience smoother.
Exit Option on Main Menu:
+Users can now easily exit the program by selecting the "0" option on the main menu, ensuring a clear and smooth termination process.


Multi-Functional Console Application [TR]

Bu proje, C# dilinde yazılmış ve temel programlama becerilerini geliştirmek amacıyla oluşturulmuş çok işlevli bir konsol uygulamasıdır. Program, üç farklı işlevi tek bir yerde toplar:

Rastgele Sayı Bulma Oyunu: 1 ile 100 arasında rastgele bir sayı tahmin etmeye çalışın.
Hesap Makinesi: Toplama, çıkarma, çarpma ve bölme işlemlerini gerçekleştirebileceğiniz basit bir hesap makinesi.
Ortalama Hesaplama: Üç farklı ders notu üzerinden ortalamanızı hesaplar ve harf notunuzu gösterir.
Kurulum ve Çalıştırma
Bu projeyi GitHub'dan indirin ya da klonlayın:

bash
Kodu kopyala
git clone https://github.com/kullaniciadi/MultiFunctionalConsoleApplicationCsharp.git
Projeyi bir C# IDE'si ile (örneğin Visual Studio) açın.

Programı çalıştırmak için Program.cs dosyasını başlatın.

Kullanım
Program başlatıldığında, kullanıcıya üç seçenek sunulur. Yapmak istediğiniz işlemi seçip programın ilgili kısmını çalıştırabilirsiniz.

Fonksiyonlar
Rastgele Sayı Bulma Oyunu: Oyuncuya 1 ile 100 arasında bir sayı tutturma fırsatı verir. Oyuncu tahminlerde bulunur ve doğru tahmine ulaşmaya çalışır.
Hesap Makinesi: İki sayı girip, aritmetik işlemler (toplama, çıkarma, çarpma, bölme) yapmanızı sağlar.
Ortalama Hesaplama: Üç ders notu girilir ve ortalama hesaplanır. Ayrıca bu ortalamaya göre harf notu belirlenir.
Katkıda Bulunma
Proje geliştirilmeye açıktır. Herhangi bir katkı sunmak isterseniz, lütfen bir pull request oluşturun ya da issue açarak geri bildirimde bulunun.

Gelecek Geliştirmeler
1. Daha İleri Hesap Makinesi İşlevleri
Geliştirme: Hesap makinesine yüzde hesaplama, üs alma, karekök hesaplama gibi daha ileri matematiksel işlemler eklenebilir.
Faydası: Kullanıcılara daha geniş bir yelpazede matematiksel işlemler yapma imkanı sunar.
2. Rastgele Sayı Tahmin Oyununun Zorluk Seviyeleri
Geliştirme: Oyuna kolay, orta ve zor olmak üzere üç zorluk seviyesi eklenebilir. Örneğin, kolay seviyede tahmin aralığı 1-50 arasında olabilir, zor seviyede ise 1-1000.
Faydası: Kullanıcılar, oyunu kendi seviyelerine göre oynayabilir ve daha uzun süre ilgi çekici kalabilir.
3. Ortalama Hesaplama Geliştirmeleri
Geliştirme: Ortalama hesaplama kısmına daha fazla ders ekleyip, kredi sistemiyle ağırlıklı not ortalaması hesaplama özelliği eklenebilir.
Faydası: Üniversite veya lise öğrencileri için daha kapsamlı bir not hesaplama aracı haline gelir.
4. Kullanıcı Arayüzü (GUI) Eklenmesi
Geliştirme: Projeyi konsol uygulamasından çıkarıp, Windows Forms veya WPF ile basit bir grafiksel arayüze dönüştürülebilir.
Faydası: Uygulama daha kullanıcı dostu ve görsel olarak çekici hale gelir.
5. Sonuç Kaydetme Özelliği
Geliştirme: Kullanıcıların yaptıkları işlemler (örneğin hesaplama sonuçları veya tahmin oyunu skorları) bir dosyaya kaydedilebilir ve daha sonra geri yüklenebilir.
Faydası: Kullanıcıların ilerlemelerini takip etmeleri sağlanabilir ve sonuçları tekrar inceleyebilmeleri mümkün olur.
6. Çoklu Dil Desteği
Geliştirme: Uygulama birden fazla dilde kullanılabilir hale getirilebilir. Örneğin, İngilizce ve Türkçe arasında seçim yapma özelliği eklenebilir.
Faydası: Uygulamanın uluslararası kullanıma daha uygun hale gelmesi sağlanır.
7. Unit Testler Eklenmesi
Geliştirme: Projede kullanılan metotlar ve işlevler için unit testler yazılabilir.
Faydası: Kodun doğruluğunu ve güvenilirliğini arttırır, gelecekte yapılacak değişikliklerde hataları minimize eder.
8. Zamanlayıcı Eklenmesi
Geliştirme: Rastgele sayı tahmin oyunu için bir zamanlayıcı eklenerek oyuncunun belirli bir süre içinde tahminde bulunması sağlanabilir.
Faydası: Oyunun heyecanını artırır ve oyunculara bir zorluk unsuru ekler.
9. Daha Karmaşık Oyunlar
Geliştirme: Rastgele sayı tahmin oyunu gibi mini oyunların sayısı artırılabilir, ya da mevcut oyun daha karmaşık bir hale getirilebilir.
Faydası: Projeyi sadece eğitim amaçlı değil, aynı zamanda eğlence amaçlı da kullanılabilir hale getirir.

Yeni Özellikler ve İyileştirmeler
+Hesap Makinesi için Gelişmiş Giriş Doğrulaması:
+Artık kullanıcı sayılar veya işlemler yerine geçersiz bir karakter veya sembol girerse, program kullanıcıdan programı yeniden başlatmadan girişi yeniden girmesini isteyecektir.
Geçersiz Sayı Girişleri İçin Sorunsuz Hata İşleme:
+Program artık hatalı sayı girişlerini (sayısal olmayan karakterler gibi) sonlandırmak veya ana menüye geri dönmek yerine kullanıcıdan geçerli bir sayıyı yeniden girmesini isteyerek işliyor.
Geliştirilmiş Operatör Girişi İşleme:
+Geçersiz bir işlem (+, -, *, / dışındaki bir karakter gibi) girilirse, kullanıcıdan programı yeniden başlatmadan doğru operatörü yeniden girmesi istenir.
Ortalama Hesaplamasında Geçersiz Puanlar İçin Yeniden Deneme Mekanizması:
+Ortalama hesaplanırken, sayısal olmayan veya aralık dışı bir puan girilirse, program kullanıcıdan diğer girdiler için işlemi kesintiye uğratmadan geçerli bir puan girmesini isteyecektir. Yapılandırılmış ve Kullanıcı Dostu Çıktı:
+Kullanıcıdan girdi ve hata mesajları isteyen mesajlar artık daha açıklayıcı ve kullanıcı dostu, bu da genel deneyimi daha akıcı hale getiriyor.
Ana Menüde Çıkış Seçeneği:
+Kullanıcılar artık ana menüde "0" seçeneğini seçerek programdan kolayca çıkabilir, bu da net ve akıcı bir sonlandırma süreci sağlar.
