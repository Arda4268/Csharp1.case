﻿using System;
using System.Security.AccessControl;

namespace _01CsharpKamp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
             #region Yazdırma Komutları
            // Console.Write("HELLO WORLD");
            // Console.WriteLine("hello");

            
            /*Console.WriteLine("****** Yemek Kategorileri ******");
            Console.WriteLine();
            Console.WriteLine("1- Corbalar");
            Console.WriteLine("2- Ana Yemekler");
            Console.WriteLine("3- Soğuk başlangıçlar");
            Console.WriteLine("4- Salatalar");
            Console.WriteLine("5- Tatlılar");
            Console.WriteLine("6- İçecekler");
            Console.WriteLine();
            Console.WriteLine("****** Yemek Kategorileri ******");*/ 
             #endregion

             #region String Değişkenler
             
             //string
             //Degişken_türü değişken_adı;

             // string name;
             // name = "Arda";
             // Console.WriteLine(name);


             /*string customerName;
             string customerSurName;
             string customerPhone;
             string customerEmail,district,city;

             customerName = "Arda";
             customerSurName = "Esmekaya";
             customerPhone = "0 500 400 3020";
             customerEmail = "kapi@mail.com";
             district = "Selçuklu";
             city = "Konya";
             
             Console.WriteLine(); 
             Console.WriteLine("***** Rezervazsyon Kartı *****");
             Console.WriteLine();
             Console.WriteLine("--------------------------------");
             Console.WriteLine("MÜŞTERİ: " + customerName + " " + customerSurName );
             Console.WriteLine("İletişim: " + customerPhone);
             Console.WriteLine("Email Adresi: " + customerEmail);
             Console.WriteLine("Adres: " + district + "/" + city);
             Console.WriteLine("--------------------------------"); 
             Console.WriteLine();  
             customerName = "Ayşe";
             customerSurName = "Sert";
             customerPhone = "0 530 480 3120";
             customerEmail = "uçacls@mail.com";
             district = "Selçuklu";
             city = "Konya";
            
             Console.WriteLine("--------------------------------");
             Console.WriteLine("MÜŞTERİ: " + customerName + " " + customerSurName );
             Console.WriteLine("İletişim: " + customerPhone);
             Console.WriteLine("Email Adresi: " + customerEmail);
             Console.WriteLine("Adres: " + district + "/" + city);
             Console.WriteLine("--------------------------------"); */
             

             

             #endregion

             #region Int Değişkenler
             
             
             //int 
             // int number = 24;
             // Console.WriteLine(number);
             
             /*int hamburgerPrice = 300;
             int cokePrice = 35;
             int waterPrice = 10;
             int friesPrice = 50;
             int pizzaPrice = 250;
             int lemonadePrice = 30;
             
             Console.WriteLine();
             Console.WriteLine("***** Restoran Menü *****");
             Console.WriteLine();
             Console.WriteLine("-----------------------------");
             Console.WriteLine("-----> Hamburger: " + hamburgerPrice + " TL" );
             Console.WriteLine("-----> Coke: " + cokePrice + " TL" );
             Console.WriteLine("-----> Water: " + waterPrice + " TL" );
             Console.WriteLine("-----> Fries: " + friesPrice + " TL" );
             Console.WriteLine("-----> Pizza: " + pizzaPrice + " TL" );
             Console.WriteLine("-----> Lemonade: " + lemonadePrice + " TL" );
             Console.WriteLine("-----------------------------");
             
             
             Console.WriteLine();
             int totalHamburgerPrice = 0;
             int totalcokePrice = 0;
             int totalwaterPrice = 0;
             int totalfriesPrice = 0;
             int totalpizzaPrice = 0;
             int totallemonadePrice = 0;

             int hamburgerCount = 3;
             int cokeCount = 3;
             int waterCount = 3;
             int friesCount = 1;
             int pizzaCount = 0;
             int lemonadeCount = 0;

             totalHamburgerPrice = hamburgerPrice * hamburgerCount;
             totalcokePrice = cokePrice * cokeCount;
             totalwaterPrice = waterPrice * waterCount;
             totalfriesPrice = friesPrice * friesCount;
             totalpizzaPrice = pizzaPrice * pizzaCount;
             totallemonadePrice = lemonadePrice * lemonadeCount;
             Console.WriteLine("***** Hesap *****");
             Console.WriteLine();
             Console.WriteLine("-----------------------------"); 
             Console.WriteLine("-----> Hamburger Tutarı: " + totalHamburgerPrice + " TL" );
             Console.WriteLine("-----> Coke Tutarı: " + totalcokePrice + " TL" );
             Console.WriteLine("-----> Water Tutarı: " + totalwaterPrice + " TL" );
             Console.WriteLine("-----> Fries Tutarı: " + totalfriesPrice + " TL" );
             Console.WriteLine("-----> Pizza Tutarı: " + totalpizzaPrice + " TL" );
             Console.WriteLine("-----> Lemonade Tutarı: " + totallemonadePrice + " TL" );
             Console.WriteLine();
             
             int totalprice = 0;
             totalprice = totalHamburgerPrice + totalcokePrice + totalfriesPrice + totalwaterPrice + totalpizzaPrice +
                          totallemonadePrice;
             Console.WriteLine("Toplam Ödenecek Tutar: " + totalprice + " TL");*/
             
             #endregion

             #region Double Değişkenleri

             // double number;
             
             // number = 4.85;
             
             // Console.WriteLine(number);
             
             /*Console.WriteLine("***** Fiyat Listesi *****");
             Console.WriteLine();

             double applePrice, orangePrice, strawberryPrice, potato, tomato;

             applePrice = 14.85;
             orangePrice = 20.95;
             strawberryPrice = 45;
             tomato = 6.88;
             potato = 9.74;
             
             Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice +" TL");
             Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice +" TL");
             Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
             Console.WriteLine("----- Patates Birim Fiyatı: " + potato + " TL");
             Console.WriteLine("----- Domates Birim Fiyatı: " + tomato + " TL");

             double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

             appleGram = 1.245;
             orangeGram = 2.650;
             strawberryGram = 0.750;
             potatoGram = 4.859;
             tomatoGram = 3.745;

             double appletotalPrice = applePrice * appleGram;  
             double orangetotalPrice = orangePrice * orangeGram;  
             double strawberrytotalPrice = strawberryPrice * strawberryGram;  
             double potatototalPrice = potato * potatoGram;  
             double tomatototalPrice = tomato * tomatoGram;
             Console.WriteLine();
             
             Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + applePrice + " TL" + " - Gramaj: " + appleGram + " TL " + " - Toplam Tutar: " + appletotalPrice + " TL");
             Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " TL" + " - Gramaj: " + orangeGram + " TL" + " - Toplam Tutar: " + orangetotalPrice + " TL");
             Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice + " TL" + " - Gramaj: " + strawberryGram + " TL" + " - Toplam Tutar: " + strawberrytotalPrice + " TL");
             Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potato + " TL" + " - Gramaj: " + potatoGram + " TL" + " - Toplam Tutar: " + potatototalPrice + " TL");
             Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomato + " TL" + " - Gramaj: " + tomatoGram + " TL" + "- Toplam Tutar: " + tomatototalPrice + " TL");

             Double totalPrice;

             totalPrice = appletotalPrice + orangetotalPrice + strawberrytotalPrice + potatototalPrice +
                          tomatototalPrice;
             
             Console.WriteLine();
             Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");*/

             #endregion

             #region Char Degişkenler

             // char symbol;
             // symbol = 'a';
             //
             // Console.WriteLine(symbol);
             

             #endregion

             #region Klavyeden Veri Girişleri String Degişkenler
             
             
             /*Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");

             string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
             
             Console.Write("Yolcu Adı: ");
             passengerName = Console.ReadLine();
             
             Console.Write("Yolcu Soyadı: ");
             passengerSurname = Console.ReadLine();

             Console.Write("Yolcu ilçesi: ");
             passengerDistrict = Console.ReadLine();
             
             Console.Write("Yolcu Şehiri: ");
             passengerCity = Console.ReadLine();
             
             Console.Write("Yolcu Yaşı: ");
             passengerAge = Console.ReadLine();
             
             Console.Write("Yolcu Kimlik numarası: ");
             passengerIdentityNumber = Console.ReadLine();
             
             Console.WriteLine();
             Console.WriteLine("------------------------------");
             Console.WriteLine("Yolcunun Tc Kimlik No: " + passengerIdentityNumber + " - Yolcu Adı ve Soyadı: " + passengerName +" "+ passengerSurname
             +" - Yolcunun Yaşı: "+ passengerAge  + " - Yolcunun Yaşadığı Şehir ve ilçesi: " + passengerCity + " / " + passengerDistrict );*/

             #endregion

             #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

             /*int shoesPrice, computerPrice, chairPrice, tvPrice;

             shoesPrice = 1000;
             computerPrice = 20000;
             chairPrice = 5000;
             tvPrice = 12000;

             int shoesCount, computerCount, chairCount, tvCount;
             
             Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
             shoesCount = int.Parse(Console.ReadLine());
             
             Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
             computerCount = int.Parse(Console.ReadLine());
             
             Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
             chairCount = int.Parse(Console.ReadLine());
             
             Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
             tvCount = int.Parse(Console.ReadLine());

             int totalPrice;

             totalPrice = chairPrice * chairCount + computerCount * computerPrice + shoesPrice * shoesCount +
                          tvPrice * tvCount;
             
             Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");*/
             
            
             
             

             #endregion

             #region Klavyeden Ondalıklı Sayı İşlemleri
             
             /*double exam1, exam2, exam3, result;
             
             Console.Write("Lütfen 1.Sinav notunu giriniz: "); 
             exam1 = double.Parse(Console.ReadLine());
             
             Console.Write("Lütfen 2.Sinav notunu giriniz: ");
             exam2 = double.Parse(Console.ReadLine());
             
             Console.Write("Lütfen 3.Sınav notunu giriniz: ");
             exam3 =double.Parse(Console.ReadLine());

             result = (exam1 + exam2 + exam3) / 3;
             
             Console.WriteLine();
             Console.WriteLine("Sınav Ortalaması: " + result);*/
             
             

             #endregion

             #region Klavyeden Karakter Girişleri

             // char gender;
             // Console.Write("Lütfen cinsiyet seçiniz: ");
             // gender = char.Parse(Console.ReadLine());
             //
             // Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);
             

             #endregion
      
            Console.Read();



        }
    }
}
