namespace ControlEnvejecimiento.Views;

public partial class ConsultSamples : ContentPage
{
	public ConsultSamples()
	{
		InitializeComponent();
	}

    private async void OnSingleSampleClicked(object sender, EventArgs e)
    {
        // Aqu� es donde se realiza la navegaci�n a la otra p�gina
        await Navigation.PushAsync(new SingleSample());
    }
}