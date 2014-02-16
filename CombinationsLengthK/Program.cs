using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationsLengthK
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            string s = "ab";
            Console.WriteLine("{0} combinations with string {1}", k, s);
            PrintCombinations(s, k);
        }

        static void PrintCombinations(string s, int k)
        {
            string prefix = null;
            PrintCombinations(s, k, prefix);
        }

        static void PrintCombinations(string s, int k, string prefix)
        {
            if (k == 0)
            {
                Console.WriteLine(prefix);
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    PrintCombinations(s, k - 1, prefix + s[i]);
                }
            }
        }
    }
}
