using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte1 // Lugar do folder
{
    public class Carro
    {
        //Atributos do carro
        public string Modelo { get; } //Fazemos deste jeito pois nao queremos que uma vez atribuido os valores, eles sejam alterados.
        public int Portas { get; } //Fizemos uma propriedade direto, sem um atributo por tras.
        public Cor Cor { get; set; } //Permitimos o set neste caso para casos em que um carro seja pintado entao e alteravel.

        private bool ligado = false; //So a classe tem acesso

        public bool Ligado //Propriedade: define uma maneira de acessar atributos.
        {
            get // retorna valor
            {
                return ligado;
            }
            
        }

        //Metodo construtor da classe 
        public Carro(Cor cor, int portas, string modelo)
        {
            Cor = cor;
            Portas = portas;
            Modelo = modelo;          
        }


        //Comportamentos do carro
        public string Ligar()
        {
            ligado = true;
            return "O carro foi ligado";     
        }
        public string Desligar()
        {
            ligado = false;
            return "O carro foi desligado";
        }
        public string Andar()
        {
            return "O carro esta andando";
        }
    }
}
