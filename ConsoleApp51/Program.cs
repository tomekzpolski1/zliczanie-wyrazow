using System;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst");
            string tekst = Console.ReadLine();
            int liczbawyrazow = 1;
            foreach (char litera in tekst)
            {
                if ( litera == ' ')
                {
                    liczbawyrazow++;
                }
            }
            Console.WriteLine("Liczba wyrazów w tekscie to : {0}", liczbawyrazow );
        }
    }
}
