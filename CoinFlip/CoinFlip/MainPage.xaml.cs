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
            int coinSide = Convert.ToString(CoinSidesPicker.SelectedItem);
            int ladoSorteado = new Random().Next(1, selectedSides + 1);

            if (coinSide == "Cara")
            {

            };

        }
    }

}
