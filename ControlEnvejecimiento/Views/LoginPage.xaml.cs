using ControlEnvejecimiento.Services;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;

namespace ControlEnvejecimiento.Views
{
    public partial class LoginPage : ContentPage
    {
        public ICommand TapCommand => new Command(async () => await Navigation.PushModalAsync(new SignInPage()));

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
           
        }
    }

}
