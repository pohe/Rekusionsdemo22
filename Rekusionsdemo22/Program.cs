using System;
using System.Threading.Channels;

namespace Rekusionsdemo22
{
    class Program
    {
        static void Main(string[] args)
        {
            RekTester rek = new RekTester();

            //rek.Happy(10);
            rek.Happy2(10);


            //samle resultatet op
            int resultat = rek.Fib(8);

            //Print resultatet
            Console.WriteLine($"Resultatet er {resultat}");

            string txt = "Regn in ger";
            //kald og opsamling af resultatet
            bool resul  = rek.Palindrom(txt.ToLower().Replace(" ", ""));

            //udskriv om det er en palindrom
            Console.WriteLine($"Er {txt} et palindrom {resul}");

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
