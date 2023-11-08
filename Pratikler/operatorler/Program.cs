using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            // mantıksal operatörler    
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            // ilişkisel operatörler   
            // <, >, <=, >=, ==, !=
            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            
            Console.WriteLine(sonuc);
            sonuc = a >= b;

            Console.WriteLine(sonuc);
            sonuc = a <= b;

            Console.WriteLine(sonuc);
            sonuc = a == b;

            Console.WriteLine(sonuc);
            sonuc = a != b;

            Console.WriteLine(sonuc);

            // aritmetik operatörler
            // /, *, +, -

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;

            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;

            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;

            Console.WriteLine(sonuc1);
            sonuc1 = sayi1--;

            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 % sayi2;

            Console.WriteLine(sonuc1);

            // /, *, +, -

            // matematiksel işlemler

            int sayi = 5;
            sayi = sayi + 1;
            sayi += 1;
            sayi /= 2;
            sayi *= 2;

            // Console.WriteLine(sayi);

            // modulus

            int sayi3 = 10;
            int sayi4 = 5;
            int sonuc2 = sayi3 % sayi4;

            // Console.WriteLine(sonuc2);

            // increment & decrement

            // Console.WriteLine(sayi5);
        }
    }
}