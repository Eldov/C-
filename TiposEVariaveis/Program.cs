using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10; //declara uma variavel inteira e armazena o valor 10 nela
            int numero2 = 20;
            var soma = numero1 + numero2; //o var define dinamicamente o tipo da variavel
            Console.WriteLine("10 + 20 = " + soma);
            int CopiaDeNumero1 = numero1; //copia o valor da variavel "numero1"
            CopiaDeNumero1 = 11; //sera que o valor de "numero1" foi alterado?
            Console.WriteLine(numero1);
            Console.WriteLine(CopiaDeNumero1);

            var quadrado1 = new Quadrado(); //cria um quadrado
            quadrado1.lado = 10; //quadrado1 tera valor de lado igual a 10
            var quadrado2 = quadrado1; //sera que a copia do quadrado foi completa? ou copiamos apenas a referencia?
            quadrado2.lado = 11;
            Console.WriteLine(quadrado1.lado); //quadrado1 deveria ter o lado igual a 10
            Console.WriteLine(quadrado2.lado); //quadrado2 deveria ter o lado igual a 11
        
        }
        
        class Quadrado //define uma classe chamada quadrado
        {
           public int lado; //define um atributo inteiro chamado lado, na classe Quadrado
        }
            
    }
}
