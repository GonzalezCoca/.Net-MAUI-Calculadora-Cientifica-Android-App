namespace Calculadora;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private async void btcalcu(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }

    private async void btfirma(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Firma());
    }

    private async void calfunct(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage2());
    }
}