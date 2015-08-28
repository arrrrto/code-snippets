using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snippets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add Digits algorithm exercise
            Solution solution = new Solution();
            Console.WriteLine(solution.AddDigits(38));

            Console.ReadLine();
        }
    }

    // Add Digits algorithm exercise
    // leetcode.com/problems/add-digits
    public class Solution
    {
        public int AddDigits(int num)
        {
            int n = num, sum;

            do
            {
                sum = 0;
                while (n != 0)
                {
                    int y = n % 10;
                    n /= 10;
                    sum += y;
                }
                n = sum;
            } while (sum > 9);
            
            return sum;
        }
    }
}
