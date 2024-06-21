using CoinFlip.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoinFlip.ViewsModels
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        public string imagem;

        [ObservableProperty]
        public string escolha;
        
        //Criando comando
        public ICommand JogarCommand { get;}

        public CoinViewModel()
        {
            JogarCommand = new Command(Jogar);
        }

        public void Jogar()
        {
            //Criando a moeda e chamando o método jogar
            Coin coin = new Coin();
            coin.Jogar();

            Imagem = $"{coin.LadoSorteado}.jpeg";

            //Resultado = Escolha == coin.LadoSorteado ? "Você venceu" : "Você perdeu";
            if (Escolha == coin.LadoSorteado)
            {
                Resultado = "Você venceu!";
            }
            else if(Escolha != coin.LadoSorteado)
            {
                Resultado = "Você perdeu...";
            }

        }
    }
}
