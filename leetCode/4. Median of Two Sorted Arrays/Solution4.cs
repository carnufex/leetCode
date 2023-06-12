using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._4._Median_of_Two_Sorted_Arrays
{
	public class Solution4
	{
		public Solution4()
		{
			int[] nums1 = { };
			int[] nums2 = { 3, 4 };
			
            Console.WriteLine($"Solution 4: {FindMedianSortedArrays(nums1, nums2)}");
        }

		public double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			int len1 = nums1.Length;
			int len2 = nums2.Length;
			int[] merged = new int[len1 + len2];
			int i = len1 - 1;
			int j = len2 - 1;
			int k = len1 + len2 - 1;

			while (i >= 0 && j >= 0)
			{
				if (nums1[i] > nums2[j])
				{
					merged[k] = nums1[i];
					i--;
				}
				else
				{
					merged[k] = nums2[j];
					j--;
				}
				k--;
			}

			while (j >= 0)
			{
				merged[k] = nums2[j];
				j--;
				k--;
			}

			while (i >= 0)
			{
				merged[k] = nums1[i];
				i--;
				k--;
			}

            int mid = merged.Length / 2;
			if (merged.Length % 2 == 0)
			{
				return (merged[mid - 1] + merged[mid]) / 2.0d;
			}

			return merged[mid];
		}
	}
}
