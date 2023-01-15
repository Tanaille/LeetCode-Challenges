using System.Globalization;

namespace _14._Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };

            Console.WriteLine(Solution.LongestCommonPrefix(strs));
        }
    }

    public class Solution
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            List<char> prefixChars = new List<char>();      // List containing the matching characters, which will be returned as a string
            char[] currentChars = new char[strs.Length];    // Holds the current characters that are being checked of each string
            bool isEqual = true;                            // Indicates whether the current characters are the same
            int stringCharIndex = 0;                        // Holds the index of the next character in each string to check

            // Return an empty string if argument array is empty
            if (strs.Length == 0 )
            {
                return string.Empty;
            }

            // If there is only one string in the argument array, return that string
            if (strs.Length == 1 )
            {
                return strs[0];
            }

            // If all the input strings are empty, return an 
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i] != string.Empty)
                    continue;
                else
                    return string.Empty;
            }

            // While the current characters are all the same, check the characters at index i in each string and 
            // compare for equality.
            while (isEqual)
            {
                // Store the current character for each string
                for (int i = 0; i < strs.Length; i++)
                {
                    currentChars[i] = strs[i][stringCharIndex];
                }

                // Increment the string character index for the followin loop
                stringCharIndex++;

                // Check if all the characthers in the currentChars array are the same (using the first character as the check value)
                char firstChar = currentChars[0];

                isEqual = currentChars.Skip(1).All(c => Equals(firstChar, c));

                // If all the characters are equal, add that character to the prefixChars list
                if (isEqual)
                {
                    prefixChars.Add(currentChars[0]);
                }

                // Index bounds checking for stringCharIndex. If the index is larger than the length of one of the input strings, 
                // set isEqual to false to exit the while loop and return the prefixChars list as a string. This check prevents
                // IndexOutOfBounds exceptions due to input strings of dissimilar lengths
                for (int i = 0; i < strs.Length; i++) 
                {
                    if (stringCharIndex >= strs[i].Length)
                    {
                        isEqual = false;
                    }
                }
            }

            return new string(prefixChars.ToArray());
        }
    }
}