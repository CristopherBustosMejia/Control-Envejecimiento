namespace ControlEnvejecimiento.Views;

public partial class AddAdmin : ContentPage
{
    public AddAdmin()
    {
        InitializeComponent();
    }
    private async void OnHomeClicked(object sender, EventArgs e)
    {
        // Aqu� es donde se realiza la navegaci�n a la otra p�gina
        await Navigation.PopAsync();
    }
}