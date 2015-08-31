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
            
            s = s.Replace(" ", "");
            t = t.Replace(" ", "");

            char[] array1 = s.ToCharArray();
            char[] array2 = t.ToCharArray();

            if (array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        array2 = array2.Where((source, index) => index != j).ToArray();
                        continue;
                    }
                    if (j == array2.Length)
                        break;
                }
            }

            if (array2.Length != 0)
            {
                Console.WriteLine("Not anagram");
                return false;
            }
            else
            {
                Console.WriteLine("Is anagram");
                return true;
            }
        }
    }
}
