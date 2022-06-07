using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExerciceCSharpPOO.Classe
{
    class IHMsalarie
    {
        private int nbSalarie;
        private Salarie[] salaries;

        public void Demarrer()
        {
            Console.Write("Merci de saisir le nombre de salarié : ");
            nbSalarie = Convert.ToInt32(Console.ReadLine());
            salaries = new Salarie[nbSalarie];
            SaisirLesSalaries();
            AfficherSalaries();
            Console.WriteLine("Total des salaires : " + Salarie.TotalSalaire);
            Console.WriteLine("Total des salaries : " + Salarie.Compteur);
        }

        private void AfficherSalaries()
        {
            foreach (Salarie s in salaries)
            {
                s.AfficherSalaire();
            }
        }

        private void SaisirLesSalaries()
        {
            for (int i = 0; i < nbSalarie; i++)
            {
                Console.Write("Merci de saisir le nom complet : ");
                string nom = Console.ReadLine();
                Console.Write("Merci de saisir le matricule : ");
                string matricule = Console.ReadLine();
                Console.Write("Merci de saisir le catégorie : ");
                string categorie = Console.ReadLine();
                Console.Write("Merci de saisir le service : ");
                string service = Console.ReadLine();
                Console.Write("Merci de saisir le salaire : ");
                decimal salaire = Convert.ToDecimal(Console.ReadLine());
                Salarie s = new Salarie(matricule, nom, categorie, service, salaire);
                salaries[i] = s;
            }
        }





    }



}

