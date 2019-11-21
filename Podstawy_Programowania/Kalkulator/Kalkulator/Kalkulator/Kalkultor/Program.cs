using System;

namespace Kalkultor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 = Dodawanie, \n2 = odejmowanie, \n3 = mnożenie, \n4 = dzielenie");
            uint choice;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWprowadz liczbe calkowita: ");
                string x = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
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
               
                catch (ArgumentException)
                {
                    Console.WriteLine("Wartość nie może być pusta");
                }

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLiczba całkowita: {0}", choice);

            Console.ResetColor();
        
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Dodawanie");
                   
                    uint liczba1;
                    while (true)
                    {
                        Console.WriteLine("\nWprowadz liczbę1, na której zostanie przeprowadzona operacja: ");
                        string Liczba1X = Console.ReadLine();
                        try
                        {
                            liczba1 = uint.Parse(Liczba1X);
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

                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta");
                        }

                    }
            

            uint liczba2;
            while (true)
            {
                Console.WriteLine("\nWprowadz liczbę2, na której zostanie przeprowadzona operacja: ");
                string Liczba2X = Console.ReadLine();
                try
                {
                    liczba2 = uint.Parse(Liczba2X);
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

                catch (ArgumentException)
                {
                    Console.WriteLine("Wartość nie może być pusta");
                }
            }


                    uint suma=0;
                    suma = liczba1 + liczba2;
                    Console.WriteLine("Wynik dodawania: " + suma);
                break;
                case 2:
                    Console.WriteLine("Odejmowanie");
                    
                    while (true)
                    {
                        Console.WriteLine("\nWprowadz liczbę1, na której zostanie przeprowadzona operacja: ");
                        string Liczba1X = Console.ReadLine();
                        try
                        {
                            liczba1 = uint.Parse(Liczba1X);
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

                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta");
                        }

                    }


                    
                    while (true)
                    {
                        Console.WriteLine("\nWprowadz liczbę2, na której zostanie przeprowadzona operacja: ");
                        string Liczba2X = Console.ReadLine();
                        try
                        {
                            liczba2 = uint.Parse(Liczba2X);
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

                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta");
                        }
                    }

                    uint roznica = 0;
                    roznica = liczba1 - liczba2;
                    Console.WriteLine("Różnica wprowadzonyczh liczb: "+roznica);

                    break;
                case 3:
                    Console.WriteLine("Mnożenie");
                    
                    while (true)
                    {
                        Console.WriteLine("\nWprowadz liczbę1, na której zostanie przeprowadzona operacja: ");
                        string Liczba1X = Console.ReadLine();
                        try
                        {
                            liczba1 = uint.Parse(Liczba1X);
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

                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta");
                        }

                    }


                   
                    while (true)
                    {
                        Console.WriteLine("\nWprowadz liczbę2, na której zostanie przeprowadzona operacja: ");
                        string Liczba2X = Console.ReadLine();
                        try
                        {
                            liczba2 = uint.Parse(Liczba2X);
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

                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta");
                        }
                    }

                    uint mnozenie = 0;
                    mnozenie = liczba1 * liczba2;
                    Console.WriteLine("Wynik Mnożenia: "+mnozenie);
                    break;
                case 4:
                    Console.WriteLine("Dzielenie");

                    
                    while (true)
                    {
                        Console.WriteLine("\nWprowadz liczbę1, na której zostanie przeprowadzona operacja: ");
                        string Liczba1X = Console.ReadLine();
                        try
                        {
                            liczba1 = uint.Parse(Liczba1X);
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

                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta");
                        }

                    }


                    
                    while (true)
                    {
                        Console.WriteLine("\nWprowadz liczbę2, na której zostanie przeprowadzona operacja: ");
                        string Liczba2X = Console.ReadLine();
                        try
                        {
                            liczba2 = uint.Parse(Liczba2X);
                            break;
                        }

                        catch (FormatException)
                        {
                            Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4\n");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Attempted divide by zero. {0}", ex.Message);
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                            Console.WriteLine("Zakres liczb: <0;4 294 967 295");
                        }

                        catch (ArgumentException)
                        {
                            Console.WriteLine("Wartość nie może być pusta");
                        }
                    }
                    uint dzielenie = 0;
                    dzielenie = liczba1 / liczba2;
                    Console.WriteLine("wynik dzielenia: " + dzielenie);
                    break;
                


            }
            Console.ReadKey();
        }

    }
}