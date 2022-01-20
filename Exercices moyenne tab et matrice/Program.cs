using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            //AlgoExemple();
            //Moyenne();
            //Moyenne2();
            // MoyenneTab();
            //Ex();
            //int[ , ] matrice = MoyenneMatriceRemplir(3);
            int[ , ] l_matrice = {{2,3}, {5,8}};
            AfficherMatrice(l_matrice);
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

        static void MoyenneTab()
        {
            int nb_notes = 0;
            double note = 0, moyenne = 0;

            Console.WriteLine("Combien de notes voulez-vous rentrer?");
            nb_notes = Int32.Parse(Console.ReadLine());

            double[] notes = new double[nb_notes];

            for(int i = 0; i < notes.Length; i++) {
                Console.WriteLine("\nEntrez la note "+ (i+1)+":");
                note = Convert.ToDouble(Console.ReadLine());
                notes[i] = note;
                moyenne += note;
            }

            Console.WriteLine("\nLa moyenne est de "+moyenne/notes.Length);

        }

        static int[ , ] MoyenneMatriceRemplir(int n) {
            int[ , ] matrice = new int[n,n];
            int value = 0;
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    Console.WriteLine("Entrez la valeur "+(j+1)+" de la ligne "+(i+1));
                    value = Int32.Parse(Console.ReadLine());
                    matrice[i,j] = value;
                    Console.WriteLine("\n");
                }
            }
            return matrice;
        }

        static void AfficherMatrice(int[ , ] matrice) {
            Console.WriteLine(matrice.Length);
            for(int i = 0; i < matrice.Length; i++) {
                Console.WriteLine(matrice[i]);
                /*for(int j = 0; j < matrice.Length; j++) {
                    Console.WriteLine(matrice[i,j]+" ");
                }*/
                //Console.WriteLine("\n");
            }
        }
    }
}
