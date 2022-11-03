using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrice();
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

        static void Matrice() {
            Console.WriteLine("Saisissez le coefficient de votre matrice carré: ");
            int lengthMatrice = Int32.Parse(Console.ReadLine());

            int[ , ] matrice = new int[lengthMatrice,lengthMatrice];
            int value = 0;
            for(int i = 0; i < lengthMatrice; i++) {
                for(int j = 0; j < lengthMatrice; j++) {
                    Console.WriteLine("Entrez la valeur "+(j+1)+" de la ligne "+(i+1));
                    value = Int32.Parse(Console.ReadLine());
                    matrice[i,j] = value;
                    Console.WriteLine("\n");
                }
            }
            AfficherMatrice(matrice, lengthMatrice);

            bool testSymetrie = estSymetrique(matrice, lengthMatrice);
            bool testAntisymetrie = estAntisymetrique(matrice, lengthMatrice);

            if(testSymetrie == true) {
                Console.WriteLine("La matrice est symétrique");
            } else if(testAntisymetrie == true) {
                Console.WriteLine("La matrice est antisymétrique");
            } else {
                Console.WriteLine("La matrice est ni symétrique ni antisymétrique");
            }
        }

        static void AfficherMatrice(int[ , ] matrice, int length) {
            string result = "";
            for(int i = 0; i < length; i++) {
                result += "| ";
                for(int j = 0; j < length; j++) {
                    result += matrice[i,j] + " | ";
                }
                result += "\n";
            }
            Console.WriteLine(result);
        }

        static Boolean estPalindrome(string pMot) {
            char[] tabMot = pMot.ToCharArray();
            char[] tabMotInverse = new char[pMot.Length];
            int index = 0;

            for(int i = pMot.Length-1; i >= 0; i--) {
                tabMotInverse[index] = tabMot[i];
                index++;
            }
            
            for(int j = 0; j < tabMot.Length; j++) {
                if(tabMot[j] != tabMotInverse[j]) {
                    return false;
                }
            }
            return true;
        }

        static bool estSymetrique(int[ , ] p_matrice, int length) {
            bool res = true;

            for(int i = 0; i < length; i++) {
                for(int j = 0; j < length; j++) {
                    if(p_matrice[j,i] != 0 && p_matrice[i,j] != p_matrice[j,i]) {
                        res = false;
                    }
                }
            }

            return res;
        }

        static bool estAntisymetrique(int[ , ] p_matrice, int length) {
            bool res = true;

            for(int i = 0; i < length; i++) {
                for(int j = 0; j < length; j++) {
                    if(p_matrice[j,i] != 0 && p_matrice[i,j] != (-p_matrice[j,i])) {
                        res = false;
                    }
                }
            }

            return res;
        }

    }
}