using System;

namespace zajecia_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = int.Parse(Console.ReadLine());

            while (a != b)
            {


                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }


            }
            Console.WriteLine("Największy wspólny dzielnik a i b: " + a);



            Console.ReadKey();
        
    }
    }
}
