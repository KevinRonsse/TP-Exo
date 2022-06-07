// See https://aka.ms/new-console-template for more information

using System;
namespace exocsharp
{
    class Program
    {
        public static void Main(String[] args)
        {



            //exo 2
            //string Prenom = "Anthony";
            //Console.WriteLine("Veuillez saisir votre prenom : " + Prenom);
            //Console.WriteLine("Bonjour " + Prenom);




            //exo 3 
            //string Nom = "Di Percio";
            //string Prenom = "Anthony";
            //string NomComplet = "Anthony Di Persio";
            //Console.WriteLine("Veuillez saisir votre prenom : " + Prenom);
            //Console.WriteLine("Bonjour " + Prenom);
            //Console.WriteLine("Bonjour " + NomComplet);


            //exo 4

            //string NomComplet = "Anthony Di Persio";
            //string Nom = "Di Percio";
            //string Prenom = "Anthony";
            //string Age = "41";
            //int Age = 41;

            //Console.WriteLine("Veuillez saisir votre nom : "+ Nom);
            //Console.WriteLine("Veuillez saisir votre prenom : " + Prenom);
            //Console.WriteLine("Veuillez saisir votre âge " + Age);
            //Console.WriteLine("Bonjour " + NomComplet + " vous avez " + Age + " ans ");

            //exo 5

            //int a = 10;
            //int b = 25;
            //int total = a + b;

            //Console.WriteLine("Veuillez saisir un nombre : " + a);
            //Console.WriteLine("Veuillez saisir un nombre : " + b);
            //Console.WriteLine("La somme de ces deux nombre est : " + total );


            //string a = "35,76";
            //string b = "23,42";
            //double c = Convert.ToDouble(a);
            //double d = Convert.ToDouble(b);
            //string total = Convert.ToString(c + d);

            //Console.WriteLine("Veuillez saisir un nombre : " + a);
            //Console.WriteLine("Veuillez saisir un nombre : " + b);
            //Console.WriteLine("La somme de ces deux nombre est : " + total);

            //exo 6

            //string a = "13,5";
            //int b = 4;
            //double c =Convert.ToDouble(a);
            //string total = Convert.ToString( b * c );


            //Console.Write("Entrez la d'un coté du carré (en cm) : " + a);
            //Console.Write("Le périmètre du carré est : " + total);
            //Console.Write("L'aire du carré est : " + a);

            //exo 7
            //Console.Write("Entrez la longeur du premier coté (en cm) : ");
            //double first = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Entrez la longeur du deuxieme coté (en cm) : ");
            //double second = Convert.ToDouble(Console.ReadLine());
            //double hypo = Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2));
            //Console.Write($"L'hypothénuse est : {Math.Round(hypo, 2)}");
            //exo 8

            //Console.WriteLine("---Calcul Montant de TVA---");

            //Console.Write("Entrez le prix HT de l'objet (en Euros) : ");
            //double euro = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Entrez le taux de TVA (en %) : ");
            //double pourcentage = Convert.ToDouble( Console.ReadLine());
            //double total = Math.Floor(euro) / Math.Floor(pourcentage);
            //double total1 = Math.Round(pourcentage) / Math.Round(euro);

            //Console.WriteLine("Le montant de la T.V.A est de " + total +  " Euros ");
            /*Console.WriteLine($"Le prix TTC de l'objet est de {Math.Round(total1 * 20)} Euros");*/

            //exo 9
            //Console.WriteLine("---Calcul des intérêts---");
            //Console.Write("Entrez Capital de départ (en Euros) : ");
            //double Euro = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Entrez le taux d'intérêt (en %) : ");
            //double Pourcentage = Convert.ToDouble( Console.ReadLine());
            //Console.Write("Entrez la durée de l'épargne ( en années) : ");
            //double année = Convert.ToDouble( Console.ReadLine());
            //double totale = Math.Round(Euro) / Math.Round(Pourcentage) * Math.Round(année);
            //Console.WriteLine("Le montant des intérêts sera de " +Math.Floor(Euro /Pourcentage)  + " Euros après " +année + " ans ");
            //Console.WriteLine("Le capital final sera de " + totale  + " Euros ");



            //exo 10


            //Console.WriteLine("Entrez une lettre : ");
            //string lettre = Console.ReadLine();
            //if (lettre == "e" || lettre == "a" || lettre == "o" || lettre == "u" || lettre == "y" || lettre == "i")
            //{

            //    Console.WriteLine("La lettre et une voyelle ! : ");

            //}
            //else
            //{
            //    Console.WriteLine("Une consonne");
            //}

            ////exo 11
            //Console.Write("Entrez un chiffre/nombre entier : ");
            //int nb = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Entrez un chiffre/nombre diviseur : ");
            //int dv = Convert.ToInt32(Console.ReadLine());
            //string type = nb <10 ? "chiffre" : "nombre";
            //if(nb % dv == 0)
            //{
            //    Console.WriteLine($"{type} {nb} est divisible par {dv}");
            //}
            //else
            //{
            //    Console.WriteLine($"Le {type} n'est pas divisible");
            //}
            //exo 12
            // Console.WriteLine("Entrez l'âge de votre enfant");
            // int age = Convert.ToInt32(Console.ReadLine());
            // if(age >=0 && age <= 2)
            // {
            //     Console.WriteLine("Votre enfant est dans la catégorie esprit ");
            // }
            // else if (age >=3 && age <=6)
            // {
            //     Console.WriteLine("Votre enfant est dans la catégorie Baby ");
            // }
            // else if(age >=7 && age <=8)
            // {
            //     Console.WriteLine("Votre enfant est dans la catégorie Poussin");
            // }

            //else if (age >=9 && age <=10)
            //{

            //    Console.WriteLine("Votre enfant est dans la catégorie Pupille");

            //}
            // else if(age >= 11 && age <=12)
            // {
            //     Console.WriteLine("Votre enfant est dans la catégorie Minime");
            // }
            // else if (age >= 13 && age <18)
            // {
            //     Console.WriteLine("Votre enfant est dans la catégorie Cadet");
            // }
            // else
            // {
            //     Console.WriteLine("Votre enfant est dans la catégorie Vieux");
            // }
            //exo 13



            ////exo 32
            //Console.WriteLine("Insertion des valeurs du tableau : ");
            //int[] tab = new int[10];
            //for (int i = 0; i < tab.Length; i++)
            //{

            //    Console.Write($"Saisir la valeur {i + 1}  : " );
            //    tab[i] = Convert.ToInt32(Console.ReadLine());              
            //}

            //Console.WriteLine("Affichage des valeurs du tableau");
            //string dec = "";
            //for(int i = 0; i < tab.Length; i++)
            //{
            //    dec += "\t";
            //    Console.WriteLine($"{dec} {tab[i]}");
            //}

            //exo 33

            //int[] tab = new int[26];
            //for(int i = 0; i < tab.Length; i++) 
            //{
            //    tab[i] = i +65;
            //}
            //string dec = "";
            //for(int i=0; i < tab.Length; i++)
            //{
            //    dec += " ";
            //    Console.WriteLine(dec + Convert.ToChar(tab[i]));
            //}

            //exo 34


            //exo 35

            //Console.WriteLine("Merci de saisir le nombre de contact");
            //int taille = Convert.ToInt32(Console.ReadLine());
            //string[] contacts = new string[taille];
            //int count = 0;
            //Console.Clear();
            //string choix;
            //do
            //{
            //    Console.WriteLine(" 1 -- Saisir un contact");
            //    Console.WriteLine(" 2 -- Afficher les contacs");
            //    Console.WriteLine(" 0 -- Quitter");
            //    choix = Console.ReadLine();
            //    Console.Clear();
            //    switch (choix)
            //    {
            //        case "1":
            //            if (count < taille)
            //            {
            //                Console.Write("Merci de saisir le contact");
            //                contacts[count++] = Console.ReadLine();
            //            }
            //            else
            //            {
            //                Console.WriteLine("Tableau plein");
            //            }
            //            break;
            //        case "2":
            //            foreach (string s in contacts)
            //            {
            //                if (s != null)
            //                    Console.WriteLine(s);
            //            }
            //            break;
            //    }
            //} while (choix != "0");

            //exo 36




            //  //exo 37
            //  string[] mois = new string[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Novembre", "Decembre" };

            //  string dec = "\t";

            //  foreach (string m in mois)
            //  {
            //     Console.WriteLine($"{dec} {m}");
            //      dec += "\t";
            //}

            // exo 38 

            Console.WriteLine("--- Où est passé mon numéro ?");
            int[] tab = new int[10];
            Random random = new Random();
            Console.WriteLine("Affectation des valeurs...");
            Console.WriteLine("");
            Console.WriteLine("Affichage avant triage");
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = random.Next(1, 51);
            }
            foreach (int i in tab)
            {
                Console.WriteLine(i);
            }
            string dec = "\t";
            foreach(int i in tab)
            {
                Console.WriteLine(dec + i);
                dec = "\t";
            }
            Console.WriteLine("après");
            Array.Sort(tab);
            dec = "\t";
            foreach(int i in tab)
            {
                Console.WriteLine(dec + i);
                dec = "\t";
            }
            
           


            // exo 39


        }
    }
}













































