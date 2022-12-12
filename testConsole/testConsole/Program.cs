using System;

/* 
 * Jeu du nb caché
 * auteur : Myo
 * date : 03/10/22
 */

namespace testConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Déclaration variable
            int valeur=0, essai, nb=1;
            bool correct = false;

            //Saisi chiffre à chercher
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }

                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier: ");
                }



             }
            
            Console.Clear();

            //Essai 2eme joueur
            
            Console.Write("Entrez un essai: ");
            essai = int.Parse(Console.ReadLine());

            //test essai par rapport à la valeur recherchée
            while (essai !=valeur)
            {
                if (essai > valeur)
                { Console.WriteLine("---> est trop grand!"); }
                else
                { Console.WriteLine("-->trop petit"); }

                //nouvel essai
                Console.Write("Entrez un essai: ");
                essai = int.Parse(Console.ReadLine());
                nb++;

            }

            // valeur trouvée
            Console.WriteLine("Bravo tu as déviné après "+nb+" essais!");
            Console.ReadLine();
        }
    }
}
