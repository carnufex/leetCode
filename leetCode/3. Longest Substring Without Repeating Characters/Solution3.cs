using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace leetCode._3._Longest_Substring_Without_Repeating_Characters
{
	public class Solution3
	{
		/**
		 * Could have used 2 pointers and a string as an alternative to improve the running time.
		 * Move right pointer as far as the string lets us without having duplicates, then move the left pointer when there is duplicates
		 *
		 */

		public Solution3()
		{
            Console.WriteLine($"Solution 3: {LengthOfLongestSubstring("dvdf")}");
        }

		public int oldMax { get; private set; } = 0;

		public int LengthOfLongestSubstring(string s)
		{
			HashSet<char> set = new();
			int j = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (set.Contains(s[i]))
				{
					CheckLengthOfSet(set);
					set.Clear();
					i = ++j;
				}
				set.Add(s[i]);
			}
			CheckLengthOfSet(set);

			return oldMax;
		}

		private void CheckLengthOfSet(HashSet<char> set)
		{
			if (set.Count > oldMax)
			{
				oldMax = set.Count;
			}
		}
	}
}
