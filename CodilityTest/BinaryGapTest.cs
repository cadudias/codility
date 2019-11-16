using Codility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityTest
{
	[TestFixture]
	public class BinaryGapTest
	{
		[TestCase(0, 0)]
		[TestCase(1, 0)]
		[TestCase(9, 2)]
		[TestCase(529, 4)]
		[TestCase(1041, 5)]
		[TestCase(15, 0)]
		[TestCase(32, 0)]
		public void CheckBinaryGap_ForBinary_ShouldReturnNumberOfZeros(int number, int expectedResult)
		{
			var binaryGap = new BinaryGap();
			var result = binaryGap.CheckBinaryGap(number);
			Assert.AreEqual(expectedResult, result);
		}
	}
}
