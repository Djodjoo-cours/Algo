using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double l_a = 0, l_b = 0;
            Console.WriteLine("A? -> ");
            l_a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B? -> ");
            l_b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n");

            //double l_result = Algo1(2,3);
            double l_cubeA = Cube(l_a);
            double l_cubeB = Cube(l_b);
            Console.WriteLine("Le cube de A = "+l_cubeA);
            Console.WriteLine("Le cube de B = "+l_cubeB);
        }

        static double Algo1(double a, double b) {
            double result = a + b;

            return result/2;
            //normalement il faut demander les valeurs
        }

        static double Cube(double a) {
            return Math.Pow(a, 3);
            //Math.Pow(nb, puissance)
        }
    }
}
