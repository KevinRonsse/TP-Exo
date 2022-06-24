using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caisseenrigistreuse.Classes
{
    public class ProductOrder
    {
        private Product product;
        private int qty;

        public Product Product { get => product; set => product = value; }
        public int Qty { get => qty; set => qty = value; }
    }
}
