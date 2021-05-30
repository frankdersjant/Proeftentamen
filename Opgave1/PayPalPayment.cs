using System;

namespace Opgave1
{
    public class PayPalPayment : Payment
    {
        public override void ExecutePayment()
        {
            Console.WriteLine("processing CreditCard payment...");
        }
    }
}
