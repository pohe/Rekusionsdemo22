using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekusionsdemo22
{
    public class RekTester
    {

        //Iterativ udgave
        public void Happy(int antal)
        {
            for (int i = 0; i < antal; i++)
            {
               Console.WriteLine("Jeg er lykkelig");
            }
        }


        //Rekursiv udgave

        public void Happy2(int antal)
        {
            if (antal>0)
            {
                Console.WriteLine("Jeg er lykkelig");
                Happy2(antal-1);
            }
        }

        //iterativ - lægge tallene sammen fra 0 til og med antal  
        public int Sum(int antal)
        {
            int s = 0;
            for (int i = 0; i <= antal; i++)
            {
                s += i;
            }
            return s;
        }

        //Rekursion - lægge tallene sammen fra 0 til og med antal 
        public int SumRek(int antal)
        {
            if (antal >0)
                return antal + SumRek(antal - 1);
            else
            {
                return 0;
            }
        }

        //Fakultet rekursivt

        public int Fak(int antal)
        {
            if (antal > 0)
                return antal * Fak(antal - 1);
            else
            {
                return 1;
            }
        }

        //Rekursiv fibonacci
        public int Fib(int antal)
        {
            if (antal >=3)
                return Fib(antal - 1) + Fib(antal - 2);
            else
                return 1;
        }

        //Returnerer om txt er en palindrom - rekursivt
        public bool Palindrom(string txt)
        {
            if (txt.Length <= 1)
                return true;
            else if (txt[0] == txt[txt.Length - 1]) 
                return Palindrom(txt.Substring(1, txt.Length - 2));
            else
                return false;
        }

    }
}
