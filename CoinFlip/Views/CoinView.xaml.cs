namespace CoinFlip.Views;
using CoinFlip.Models;
using CoinFlip.ViewModels;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();

		this.BindingContext = new CoinViewModel();
	}

}