using Codility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityTest
{
	[TestFixture]
	public class Problem2Test
	{
		[Test]
		public void test1()
		{
			var array = new int[] { 0, 3, 3, 7, 5, 3, 11, 1 };
			var cl = new Problem2();
			var result = cl.Solution(array);
			Assert.AreEqual(0, result);
		}
	}
}
