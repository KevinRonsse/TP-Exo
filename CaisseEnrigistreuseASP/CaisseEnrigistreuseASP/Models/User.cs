using System.ComponentModel.DataAnnotations.Schema;

namespace CaisseEnrigistreuseASP.Models
{
    [Table("utilisateur")]
    public class User
    {
        private string id;
        private string last_name;
        private string first_name;
        private string password;

        [Column("id")]
        public string Id { get => id; set => id = value; }
        [Column("Prenom")]
        public string Last_name { get => last_name; set => last_name = value; }

        [Column("Nom")]
        public string First_name { get => first_name; set => first_name = value; }
        [Column("mot de passeç")]
        public string Password { get => password; set => password = value; }
    }
}
