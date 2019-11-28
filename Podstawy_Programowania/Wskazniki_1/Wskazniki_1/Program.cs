using System;

namespace Wskazniki_1
{
    class Program
    {
        unsafe static void Main(string[] args)  //przy wskaźnikach dodajemy unsafe!
        {
            char* x;            //w Projekt-->właściwości--> kompilacja--> zezwalaj na niebezpieczny kod
            char letter = 'x';
            x = &letter;        // x ma teraz przypisany adres zmiennej letter, & - operator adresowania
            letter = 'a';
            //2 sposoby wyświetlania
            //*- operator zwracający zmienną przechowywaną
            Console.WriteLine("znak: {0}", letter);
            Console.WriteLine("znak: {0}", *x);     //pamiętaj o * przed x, * - kopiuje wartość danej zmiennej
            //Console.WriteLine("Adres w pamięci zmiennej letter: {0:x} ", (int)x); //zamiana na HEX

            int test = 10;
            Console.WriteLine(Convert.ToString(test, 8));   //zamiana na ósemkowy

            double number;
            double* numberAddress;
            numberAddress = &number;

            number = 10;
            Console.WriteLine("Liczba wynosi: {0}", number);
            Console.WriteLine("Liczba wynosi: {0}", numberAddress->ToString());       //Operator wskaźnika do składowej "->"
            Console.WriteLine("Adres w pamięci zmiennej letter: {0} ", (int)numberAddress);

            Console.ReadKey();
        }
    }
}
