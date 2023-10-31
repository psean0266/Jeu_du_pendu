using System;
using System.Collections.Generic;

namespace Jeu_du_pendu
{
    internal class Program
    {

        static void AfficherMot(string mot, List<char> lettres)
        {
  
           for (int i = 0; i < mot.Length; i++)
            {
                char lettre = mot[i];
                if (lettres.Contains(lettre))
                {
                   Console.Write(lettre+" ");
                }
                else
                {
                    Console.Write("_ ");
                }
                
            }
           Console.WriteLine();
           

        }
        static void DevinerMot(string mot)
        {
            //var lettreDevinez = new List<char>();

            //while (true)
            //{
            //    AfficherMot(mot, lettreDevinez);
            //    Console.WriteLine();
            //    var lettre = DemanderUneLettre();
            //    if (mot.Contains(lettre))
            //    {
            //        Console.WriteLine("Cette lettre est dans le mot");
            //        lettreDevinez.Add(lettre);

            //    } else
            //    {
            //        Console.WriteLine("Cette lettre n'est pas dans le mot");
            //    }

            //}
 

        }

        static char DemanderUneLettre()
        {
      
            while (true)
            {
                Console.Write ("Veuillez Rentrer une lettre: ");
                string reponse = Console.ReadLine();
                if (reponse.Length == 1)
                {
                    reponse = reponse.ToUpper();
                    return reponse[0];                
                }
                else
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer une seule lettre");
                }
            }

        }
        static void Main(string[] args)
        {
            string mot = "ELEPHANT";

            char lettre = DemanderUneLettre();

            //AfficherMot(mot, new List<char> { 'E','T','L','P' });

            AfficherMot(mot, new List<char> { lettre });

            //DevinerMot(mot);

          //  DevinerMot(mot);



        }
    }
}
