using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_instukcjeWarunkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = -5;

            if (x > 3)
            {
                Console.WriteLine("prawda");
            }

            else if (x==-5)
            {
                Console.WriteLine("x równy -5");
            }

            else
            {
                Console.WriteLine("inna");
            }

            Console.ReadKey();
            */


            /*ZADANIE: oblicz pole trójkąta-->

            Console.Write("Podaj podstawę trójkąta");
            string podstawa= Console.ReadLine();
            Console.Write("Podaj wysokość trójkąta");
            string wysokosc = Console.ReadLine();
            //double x1 = double.Parse();

            double podstawa1, wysokosc1, pole;


            if (double.TryParse(podstawa, out podstawa1) && (double.TryParse(wysokosc, out wysokosc1)))    //zabezpieczenie przed podaniem błędnych danych, no tekstu

            {
                //obliczenie pola trójkąta
               
                pole= 0.5 * podstawa1 * wysokosc1;
                Console.WriteLine("\nDługość podstawy: {0}, wysokość: {1}", podstawa1, wysokosc1);
                Console.WriteLine("Pole trójkąta wynosi: {0}", pole); //lub "Pole trojkąta wynosi:" + pole +...
            }

            else
            {
                Console.WriteLine("Error! Błędne dane");
            }
            */


            //SWITCH

            /*

            Console.WriteLine("1 - pole kwadratu\n2 - pole koła");
            Console.Write("\nPodaj wartość:");

            string x;
            double kolo, kwadrat;

            x = Console.ReadLine();
            switch (x)
            {
                case "2":
                    Console.WriteLine("1");

                    Console.Write("Podaj promień koła: ");
                    string promien = Console.ReadLine();
                    double promien1;
                    if (double.TryParse(promien, out promien1))
                    {

                        kolo = Math.PI * promien1 * promien1;
                      Console.WriteLine("\nPromien: {0}" , promien1);
                        Console.WriteLine("Pole kola wynosi: {0}", kolo);
                    }
                    else
                    {
                        Console.WriteLine("podałeś błędne dane");
                     
                    }
                break;

                case "1":
                    Console.WriteLine("2");

                    Console.WriteLine("Podaj długość boku kwadratu:");
                    string bok= Console.ReadLine();
                    double bok1;
                    if (double.TryParse(bok, out bok1))
                    {

                        kwadrat = bok1 * bok1;
                        Console.WriteLine("\nbok: {0}", bok1);
                        Console.WriteLine("Pole kola wynosi: {0}", kwadrat);
                    }

                    else
                    {
                        Console.WriteLine("podałeś błędne dane");

                    }
                    break;
            }
            */

            //ITERACJE FOR
            
            // wyświetl liczby z przedaziału <1;10>


            for( int i = 1; i<=10; i++)
            {
                Console.Write("{0} ", i); //szybsza niż (i+ " " + i)     //"{0} = spacja między liczbami
            }

            // wyświetl liczby parzyste z przedaziału <5;20>

            for (int i = 20; i >=5 ; i--)       //i++    i=i+1
            {
                if (i % 2 == 0)
                {
                    Console.Write("\n{0} ", i);
                }
            }

            //choinka  
            Console.Write("Podaj wysokość choinki: ");
            string ile=Console.ReadLine();
            double ile1;
            

            if (double.TryParse(ile, out ile1))
            {
              
             
               ile1 = Console.ReadLine();
                for (int i = 0; i < ile1; i++)
                {
                    Console.WriteLine("*");
                }
                   // for (int j = 0; i < ile1; j++) ;
            }

            

            Console.ReadKey();

        }
    }
}
