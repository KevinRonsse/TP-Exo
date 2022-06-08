using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_HeritageForum.Classes
{
    class Abonnée
    {
        private string prenom;
        private string nom;
        private int age;


        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Age { get => age; set => age = value; }

        public Abonnée(string prenom, string nom, int age)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.age = age;
        }

        public static string CreerUneNouvelle()
        {

        }
        public static string DeposerNouvelle()
        {

        }
        public static string ConsulterNouvelle()
        {

        }
        public static string RepondreNouvelle()
        {

        }

    }
}
