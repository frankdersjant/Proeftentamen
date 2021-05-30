using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            PrintHeader("[CreditCard]");
            Payment ccPayment = new CreditCardPayment();
            ccPayment.Execute();
            PrintHeader("[PayPal]");
            Payment ppPayment = new PayPalPayment();
            ppPayment.Execute();
            PrintHeader("[PIN]");
            Payment pinPayment = new PINPayment();
            pinPayment.Execute();
            Console.ReadKey();
        }
        void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ResetColor();
        }
    }
}
