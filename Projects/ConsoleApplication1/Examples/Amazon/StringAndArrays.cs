using System;
using System.Collections.Generic;

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
                else
                {
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

            for (int i = str.Length - 1; i >= 0; i--)
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
        {//Note: Needs work

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
            int rCount = strArray.Length - 1;

            //find all indexes of vowels
            for (int i = 0; i < strArray.Length; i++)
            {
                for (int j = strArray.Length - 1; j >= strArray.Length; j--)
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

            //  Array.Reverse(cArray);





            return "";
        }

        public void ReverseWordsInAString()
        {
            /*
             Given an input string , reverse the string word by word. 

            Example:

            Input:  ["t","h","e"," ","s","k","y"," ","i","s"," ","b","l","u","e"]
            Output: ["b","l","u","e"," ","i","s"," ","s","k","y"," ","t","h","e"]
            Note: 

            A word is defined as a sequence of non-space characters.
            The input string does not contain leading or trailing spaces.
            The words are always separated by a single space.
            Follow up: Could you do it in-place without allocating extra space?
            */

            char[] sArr = new char[] { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' };

         

            char[] sArrayOutput = new char[sArr.Length];

            int start = sArr.Length - 1;
            int end = sArr.Length - 1;

            int counter = 0;

            for (int i = sArr.Length - 1; i >= 0; i--)
            {
                if (sArr[i] == ' ' || i == 0)
                {
                    if (i == 0)
                        start = 0;
                    else
                        start = i + 1;

                    for (int j = start; j <= end; j++)
                    {
                        // Console.Write($"\'{sArr[j]}\',");
                        sArrayOutput[counter++] = sArr[j];

                        if (i > 0 && j == end)
                        {
                            sArrayOutput[counter++] = ' ';
                            end = start - 2;
                        }

                    }

                    //if (i != 0)
                    //    Console.Write($"' ',");
                }


            }

        }


        public void ReverseWordsInAString_SecondTry()
        {
            /*
             Given an input string , reverse the string word by word. 

            Example:

            Input:  ["t","h","e"," ","s","k","y"," ","i","s"," ","b","l","u","e"]
            Output: ["b","l","u","e"," ","i","s"," ","s","k","y"," ","t","h","e"]
            Note: 

            A word is defined as a sequence of non-space characters.
            The input string does not contain leading or trailing spaces.
            The words are always separated by a single space.
            Follow up: Could you do it in-place without allocating extra space?
            */

            char[] sArr = new char[] { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' };

            ReverseArray(sArr, 0, sArr.Length - 1);

            int start = 0;
            int end = 0;
            for (int i = 0; i < sArr.Length; i++)
            {

                if (sArr[i] == ' ' || i == sArr.Length - 1)
                {
                    end = i - 1;
                    ReverseArray(sArr, start, end);
                    start = end + 2;
                }
            }

            for (int i = 0; i < sArr.Length; i++)
            {
                Console.Write($"\"{sArr[i]}\",");
            }
        }

        private void ReverseArray(char[] arr, int start, int end)
        {
            char temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        public int[] TwoSumBruteForce()
        {
            https://www.youtube.com/watch?v=31duyrXaE_g

            /*
            Given an array of integers, return indices of the two numbers such that they add up to a specific target.

            You may assume that each input would have exactly one solution, and you may not use the same element twice.

            Example:

            Given nums = [2, 7, 11, 15], target = 9,

            Because nums[0] + nums[1] = 2 + 7 = 9,
            return [0, 1].

            Scratchbook:-

            1) Ask questions
            - Is the array always sorted ?
            - is it possible there are no solution in the array for the target

            2) Step back and think without code.
            don;t think abt time compexity for now.

            [2,7,11,15] , target=9

            2+7=9 {0,1}

            [2,7,11,15] , target=22
            
            2+7=9
            2+11=13
            2+15=17
            
            7+11=18
            7+15=22 [sol] 

            Do you want me to code brute force ? or I can also look at better question
            
            Complexity of this sol: is O(n^2) as we are going through 2 loops. Complexity of inner for loop is O(n) 

             */

            //  int[] nums = { 2, 7, 11, 15 };
            //   int target = 9;

            int[] nums = { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };
              int target = 542;

            //what if nothing match to target
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };


        }

        public int[] TwoSumHashMap()
        {
            /*
             
            Given nums = [2, 7, 11, 15], target = 22,

            x+7=22
            x=22-7  on hashmap
            x=15 if 15 exists in Array

            
            22-2 =20 ? is this on our hashmap no then we add 2 to hasmap and move to next
            {2,0}

            22-7 = 15? no this is not on hashmap, so we add 7
            
            22-15 = 7 does it exist on HM? yes then return its index and current index

            HM:-
            {2,0}
            {7,1}
            {11,2}
            output {1,3}

            Review the sol now:-
            For each number we check target-number on hashmap if it exists. If it does we have solution, if it does we add number to hashmap and move to next in array




            We are looking for better solution then O(n) when each touch once
            So we look at HashMap that has O(1) time. It has very low complexity

             */

            int[] nums = { 2, 7, 11, 15 };
            //only unique sorted
            //this code will errout in case of duplicate value
           
            int target = 22;
            // x=target-y

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            //number that we are looking at and its index

            for (int i = 0; i < nums.Length; i++)
            {
                int x = target - nums[i];
                if (keyValuePairs.ContainsKey(x))
                {
                    Console.WriteLine($"{ keyValuePairs[x] },{i}");
                    return new int[] { keyValuePairs[x], i };
                }

                keyValuePairs.Add(nums[i], i);
            }


            return new int[] { -1, -1 };
        }
    }
}