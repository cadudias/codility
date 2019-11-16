using System;
using System.Linq;

namespace Codility
{
	public class DistributeCandiesEqualy
	{

		public int DistributeCandies(int[] candies)
		{
			candies = candies.OrderBy(c => c).ToArray();
			int candiesToGet = 1;
			for (int i = 1; i < candies.Length && candiesToGet < candies.Length / 2; i++)
			{
				var actualCandy = candies[i];
				var previousCandy = candies[i - 1];
				if (actualCandy > previousCandy)
				{
					candiesToGet++;
				}
			}
			return candiesToGet;
			/*
			int count = 0;
			for (int i = 0; i < candies.Length && count < candies.Length / 2; i++)
			{
				if (candies[i] != Int32.MinValue)
				{
					count++;
					for (int j = i + 1; j < candies.Length; j++)
					{
						if (candies[j] == candies[i])
						{
							candies[j] = Int32.MinValue;
						}
					}
				}
			}
			return count;
			*/
		}

		//	public int distributeCandiesSorted(int[] candies)
		//	{
		//		candies = candies.OrderBy(c => c).ToArray();
		//		int candiesToGet = 1;
		//		for (int i = 1; i < candies.Length && candiesToGet < candies.Length / 2; i++)
		//		{
		//			var actualCandy = candies[i];
		//			var previousCandy = candies[i - 1];
		//			if (actualCandy > previousCandy)
		//			{
		//				candiesToGet++;
		//			}
		//		}
		//		return candiesToGet;
		//	}

		//	int max_kind = 0;
		//	public int distributeCandies2(int[] nums)
		//	{
		//		permute(nums, 0);
		//		return max_kind;
		//	}

		//	public void permute(int[] nums, int l)
		//	{
		//		if (l == nums.Length - 1)
		//		{
		//			HashSet<int> set = new HashSet<int>();
		//			for (int i = 0; i < nums.Length / 2; i++)
		//			{
		//				set.Add(nums[i]);
		//			}
		//			max_kind = Math.Ceiling(max_kind, set.Count);
		//		}
		//		for (int i = l; i < nums.Length; i++)
		//		{
		//			swap(nums, i, l);
		//			permute(nums, l + 1);
		//			swap(nums, i, l);
		//		}
		//	}
		//	public void swap(int[] nums, int x, int y)
		//	{
		//		int temp = nums[x];
		//		nums[x] = nums[y];
		//		nums[y] = temp;
		//	}
		//}

	}
}
