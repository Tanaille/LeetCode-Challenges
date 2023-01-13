using System.Windows.Markup;

namespace _1._Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;

            int[] answer = Solution.TwoSum(nums, target);
            Console.WriteLine("[" + answer[0] + ", " + answer[1] + "]");
        }


    }

    public class Solution
    {
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
    }
}