using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args) {
            const uint NOMBRE_ITERATIONS = 300000;
            const uint NOMBRE_PLACE = 10000;

            int[] tableau = new int [NOMBRE_PLACE];

            void BrasserTableau(int[] tableau)
            {
                Random rng = new Random(); for (int i = 0; i < tableau.Length; i++)
                {
                    int candidat = rng.Next(0, tableau.Length);
                    int temp = tableau[candidat];
                    tableau[candidat] = tableau[i];
                    tableau[i] = temp;
                }
            }
            SortedSet<int> arbreBinaire = new SortedSet<int>();
            SortedList<int, int> listeTriee = new SortedList<int, int>();

            void remplirListEnOrdre (SortedSet<int> list) {

                for (int i = 0; i < NOMBRE_PLACE; i++)
                {
                    listeTriee.Add(i, i);
                   // listeTriee.Add(i, i);
                   //arbreBinaire.Add(i);

                    ;
                }
                listeTriee.sort
            }

            
            


            
             void vitesseList()
            {
                Stopwatch sw = new Stopwatch(); // Pour évaluer le temps des opérations
                                                // On va concaténer les nombres de 0 à NOMBRE ITERATIONS-1 dans une
                                                // chaîne de caractères
                sw.Start();


               
                string premiereChaine = "";
                for (int i = 0; i < NOMBRE_ITERATIONS; i++)
                {
                    
                    tableau [i] = i;

                    //insertion au debut
                    
                }
                 BrasserTableau(tableau);

                 BrasserTableau(tableau);

                for (int i = 0; i < NOMBRE_ITERATIONS; i++)
                {

                    tableau[i] = i;

                    //insertion au debut
                    
                }

                sw.Stop();
                Console.WriteLine($"La concatenation a pris {sw.ElapsedMilliseconds} millisecondes");
                // On fait la même chose mais cette fois avec un StringBuilder
                
                sw.Restart();
                SortedSet<int> arbreBinaire = new SortedSet<int>();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < NOMBRE_ITERATIONS; i++)
                {
                    

                    BrasserTableau(tableau);
                }
                string deuxiemeChaine = sb.ToString();
                sw.Stop();
                Console.WriteLine($"L'utilisation de StringBuilder a pris {sw.ElapsedMilliseconds} millisecondes");
            }

            void compareVitesse(int[] tableau) { 


            
            
            }




        }    

    }
}
