using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lependu.Classes
{
    class IHMPendu
    {
        private LePendu lePendu;
        private Generateurdemot generateur;

        public IHMPendu()
        {
            lePendu = new LePendu();
            generateur = new Generateurdemot();
        }

        public void Jouer()
        {
            lePendu.GenererMasque(generateur);
            do
            {
                Console.WriteLine("Merci de saisir une lettre");
                char c = Convert.ToChar(Console.ReadLine());
                if (lePendu.TestChar(c))
                {
                    Console.WriteLine("Bravo vous avez trouver uen lettre");
                }
                else
                {
                    Console.WriteLine($"Il vous reste {lePendu.NbEssai} essais");
                }

            } while (lePendu.NbEssai > 0 && !lePendu.TestWin());
            if(lePendu.NbEssai > 0)
            {
                Console.WriteLine("Bravo vous avaez gagnez");
            }
        }
    }
}
