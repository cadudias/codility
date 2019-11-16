using Codility;
using NUnit.Framework;

namespace CodilityTest
{
	public class NumberOfStepsToZeroTest
	{
		[TestCase("011100", 7)]
		[TestCase("0111", 5)]
		[TestCase("10", 2)]
		public void CheckNumberOfStepsToZero(string number, int expectedNumber)
		{
			var calss1 = new NumberOfStepsToZero();
			var result = calss1.CheckNumberOfStepsToZero(number);
			Assert.AreEqual(expectedNumber, result);
		}
	}
}
