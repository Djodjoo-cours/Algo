using System;

namespace Algo_du_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mystere1();
            //Mystere2();
            //Comptage();
            double [,] l_tab = new double[2,2]{ {1,2}, {5,6} };
            Matrice();
            //afficherMatrice(l_tab);
            Console.ReadKey(true);
        }

        static void Mystere1() {
            int n = 0;
            double note;

            Console.WriteLine("Combien de notes voulez-vous saisir? ");
            n = Int32.Parse(Console.ReadLine());
            double[] tab = new double[n];

            for(var i = 0; i < n; i++) {
                Console.WriteLine("\nSaisissez la "+(i+1)+"ème/ère note: ");
                tab[i] = Convert.ToDouble(Console.ReadLine());
            }
            note = tab[0];
            for(int i = 0; i < n; i++) {
                if(tab[i] > note) {
                    note = tab[i];
                }
            }
            Console.WriteLine("La meilleure note est: "+note);
        }

        static void Mystere2() {
            double a = 0, b = 0, c = 0, delta = 0, x0 = 0, x1 = 0, x2 = 0;

            Console.WriteLine("Saisir le coefficient a ?");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSaisir le coefficient b ?");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSaisir le coefficient c ?");
            c = Convert.ToDouble(Console.ReadLine());

            delta = b*b-4*a*c;
            if(delta > 0) {
                x1 = (-b - Math.Sqrt(delta))/2*a;
                x2 = (-b + Math.Sqrt(delta))/2*a;
                Console.WriteLine("\nLes 2 racines sont: "+x1+" et "+x2);
            } else if (delta == 0) {
                x0 = -b/2*a;
                Console.WriteLine("\nLa seul racine est: "+x0);
            } else {
                Console.WriteLine("\nIl n'y a pas de racine");
            }
        }

        static void Comptage() {
            int n = 0, cumul = 0, nb_valeurs_sup = 0;
            double moy = 0, pourcent = 0;

            Console.WriteLine("Combien d'entiers voulez-vous saisir? ");
            n = Int32.Parse(Console.ReadLine());
            int[] tab = new int[n];

            for(int i = 0; i < n; i++) {
                Console.WriteLine("\nSaisissez la "+(i+1)+"ème/ère valeur: ");
                tab[i] = Int32.Parse(Console.ReadLine());
                cumul += tab[i];
            }
            moy = cumul/n;
            for(int j = 0; j < n; j++) {
                if(tab[j] > moy) {
                    nb_valeurs_sup += 1;
                }
            }
            pourcent = (nb_valeurs_sup*100)/n;
            Console.WriteLine(pourcent+"%");
        }

        static async void afficherMatrice(double[,] p_tab, int p_nbPassage) {
            string res = "| ";
            for (int i = 0; i < p_tab.Length/p_nbPassage; i++) {
                //int passage = 1;
                /*double val1 = 0, val2 = 0;
                for (int j = 0; j < p_tab.Length/p_nbPassage; j++) {
                    if(passage == p_nbPassage) {
                        val2 = p_tab[i,j];
                        passage = 0;
                    } else {
                        passage++;
                        val1 = p_tab[i,j];
                    } 
                }
                Console.WriteLine("| "+val1+" - "+val2+" |");*/
                for (int j = 0; j < p_tab.Length/p_nbPassage; j++) {
                    if (j == p_nbPassage -1) {
                        res += p_tab[i,j]+" |\n| ";
                    } else {
                        res += p_tab[i,j]+" ";
                    }
                }

            }
            Console.WriteLine(res);
        }

        static void moyenneMatrice(double[,] p_tab, int p_nbPassage) {
            double cumul = 0, moyenne = 0;
            for(int i = 0; i < p_tab.Length/p_nbPassage; i++) {
                for(int j =0; j < p_tab.Length/p_nbPassage; j++) {
                    cumul += p_tab[i,j];
                }
            }
            moyenne = cumul/p_tab.Length;
            Console.WriteLine("La moyenne est de "+moyenne);
        }
        
        static void pourcentageMatrice(double[,] p_tab, int p_nbPassage) {
            double cumul = 0, moyenne = 0;
            for(int i = 0; i < p_tab.Length/p_nbPassage; i++) {
                for(int j =0; j < p_tab.Length/p_nbPassage; j++) {
                    cumul += p_tab[i,j];
                }
            }
            moyenne = cumul/p_tab.Length;

            double percent = 0;
            for(int i = 0; i < p_tab.Length/p_nbPassage; i++) {
                for(int j =0; j < p_tab.Length/p_nbPassage; j++) {
                    if(p_tab[i,j] > moyenne) {
                        percent ++;
                    }
                }
            }
            Console.WriteLine("Pourcentage de valeurs au-dessus de la moyenne: "+((percent*100) / p_tab.Length)+"%");
        }

        static void Matrice() {
            Console.WriteLine("Entrez la taille de votre matrice carrée: ");
            int n = Int32.Parse(Console.ReadLine());

            double [,] l_tab = new double[n,n];

            for(int i = 0; i < n; i++) {
                for(int j =0; j < n; j++) {
                    Console.WriteLine("\nEntrez la "+(j+1)+" ère/ème valeur de la "+(i+1)+" ère/ème ligne: ");
                    l_tab[i,j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            Console.WriteLine("\n");
            afficherMatrice(l_tab, n);
            moyenneMatrice(l_tab, n);
            pourcentageMatrice(l_tab, n);
        }
    }
}
