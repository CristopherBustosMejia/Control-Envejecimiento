namespace ControlEnvejecimiento.Views;

public partial class ConsultSamples : ContentPage
{
	public ConsultSamples()
	{
		InitializeComponent();
	}

    private async void OnSingleSampleClicked(object sender, EventArgs e)
    {
        // Aquí es donde se realiza la navegación a la otra página
        await Navigation.PushAsync(new SingleSample());
    }
}