using System;

namespace funkcje1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);
            Show();
            Console.WriteLine(Show1());// wyświetli 0
            Add(4, 8);
            Add(1, 2, 3);
            Console.WriteLine("\nWywołanie funkcji 4-argumentowej:");
            Console.WriteLine(Add(1, 2, 3,4));
            //Console.WriteLine(Add(d:3, a:2));
            Console.WriteLine(Add(d:3, a:2, b:1));
            Console.ReadKey();
        }


        static void Show()
        {
            Console.WriteLine("WSB");
        }


        static int Show1()
        {
            return 0;
        }


        static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("\nWynik dodawania: {0} + {1} = {2} ",a,b,result);
        }

        //przeciążanie
        static void Add(int a, int b, int c)
        {
            int result = a + b + c; 
            Console.WriteLine("\nWynik dodawania: {0} + {1} + {2} = {3} ", a, b,c, result);
        }

        static int Add(int a, int b, int d, int c=5)
        {
            return a + b + c + d;
        }


    }
}
