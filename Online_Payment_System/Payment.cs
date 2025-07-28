using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Payment_System
{
   public abstract class Payment :IPayable
    {
        protected double amount;
        protected string transactionID;

        public double Amount
        {
            get { return this.amount; }
            set { this.amount=value; }
        }
        public string TransactionID
        {
            get { return this.transactionID; }
            set { this.transactionID = value; }
        }
        public Payment()
        {
            Amount = 0;
            TransactionID = "TXN0000";
        }

        public Payment(double amount, string transactionId)
        {
            this.amount = amount;
            this.transactionID = transactionID;
        }
        public abstract bool Validate();

        public abstract bool ProcessPayment(double amount);
    }
}

