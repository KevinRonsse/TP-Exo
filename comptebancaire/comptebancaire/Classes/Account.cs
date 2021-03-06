using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comptebancaire.Classes
{
    public class Account
    {
        private int id;
        private Customer customer;
        private int accountNumber;
        private decimal totalAmount;

        private List<Operation> operations;

        public int Id { get => id; set => id = value; }
        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public decimal TotalAmount { get => totalAmount; set => totalAmount = value; }
        public Customer Customer { get => customer; set => customer = value; }
        
        public List<Operation> Operations { get => operations; set => operations = value; }
    
        public Account()
        {
            TotalAmount = 0;
        }
        public Account(Customer customer, int accountNumber)
        {
            Customer = customer;
            AccountNumber = accountNumber;
            Operations = new List<Operation>();
            totalAmount = 0;
        }

        public bool WithDraw(Operation operation)
        {
            if(totalAmount >= Math.Abs(operation.Amount))
            {
                operation.Add(operation);
                totalAmount -= Math.Abs(operation.Amount);
                return true;
            }
            return false;
        }
        public bool Deposit(Operation operation)
        {
            if(operation.Amount > 0)
            {
                operation.Add(operation);
                totalAmount += operation.Amount;
                return true;
            }
            return false;
        }
    
    
    
    
    
    }
}
