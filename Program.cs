using System;

namespace CrashTestDummy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("This should show a line number!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("Press the any key to continue.");
            Console.ReadKey();
        }
    }
}
