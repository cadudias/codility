using Codility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityTest
{
	[TestFixture]
	public class Problem1Test
	{
		[TestCase("0-0", "00")]
		[TestCase("1  1", "11")]
		[TestCase("111", "111")]
		[TestCase("00-44  48 5555 8361", "004-448-555-583-61")]
		[TestCase("0 - 22 1985--324", "022-198-53-24")]
		public void test1(string S, string expected)
		{
			var cl = new Problem1();
			var result = cl.solution(S);

			Assert.AreEqual(expected, result);
		}
	}
}
