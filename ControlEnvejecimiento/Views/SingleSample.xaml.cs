namespace ControlEnvejecimiento.Views;

public partial class SingleSample : ContentPage
{
	public SingleSample()
	{
		InitializeComponent();
	}
    private async void OnHomeClicked(object sender, EventArgs e)
    {
        // Aquí es donde se realiza la navegación a la otra página
        await Navigation.PushAsync(new DashboardPage());
    }
}