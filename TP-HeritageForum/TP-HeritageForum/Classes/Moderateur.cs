using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_HeritageForum.Classes
{
    class Moderateur
    {
        private string Prenom;
        private string Nom;
        private int Age;

        public string Prenom1 { get => Prenom; set => Prenom = value; }
        public string Nom1 { get => Nom; set => Nom = value; }
        public int Age1 { get => Age; set => Age = value; }

        public Moderateur(string prenom, string nom, int age)
        {
            this.Prenom = prenom;
            this.Nom = nom;
            this.Age = age;
        }
    }
}
