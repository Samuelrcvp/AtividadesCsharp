/*Nome: Samuel Rodrigues Cardilo Van Petten
 Faça um programa para preencher um vetor com 100 valores inteiros e verificar
se existem elementos iguais a zero. Se existirem, imprima as posições em que
estão armazenados.*/

using System;

namespace Lista6ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[100]; 
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                vetor[i] = random.Next(0, 10);
                Console.WriteLine("Posição " + i + " = " + vetor[i]);
            }
            for (int i = 0; i < 100; i++)
            {
                if (vetor[i] == 0)
                {
                    Console.WriteLine("O número na posição " + i + " é igual a zero.");
                }
            }
        }
    }
}