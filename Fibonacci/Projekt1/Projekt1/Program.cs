using System;
using System.Diagnostics;
namespace ProjektWzorcowy
{
    class Program
    {
        static uint fib(uint n)
        {
            switch (n)
            {
                case 0: return 1;
                case 1: return 1;
                default: return fib(n - 1) + fib(n - 2);
            }
        } /* fib() */
        static void Main(string[] args)
        {
            const int NIter = 10; // liczba powtórzeń testu
            Console.WriteLine("n\tt[s]");
            for (uint u = 30; u < 48; u++)
            {
                double ElapsedSeconds;
                long ElapsedTime = 0, MinTime = long.MaxValue, MaxTime = long.MinValue, IterationElapsedTime;
                for (int n = 0; n < (NIter + 1 + 1); ++n) // odejmujemy wartości skrajne
                {
                    long StartingTime = Stopwatch.GetTimestamp(); //pobieranie znacznika czasowego - pomiar czasu byłby bez sensu
                    ulong r = fib(u);                             //wykonujemy - tu wklejamy badany kod
                    long EndingTime = Stopwatch.GetTimestamp();   //odczytujemy czas  
                    IterationElapsedTime = EndingTime - StartingTime;
                    ElapsedTime += IterationElapsedTime;
                    //Console.Write("Iter[" + n + "]:" + IterationElapsedTime + "\t");
                    if (IterationElapsedTime < MinTime) MinTime = IterationElapsedTime;
                    if (IterationElapsedTime > MaxTime) MaxTime = IterationElapsedTime;
                }
                ElapsedTime -= (MinTime + MaxTime);
                ElapsedSeconds = ElapsedTime * (1.0 / (NIter * Stopwatch.Frequency));
                Console.WriteLine("{0}\t{1}", u, ElapsedSeconds.ToString("F4"));
            }
        }
    }
}
// pomiar czasu wykonania ciągu
