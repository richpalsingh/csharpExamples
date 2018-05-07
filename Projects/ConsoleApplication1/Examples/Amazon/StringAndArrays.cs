using System;

namespace CSharpExamples.Examples.Amazon
{
    public class HashMap
    {

    }

    public class StringAndArrays
    {



        public int FirstUniqueCharacterinaString()
        {
            // Note this is exceeding time - need to find another solution
            /*
             Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.
            Examples:

            s = "leetcode"
            return 0.

            //Note: l is not repeating

            s = "loveleetcode",
            return 2.
            Note: You may assume the string contain only lowercase letters.

            //Note: v at index=2 is not repeating
             * 
             */


            string s = "sdnvlbkrmtbollujsdjfjfppksravjkwwsimlmdtcmi";

            char[] carray = s.ToCharArray();

            int countOccurance = 0;
            int firstOccurance = -1;



            for (int i = 0; i < carray.Length; i++)
            {
                char currentChar = carray[i];
                firstOccurance = i;
                countOccurance = 1;
                Console.WriteLine($"Searching char='{(char)currentChar}'");
                for (int j = i + 1; j < carray.Length; j++)
                {
                    if (carray[j] == carray[i])
                    {
                        countOccurance++;
                    }
                }


                if (countOccurance == 1) //if not repeating print index
                {
                    Console.WriteLine($"Index={i} not found in entire array");
                    return firstOccurance;
                }
                else
                {
                    Console.WriteLine($"Found '{carray[i]}' {countOccurance} times");
                }

            }
            return -1;
        }

        public int FirstUniqueCharacterinaStringSecondAttempt()
        {

            string s = "loveleetcode";

            char[] carray = s.ToCharArray();

            char[] charFrequency = new char[256];


            for (int i = 0; i < carray.Length; i++)
            {
                charFrequency[s[i]]++;
            }

            for (int i = 0; i < carray.Length; i++)
            {
                if (charFrequency[s[i]] == 1)
                {
                    Console.WriteLine($"Index={i} not found in entire array");
                    return i;
                }
                else {
                    Console.WriteLine($"Found '{carray[i]}' - " +
                        $"{(int)charFrequency[s[i]]} times");
                }
            }


          return -1;
        }


        /// <summary>
        /// Write a function that takes a string as input and returns the string reversed.
        /// Given s = "hello", return "olleh".
        /// </summary>
        /// <returns></returns>
        public string ReverseString()
        {
            string str = "hello";

            char[] cArr = new char[str.Length];
            int j = 0;

            for (int i = str.Length-1; i >= 0; i--)
            {
                cArr[j] = str[i];
                j++;
            }

            return new string(cArr);

        }

        /// <summary>
        ///  Write a function that takes a string as input and reverse only the vowels of a string.
        /// </summary>
        /// <returns></returns>
        public string ReverseVowelsString()
        {
            /*
             Write a function that takes a string as input and reverse only the vowels of a string.

                Example 1:
                Given s = "hello", return "holle".

                Example 2:
                Given s = "leetcode", return "leotcede".

                Note:
                The vowels does not include the letter "y".
             */

            string str = "leetcode";
            char[] strArray = str.ToCharArray();
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            char[] cArray = new char[strArray.Length];

            int lCount = 0;
            int rCount = strArray.Length-1;

            //find all indexes of vowels
            for (int i = 0; i < strArray.Length; i++)
            {
                for (int j = strArray.Length-1; j >= strArray.Length; j--)
                {
                    if (strArray[i] == strArray[j]) break;

                    for (int k = 0; k < vowels.Length; k++)
                    {
                        if (strArray[i] == vowels[j])
                        {
                            cArray[lCount] = strArray[i];
                            lCount++;
                        }
                    }
                }
                                   
            }

            Array.Reverse(cArray);








            string s = new string(cArr);
            Console.WriteLine(s);

            return s;
        }

        }
    }