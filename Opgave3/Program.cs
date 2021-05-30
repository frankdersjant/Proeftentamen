using System;

namespace Opgave3
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
            CopyingMachine machine1 = CopyingMachine.GetUniqueInstance();
            CopyingMachine machine2 = CopyingMachine.GetUniqueInstance();
            Console.WriteLine("copying with 'machine 1'");
            machine1.Copy(10);
            machine1.Copy(23);
            Console.WriteLine();
            Console.WriteLine("copying with 'machine 2'");
            machine2.Copy(40);
            Console.ReadKey();
        }
    }
}
