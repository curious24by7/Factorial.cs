using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, fact = 1;
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++) 
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + num + " is : " + fact);
            Console.ReadLine();
        }
    }
}
