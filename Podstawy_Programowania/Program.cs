using System;

namespace Kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WSB - kolokwium nr 1, Michał Olejnik");


            //prostokąt
            uint bok1=0;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPodaj długość pierwszego boku prostokąta:");
                string a1 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;

                try
                {
                    bok1 = uint.Parse(a1);
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Podana wartość: {0}, nie mieści się w zakresie (0;~4200 000 000)", a1);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podana wartość: {0}, nie jest liczbą całkowitą", a1);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Podana wartość (ctrl+z) = NULL");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("pierwszy bok: " + bok1);
            Console.ForegroundColor = ConsoleColor.White;


            uint bok2 = 0;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPodaj długość drugiego boku prostokąta:");
                string a2 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                try
                {
                    bok2 = uint.Parse(a2);
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Podana wartość: {0}, nie mieści się w zakresie(0; ~4200 000 000)", a2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podana wartość: {0}, nie jest liczbą całkowitą", a2);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Podana wartość (ctrl+z) = NULL");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("drugi bok: " + bok2);
            Console.ForegroundColor = ConsoleColor.White;
            //wiek

            uint wiek = 0;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPodaj wiek");
                string w = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;

                try
                {
                    wiek = uint.Parse(w);
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Podana wartość: {0}, nie mieści się w zakresie (0;~4200 000 000)", w);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podana wartość: {0}, nie jest liczbą całkowitą", w);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Podana wartość (ctrl+z) = NULL");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wiek: " + wiek);
            Console.ForegroundColor = ConsoleColor.White;

            //Menu


            Console.WriteLine("\n1. Pole prostokąta \n2. Wyświetl czy wiek jest liczbą parzystą \n3. Macierz \n4. Funkcja \n0. Wyjdź");
            uint choice = 0;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Wybierz zadanie: ");
                string c = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;

                try
                {
                    choice = uint.Parse(c);
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Podana wartość: {0}, nie jest liczbą całkowitą i nie znajduje się w zakresie możliwego wyboru ", c);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podana wartość: {0}, nie jest liczbą całkowitą", c);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Podana wartość (ctrl+z) = NULL");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Wybrane zadanie: {0}: ",choice);
            Console.ForegroundColor = ConsoleColor.White;

            switch (choice)
            {
                case 0:
                    break;

                case 1:
                    Console.Write("Pole prostokąta");
                    Console.Clear();
                    uint pole = 0;
                    pole = bok1 * bok2;
                    Console.WriteLine("Bok a: {0}",bok1);
                    Console.WriteLine("Bok b: {0}",bok2);
                    Console.WriteLine("Pole prostokąta: {0}",pole);
                    break;
                
                case 2:
                    Console.WriteLine("Podany wiek:" +wiek);
                    if (wiek % 2 == 0) { Console.WriteLine("parzysty"); }
                    else { Console.WriteLine("nieparzysty"); }
                    break;

                case 3:
                    
                    uint stopien = 0;
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Podaj stopień macierzy: ");
                        
                        string s = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        try
                        {
                            stopien = uint.Parse(s);
                            break;
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Podana wartość: {0}, nie mieści się w zakresie(0; ~4200 000 000)", s);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Podana wartość: {0}, nie jest liczbą całkowitą", s);
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Podana wartość (ctrl+z) = NULL");
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("stopień macierzy: " + stopien);
                    Console.ForegroundColor = ConsoleColor.White;
                    uint macierz = 0;
                    macierz = stopien * stopien;

                    string[] Tab = new string[macierz];
                    

                    for(int i=0; i<=macierz-1; i++)
                    {
                        if(i%stopien ==0 || i == 1)
                        {
                            Tab[i] = "WSB";
                        }
                        
                        
                    }


                    break;

                case 4:
                    Show();
                    break;

            }
           
        }


        public static void Show()
        {
            uint ilosc = 0;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPodaj ilosc osob:");
                string il = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;

                try
                {
                    ilosc = uint.Parse(il);
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Podana wartość: {0}, nie mieści się w zakresie (0;~4200 000 000)", il);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podana wartość: {0}, nie jest liczbą całkowitą", il);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Podana wartość (ctrl+z) = NULL");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ilosc: " + ilosc);
            Console.ForegroundColor = ConsoleColor.White;


            uint wiek = 0;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPodaj wiek osoby:");
                string age = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;

                try
                {
                    wiek = uint.Parse(age);
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Podana wartość: {0}, nie mieści się w zakresie (0;~4200 000 000)", age);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podana wartość: {0}, nie jest liczbą całkowitą", age);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Podana wartość (ctrl+z) = NULL");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ilosc: " + wiek);
            Console.ForegroundColor = ConsoleColor.White;

            string imie;
            while (true)
            {
                Console.WriteLine("\nPodaj imie osoby:");
                imie = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Imię: "+imie);
                Console.ForegroundColor = ConsoleColor.White;
            } 

            
        }
    }
}
