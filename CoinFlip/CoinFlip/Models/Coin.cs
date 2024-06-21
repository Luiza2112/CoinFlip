using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip.Models
{
    public class Coin
    {
        //prop + enter
        public string Ladoescolhido { get; set; }
        public string LadoSorteado { get; set; }

        //Construtor tem sempre o nome da classe
        public Coin()
        {

        }

        public string Jogar()
        {
            //Operador Ternario ? -> if resumido
            LadoSorteado = new Random().Next(2) == 0 ? "cara" : "coroa";
            return (LadoSorteado);
        }

    }
}
