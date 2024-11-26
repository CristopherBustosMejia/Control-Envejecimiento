namespace ControlEnvejecimiento.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}
    private async void OnAddMaterialClicked(object sender, EventArgs e)
    {
        // Aqu� es donde se realiza la navegaci�n a la otra p�gina
        await Navigation.PushAsync(new AddMaterial());
    }
    private async void OnAddAdminClicked(object sender, EventArgs e)
    {
        // Aqu� es donde se realiza la navegaci�n a la otra p�gina
        await Navigation.PushAsync(new AddAdmin());
    }
    private async void OnConsultSamplesClicked(object sender, EventArgs e)
    {
        // Aqu� es donde se realiza la navegaci�n a la otra p�gina
        await Navigation.PushAsync(new ConsultSamples());
    }
    private async void OnAddSamplesClicked(object sender, EventArgs e)
    {
        // Aqu� es donde se realiza la navegaci�n a la otra p�gina
        await Navigation.PushAsync(new AddSamples());
    }
    private async void OnSamplesWaitClicked(object sender, EventArgs e)
    {
        // Aqu� es donde se realiza la navegaci�n a la otra p�gina
        await Navigation.PushAsync(new SamplesWait());
    }
}