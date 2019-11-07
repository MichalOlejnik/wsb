using System;

namespace Zadanie_wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = 10;
            try
            {
            Console.Write("Podaj dzień tygodnia (1-5)");

            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine("x = {0}", x);
            }

            //****************************************************

            switch (x)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:         //Pierwszy własny wyjątek
                    throw new System.Exception("Masz już weekend, DO DOMU!");
                    break;
                case 7:
                    throw new System.Exception("Masz już weekend, NIEDZIELA");
                    break;
                default:
                    Console.WriteLine("Przedział 1-5");
                    break;


            }
            Console.ReadKey();
        }

    }
}
