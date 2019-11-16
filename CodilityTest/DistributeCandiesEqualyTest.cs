using Codility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityTest
{
	public class DistributeCandiesEqualyTest
	{
		[TestCase(new int[] { 1, 2 }, 1)]
		[TestCase(new int[] { 1, 2, 3, 4 }, 2)]
		[TestCase(new int[] { 1, 2, 2, 2 }, 2)]
		[TestCase(new int[] { 3, 4, 4, 7, 7, 6, 6 }, 3)]
		[TestCase(new int[] { 80, 80, 10000000, 80, 80, 80, 80, 80, 80, 123456789 }, 3)]


		public void Test1(int[] candies, int expectedResult)
		{
			var calss1 = new DistributeCandiesEqualy();
			var result = calss1.DistributeCandies(candies);
			Assert.AreEqual(expectedResult, result);
		}		
	}
}
