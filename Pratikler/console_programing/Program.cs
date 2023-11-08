using System;

namespace console_progmaming
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("isminizi giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("soyisminizi giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
