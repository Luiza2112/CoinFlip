using CoinFlip.ViewsModels;

namespace CoinFlip.Views;

public partial class CoinView : ContentPage
{
    public CoinView()
    {
        InitializeComponent();
        BindingContext = new CoinViewModel();
    }
}