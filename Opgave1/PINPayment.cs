using System;

namespace Opgave1
{
    public class PINPayment : Payment
    {
        public override void ExecutePayment()
        {
            Console.WriteLine("processing PIN payment...");
        }
    }
}
