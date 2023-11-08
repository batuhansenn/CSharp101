using System;

namespace degiskenler
{
    class Program 
    {
        static void Main(string[] args)
        {
           Console.WriteLine(" ");

            byte b = 5; // 1 byte
            byte c = 5; // 1 byte

            short s = 5; // 2 byte
            ushort us = 5; // 2 byte

            Int16 i16 = 2; // 2 byte
            Int32 i32 = 2; // 4 byte
            Int64 i64 = 2; // 8 byte

            uint ui = 2; // 4 byte
            long l = 4; // 8 byte
            ulong ul = 4; // 8 byte

            float f = 5; // 4 byte
            double d = 5; // 8 byte
            decimal de = 5; // 16 byte

            char ch = '2'; // 2 byte
            string str = "Batuhan"; // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler
            
            string str1 = string.Empty;
            str1 = "Batuhan Şen";
            string ad = "Batuhan";
            string soyad = "Şen";
            string tamIsim = ad + " " + soyad;

            // integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // boolean

            bool bool1 = 10 < 2;

            // Değişken Dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22); // 40

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            // saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

            // toplama
            Console.WriteLine(" ");
            Console.WriteLine("Toplama İşlemi");
            Console.WriteLine(" ");

            int sayi1 = 10;
            int sayi2 = 5;
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);

            // Çıkarma
            Console.WriteLine(" ");
            Console.WriteLine("Çıkarma İşlemi");
            Console.WriteLine(" ");
            
            int fark = sayi1 - sayi2;
            Console.WriteLine("Fark: " + fark);

            // Çarpma
            Console.WriteLine(" ");
            Console.WriteLine("Çarpma İşlemi");
            Console.WriteLine(" ");

            int carpim = sayi1 * sayi2;
            Console.WriteLine("Çarpım: " + carpim);

            // Bölme
            Console.WriteLine(" ");
            Console.WriteLine("Bölme İşlemi");
            Console.WriteLine(" ");

            int bolum = sayi1 / sayi2;
            Console.WriteLine("Bölüm: " + bolum);

            // Mod Alma
            Console.WriteLine(" ");
            Console.WriteLine("Mod Alma İşlemi");
            Console.WriteLine(" ");

            int mod = sayi1 % sayi2;
            Console.WriteLine("Mod: " + mod);

            // Ödev
            Console.WriteLine(" ");
            Console.WriteLine("Ödev");
            Console.WriteLine(" ");

            int sayi3 = 3;
            int sayi4 = 4;
            int sayi5 = 2;
            int sonuc = sayi3 * sayi4 / sayi5;
            Console.WriteLine("Sonuç: " + sonuc);

            // Ödev
            Console.WriteLine(" ");
            Console.WriteLine("Ödev");
            Console.WriteLine(" ");

            int sayi6 = 10;
            int sayi7 = 5;
            int sayi8 = 2;
            int sonuc2 = (sayi6 / sayi7) + sayi8;
            Console.WriteLine("Sonuç: " + sonuc2);

            // Ödev
            Console.WriteLine(" ");
            Console.WriteLine("Ödev");
            Console.WriteLine(" ");

            int sayi9 = 10;
            int sayi10 = 5;
            int sayi11 = 2;
            int sonuc3 = sayi9 / (sayi10 * sayi11);
            Console.WriteLine("Sonuç: " + sonuc3);

            // Ödev
            Console.WriteLine(" ");
            Console.WriteLine("Ödev");
            Console.WriteLine(" ");

            int sayi12 = 10;
            int sayi13 = 5;
            int sayi14 = 2;
            int sonuc4 = sayi12 / sayi13 * sayi14 + 1;
            Console.WriteLine("Sonuç: " + sonuc4);

            // Ödev
            Console.WriteLine(" ");
            Console.WriteLine("Ödev");
            Console.WriteLine(" ");

            int sayi15 = 10;
            int sayi16 = 5;
            int sayi17 = 2;
            int sonuc5 = sayi15 / sayi16 * (sayi17 + 1);
            Console.WriteLine("Sonuç: " + sonuc5);

            // Ödev
            Console.WriteLine(" ");
            Console.WriteLine("Ödev");
            Console.WriteLine(" ");

            int sayi18 = 10;
            int sayi19 = 5;
            int sayi20 = 2;
            int sonuc6 = sayi18 / sayi19 * sayi20 + 1;
            Console.WriteLine("Sonuç: " + sonuc6);

            // Ödev
            Console.WriteLine(" ");
            Console.WriteLine("Ödev");
            Console.WriteLine(" ");

            int sayi21 = 10;
            int sayi22 = 5;
            int sayi23 = 2;
            int sonuc7 = sayi21 / sayi22 * sayi23 + 1;
            Console.WriteLine("Sonuç: " + sonuc7);

            // Ödev
            Console.WriteLine(" ");
            Console.WriteLine("Ödev");
            Console.WriteLine(" ");

            int sayi24 = 10;
            int sayi25 = 5;
            int sayi26 = 2;
            int sonuc8 = sayi24 / sayi25 * sayi26 + 1;
            Console.WriteLine("Sonuç: " + sonuc8);
            
        }
    }
}