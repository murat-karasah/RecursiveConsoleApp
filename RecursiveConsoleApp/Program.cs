using System;

namespace RecursiveConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            Console.WriteLine($"{i} sayısının faktoriyeli {faktoriyel(i)}" );
        }
        static int faktoriyel(int n)
        {
            if (n<=0)
            {
                return 1;
            }
            else
            {
              return  n*faktoriyel(n-1);
            }
        }
    }
}
