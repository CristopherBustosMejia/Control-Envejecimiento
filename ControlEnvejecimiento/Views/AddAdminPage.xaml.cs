namespace ControlEnvejecimiento.Views;

public partial class AddAdmin : ContentPage
{
    public AddAdmin()
    {
        InitializeComponent();
    }
    private async void OnHomeClicked(object sender, EventArgs e)
    {
        // Aquí es donde se realiza la navegación a la otra página
        await Navigation.PopAsync();
    }
}