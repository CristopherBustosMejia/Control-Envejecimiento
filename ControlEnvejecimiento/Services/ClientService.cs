using ControlEnvejecimiento.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ControlEnvejecimiento.Services
{
    internal class ClientService : IClientService
    {
        private readonly HttpClient _httpClient;
        private readonly String _baseUri;
        public ClientService()
        {
            _httpClient = new HttpClient();
            _baseUri = "https://maquinaenvejecimiento.bsite.net/api/";
        }

        public async Task<HttpStatusCode> SigninUserSelf(UsuarioDTO user)
        {
            user.RolId = 2;
            String requestUri = $"{_baseUri}Usuarios";
            String jsonContent = JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(requestUri,content);
            return response.StatusCode;
        }
    }
}
