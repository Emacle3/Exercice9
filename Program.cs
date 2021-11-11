/*
 * Exercice 9 : saisie d'une note
 * Author : Emma Caillé
 * Date : 09/11/2021
 */
using System;

namespace Exercice9
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration
            int note;

            // saisie de la note avec contrôle
            do
            {
                Console.Write("Entrez une note (entre 0 et 20) = ");
                note = int.Parse(Console.ReadLine());
            } while (note<0 || note>20);
           

            // affichage de la note correcte
            Console.WriteLine("note saisie = " + note);
            Console.ReadLine();
        }
    }
}
