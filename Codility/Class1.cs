using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility
{
	public class Class1
	{
		
		public int GetGreaterNecklace(int[] beads)
		{
			// pegar a posicao 0 do array e achar qual posicao do array tem esse valor
			// exemplo 

			if (beads.Length == 1)
				return 1;

			var count = 0;
			var startingValue = 0;
			for (int i = 0; i < beads.Length; i++)
			{
				int index = Array.IndexOf(beads, startingValue); // 0 esta na pos 2
				var value = beads[index]; // 0
				startingValue = index; // agora é 2
				//var pos = beads[value]; // 0 esta na pos 2
				if (value > 0) {
					count++;
				}

			}

			return count;
			// exemplo o valor 0 esta na poscao 2

			// exemplo o valor 2 esta na poscao 6

			// exemplo o valor 6 esta na poscao 5

			// exemplo o valor 5 esta na poscao 0 - se voltou pra 0 termina

			// achar o 5 nno array
			return 0;
		}
	}
}

