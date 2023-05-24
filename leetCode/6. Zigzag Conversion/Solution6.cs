using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._6._Zigzag_Conversion
{
	public class Solution6
	{
		public Solution6()
		{
			string s = "PAYPALISHIRING";
			Console.WriteLine($"Solution 6: {this.Convert(s, 4)}");
		}

		public string Convert(string s, int numRows)
		{
			if (numRows == 1) return s;

			string[] results = new string[numRows];

			int index = 0;
			int offset = 1;
			foreach (char letter in s)
			{
				results[index] += letter.ToString();
				
				if (index == numRows-1)
				{
					offset = -1;
				}
				else if (index == 0)
				{
					offset = 1;
				}
				index += offset;
			}

			return string.Join("", results);
		}
	}
}
