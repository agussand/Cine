using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFront.Servicios
{
    public class ClienteSingleton
    {
        private static ClienteSingleton instancia;
        private HttpClient cliente;

        private ClienteSingleton()
        {
            cliente = new HttpClient();
            cliente.Timeout = TimeSpan.FromSeconds(200);
        }

        public static ClienteSingleton GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new ClienteSingleton();
            }
            return instancia;
        }

        //CRUD


        //Metodo GET
        public async Task<string> GetAsync(string url)
        {
            var result = await cliente.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
            {
                content = await result.Content.ReadAsStringAsync();
            }
            return content;
        }

        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await cliente.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
            {
                response = await result.Content.ReadAsStringAsync();
            }
            return response;
        }
    }
}
