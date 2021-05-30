using System;

namespace Opgave3
{
    public class CopyingMachine
    {
        private int totalNumberOfCopies;
        private static CopyingMachine uniqueInstance;
        public int TotalNumberOfCopies
        {
            get { return totalNumberOfCopies; }
        }
        private CopyingMachine()
        {
            totalNumberOfCopies = 0;
        }
        public static CopyingMachine GetUniqueInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new CopyingMachine();
            }
            return uniqueInstance;
        }
        public void Copy(int nrOfCopies)
        {
            Console.WriteLine("copying, {0}x", nrOfCopies);
            totalNumberOfCopies += nrOfCopies;
            Console.WriteLine("total number of copies: {0}x", totalNumberOfCopies);
        }
    }
}
