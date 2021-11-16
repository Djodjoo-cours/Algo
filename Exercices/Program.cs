using System;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            //AlgoExemple();
            //Moyenne();
            Moyenne2();
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
            A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nValeur de B?");
            B = Convert.ToDouble(Console.ReadLine());

            Result = (A + B)/2;
            Console.WriteLine("\nLa moyenne est égale à "+Result);
        }

        static void Moyenne2()
        {
            int A = 0, B = 0;
            double Result = 0;
            Console.WriteLine("Valeur de A?");
            A = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nValeur de B?");
            B = Int32.Parse(Console.ReadLine());

            Result = (double)(A + B)/2;
            //(double) préciser que le calcul est en double
            Console.WriteLine("\nLa moyenne est égale à "+Result);
        }
    }
}
