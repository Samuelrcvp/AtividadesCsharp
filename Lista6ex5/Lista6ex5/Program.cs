/* Nome: Samuel Rodrigues Cardilo Van Petten
Dados dois vetores:
A – 8 elementos do tipo inteiro
B – 12 elementos do tipo inteiro
Faça um programa que leia os dois vetores A e B, gere o vetor C correspondente a
união dos vetores A e B. */

using System;

namespace Lista6ex5
{
    class Program
    {
        static void Main(string[] args)
        {   Random rd = new Random();
            int[] A = new int[8];
            int[] B = new int[12];
            int[] C = new int[A.Length + B.Length];
            Console.WriteLine("Vetor A:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rd.Next(0, 100);
                Console.WriteLine("Posição " + i + " = " + A[i]);
            }
            Console.WriteLine("Vetor B:");
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = rd.Next(0, 50);
                Console.WriteLine("Posição " + i + " = " + B[i]);
            }
            Console.WriteLine("Vetor C:");
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                C[A.Length + i] = B[i];
            }
            for (int i = 0; i < C.Length; i++)
            {
                Console.WriteLine("Posição "+i+" = " + C[i]);
            }
        }
    }
}
