using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility
{
	public class Problem2
	{
		public int Solution(int[] a)
		{
			if (a.Length == 0 || a.Length == 1)
				return 0;

			List<int> distances = new List<int>();
			for (int i = 0; i < a.Length; i++)
			{
				for (int j = i + 1; j < a.Length; j++)
				{
					if (a[i] == a[j])
						return 0;

					IEnumerable<int> numbersToCheckBetween = Enumerable.Range(a[i] + 1, a[j] - 1);

					// verifica se existe algum deles no array
					if (!a.Any(n => numbersToCheckBetween.Contains(n)))
					{
						var distance = a[i] - a[j];
						if (distance == 0)
						{
							return distance;
						}
						else if (distance > 0)
						{
							distances.Add(distance);
						}
					}
				}			
			}

			if (!distances.Any())
				return -2;

			if (distances.Min() > 100000000)
				return -1;

			return distances.Min();
		}
	}
}

//if (a[i] == prev)
//				{
//					currentCount++;

//					//pair current value with all previous equal values
//					//plus all values equal to the current one, eg: 1 1 1 2 2(current)
//					result += previousCount + currentCount - 1;
//				}
//				else
//				{
//					//a new value, pair it with all previous equal values
//					result += currentCount;
//					previousCount = currentCount;
//					currentCount = 1;
//				}
//				prev = a[i];
