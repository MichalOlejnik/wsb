using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;

namespace pliki
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo wsbDir = new DirectoryInfo(".");
            Console.WriteLine(wsbDir.FullName);

            DirectoryInfo studentDir = new DirectoryInfo(@"C:\Users\Student\Desktop");//gdzie chcemy przechowywać nasze pliki/ @- nie trzeba 2x "\"
            //studentDir przechowuje info o lokalizacji
            Console.WriteLine(studentDir.FullName); //pokazuje całą ścieżkę
            Console.WriteLine(studentDir.Name);     //pokazuje folder, w którym aktualnie się znajdujemy
            Console.WriteLine(studentDir.Parent);
            Console.WriteLine(studentDir.Attributes);
            Console.WriteLine(studentDir.CreationTime);//czas powstania 
            
            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\Student\C#Files");

            string[] customers =
            {
                "Agnieszka Nowak",
                "Anna Nowak",
                "Tomasz Kowalski",
            };

            //czy uda sie utworzyć katalog


            string path = @"C:\Users\student\C#Files";  //ścieżka
            //wyjątki
            try
            {


                if (Directory.Exists(path))
                {
                    Console.WriteLine("Katalog istnieje");
                }
                else
                {
                    Directory.CreateDirectory("\\Users\\student\\C#Files"); //Sposob bez @, tworzenie folderu
                    string textFilePath = @"C\Users\student\C#Files\testFile1.txt";
                    File.WriteAllLines(textFilePath, customers);        //zapisuje zawartość customers w textFilePath (testFile1.txt)


                    Console.WriteLine("\nutworzono katalog: {0}", Directory.GetCreationTime(path));

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }

            //czy chcesz usunąć katalog 1-Tak, 0-Nie, Jesli tak-sprawdamy czy został usunięty+ komunikat czy udało się usunąć
            if (Directory.Exists(path))
            {
                Console.WriteLine("\n\nCzy chcesz usunąć katalog? 1-true 0-false");
                string delete = Console.ReadLine();

                if (delete == "1")
                {
                    Directory.Delete(path, true);
                    if (Directory.Exists(path)) //upewnić się, jeśli prawda tzn ze katalogu juz nie ma 
                    {
                        Console.WriteLine("katalogu już nie ma");
                    }
                }
                else
                {
                    Console.WriteLine("nie usunąłeś katalogu" );
                }
            }

            Console.ReadKey();
        }
    }
}
