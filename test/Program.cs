using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = genererTab();

            afficherTab(triBulle(tab));
        }

        static double Algo1(double a, double b) {
            double result = a + b;

            return result/2;
        }

        static double Cube(double a) {
            return Math.Pow(a, 3);
            //Math.Pow(nb, puissance)
        }

        static int[] triBulle(int[] pTab) {
            bool tri = false;
            int borne = 0;
            while(tri == false) {
                tri = true;
                borne++;
                for(int i = 0; i < pTab.Length - borne; i++) {
                    if (pTab[i] > pTab[i+1]) {
                        /*int temp = pTab[i];
                        pTab[i] = pTab[i+1];
                        pTab[i+1] = temp;*/
                        pTab[i] = echanger(pTab[i], pTab[i+1])[0];
                        pTab[i+1] = echanger(pTab[i], pTab[i+1])[1];
                        tri = false;
                    }
                }
            }

            return pTab;
        }

        static int[] echanger(int p1, int p2) {
            int[] tab = new int[2];
            int temp = p1;
            p1 = p2;
            p2 = temp;

            tab[0] = p1;
            tab[1] = p2;

            return tab;
        }

        static void afficherTab(int[] pTab) {
            foreach(int elmt in pTab) {
                Console.WriteLine(elmt);
            }
        }

        static int[] genererTab() {
            int[] tab = new int[50];

            for(int i = 0; i < tab.Length; i++) {
                Random value = new Random();
                tab[i] = value.Next(0,50);
            }

            return tab;
        }
    }
}
