using ControlEnvejecimiento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ControlEnvejecimiento.Services
{
    internal interface IClientService
    {
        Task<HttpStatusCode> SigninUserSelf(UsuarioDTO user);
        Task<HttpStatusCode> LoginUser(Dictionary<String, String> user);
    }
}
