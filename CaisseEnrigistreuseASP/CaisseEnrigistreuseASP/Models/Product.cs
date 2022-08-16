using System.ComponentModel.DataAnnotations.Schema;

namespace CaisseEnrigistreuseASP.Models
{
    [Table("produit")]
    public class Product
    {
        private int id;
        private string titre;
        private decimal price;
        private int stock;

        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("titre")]

        public string Titre { get => titre; set => titre = value; }

        [Column("prix")]
        public decimal Price { get => price; set => price = value; }
        [Column("stock")]
        public int Stock { get => stock; set => stock = value; }
    }
}
