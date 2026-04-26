using ConsultaHub.Models.Entities;
using ConsultaHub.Models.Interfaces;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace ConsultaHub.Services.Omie
{
    public class ClienteOmieApiClient(HttpClient httpClient) : IClienteOmieApiClient
    {
        public async Task<List<ClienteOmie>> GetClientesOmie(string appKey, string appSecret)
        {
            var primeiraResposta = await BuscarPagina(appKey, appSecret, pagina: 1);

            var todosClientes = new List<ClienteOmie>(primeiraResposta.TotalDeRegistros);
            todosClientes.AddRange(primeiraResposta.ClientesCadastroResumido);

            if (primeiraResposta.TotalDePaginas <= 1)
                return todosClientes;

            var semaforo = new SemaphoreSlim(5);
            var paginas = Enumerable.Range(2, primeiraResposta.TotalDePaginas - 1);

            var tasks = paginas.Select(async pagina =>
            {
                await semaforo.WaitAsync();
                try
                {
                    var resposta = await BuscarPagina(appKey, appSecret, pagina);
                    return resposta.ClientesCadastroResumido;
                }
                finally
                {
                    semaforo.Release();
                }
            });

            var resultados = await Task.WhenAll(tasks);
            foreach (var clientes in resultados)
            {
                todosClientes.AddRange(clientes);
            }

            return todosClientes;
        }

        private async Task<RespostaOmie> BuscarPagina(string appKey, string appSecret, int pagina)
        {
            var request = new
            {
                call = "ListarClientesResumido",
                app_key = appKey,
                app_secret = appSecret,
                param = new[]
                {
                    new
                    {
                        pagina,
                        registros_por_pagina = 100,
                        apenas_importado_api = "N"
                    }
                }
            };
            var content = JsonContent.Create(request, new MediaTypeHeaderValue("application/json"));
            var response = await httpClient.PostAsync("", content);
            if (!response.IsSuccessStatusCode)
            {
                var erro = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erro Omie: {erro}");
            }
            var respostaClientes = await response.Content.ReadFromJsonAsync<RespostaOmie>();
            return respostaClientes!;
        }
    }
}
