namespace ControlEnvejecimiento.Views;

public partial class SingleSample : ContentPage
{
	public SingleSample()
	{
		InitializeComponent();
	}
    private async void OnHomeClicked(object sender, EventArgs e)
    {
        // Aqu� es donde se realiza la navegaci�n a la otra p�gina
        await Navigation.PushAsync(new DashboardPage());
    }
}