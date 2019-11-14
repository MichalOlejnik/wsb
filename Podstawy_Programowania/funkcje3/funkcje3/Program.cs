using System;

namespace funkcje3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine("Wartość zmiennej a przed wywołaniem funkcji:{0} ",a);
            increment(ref a);
            Console.WriteLine("wartość zmiennej po wywołaniu funkcji:{0}",a );
            Console.ReadKey();
        }
        static void increment(ref int x)    //referencje - bez tego zmiany poza funkcją nie nastąpią
        {
            x += 10;
            Console.WriteLine("zmienna x wewnątrz funkcji:{0}",x);
        }
    }
}
