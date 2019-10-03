using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_1
{
    class Program
    {
        static void Main(string[] args)
        {





            /*komentarz*/
            Console.WriteLine("Janusz");        //cout ze spacja , write - bez spacji
            Console.ReadKey();                  //Wciśnięcie klawisza powoduje zakończenie programu     cin??

            //zmienne i typy danych
            int x;  //liczby całkowite
            x = 15;
            Console.WriteLine(x);

            int x1, y = 10, z = 15;
            x1 = 2;

            Console.Write("zmienna x1 wnosi: ");
            Console.WriteLine(x1);

            //Konkatenacja
            // \n - nowa linia
            Console.WriteLine("y= " + y + "\nz= " + z);

            int a = 10;
            int b = a;
            b = 15;
            Console.WriteLine(a + " " + b);

            //alternatywny sposob deklaracji zmiennej
            // int c=0;

            int c = new int(); //wartość domyslna ==> null (brak referencji)
            Console.WriteLine("wartość zmiennej c:" + c);

            Console.Write("Podaj imie");
            string name = Console.ReadLine();
            Console.WriteLine("twoje imie podane z klawiatury" + name);

            int z1 = -12;
            uint z2 = 20;   //unsigned int
            float y1=10.55F;

            Console.WriteLine("Zmienna y1= " + y1);






            //ZADANIE
            //Pole prostokąta- dane podaje użytkownik

            Console.WriteLine("podaj bok1");
            double bok1 = double.Parse(Console.ReadLine());


            Console.WriteLine("podaj bok2");
            double bok2= double.Parse(Console.ReadLine());
            double result = bok1 * bok2;
            Console.WriteLine("pole kwadratu wynosi:"+ result);




        }
    }
}
