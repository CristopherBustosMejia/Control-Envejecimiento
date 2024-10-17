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
    internal class SignInViewModel
    {
        private readonly IClientService _clientService;

        public SignInViewModel()
        {
            _clientService = new ClientService();
        }
        public SignInViewModel(IClientService clientService)
        {
            _clientService = clientService;
        }

        public async Task<bool> SigninUserSelf(UsuarioDTO user)
        {
            bool result = await _clientService.SigninUserSelf(user) == HttpStatusCode.Created ? true : false;
            return result;
        }
    }
}
