using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.OddOccurencesInArray
{
	public class OddOcurrencesInArray
	{
		public int CheckOddOcurrencesInArray(int[] A)
		{
			var numberUnpaired = 0; 
			for (int i = 0; i < A.Length; i++)
			{
				var indexAtual = i;
				var numToRemove = A[i];
				A = A.Where((val, idx) => idx != indexAtual).ToArray();

				// varre a o array ate achar o igual
				var numberEqual = A.Where(n => n == numToRemove).FirstOrDefault();
				// se achou um igual, salva o indexEncontrado desse, no caso seria 0 pq ja removeu o primeiro 1
				var indexEncontrado = Array.IndexOf(A, numberEqual); // 0

				if (indexEncontrado != -1)
				{

					// remove do array o indexAtual 0 e o indexEncontrado 1
					A = A.Where((val, idx) => idx != indexEncontrado).ToArray();

					// verifica se o array tem so um elemento
					// se sim retorna ele
					if (A.Length == 1)
						numberUnpaired = A[0];
				}
				else {
					numberUnpaired = numToRemove;
				}
			}

			return numberUnpaired;
		}
	}
}
