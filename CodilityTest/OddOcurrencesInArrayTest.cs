using Codility.OddOccurencesInArray;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityTest
{
	[TestFixture]
	public class OddOcurrencesInArrayTest
	{
		[TestCase(new int[] { 1, 1, 2 }, 2)]
		[TestCase(new int[] { 2, 1, 1 }, 2)]
		[TestCase(new int[] { 1, 1, 2, 2, 3 }, 3)]
		[TestCase(new int[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
		public void CheckOddOcurrencesInArray_For3elementArray_1_1_2_Return2(int[] array, int expectedResult)
		{
			var oddOcurrences = new OddOcurrencesInArray();
			var result = oddOcurrences.CheckOddOcurrencesInArray(array);
			Assert.AreEqual(expectedResult, result);
		}
	}
}
