using CoursCSharpPOO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CoursCSharpPOO.Classes
{ 
    public class CalculatriceTest
    {
        private Calculatrice calculatrice = new Calculatrice();

        public void SoustractionTest()
        {
            int result = calculatrice.Soustraction(10, 20);

            Assert.AreEqual(10, result);
        }
    }
}

