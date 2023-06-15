using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._12._Integer_to_Roman
{
	public class Solution12
	{
		Dictionary<int, string> numbers = new();

		public Solution12()
		{
			numbers.Add(1000, "M");
			numbers.Add(900, "CM");
			numbers.Add(500, "D");
			numbers.Add(400, "CD");
			numbers.Add(100, "C");
			numbers.Add(90, "XC");
			numbers.Add(50, "L");
			numbers.Add(40, "XL");
			numbers.Add(10, "X");
			numbers.Add(9, "IX");
			numbers.Add(5, "V");
			numbers.Add(4, "IV");
			numbers.Add(1, "I");
		}

		public string IntToRoman(int num)
		{
			string roman = "";
			foreach (var item in numbers)
			{
				while (num >= item.Key)
				{
					num -= item.Key;
					roman += item.Value;
				}
			}
			return roman;
		}
	}
}
