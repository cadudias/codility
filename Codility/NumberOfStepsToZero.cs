using System;

namespace Codility
{
	public class NumberOfStepsToZero
	{

		public int GetIntFromBinary(string binaryString)
		{
			int resultado = Convert.ToInt32(binaryString, 2);
			return resultado;
		}

		public int CheckNumberOfStepsToZero(string S)
		{

			int number = GetIntFromBinary(S);

			if (number == 1)
			{
				return 1;
			}

			var stepsToZero = 0;

			while (number > 0)
			{
				if (IsEven(number))
				{
					number /= 2;
					stepsToZero++;
				}
				else
				{
					number -= 1;
					stepsToZero++;
				}
			}

			return stepsToZero;
		}

		private static bool IsEven(int number)
		{
			return number % 2 == 0;
		}

	}
}
