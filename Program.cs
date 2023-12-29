using System.Transactions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your num");
            int x = int.Parse(Console.ReadLine());
            int y = fibo(x-1);
            Console.WriteLine(y);
            Console.ReadKey();

        }
        static int fibo(int x)
        {
            if (x <= 1)

                return x;

                return fibo(x -1)+ fibo(x-2);
            

       



        }
    }
}
