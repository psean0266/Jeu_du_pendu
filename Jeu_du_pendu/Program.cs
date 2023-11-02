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
            var lettreDevinee = new List<char>();
            const int NB_VIES = 6;
            int vieRestantes = NB_VIES;

            while (vieRestantes > 0)
            {
                Console.WriteLine("Nombres de vie restantes: " + vieRestantes);
                AfficherMot(mot, lettreDevinee);
                Console.WriteLine();
                var lettre = DemanderUneLettre();
                Console.Clear();

                if (mot.Contains(lettre))
                {
                    Console.WriteLine("La lettre existe ");
                    lettreDevinee.Add(lettre);
                }
                else
                {
                    Console.WriteLine("Erreur: la lettre n'existe pas");
                    vieRestantes--;
                    Console.WriteLine("Nombre de vie restante "+vieRestantes);
                }



                //AfficherMot(mot, lettreDevinee);
                //Console.WriteLine();
                //var lettre = DemanderUneLettre();
                //Console.Clear();

                //if (mot.Contains(lettre))
                //{
                //    Console.WriteLine("Cette lettre est dans le mot");
                //    lettreDevinee.Add(lettre);

                //}
                //else
                //{
                //    Console.WriteLine("Cette lettre n'est pas dans le mot");
                //}

            }
               
            if (vieRestantes == 0)
            {
                Console.WriteLine("PERDU ! Le mot était : "+mot );
            }


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

            //char lettre = DemanderUneLettre();

            //AfficherMot(mot, new List<char> { 'E', 'T', 'L', 'P' });

            //AfficherMot(mot, new List<char> { lettre });

            //DevinerMot(mot);

            DevinerMot(mot);



        }
    }
}
