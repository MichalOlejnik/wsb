using System;

namespace Tablice_zajecia_4
{
    class Program
    {
        static void Main(string[] args)
        {

            // WYŚWIETLANIE TABLICY WIELOWYMIAROWEJ
            /*
            int[,] values = new int[4,4]
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 },
                {9, 10, 11, 12 },
                {13, 14, 15, 16 },
            };

            for(int i=0; i<4; i++)
            {
                for (int j=0; j < 4; j++)
                {
                    Console.Write("\t"+values[i,j]);
                }
                Console.WriteLine("");
            }
            */


            //DNI TYGODNIA W TABELCE

            string[,] DZIEN = new string[7, 3];
            string i1;
           
            for(int i=0; i<7; i++)
            {
                i1 = (i+1).ToString();
                DZIEN[i, 0] = i1;
                
                Console.WriteLine("Podaj nazwę dnia tygodnia nr:{0}, po polsku", i+1);
                DZIEN[i, 1] = Console.ReadLine();
               
                Console.WriteLine("Podaj nazwę dnia tygodnia nr:{0}, po angielsku", i+1);
                DZIEN[i, 2] = Console.ReadLine();
                    
            }
            for(int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                Console.Write(DZIEN[i,j]+ " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
            



        }
    }
}
