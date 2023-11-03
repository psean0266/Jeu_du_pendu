using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

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
            var lettresExclue = new List<char>();

            const int NB_VIES = 6;
            int vieRestantes = NB_VIES;

            while (vieRestantes > 0)
            {
                AfficherMot(mot, lettreDevinee);
                Console.WriteLine();
                var lettre = DemanderUneLettre();
                Console.Clear();

                if (mot.Contains(lettre))
                {
                    Console.WriteLine("La lettre existe ");
                    lettreDevinee.Add(lettre);
                    //bool b =  ToutesLettresDevinees(mot,lettreDevinee);
                    // if (b)
                    // {
                    //     break;
                    // }

                   if( ToutesLettresDevinees(mot, lettreDevinee))
                    {
                      //  Console.WriteLine("GAGNE") ;
                        //return;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Erreur: la lettre n'existe pas");
                    lettresExclue.Add(lettre);
                    vieRestantes--;
                    Console.WriteLine("Nombre de vie restante "+vieRestantes);
                }

                Console.WriteLine("Le mot ne contient pas les lettres : " + String.Join(", ", lettresExclue));

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
            else
            {
                AfficherMot(mot, lettreDevinee);
                Console.WriteLine();

                Console.WriteLine("GAGNE");
            }

        }

        static bool ToutesLettresDevinees(string mot, List<char> lettres)
        {

            //for(int i = 0; i < lettres.Count; i++)

            //{
            //    mot = mot.Replace(lettres[i].ToString(), "");
            //}

            //if(mot.Trim() == "")
            //{
            //    Console.WriteLine("Vous aviez trouvez toutes les lettre");
            //    return true;
            //} else  
            //{ 
            //    return false;
            //}


            foreach (var lettre in lettres)

            {
                mot = mot.Replace(lettre.ToString(), "");
            }

            if (mot.Length==0)
            {
                return true;
            }
                return false;

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
