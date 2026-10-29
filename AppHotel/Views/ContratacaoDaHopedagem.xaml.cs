namespace AppHotel.Views;

public partial class ContratacaoDaHopedagem : ContentPage
{
	public ContratacaoDaHopedagem()
	{
		InitializeComponent();
	}

	private async void Button_Avancar_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new HospedagemContratada());
	}

	private async void Button_Sobre_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Sobre());
	}
}
