using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1010_CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, 
            o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

            Entrada
            O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

            Saída
            A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". 
            O valor deverá ser apresentado com 2 casas após o ponto.
            */

            String pecas_1 = Console.ReadLine();
            String pecas_2 = Console.ReadLine();

            pecas_1 = pecas_1.Replace(" ", "");
            pecas_2 = pecas_1.Replace(" ", "");

            int codigo_1 = Convert.ToInt32(pecas_1[0]);
            int quantidade_1 = Convert.ToInt32(pecas_1[1]);
            double preco_1 = Convert.ToDouble(pecas_1[2]);

            Console.WriteLine(pecas_1 + ", " + pecas_2);
        }
    }
}
