namespace _9._Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.IsPalindrome(2552));
        }
    }

    public class Solution
    {
        public static bool IsPalindrome(int x)
        {
            bool isPalindrome = true;
            string number = x.ToString();

            for (int i = 0, j = (number.Length - 1); i < number.Length; i++)
            {
                if (number[i] != number[j])
                    isPalindrome = false;

                j--;
            }

            return isPalindrome;
        }
    }
}