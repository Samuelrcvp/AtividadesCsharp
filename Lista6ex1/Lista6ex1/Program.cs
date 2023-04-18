/*Nome: Samuel Rodrigues Cardilo Van Petten
 Faça um programa para preencher um vetor com 30 valores quaisquer do tipo
inteiro e contabilizar o número de elementos iguais a ‘10`.
 */
using System;

namespace Lista6ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int cont = 0;
            int[] vet = new int[30];
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rd.Next(0, 20);
                Console.WriteLine("Posição " + i + " = " + vet[i]);
                if (vet[i] == 10)
                {
                    cont++;
                }
            }
            Console.WriteLine("Existem um total de " + cont + " números iguais a 10");
        }
    }
}
