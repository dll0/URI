﻿using System;
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

            String[] valores = new string[2];

            for (int i = 0; i < 2; i++)
            {
                valores[i] = Console.ReadLine();
                //Terminar
            }

            int codigo1 = int.Parse(valores[0]);
            int quant1 = int.Parse(valores[1]);
            double preco1 = double.Parse(valores[2]);
        }
    }
}
