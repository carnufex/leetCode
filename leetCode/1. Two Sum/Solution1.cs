using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1._Two_Sum
{
	public class Solution1
	{
		public Solution1()
		{
			int[] nums = new int[4] { 2, 7, 11, 15 };
            Console.WriteLine($"Solution 1: {string.Join("", TwoSum(nums, 9))}"); 
		}

		public int[] TwoSum(int[] nums, int target)
		{
			Dictionary<int, int> complements = new();

			for (int i = 0; i < nums.Length; i++)
			{
				int complement = target - nums[i];
				if (complements.ContainsKey(complement))
				{
					return new int[] { complements[complement], i };
				}

				complements[nums[i]] = i;
			}

			return null;
		}
	}
}
