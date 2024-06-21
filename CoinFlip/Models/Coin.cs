using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip.Models
{
    public class Coin
    {
        //Propriedade ->  escrever Prop, enter e alterar o tipo e o nome Lado
        public string LadoEscolhido { get; set; }
        public string LadoSorteado { get; set; }

        //Método construtor
        public Coin()
        {

        }
        //Método Jogar a moeda 
        public string Jogar()
        {
            LadoSorteado = new Random().Next(2) == 0 ? "Cara" : "Coroa";
            return (LadoSorteado);
        }
    }
}
