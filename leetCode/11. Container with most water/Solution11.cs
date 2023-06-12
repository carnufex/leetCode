using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._11._Container_with_most_water
{
	public class Solution11
	{
		public int MaxArea(int[] height)
		{
			int area = 0;
			int left = 0;
			int right = height.Length - 1;
			while (left < right)
			{
				int currentArea = Math.Min(height[left], height[right]) * (right-left);
				area = Math.Max(area, currentArea);

				if (height[left] < height[right])
				{
					left += 1;
				}
				else
				{
					right -= 1;
				}
			}

			return area;
		}
		
	}
}
