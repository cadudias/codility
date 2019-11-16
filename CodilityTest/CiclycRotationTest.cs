using Codility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityTest
{
	[TestFixture]
	public class CiclycRotationTest
	{
		[Test]
		public void TestRotate() {
			int[] A = new int[] {3, 8, 9, 7, 6};
			//int[] A = new int[] { 1, 2, 3, 4 };  

			var test = new CiclycRotation();
			var result = test.Rotate(A, 3);

			Assert.AreEqual(new int[]{ 9, 7, 6, 3, 8 }, result);
		}
	}
}
