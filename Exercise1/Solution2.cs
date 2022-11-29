using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Solution2
    {
        static void Main(string[] args)
        {
            Random var = new Random();int j = 0;
            Console.Write("Enter the number of random numbers to evaluate: ");
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                //In this situation, we're only print palindrome numbers of 3 characters 
                int ans = var.Next(100, 1000);
                //we use the form of the division equation to make a new one linked to our purpose 
                if (ans%10==(ans-ans%100)/100)
                {
                    //we highlight the number to tell apart from the others 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ans);
                    Console.ForegroundColor = ConsoleColor.White;
                    j++;
                }
                else
                { Console.WriteLine(ans); }
            }
            Console.WriteLine("\n# capicua numbers: " + j);
        }
    }
}
