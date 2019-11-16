using System;
using System.Collections.Generic;
using System.Text;

namespace Codility
{
	// é um problema de limpeza de string
	// daria pra usar mode de 3 pra ir reformatadno????

	// removder todos os espcaos e dashes prim eiro sobrando só os numeros

	// no0 exemplo fiocaria "00444855558361" = 14 numeros - 14 % 3 = 2 sei que sobram 2 numeros no final
	// se o indice que sesta for mod de 3 = 0 - adiciona o -

	// comecar o for no 1
	// 0 - indice 1 - apenda na string fpormatada
	// 0 - indice 2 - apenda na string fpormatada
	// 4 - indice 3 - 3 % 3 = 0 - appenda um - na string fpormatada nessa posição
	// 4 - indice 4 - apenda na string fpormatada
	// 4 - indice 5 - apenda na string fpormatada
	// 8 - indice 6 - 3 % 3 = 0 - appenda um - na string fpormatada nessa posição

	// seguindo o exemplo teria que ir vendo cada caracter da string e 
	// 
	// 

	//a string S consiste de N characters, 
	//espaço 
	//e ou dashes - e contam pelo menos 2 digitos

	//os espaços e dashes podem ser ignorados -- ---1

	//o agrupamento dos numeros do telefone devem ser em grupos de 3 digitos

	//separado por um dash simpl,es

	//se necessario os ultimos blocos devemn ter tamanho 2

	//exemplo

	//S = "00-44  48 5555 8361"

	//o formatado sera "004-448-555-583-61"

	//N é inteiro com tamanho até 100

	//S contem pelo menos 2 digitos

	public class Problem1
	{
		//public string reformata(string S)
		//{
		//string cleanS = S.Replace("-", "").Replace(" ", "");
		//if (cleanS.Length == 2) 
		//	return cleanS;

		//return string.Format("{0:###-###-###-###-##}", double.Parse(cleanS));

		//StringBuilder sb = new StringBuilder();
		//for (int i = 0; i < cleanS.Length; i++)
		//{
		//	GroupBy3(cleanS, sb, i);

		//	if ((i + 1) % 3 != 0)
		//		sb.Append(cleanS[i]);
		//}


		// 0 - 22 1985--324
		// 022-198-53-24 - 10 % 3 = 1 - 
		// 10 / 3 = 3 - da pra dividir 3 vezes mas se o resto é 1 
		// teria que dividir por 3 duas vezes e por 2 2 vezes 
		// na terceira seria 


		//  aprimeira coisa a se fazer é ver se vai sobrar 1 ou 2 numeros nno fim
		// se sobrar 1 - S.Length % 3
		// divide S.Lenght por 3 = 3 , diminui 1 pq da pra agrupar 2 vezes por 3
		// faz o agrupamento por 3
		// senao 

		// se sobrar 1 

		// 004-448-555-583-61 - 14 % 3 = 2
		// 14 / 3 = 4 - da pra divir 4 vezes e sobra 2 numero

		// se op resto é 1, não vai dar pra deixar so um no fim
		// se é 2 da pra deixar os dois no fim como ja esta


		// a cada iteracao verificar se o numero de posicoes restantes é 
		// divisivel por 

		// 0 - indice 1 = apenda na string formatada
		// 2 - indice 2 = apenda na string formatada
		// 2 - indice 3 = apenda na string formatada e adiciona o -
		// 1 - indice 4 = apenda na string formatada
		// 9 - indice 5 = apenda na string formatada
		// 8 - indice 6 = apenda na string formatada
		// 5 - indice 7 = apenda na string formatada
		// 3 - indice 8 = apenda na string formatada
		// 2 - indice 9 = apenda na string formatada
		// 4 - indice 10 = apenda na string formatada

		//return sb.ToString();
		//}

		public string solution(string S)
		{
			var cleanS = S.Replace("-", "").Replace(" ", "");

			if (cleanS.Length <= 3)
				return cleanS;

			var dashCount = 0;
			StringBuilder formatedPhone = new StringBuilder();

			for (int i = 0; i < cleanS.Length; i++)
			{
				if (dashCount == 3)
				{
					formatedPhone.Append("-");
					formatedPhone.Append(cleanS[i]);
					dashCount = 1;
				}
				else if (dashCount < 3)
				{
					formatedPhone.Append(cleanS[i]);
					dashCount++;
				}
			}

			var hasLastGroupToRearrange = cleanS.Length % 3 == 1;
			if (hasLastGroupToRearrange)
			{
				char[] rearrangedPhone = formatedPhone.ToString().ToCharArray();
				rearrangedPhone[rearrangedPhone.Length - 2] = rearrangedPhone[rearrangedPhone.Length - 3];
				rearrangedPhone[rearrangedPhone.Length - 3] = '-';
				return new string(rearrangedPhone);
			}

			return formatedPhone.ToString();
		}
	}
}
