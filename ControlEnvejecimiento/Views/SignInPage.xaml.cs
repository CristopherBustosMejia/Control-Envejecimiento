using ControlEnvejecimiento.Models;
using ControlEnvejecimiento.Services;
using System.Text.RegularExpressions;
using System.Net;
using ControlEnvejecimiento.ViewModels;
using CommunityToolkit.Maui.Alerts;

namespace ControlEnvejecimiento.Views;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
		SignInViewModel viewModel = new SignInViewModel();
		BindingContext = viewModel;
	}
	private async void OnSignInClicked(object sender, EventArgs e)
	{
		Regex regEmail = new Regex("^([\\w-]+(?:\\.[\\w-]+)*)@((?:[\\w-]+\\.)*\\w[\\w-]{0,66})\\.([a-z]{2,6}(?:\\.[a-z]{2})?)$");
		Regex regPassword = new Regex("^(?=.*\\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\\w\\d\\s:])([^\\s]){8,16}$");
		if(NameEntry.Text == null ||  NameEntry.Text == String.Empty)
		{
			await Toast.Make("Porfavor ingrese el nombre del usuario").Show();
            return;
		}
        if (PasswordEntry.Text == null || PasswordEntry.Text == String.Empty || PasswordEntry.Text == null || PasswordEntry.Text == String.Empty)
        {
            await Toast.Make("Porfavor ingrese una contraseña").Show();
            return;
        }
        if (PasswordEntry.Text != ConfirmPassEntry.Text)
        {
            await Toast.Make("Las contraseñas ingresadas no coinciden").Show();
            return;
        }
        if (!regEmail.IsMatch(EmailEntry.Text))
		{
            await Toast.Make("Porfavor ingrese correo valido").Show();
            return;
		}
		if (!regPassword.IsMatch(PasswordEntry.Text))
		{
            await Toast.Make("Porfavor ingrese una contraseña valida").Show();
            return;
		}
		UsuarioDTO usuarioDTO = new UsuarioDTO()
		{
			Nombre = NameEntry.Text,
			Correo = EmailEntry.Text,
			HashContraseña = Hash.getSHA(PasswordEntry.Text)
		};
		if(BindingContext is SignInViewModel viewModel)
		{
			bool result = await viewModel.SigninUserSelf(usuarioDTO);
            if (result)
			{
                await DisplayAlert("Operacion exitosa", $"El usuario {usuarioDTO.Nombre} ha sido creado correctamente", "OK");
				await Navigation.PopAsync();
			}
			else
			{
                await DisplayAlert("Operacion Fallida", "No se pudo registrar el usuario", "OK");
            }
		}
	}

    private async void OnLoginTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}