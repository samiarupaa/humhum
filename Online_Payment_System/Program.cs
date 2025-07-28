using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Payment_System
{

    class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment ccp = new CreditCardPayment(
                1500.75,
                "TXN123456",
                "1234567890123456",
                "John Doe",
                "12/2026"
            );

            bool result = ccp.ProcessPayment(ccp.Amount);

            Console.WriteLine("Payment Status: " + (result ? "Success" : "Failure"));
        }
    }
}
