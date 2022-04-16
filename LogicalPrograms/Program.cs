using LogicalPrograms;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to Logicl Programs");
        bool end = true;
        Console.WriteLine("1. FibonacciSeries\n2. PerfectNumber\n3. PrimeNumber\n4. End the program");
        while (end)
        {
            Console.WriteLine("\nTake an option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.CheckFibonacci();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.CheckPerfectNumber();
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.CheckPrimeNumber();
                    break;
                case 4:
                    end = false;
                    break;

                default:
                    Console.WriteLine("Enter proper option to Execute");
                    break;
            }
        }
    }
}