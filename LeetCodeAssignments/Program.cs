using System;

namespace LeetCodeAssignments
{
    class LeetCodeAssignments
    {
        static void Main(string[] args)
        {
            IsPalindrome(121);
        }
        static bool IsPalindrome(int x)
        {
            var y = x.ToString().ToCharArray();
            Array.Reverse(y);
            return x.ToString() == new String(y);
        }

        static int RomanToInteger(string s)
        {
            int answer = 0;
            int num = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                switch (s[i])
                {
                    case 'I':
                        num = 1;
                        break;
                    case 'V':
                        num = 5;
                        break;
                    case 'X':
                        num = 10;
                        break;
                    case 'L':
                        num = 50;
                        break;
                    case 'C':
                        num = 100;
                        break;
                    case 'D':
                        num = 500;
                        break;
                    case 'M':
                        num = 1000;
                        break;

                }
                if (num * 4 < answer)
                {
                    answer -= num;
                }
                else
                {
                    answer += num;
                }
            }
            return answer;
        }
        static string LongestCommonPrefix(string[] str)
        {
            if (str.Length == 0 && str == null)
            {
                return "";
            }

            string prefix = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                int j = 0;
                while (j < prefix.Length && j < str[i].Length && prefix[j] == str[i][j])
                {

                    j++;
                }

                prefix = prefix.Substring(0, j);
            }
            return prefix;
        }
        static bool IsValid(string s)
        {
            while (s.Contains("()") && s.Contains("{}") && s.Contains("[]"))
            {
                s = s.Replace("{}", "").Replace("()", "").Replace("{}", "");
            }
            return s.Length == 0;
        }
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
        static ListNode MergeTwoSortedList(ListNode list1, ListNode list2)
        {
            if(list1 == null) { return list2; }
            if(list2 == null) { return list1; }

            if(list1.val <= list2.val)
            {
                list1.next = MergeTwoSortedList(list1.next,list2); 
                return list1;
            }
            else
            {
                list2.next = MergeTwoSortedList(list1, list2.next);
                return list2;
            }
        }
        static int RemoveDublicates(int[] nums)
        {
            int k = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                if(nums[i] != nums[i - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
        static int RemoveElement(int[] nums, int val)
        {
            int current = 0; 
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    nums[current] = nums[i];
                    current++;
                }
            }
            return current;
        }
        static int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0) { return 0; }

            for(int i = 0; i < haystack.Length - needle.Length; i++)
            {
                if(haystack.Substring(i, needle.Length)== needle)
                {
                    return i;   
                }
            }
            return -1;
        }
    }

}
