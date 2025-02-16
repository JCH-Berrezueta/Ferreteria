using CapaEntidades.Gestion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rol = CapaEntidades.Gestion.Rol;
namespace PresentacionCliente.Services
{
    public class Rol
    {
        private readonly HttpClient _httrol;

        public Rol()
        {
            _httrol = new HttpClient();
        }

        public async Task<List<rol>> listarRoles()
        {
            var res = await _httrol.GetStringAsync("https://localhost:44386/api/rol/listar-rol");
            var roles = JsonConvert.DeserializeObject<List<rol>>(res);
            return roles;
        }
    }
}
