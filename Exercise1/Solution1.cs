using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Solution1
    {
        static void Main(string[] args)
        {
            Random var = new Random();
            int q, j = 0;
            Console.Write("Enter the number of random numbers to evaluate: ");
            q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                //In this situation, we're only print palindrome numbers of 3 characters 
                int num = var.Next(100,1000);
                //we convert int to string so we can use "Substring" to catch the principal
                //and last character
                string chain = Convert.ToString(num);
                string ans1 = chain.Substring(0,1);
                string ans2 = chain.Substring(2,1);
                if (ans1 == ans2)
                {
                    //we highlight the number to tell apart from the others
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(num);
                    Console.ForegroundColor = ConsoleColor.White;
                    j++;
                }
                else
                { Console.WriteLine(num); }
            }
            Console.WriteLine("\n# capicua numbers --> " + j);
        }
    }
}
