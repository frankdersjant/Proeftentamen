using System;

namespace Opgave1
{
    public abstract class Payment
    {
        public void Execute()
        {
            EnterInformation();
            ExecutePayment();
            ConfirmPayment();
        }
        public void EnterInformation()
        {
            Console.WriteLine("entering information...");
        }
        public abstract void ExecutePayment();
        public void ConfirmPayment()
        {
            Console.WriteLine("sending confirmation mail...");
        }
    }
}
