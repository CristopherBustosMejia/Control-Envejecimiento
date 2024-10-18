using ControlEnvejecimiento.Models;
using ControlEnvejecimiento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ControlEnvejecimiento.ViewModels
{
    internal class LoginViewModel
    {
        private readonly IClientService _clientService;

        public LoginViewModel()
        {
            _clientService = new ClientService();
        }

        public LoginViewModel(IClientService clientService)
        {
            _clientService = clientService;
        }

        public async Task<bool> Login(String email, String contraseña)
        {
            Dictionary<String, String> user = new Dictionary<String, String>();
            user.Add("Correo", email);
            user.Add("HashContrasena", Hash.getSHA(contraseña));
            bool result = await _clientService.LoginUser(user) == HttpStatusCode.OK ? true : false;
            return result;
        } 
    }
}
