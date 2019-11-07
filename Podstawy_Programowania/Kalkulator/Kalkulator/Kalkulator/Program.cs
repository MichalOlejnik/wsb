using System;

namespace Kalkulator
{
    class Program
    {
        public void TEST(string x, uint choice)
        {
            try
            {
                choice = uint.Parse(x);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4\n");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                Console.WriteLine("Zakres liczb: <0;4 294 967 295");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Wartość nie może być równa NULL");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator");
            Console.Write("Podaj liczbę całkowitą, do wyboru działania:\n" +
                "1.SUMA\n"+
                "2.RÓŻNICA\n"+
                "3.ILOCZYN\n"+
                "4.ILORAZ\n"+
                "5.MODULO\n");

            string x = Console.ReadLine();
            uint choice;
            TEST();
            Console.WriteLine("Podaj pierwszą liczbę: ");
            string Liczba1X = Console.ReadLine();
            double Liczba1;
            Liczba1 = double.Parse(Liczba1X);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Dodawnie");
                    break;
                case 2:
                    Console.WriteLine("Odejmowanie");
                    break;
                case 3:
                    Console.WriteLine("Mnożenie");
                    break;
                case 4:
                    Console.WriteLine("Dzielenie");
                    break;
                case 5:
                    Console.WriteLine("Modulo");
                    break;
                default:
                    break;
            }

        }
         Console.ReadKey();   
        }
    }
}
