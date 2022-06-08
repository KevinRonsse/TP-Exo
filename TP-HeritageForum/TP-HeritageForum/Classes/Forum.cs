using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_HeritageForum.Classes
{
    class Forum
    {
        private string name;
        private int dateCreation;

        public Forum(string name, int dateCreation)
        {
            this.name = name;
            this.dateCreation = dateCreation;
        }

        public string Name { get => name; set => name = value; }
        public int DateCreation { get => dateCreation; set => dateCreation = value; }
    }

    public static string NomForum()
    {
        Console.WriteLine("ForumNouvelle");
    }

    public static string ModifierNouvelle()
    {

    }
}
