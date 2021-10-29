using System;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            //AlgoExemple();
            Moyenne();
            Console.ReadKey(true);
        }

        static void AlgoExemple()
        {
            int A = 0,B = 0,Result = 0;
            Console.WriteLine("Valeur de A?");
            A = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n"+"Valeur de B?");
            B = Int32.Parse(Console.ReadLine());

            Result = A+B;
            Console.WriteLine("\n"+A+" + "+B+" = "+Result);
        }

        static void Moyenne()
        {
            double A = 0, B = 0, Result = 0;
            Console.WriteLine("Valeur de A?");
            A = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nValeur de B?");
            B = Int32.Parse(Console.ReadLine());

            Result = (A + B)/2;
            Console.WriteLine("\nLa moyenne est égale à "+Result);
        }
    }
}
