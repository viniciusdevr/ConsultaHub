using ConsultaHub.Models.Entities;

namespace ConsultaHub.Models.Interfaces
{
    public interface IClienteOmieApiClient
    {
        Task<List<ClienteOmie>> GetClientesOmie(string appKey, string appSecret);
    }
}
