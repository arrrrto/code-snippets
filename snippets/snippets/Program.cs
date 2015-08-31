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

            solution.IsPalindrome("rat", "car");
            solution.IsPalindrome("anagram", "margana");

            solution.IsAnagram("anagram", "nagaram");
            solution.IsAnagram("rat", "car");
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

        public bool IsPalindrome(string s, string t)
        {
            char[] array = t.ToCharArray();
            Array.Reverse(array);
            if (new String(array) == s)
                return true;
            else
                return false;
        }

        public bool IsAnagram(string s, string t)
        {
            
            char[] array1 = s.ToArray();
            char[] array2 = t.ToArray();

            if (array1.Length != array2.Length)
                return false;

            Array.Sort(array1);
            Array.Sort(array2);

            if (array1.SequenceEqual(array2))
            {
                Console.WriteLine("Is anagram");
                return true;
            }
            else
            {
                Console.WriteLine("Not anagram");
                return false;
            }
        }
    }
}
