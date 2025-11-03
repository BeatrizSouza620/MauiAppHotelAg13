namespace MauiAppHotelAg13.Views;

public partial class Informacoes : ContentPage
{
	public Informacoes()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}