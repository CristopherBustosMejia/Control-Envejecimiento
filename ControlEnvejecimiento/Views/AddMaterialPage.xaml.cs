namespace ControlEnvejecimiento.Views;

public partial class AddMaterial : ContentPage
{
	public AddMaterial()
	{
		InitializeComponent();
	}

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        // Aqu� es donde se realiza la navegaci�n a la otra p�gina
        await Navigation.PopAsync();
    }
}