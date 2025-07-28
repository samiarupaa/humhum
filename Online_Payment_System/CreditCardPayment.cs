using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Payment_System
{
   public class CreditCardPayment:Payment
    {
        private string cardNumber;
        private string cardHolder;
        private string expiryDate;
        public string CardNumber
        { get { return this.cardNumber; }
            set { this.cardNumber = value; }

        }
        public string CardHolder
        {
            get { return this.cardHolder; }
            set { this.cardHolder = value; }

        }
        public string ExpiryDate
        { get { return this.expiryDate; }
            set { this.expiryDate = value; }
        }
        public CreditCardPayment() : base()
        {
        }

        public CreditCardPayment(double amount, string transactionId, string cardNumber, string cardHolder, string expiryDate)
            : base(amount, transactionId)
        {
            this.cardNumber = cardNumber;
            this.cardHolder = cardHolder;
            this.expiryDate = expiryDate;
        }
        public override bool Validate()
        {
            
            return CardNumber.Length == 16 && !string.IsNullOrWhiteSpace(CardHolder) && ExpiryDate.Contains("/");
        }

        public override bool ProcessPayment(double amount)
        {
            Console.WriteLine("Processing");

            if (!Validate())
            {
                Console.WriteLine("Payment failed: Invalid card details.");
                return false;
            }

            Amount = amount;
            Console.WriteLine($"Transaction ID: {TransactionID}");
            Console.WriteLine($"Amount: ${Amount}");
            Console.WriteLine("Payment successful via Credit Card.");
            return true;
        }
    }
}
