using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosIterativos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lacos Iterativos => estruturas que repetem um bloco de codigo, determinado numero de vezes
            //Laço FOR
            for(int i=0;i<5; i++) //i++ significa que i sera incrementado de 1 em 1
            {
                Console.WriteLine("Valor de i e " + i);
            }
            //Laço WHILE
            int contador = 3;
            while(contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            //Laço "DO... WHILE";
            //Execução garantida pelo menos uma vez! (Executa o bloco primeiro e depois faz o teste de condição)
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;
            } while (j < 100);

            //Laço FOREACH
            //Percorre todos os elementos de um conjunto
            int[] conjunto = { 1, 2, 3, 4 }; //Vetor
            foreach(int numero in conjunto) //numero sendo o nome temporario que damos aos elementos do conjunto
            {
                Console.WriteLine("Esse elemento do conjunto tem valor " + numero + "! " + "Somando este valor a 10, temos " + (numero+10));
            }
        }
    }
}
