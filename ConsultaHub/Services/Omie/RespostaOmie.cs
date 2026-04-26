using ConsultaHub.Models.Entities;
using System.Text.Json.Serialization;

namespace ConsultaHub.Services.Omie
{
    public class RespostaOmie
    {
        [JsonPropertyName("pagina")]
        public int Pagina { get; set; }
        
        [JsonPropertyName("total_de_paginas")]
        public int TotalDePaginas { get; set; }
        [JsonPropertyName("total_de_registros")]
        public int TotalDeRegistros { get; set; }
        [JsonPropertyName("clientes_cadastro_resumido")]
        public List<ClienteOmie> ClientesCadastroResumido { get; set; } = [];
    }
}
