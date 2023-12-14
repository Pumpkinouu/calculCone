using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volumeCone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Déclaration des variables ////

            int intHauteur = 0;      // Stock la valeur de la hauteur
            double dblRayon = 0;     // Stock la valeur du rayon
            bool refaire = true;     // Valeur réel qui est égal a True
            string oui = "o";        // Variable oui qui est égale à 'o'

            //// Programme principal ////
            do
            {
                // Affichage du titre
                Titre();

                // Demande à l'utilsateur de rentrer la valeur de la hauteur
                Console.Write("\nEntrer la hauteur du cône :");
                intHauteur = Convert.ToInt32(Console.ReadLine());

                // Demande à l'utilisateur de rentrer la valeur du rayon
                Console.Write("Entrer le rayon du cône :");
                dblRayon = Convert.ToDouble(Console.ReadLine());

                // Affiche le volume avec du cône calculer avec les valeurs saisie par l'utilisateur
                Console.Write("\nLe volume du cône est " + CalculerVolumeCone(intHauteur, dblRayon));

                // Demande à l'utilisateur si il aimerait recommencer le programme 
                Console.Write("\nvoulez vous refaire le programme ? (o/n):");

                if (oui == Console.ReadLine())
                {
                    refaire = true;
                }
                else
                {
                    refaire = false;
                }
                Console.Clear();

            } while (refaire == true);
        }

        /// <summary>
        /// Affichage du titre
        /// </summary>
        static void Titre()
        {

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*         Calculer le volume d'un cône (Danilo Zivanovic)         *");
            Console.WriteLine("*******************************************************************");
        }

        /// <summary>
        /// Méthode pour calculer un volume d'un cône
        /// </summary>
        /// <param name="intMHauteur"></param>
        /// <param name="dblMRayon"></param>
        /// <returns></returns>
        static double CalculerVolumeCone(int intMHauteur, double dblMRayon)
        {
            return (Math.PI * (Math.Pow(dblMRayon, 2) * intMHauteur) / 3);
        }
    }
}
