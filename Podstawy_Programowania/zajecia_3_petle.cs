using System;

namespace zajecia_3_petle
{
    class Program
    {
        static void Main(string[] args)
        {
            // polecamy stronę: w3resource.com      c#

            /*napisz program, który za pomocą instrukcji do while 
             * dla danych wartośći zmieniających się w przedziale
             * od 0 do 15, oblicza wartość funkcji y=4x */

            /*    Console.WriteLine("y=4x");
                int x=0;
                do
                {
                    Console.WriteLine("y Dla x=" + x + ":" + 4 * x);
                    x++;
                }
                while (x <= 15);

            */

            /*
                //Tabliczka mnożenia
                Console.WriteLine("Tabliczka mnożenia");
                int x = 1, y = 1;
                do
                {
                    y = 1;
                    do
                    {
                        Console.Write("\t " + x * y);
                        y++;
                    } while (y <= 10);
                    Console.Write("\n");
                    x++;
                } while (x <= 10);

            */

            //Oblicz wartość wyrażenia y=(a^2+b)/(b+a)^2


            /*
            double a1, b1;

            Console.WriteLine("podaj wartość a:");

            string a = Console.ReadLine();
            if (double.TryParse(a, out a1))
            {
                Console.WriteLine("podaj b:");
                string b = Console.ReadLine();
                if (double.TryParse(b, out b1))
                {
                    Console.WriteLine("wynik działania: (a^2+b)/(b+a)^2:   " + (a1 * a1 + b1) / ((a1 + b1) * (a1 + b1)));


                }
                else
                {
                    Console.WriteLine("wprowadzone b nie jest liczbą");
                }

            }
            else
            {
                Console.WriteLine("wprowadzone a nie jest liczbą");
            }
            */

            //zadanie 2, pdf z zajęć
            /*
             * Wykorzystując zmienne typu double obliczyć wartość wyrażenia wynoszącą:
             * a^2+b dla c>0
             * a-b^2 dla c<0
             * 1/(a-b) dla c=0
            */


            Console.WriteLine("Wprowadź a: ");
            string a1 = Console.ReadLine();
            double a;
            if (double.TryParse(a1, out a))
            {
                Console.WriteLine("Wprowadź b: ");
                string b1 = Console.ReadLine();
                double b;
                if (double.TryParse(b1, out b))
                {
                    Console.WriteLine("wprowadź c: ");
                    string c1 = Console.ReadLine();

                    double c;
                    int wybór;

                    if (double.TryParse(c1, out c))
                    {
                        if (c < 0)
                        {
                            wybór = 1;
                        }
                        else if (c == 0)
                        {
                            wybór = 2;
                        }
                        else
                        {
                            wybór = 3;
                        }

                        switch (wybór)
                        {
                            case 1:
                                Console.WriteLine("Dla c<0: a-b^2:  " + (a - b * b));
                                break;

                                case 2:
                                    Console.WriteLine("Dla c=0: 1/(a-b) " + (1 / (a - b)));
                                break;

                                case 3:
                                    Console.WriteLine("Dla c>0: a^2+b " + (a * a + b));
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("wprowadzone c nie jest liczbą");
                    }
                }
                else
                {
                    Console.WriteLine("Wprowadzone b nie jest liczbą");
                }

            }
            else
            {
                Console.WriteLine("wprowadzone a nie jest liczbą");
            }

            





Console.ReadKey();
}
}
}
