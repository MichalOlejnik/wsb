using System;

namespace wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number; 
            while (true)        //while-break wprowadzaj wartość tak długo, aż liczba całkowita
            {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nWprowadź liczbę całkowitą: ");
            string x = Console.ReadLine();

            


                try
                {
                    number = uint.Parse(x);        //Try.Parse - jeśli wprowadzona wartość nie jest liczbą całkowitą
                    break;
                }
                
                catch (SystemException e)            //tu sprawdzamy jakie są wyjątki, po kolei
                {
                    //Console.ForegroundColor = ConsoleColor.Red; //zmień kolor tekstu na (czerwony)
                    //Console.WriteLine("Error"); 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                   
                    Console.WriteLine("Wprowadzona wartość nie jest liczbą całkowitą:{0}", x);
                    
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Prawidłowe dane:{0} ", number);
            
            Console.ReadKey();
        }

        
    }
}
