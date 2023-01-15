namespace _13._Roman_to_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.RomanToInt("CMXCI"));
        }
    }

    public class Solution
    {
        public static int RomanToInt(string s)
        {
            int value = 0;

            // Dictionary for single value numerals.
            Dictionary<char, int> numerals = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            // Dictionary for numerals where the subtraction rules apply.
            Dictionary<string, int> combinedNumerals = new Dictionary<string, int>()
            {
                { "IV", 4 },
                { "IX", 9 },
                { "XL", 40 },
                { "XC", 90 },
                { "CD", 400 },
                { "CM", 900 }
            };

            // Loop throught the input string. Get each instance of a 2-character substring and try to match against
            // the combinedNumerals dictionary. If a match is found, add the corrosponding value to the value variable,
            // then remove the substring from the input string. Subtract 1 from the iterator if a substring is removed
            // to prevent character skips.
            for (int i = 0; i < s.Length - 1; i++)
            {
                string substring = s.Substring(i, 2);

                if (combinedNumerals.ContainsKey(substring))
                {
                    value += combinedNumerals[substring];
                    s = s.Remove(i, 2);
                    i--;
                }
            }

            // This loop iterates over the input string after all 2-character value have been removed. It simply
            // adds the dictionary value of each remaining character to the value variable.
            for (int i = 0; i < s.Length; i++)
            {
                value += numerals[s[i]];
            }

            return value;
        }
    }
}