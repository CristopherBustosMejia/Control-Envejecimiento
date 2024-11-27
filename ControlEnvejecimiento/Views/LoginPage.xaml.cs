using CommunityToolkit.Maui.Alerts;
using ControlEnvejecimiento.Services;
using ControlEnvejecimiento.ViewModels;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;

namespace ControlEnvejecimiento.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            LoginViewModel viewModel = new LoginViewModel();
            BindingContext = viewModel;
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            if (EmailEntry.Text == String.Empty && PasswordEntry.Text == String.Empty)
            {
                await Toast.Make("Porfavor asegurese de llenar los 2 campos").Show();
                return;
            }
            if (BindingContext is LoginViewModel viewModel)
            {
                bool result = await viewModel.Login(EmailEntry.Text, PasswordEntry.Text);
                if(result)
                {
                    await Toast.Make("Sesion iniciada con exito").Show();
                    Application.Current.MainPage = new NavigationPage(new DashboardPage());
                }
                else
                {
                    await Toast.Make("No se pudo iniciar sesion").Show();
                }
            }
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Aquí es donde se realiza la navegación a la otra página
            await Navigation.PushAsync(new SignInPage());
        }
        private async void OnForgotPasswordClicked(object sender, EventArgs e)
        {
            // Aquí es donde se realiza la navegación a la otra página
            await Navigation.PushAsync(new ForgotPasswordPage());
        }

        private async void OnRegisterTapped(object sender, TappedEventArgs e)
        {
            await Navigation.PushModalAsync(new SignInPage());
        }

        private async void OnForgotPasswordTapped(object sender, TappedEventArgs e)
        {
            await Navigation.PushModalAsync(new ForgotPasswordPage());
        }

        private async void OnDasboardClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new DashboardPage());
            Application.Current.MainPage = new NavigationPage (new DashboardPage());
        }
      
    }

}
