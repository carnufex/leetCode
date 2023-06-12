using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._7._Reverse_Integer
{
	public class Solution7
	{
		public Solution7()
		{
			int x = 1534236469;
			int rev = Reverse(x);
            Console.WriteLine($"Solution 7: input: {x}, reversed: {rev}");
        }

		public int Reverse(int x)
		{
			int result = 0;
			while (x != 0)
			{
				int digit = x % 10;
				int newResult = result * 10 + digit;

				// Check for overflow
				if ((newResult - digit) / 10 != result)
				{
					return 0;
				}

				result = newResult;
				x /= 10;
			}
			return result;
		}
	}
}
