using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caisseenrigistreuse.Classes
{
    public class CardPayment : Payment
    {
        public override bool Pay(decimal amount)
        {
            return amount % 2 == 0;
        }
    }
}
