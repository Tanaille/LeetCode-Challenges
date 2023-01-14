using System.ComponentModel;
using System.Numerics;

namespace _2._Add_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(9);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(9);

            //ListNode l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);
            //l2.next.next.next = new ListNode(9);

            ListNode l2 = new ListNode(1);
            ListNode currNode = l2;

            for (int i = 0; i < 9; i++)
            {
                currNode.next = new ListNode(9);
                currNode = currNode.next;
            }

            Console.WriteLine("L1: ");
            for (ListNode node = l1; node != null; node = node.next)
            {
                Console.Write(node.val);
            }

            Console.WriteLine("\n\nL2: ");
            for (ListNode node = l2; node != null; node = node.next)
            {
                Console.Write(node.val);
            }

            Console.WriteLine("\n\nSolution");

            ListNode l3 = Solution.AddTwoNumbers(l1, l2);
            for (ListNode node = l3; node != null; node = node.next)
            {
                Console.Write(node.val);
            }
        }
    }

    public class Solution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // Create variables and lists to hold the digits and reversed numbers
            // Note: BigInteger objects and unsigned long types are used due to some LeetCode test cases where
            // the answers are massive integer values that exceed the maximum lengths of all
            // integer and floating point types. There are other more memory efficient ways to
            // work with those huge integers but this method is simple and fast (in terms of execution time)
            BigInteger num1 = 0;
            BigInteger num2 = 0;
            List<ulong> numListL1 = new List<ulong>();
            List<ulong> numListL2 = new List<ulong>();

            // Add digits to the list in reverse order, in order to get the proper value
            for (ListNode node = l1; node != null; node = node.next)
            {
                numListL1.Insert(0, Convert.ToUInt64(node.val));
            }

            for (ListNode node = l2; node != null; node = node.next)
            {
                numListL2.Insert(0, Convert.ToUInt64(node.val));
            }

            // Combine the digits in each list to create a single integer representation of that list
            foreach (int num in numListL1)
            {
                num1 = 10 * num1 + (ulong)num;
            }

            foreach (int num in numListL2)
            {
                num2 = 10 * num2 + (ulong)num;
            }

            // Add the two integers
            BigInteger answer = num1 + num2;

            // Convert the answer number to a string, select each character in that string, convert it to an integer,
            // add it to an array and reverse the array. This is basically the reverse of the first steps of the method.
            int[] digits = answer.ToString().Select(x => int.Parse(x.ToString())).ToArray();
            Array.Reverse(digits);

            // Create a new ListNode (l3) head for the return linked list (initialized with the first index in the digits array),
            // as well as a node currNode representing the current node (assigned to the head of l3).
            ListNode l3 = new ListNode(digits[0]);
            ListNode currNode = l3;

            // For each index in the digits array (starting at index 1), create a new ListNode and assign index[i] to its value.
            // currNode keeps track of the current node and enables easy iteration over the linked list.
            for (int i = 1; i < digits.Length; i++)
            {
                currNode.next = new ListNode(digits[i]);
                currNode = currNode.next;
            }

            return l3;
        }
    }


    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}