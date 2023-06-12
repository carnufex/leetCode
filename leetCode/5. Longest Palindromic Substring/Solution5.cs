using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._5._Longest_Palindromic_Substring
{
	public class Solution5
	{
		public Solution5()
		{
            Console.WriteLine($"Solution 5: {LongestPalindrome("babad")}");
        }

		public string LongestPalindrome(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return string.Empty;
			}

			int start = 0;
			int end = 0;

			for (int i = 0; i < s.Length; i++)
			{
				int len1 = ExpandAroundCenter(s, i, i); // For odd-length palindromes
				int len2 = ExpandAroundCenter(s, i, i + 1); // For even-length palindromes
				int len = Math.Max(len1, len2);

				if (len > end - start)
				{
					start = i - (len - 1) / 2;
					end = i + len / 2;
				}
			}

			return s.Substring(start, end - start + 1);
		}

		private static int ExpandAroundCenter(string s, int left, int right)
		{
			while (left >= 0 && right < s.Length && s[left] == s[right])
			{
				left--;
				right++;
			}

			return right - left - 1;
		}
	}
}
