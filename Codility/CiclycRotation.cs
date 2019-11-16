using System;
using System.Collections.Generic;
using System.Text;

namespace Codility
{
	public class CiclycRotation
	{
		public int[] Rotate(int[] A, int K) {
			int[] B = new int[A.Length];

			for (int i = 0; i < A.Length; i++)
			{
				B[(i + K) % A.Length] = A[i];
			}

			return B;
		}
	}
}
