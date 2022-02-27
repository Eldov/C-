using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laços Condicionais => execução mediante determinada condição/situação satisfeita
            //Laço "IF"
            int hora = 18;
            //if(hora < 15) 
            //{
            //    Console.WriteLine("Sao menos de 15h!");
            //}
            //else if(hora <= 17)            
            //    Console.WriteLine("A hora e menor ou igual a 17!");
            //else
            //    Console.WriteLine("Ja sao mais de 17h!");
            switch(hora)
            {
                case 15: //O teste condicional e exato
                    Console.WriteLine("Sao 15h!");
                     break;
                case 18:
                    Console.WriteLine("Sao 18h!");
                     break;
            }
            PrimeiroSemestre mes = PrimeiroSemestre.Maio;
            switch(mes)
            {
                case PrimeiroSemestre.Janeiro:
                    Console.WriteLine("Estamos no mes de Janeiro");
                    break;
                case PrimeiroSemestre.Fevereiro:
                    Console.WriteLine("Estamos no mes de Fevereiro");
                    break;
                case PrimeiroSemestre.Marco:
                    Console.WriteLine("Estamos no mes de Marco");
                    break;
                default:
                    Console.WriteLine("Nao estamos no primeiro trimestre, estamos no mes de " + mes);
                    break;
            }
        }
    }
    public enum PrimeiroSemestre
    {
        Janeiro, Fevereiro, Marco, Abril, Maio, Junho
    }
}
