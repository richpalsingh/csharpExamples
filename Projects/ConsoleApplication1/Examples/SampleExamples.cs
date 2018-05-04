using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SampleExamples
    {
        /// <summary>
        /// print all positive integer solutions to the equation apow3 + b3=c3+dpow3 and d are integers between 1 and 1000.
        /// </summary>
        public static void PrintAllPositiveIntegers()
        {
            for (int a = 0; a < 1000; a++)
            for (int b = 0; b < 1000; b++)
            for (int c = 0; c < 1000; c++)
            for (int d = 0; c < 1000; c++)
            {
                            
                if (Math.Pow(a, 3) + Math.Pow(b, 3) == Math.Pow(c, 3) + Math.Pow(d, 3))
                {
                    Console.Write($"{a},{b},{c},{d}");
                    break;
                }
                            //O(N pow 4)
                // we can calculate d=sq root of (aP3+bP3-cP3)
                //it will be O(N pow 3)

                        }
        }

        //Example: Given a smaller string 5 and a bigger string b, design an algorithm to find all permutations
        //of the shorter string within the longer one.Print the location of each permutation.
        public static void CountStringInBigString(string smallString,string largeString)
        {
            //1) Solution 1:-
            //find all permutations of smallstring
            //take each small and find in large string

            //2)

        }

        public static void PrintStringPermutation()
        {
            string input = "abc";

            RecursivePrint(input,0, input.Length-1);
        }

        private static void RecursivePrint(string s, int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine($"print: {s}");
            }
            else
            {
               // char[] strArray = s.ToCharArray();

                for (int i = start; i <= s.Length-2; i++)
                {
                    Console.Write($"{s[i]}");
                     // Console.Write($"{Swap(s, start, end)},");
                      RecursivePrint(s, start + 1, end);

                   // Console.Write($"{Swap(s, start+1, end)},");
                }

                
            }
        }

        private static string  Swap(string str,int i,int j)
        {
            char[] charArray = str.ToCharArray();
            var temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;

            return new string(charArray);
        }
    }
}
