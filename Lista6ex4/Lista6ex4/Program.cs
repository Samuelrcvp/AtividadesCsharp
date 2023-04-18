/* Nome: Samuel Rodrigues Cardilo Van Petten
Faça um programa que receba a temperatura média de cada mês do ano,
armazenando-as em um vetor. Calcule e mostre a maior e a menor
temperatura do ano e em que mês ocorreram (quando for imprimir, mostrar o
mês por extenso: 1- Janeiro, 2- fevereiro, ...) Desconsidere empates. */

using System;

namespace Lista6ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperaturaMedia = new int[12];
            string[] meses = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho","Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
                              
            int maiorTemperatura = int.MinValue, menorTemperatura = int.MaxValue;
            int posicaoMaiorTemp = 0, posicaoMenorTemp = 0;
            /* testar: Random rd = new Random();*/

            for (int i = 0; i < temperaturaMedia.Length; i++)
            {
                Console.Write("Digite a temperatura média do mês " + meses[i] + ":");
                temperaturaMedia[i] = int.Parse(Console.ReadLine());
                /* testar: temperaturaMedia[i] = rd.Next(-20, 50);*/
            }

            for (int i = 0; i < temperaturaMedia.Length; i++)
            {
                if (temperaturaMedia[i] > maiorTemperatura)
                {
                    maiorTemperatura = temperaturaMedia[i];
                    posicaoMaiorTemp = i;
                }
                if (temperaturaMedia[i] < menorTemperatura)
                {
                    menorTemperatura = temperaturaMedia[i];
                    posicaoMenorTemp = i;
                }
            }
            Console.WriteLine("A maior temperatura do ano foi de "+maiorTemperatura+" graus, em "+meses[posicaoMaiorTemp]);
            Console.WriteLine("A menor temperatura do ano foi de "+menorTemperatura+" graus, em "+meses[posicaoMenorTemp]);
        }
    }
}
