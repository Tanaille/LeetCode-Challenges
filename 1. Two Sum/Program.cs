using System.Buffers;
using System.Windows.Markup;

namespace _1._Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 3 };
            int target = 6;

            int[] answer = Solution.TwoSumHashmap(nums, target);
            Console.WriteLine("[" + answer[0] + ", " + answer[1] + "]");
        }
    }

    // For a small dataset such as the example inputs,
    // the run time seems to be similar to the hashmap version. Larger input 
    // arrays will perform better on the hashmap version.
    public class Solution
    {
        // Own solution, runs in O(n^2) time complexity. 
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] indices = new int[2];

            for (int i = 0; i < (nums.Length); i++)
            {
                for (int j = 0; j < (nums.Length); j++)
                {
                    if (i == j)
                        break;

                    if (nums[i] + nums[j] == target)
                    {
                        indices[0] = j;
                        indices[1] = i;
                    }    
                }
            }

            return indices;
        }

        // Solution from ChatGPT using a dictionary. Runs in O(n) time complexity
        public static int[] TwoSumHashmap(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            throw new Exception("No two sum solution");
        }
    }
}