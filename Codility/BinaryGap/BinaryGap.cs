using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility
{
	public class BinaryGap
	{
		public int CheckBinaryGap(int N)
		{
			if (N == 0 || N == 1) return 0;

			// 1001
			var stringBinary = Convert.ToString(N, 2);
			var totalNumbersInBinary = stringBinary.Split(); // 4
			var countZeroList = new List<int>();
			var countZero = 0;
			var countOne = 0;
			for (int i = 1; i < stringBinary.Length; i++)
			{
				if (stringBinary[i] == '0')
				{
					countZero++;
				}
				else { // se é 1
					countZeroList.Add(countZero);
					countZero = 0;
					countOne++;
				}
			}

			if (countOne == 0)
				return 0;

			return countZeroList.Select(q => q).Max();
		}
	}
}

// 1 - s 