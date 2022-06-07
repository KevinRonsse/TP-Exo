using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceCSharpPOO.Classe
{
    public class Salarie
    {
        private string matricule;
        private string categorie;
        private string service;
        private string nom;
        private decimal salaire;
        private static decimal totalsalaire = 0;
        private static int compteur = 0;

        public string Matricule { get => matricule; set => matricule = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Service { get => service; set => service = value; }
        public string Nom { get => nom; set => nom = value; }
        public decimal Salaire
        {
            get => Salaire; set
            {
                if (salaire > 0)
                {
                    totalsalaire = salaire;
                }
                totalsalaire += value;
                salaire = value;
            }
        }

        public static decimal TotalSalaire { get => totalsalaire; }

        public static int Compteur { get => compteur; }


        public Salarie(string matricule,string nom,string categorie,string service,decimal salaire)
        {
            Matricule = matricule;
            Nom = nom;
            Categorie = categorie;
            Service = service;
            Salaire = salaire;
            compteur++; 
        }

        public void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire fixe de {Nom} est de {Salaire} euro");

        }
        public static void ResetCompteur(int valeur = 0)
        {
            compteur = valeur;
        }


    }


}

