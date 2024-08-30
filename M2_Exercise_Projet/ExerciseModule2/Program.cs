using System.Diagnostics;
using System.Text;

class Program()
{
    const uint NOMBRE_ITERATIONS = 100000; // Le nombre d'itérations
    public static void Main(string[] args)
    {

        SortedList<int> arbreBinaire = new SortedList<int>();
        SortedSet<int> listeTrie = new SortedSet<int>();

        static void vitesseList(typeList) {
            Stopwatch sw = new Stopwatch(); // Pour évaluer le temps des opérations
                                            // On va concaténer les nombres de 0 à NOMBRE ITERATIONS-1 dans une
                                            // chaîne de caractères
            sw.Start();


            typeList<int> list = new typeList<int>();
            string premiereChaine = "";
            for (int i = 0; i < NOMBRE_ITERATIONS; i++)
            {
                //insertion au debut
                list.AddFirst(i);
            }
            sw.Stop();
            Console.WriteLine($"La concatenation a pris {sw.ElapsedMilliseconds} millisecondes");
            // On fait la même chose mais cette fois avec un StringBuilder
            sw.Restart();
            typeList<int> listB = new typeList<int>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < NOMBRE_ITERATIONS; i++)
            {
                listB.AddLast(i);
                //insertion a la fin
            }
            string deuxiemeChaine = sb.ToString();
            sw.Stop();
            Console.WriteLine($"L'utilisation de StringBuilder a pris {sw.ElapsedMilliseconds} millisecondes");
        }

        vitesseList(LinkedList);
    }
}
