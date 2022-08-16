using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exoentityannuaire
{
    [Table("contact_entity")]
    public class Contact
    {
        private int id;
        private string first_name;
        private string last_name;
        private string phone;
        private string email;

        public int Id { get => id; set => id = value; }

        [Column("first_name")]
        public string First_name { get => first_name; set => first_name = value; }
        [Column("last_name")]
        public string Last_name { get => last_name; set => last_name = value; }
        [Column("phone")]
        public string Phone { get => phone; set => phone = value; }

 
    }
}
