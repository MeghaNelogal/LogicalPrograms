using LogicalPrograms;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to Logicl Programs");
        bool end = true;
        Console.WriteLine("1. FibonacciSeries\n2. PerfectNumber\n3. PrimeNumber\n4. ReverseNumber\n5. CouponNumbers\n6. StopWatch\n7. End the program");
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
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.CheckReverseNum();
                    break;
                case 5:
                    CouponNumbers couponNumbers = new CouponNumbers();
                    couponNumbers.CheckCoupons();
                    break;
                case 6:
                    StopWatch stopWatch = new StopWatch();
                    stopWatch.StopWatches();
                    break;
                case 7:
                    end = false;
                    break;

                default:
                    Console.WriteLine("Enter proper option to Execute");
                    break;
            }
        }
    }
}