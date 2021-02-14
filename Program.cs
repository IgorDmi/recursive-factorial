using System;

namespace factorial
{

    class Factorial
    {
        private long _resoult;

        public long factorialCalc(int i)
        {
            if (i == 0)
            {
                return 1;
            }
            return i * factorialCalc(i - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            long resoult = 1;
            int n = 0;

            Factorial f1 = new Factorial();

            Console.Write("Enter number from will calculate factorial: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(f1.factorialCalc(n));

        }
    }
}
