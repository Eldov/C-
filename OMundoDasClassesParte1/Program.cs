using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte1
{
    class Program //Sem modificador de acesso explicito = internal por padrao
    {
        static void Main(string[] args) // void significa que nao retorna nada
        {
            Carro carro = new Carro(Cor.Branca, 4, "Gol G6"); //Criando carro

            //Exibindo atributos do carro
            Console.WriteLine("O carro e um " + carro.Modelo + " de cor " + carro.Cor + " e tem " + carro.Portas + " portas.");
            
            Console.WriteLine(carro.Ligar());
            Console.WriteLine("Ligado? " + carro.Ligado);
            Console.WriteLine(carro.Andar());
            Console.WriteLine(carro.Desligar());
            Console.WriteLine("Ligado? " + carro.Ligado);
            /*Ligar e desligar sao comportamentos e Ligado e um atributo.
            Se mantivermos o Ligado como public, coisas como escrever carro.Ligado = false sao possiveis
            e entraria em contradicao com o comportamento. Para evitar isso, colocamos o atributo Ligado como privado.
            O problema e que colocar como privado vai impedir que o atributo seja usado aqui.
            Criamos a propriedade ligado que mostra o get (o retorno) mas nao o set (nao atribui valor) do atributo Ligado.
            Esse processo se chama encapsulamento.
            */
            carro.Cor = Cor.Azul;
            Console.WriteLine("A nova cor do carro e " + carro.Cor); //A cor e manipulavel.
        }
    }
}
