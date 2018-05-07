using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples.Examples.Amazon
{
    /// <summary>
    /// Notes:-
    /// Single/Multi 
    /// Dynamic array- array with variable size . but still a random access list Data structure. this is similar to vector in c++ and ArrayList in java
    /// </summary>
    public class ArrayExamples
    {

        public void ArrayOneDim()
        {
            int[] arr = new int[5] { 2, 3, 5, 7, 8 };

            int[] array1 = { 1, 2, 3, 4 }; //shortcut

            //You can initialize arr but on assignment must use new as below
            string[] strArray;
            strArray = new string[] { "a", "b", "c" };
        }

        public void MultiDim()
        {
            int[,] arr1 = new int[4, 2]; //4-row,2-col

            int[,,] arr2 = new int[4, 2, 3]; //array of 3 dimension 4,2,3 


            //2 dim array without dim specified
            int[,] array2D = new int[,] {

                {1,2},
                {3,4}
            };

            //2-dim array with dim specified
            int[,] array2Da = new int[2, 3] //2 - row , 3- col
            {
                {1,2,1},
                {3,4,2},
            };

            //similar string array

            int[,,] array3D = new int[2, 2, 3] {
                {
                    {1,2,1},
                    {2,3,1}
                },
                {
                    {4,5,2},
                    {6,3,2}
                }

                //Note above 3 is 3rd col and mid 2 is 2 gp s
            };

            // Getting the total count of elements or the length of a given dimension.
            var allLength = array3D.Length;
            var total = 1;
            for (int i = 0; i < array3D.Rank; i++)
            {
                total *= array3D.GetLength(i);
            }
            System.Console.WriteLine("{0} equals {1}", allLength, total);

        }

        public void DynamicArrayExample()
        {
            ArrayList arrList1 = new ArrayList();

            int[] arr = { 21, 2, 3, 4 };
            // 2. cast an array to a vector
            ArrayList arrList = new ArrayList(arr);

            //get len
            Console.WriteLine($"arrList Len ={arrList.Count}");
            Console.WriteLine($"arrList capacity={arrList.Capacity}");

            //iterate
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.Write($"{arrList[i]},");
            }


            //delete last element
            arrList.RemoveAt(arrList.Count - 1);

            arrList.Add(33);

            arrList.Sort();
            Console.WriteLine($"\nSort list");
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.Write($"{arrList[i]},");
            }

        }

        /// <summary>
        /// Given an array of integers nums, write a method that returns 
        /// the "pivot" index of this array. 
        /// We define the pivot index as the index where the sum of the numbers to the left of the 
        /// index is equal to the sum of the numbers to the right of the 
        /// index. 
        /// If no such index exists, we should return -1. 
        /// If there are multiple pivot indexes, you should return the 
        /// left-most pivot index.
        /// 
        /// </summary>
        public int PivotIndex()
        {
            /*
             Examples
                Input: 
                nums = [1, 7, 3, 6, 5, 6]
                Output: 3
                Explanation: 
                The sum of the numbers to the left of index 3 (nums[3] = 6) is equal to the sum of numbers to the right of index 3.
                Also, 3 is the first index where this occurs.
             
            Richpal Notes: - Here index[3] i.e 6


            Input: 
            nums = [1, 2, 3]
            Output: -1
            Explanation: 
            There is no index that satisfies the conditions in the problem statement.
             
             */

            //int[] nums = { 1, 7, 3, 6, 5, 6 };
            int[] nums = { 1, 2, 3 };

            int LSum = 0;
            int RSum = 0;
            int pivotIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                pivotIndex = i;
                Console.WriteLine($"PivotIndex={pivotIndex}");
                LSum = 0;
                RSum = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j < pivotIndex)
                    {
                        LSum += nums[j];
                    }
                    else if (j > pivotIndex)
                    {
                        RSum += nums[j];
                    }
                }

                Console.WriteLine($"LSum={LSum}, RSum={RSum}");

                if (LSum == RSum)
                    return pivotIndex;
                else
                    pivotIndex = -1;
            }

            Console.WriteLine(pivotIndex);

            return pivotIndex;
        }

        public int PivotIndexSecond()
        {
            //This is accepted

            int[] nums = { 1, 7, 3, 6, 5, 6 };

            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            int lSum = 0;
            int rSum = 0;
            //LSum+RSum= sum so 
            for (int i = 0; i < nums.Length; i++)
            {
                rSum = sum - lSum - nums[i];
                Console.WriteLine($"LSum={lSum}, RSum={rSum}");
                if (lSum == rSum) return i;
                lSum += nums[i];
            }
            return -1;
        }

        /// <summary>
        /// Subarray largest sum
        /// </summary>
        public void ContagiousArrayLargestSum()
        {
            int[] arr = { 4, -3, -2, 2, 3, 1, -2, -3, 4, 2, -6, -3, -1, 3, 1, 2 };

            int max_so_far = 0;
            int max_ending_here = 0;

            int start = 0;
            int end = 0;
            int s = 0; //search after this index            

            Console.WriteLine("Print sample array");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write($"{arr[i]},");
            }

            //////////////////////


            for (int i = 0; i < arr.Length; i++)
            {
                max_ending_here += arr[i];

                if (max_ending_here > max_so_far)
                {
                    max_so_far = max_ending_here;
                    start = s;
                    end = i;
                }


                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    s = i + 1;
                }
            }

            Console.WriteLine($"\nstart={start},end={end}");

            Console.WriteLine("Print final array");
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{arr[i]},");
            }

        }

        /// <summary>
        /// Subarray largest sum
        /// </summary>
        public int ContagiousArraySumEqualToGivenValue()
        {
            //[not valid]
            int[] arr = { 1, 2, 3 };
            int k = 2;

            int totalArr = 0;

            int[] arr1 = arr;
            // int totalCombinations = arr.GetLength(0) * arr.GetLength(0);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == k)
                    {
                        totalArr++;
                    }

                    Console.Write($"[{arr[i]},{arr[j]}],");

                }
            }

            return totalArr;

            Console.WriteLine($"Total array with {k} = { totalArr }");
        }

        /// <summary>
        /// 560. Subarray Sum Equals K
        /// </summary>
        /// <returns></returns>
        public int SubarraySumEqualsK()
        {
            /**
                Given an array of integers and an integer k, you need to find the total number of continuous subarrays whose sum equals to k.

                Example 1:
                Input:nums = [1,1,1], k = 2
                Output: 2
                Note:
                The length of the array is in range [1, 20,000].
                The range of numbers in the array is [-1000, 1000] and the range of the integer k is [-1e7, 1e7].


            Possible Solutions:-
            1)[brute force] Find all sub array and calculate their sum equal k. 
            Time Complexity: O(n3)
            
            2)[Accepted] as below
            Instead of determining the sum of elements everytime for every new subarray considered, we can make use of a cumulative sum array , sumsum. Then, in order to calculate the sum of elements lying between two indices, we can subtract the cumulative sum corresponding to the two indices to obtain the sum directly, instead of iterating over the subarray to obtain the sum.
              In this implementation, we make use of a cumulative sum array, sumsum, such that sum[i]sum[i] is used to store the cumulative sum of numsnums array upto the element corresponding to the (i-1)^{th}(i−1)
            ​the index. Thus, to determine the sum of elements for the subarray nums[i:j]nums[i:j], we can directly use sum[j+1] - sum[i]sum[j+1]−sum[i

        Complexity Analysis
            Time complexity : O(n^2)Considering every possible subarray takes O(n^2) time. Finding out the sum of any subarray takes O(1)  time after the initial processing of O(n) for creating the cumulative sum array.
            Space complexity : O(n). Cumulative sum array sumsum of size n+1 is used.
             
             
            3) Without space. We can also not store in sum array

           check second version below

             * 
             * * 
             * * */

            int[] nums = { 1, 1, 1 };
            int k = 2;
            int count = 0;

            int[] sum = new int[nums.Length + 1];
            sum[0] = 0;

            for (int i = 1; i <= nums.Length; i++)
            {
                sum[i] = sum[i - 1] + nums[i - 1]; //comulative sum

                Console.Write($"{sum[i]},");
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j <= nums.Length; j++)
                {
                    Console.Write($"\nj={j},i={i} => {sum[j]}-{sum[i]}={sum[j] - sum[i]}");
                    if (sum[j] - sum[i] == k)
                        count++;
                }

            }
            Console.WriteLine($"\ncount={count}");
            return count;
        }

        /// <summary>
        /// Same as above without space consideration. I like this short version
        /// </summary>
        /// <returns></returns>
        public int SubarraySumEqualsKWithoutSpace()
        {
            /*
            Complexity Analysis
            Time complexity : O(n^2). We need to consider every subarray possible.

            Space complexity : O(1). Constant space is used.
             */


            int[] nums = { 1, 1, 1 };
            int k = 2;
            int count = 0;

            //int[] sum = new int[nums.Length + 1];
            //sum[0] = 0;

            //for (int i = 1; i <= nums.Length; i++)
            //{
            //    sum[i] = sum[i - 1] + nums[i - 1]; //comulative sum

            //    Console.Write($"{sum[i]},");
            //}
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j <= nums.Length; j++)
                {
                    //  Console.Write($"\nj={j},i={i} => {sum[j]}-{sum[i]}={sum[j] - sum[i]}");
                    sum += nums[j];

                    if (sum == k)
                        count++;
                }

            }
            Console.WriteLine($"\ncount={count}");
            return count;
        }
    }
}
