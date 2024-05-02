using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip.Models
{
    public class Coin
    {
        public string Lado { get; set; }
        public string LadoEscolhido { get; set; }

        //Construtor tem sempre o nome da classe
        public Coin()
        {

        }

        public string Jogar()
        {
            //Operador Ternario ? -> if resumido
            return (new Random().Next(2) == 0) ? "Cara" : "Coroa";
        }

    }
}
