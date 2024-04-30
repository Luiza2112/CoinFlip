namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            CoinSidesPicker.SelectedIndex = 0;
        }

        private void FlipCoinButton_Clicked(System.Object sender, System.EventArgs e)
        {
            string coinSide = Convert.ToString(CoinSidesPicker.SelectedItem);
            int ladoSorteado = new Random().Next(2);
            // retorna um número inteiro não negativo aleatório, menor que 2. Ou seja, 0 ou 1.
            //0 é Cara e 1 é Coroa


            if (coinSide == "Cara" && ladoSorteado == 0)
            {
                CoinImage.Source = "cara.jpeg";
                TextResult.Text = "O resultado foi Cara, você ganhou!";
            } 
            else if(coinSide == "Cara" && ladoSorteado == 1)
            {
                CoinImage.Source = "coroa.jpeg";
                TextResult.Text = "O resultado foi Coroa, você perdeu!";
            }
            else if(coinSide == "Coroa" && ladoSorteado == 0)
            {
                CoinImage.Source = "cara.jpeg";
                TextResult.Text = "O resultado foi Cara, você perdeu!";
            } 
            else if(coinSide == "Coroa" && ladoSorteado == 1)
            {
                CoinImage.Source = "coroa.jpeg";
                TextResult.Text = "O resultado foi Coroa, você ganhou!";
            }

        }
    }

}
