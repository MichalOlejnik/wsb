using System;

namespace wskaznik_2
{
    class Program
    {
        unsafe static void Swap(int* a, int* b)
            {
            int pom = *a;
            *a = *b;
            *b = pom;
            }
            
        unsafe static void Main(string[] args)
        {
            int x = 2;
            int y = 5;

            Console.WriteLine("Wartośći przed zmianą: x={0}, y={1}", x , y);
            Swap(&x, &y);       //dodajemy & -bo nie można przekonwertować int na int*
            Console.WriteLine("Wartośći przed zmianą: x={0}, y={1}", x, y);

            int a = 100;
            int b = 200;
            int* a1 = &a;
            int* b1 = &b;
            Console.WriteLine("Wartośći przed zmianą: a={0}, b={1}", a, b);
            Swap(a1, b1);
            Console.WriteLine("Wartośći przed zmianą: a={0}, b={1}", a, b);

            Console.ReadKey();
        }
    }
}
