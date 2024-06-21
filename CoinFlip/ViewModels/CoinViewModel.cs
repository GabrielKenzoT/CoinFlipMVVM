using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinFlip.Models;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;


namespace CoinFlip.ViewModels
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private string imagem;

        [ObservableProperty]
        private string escolha;
        
        public ICommand JogarComand { get; }

        public CoinViewModel()
        {
            JogarComand = new Command(Jogar);
        }

        public void Jogar()
        {
  
            //Instanciando uma moeda
            //Sorteio um lado
            //Comparo a o lado sorteado com a esclha do jogador
            //Exibo o resultado

            Coin coin = new Coin();
            coin.Jogar();
            //Resultado = Escolha == coin.LadoSorteado ? "Você venceu" : "Você Perdeu";

            if(Escolha == coin.LadoSorteado)
            {
                Resultado = "Você venceu";
            }
            else
            {
                Resultado = "Você perdeu";
            }

            //public void OnPropertyChanged([CallerMemberName] string name = "") =>
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
    }

