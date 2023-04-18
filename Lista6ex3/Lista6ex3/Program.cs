/* Nome: Samuel Rodrigues Cardilo Van Petten
 * Faça um programa que preencha um vetor com dez números inteiros, calcule e
mostre o vetor resultante colocando os elementos em ordem decrescente*/

using System;

namespace Lista6ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[] num = new int[10];
            // Preencher o valor dos números
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rd.Next(0, 1000);
            }
            // Inverte a ordem dos números para ficar decrescente
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {   // Se o num não estiver em ordem decrescente entra no if
                    if (num[i] < num[j])
                    {
                        // Soma a posição [i] com a [j] para não ser substituído pela sequência
                        num[i] += num[j];
                        // Guarda em [j] a diferença entre o valor atual de num[i] e o valor original de num[j]
                        num[j] = num[i] - num[j];
                        // subtrai o valor do elemento pela diferença para assim inverter a ordem
                        num[i] -= num[j];
                    }
                }
            }
            // Mostrar na tela os números em ordem decrescente
            Console.WriteLine("Ordem Decrescente:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}