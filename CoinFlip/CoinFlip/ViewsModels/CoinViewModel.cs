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
        public string image;

        [ObservableProperty]
        public string escolha;
        
        public ICommand JogarCommand { get;}

        public CoinViewModel()
        {
            JogarCommand = new Command(Jogar);
        }

        public void Jogar()
        {
            Coin coin = new Coin();
            coin.Jogar();

            //Resultado = Escolha == coin.LadoSorteado ? "Você venceu" : "Você perdeu";
            if (Escolha == coin.LadoSorteado)
            {
                Resultado = "Você venceu";
            }
            else
            {
                Resultado = "Você perdeu";
            }
        }
    }
}
