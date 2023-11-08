using System;

class tip_donusumleri
{
    static void Main()
    {
        // Implicit Conversion(Bilinçsiz Dönüşüm)

        byte a = 5;
        sbyte b = 30;
        short c = 10;

        int d = a + b + c;
        Console.WriteLine("d: " + d);

        long h = d;
        Console.WriteLine("h: " + h);

        float i = h;
        Console.WriteLine("i: " + i);

        string e = "Batuhan";
        char f = 'E';

        object g = e + f + d;
        Console.WriteLine("g: " + g);



        // Explicit Conversion(Bilinçli Dönüşüm)
         
        int x = 4;
        byte y = (byte)x;
        Console.WriteLine("y: " + y);

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine("t: " + t);

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v: " + v);
        
    }
}