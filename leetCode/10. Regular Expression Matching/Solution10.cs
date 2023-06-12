using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._10._Regular_Expression_Matching
{
	public class Solution10
	{
		public Solution10()
		{
			string s = "abcccde";
			string p = "abccc.*e";

			bool isSubstring = IsMatch(s, p);
			Console.WriteLine($"{isSubstring}, {p} is a substring of {s}");
		}

		/**
		 * The IsMatch method checks if a given string 's' matches a pattern 'p'.
		 * It uses the IsSubstringRecursive helper method to perform the matching.
		 * @param s: The input string to be matched.
		 * @param p: The pattern string to match against.
		 * @return: Returns true if 's' matches the pattern 'p', false otherwise.
		 */
		public bool IsMatch(string s, string p)
		{
			return IsSubstringRecursive(s, p, 0, 0);
		}

		/**
		 * The IsSubstringRecursive method is a helper function that performs the actual matching between
		 * a given string 's' and a pattern 'p' recursively.
		 * @param s: The input string to be matched.
		 * @param p: The pattern string to match against.
		 * @param sIndex: The current index of 's' being processed.
		 * @param pIndex: The current index of 'p' being processed.
		 * @return: Returns true if 's' matches the pattern 'p', false otherwise.
		 */
		private bool IsSubstringRecursive(string s, string p, int sIndex, int pIndex)
		{
			// Base case: If both 's' and 'p' have been completely processed, return true.
			if (sIndex == s.Length && pIndex == p.Length)
				return true;

			// Base case: If 'p' has been completely processed but 's' still has characters, return false.
			if (pIndex == p.Length)
				return false;

			// If the next character in 'p' is '*', handle it separately.
			if (pIndex + 1 < p.Length && p[pIndex + 1] == '*')
			{
				// Check if 's' matches the pattern with '*' (zero occurrence of the preceding character).
				if (IsSubstringRecursive(s, p, sIndex, pIndex + 2))
					return true;

				// Check if the current character in 'p' matches the current character in 's'.
				// If there is a match, move to the next character in 's' and continue matching.
				if (sIndex < s.Length && (p[pIndex] == '.' || p[pIndex] == s[sIndex]))
				{
					if (IsSubstringRecursive(s, p, sIndex + 1, pIndex))
						return true;
				}
			}
			else if (sIndex < s.Length && (p[pIndex] == '.' || p[pIndex] == s[sIndex]))
			{
				// If the current character in 'p' is not '*', check if it matches the current character in 's'.
				// If there is a match, move to the next characters in both 's' and 'p' and continue matching.
				return IsSubstringRecursive(s, p, sIndex + 1, pIndex + 1);
			}

			// If none of the above conditions are satisfied, return false.
			return false;
		}
	}
}
