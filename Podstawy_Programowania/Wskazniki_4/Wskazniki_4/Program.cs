using System;

namespace Wskazniki_4
{
    class Program
    {

        struct Test
        {
           public int n;
        }


        unsafe static void Main(string[] args)
        {
            Test x = new Test();
            Test* p = &x;

            //przypisywanie wartości do wskaźnika
            // p->n=20;      lub         (*p).n=20;

            Console.WriteLine(x.n);
        }
    }
}
