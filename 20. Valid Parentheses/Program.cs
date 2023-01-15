namespace _20._Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "{[]}";
            string s2 = "()[]";
            Console.WriteLine(Solution.IsValid(s1));
        }
    }

    public class Solution
    {
        public static bool IsValid(string s)
        {
            Dictionary<char, char> brackets = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            Dictionary<char, char> inverseBrackets = new Dictionary<char, char>()
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };

            // Check if array length is uneven. For valid parentheses to exist, each bracket
            // needs a matching closing bracket. If the number of characters is uneven, then
            // one bracket must not have a matching bracket.
            if ((s.Length % 2) != 0)
            {
                return false;
            }

            List<char> closingBrackets = new List<char>();
            List<char> openingBrackets = new List<Char>();

            string tmp = s.Substring(0, s.IndexOf(brackets[s[0]]) + 1);

            if (tmp.Length > 2) 
            { 
                
            }
            

            return true;
        }
    }
}