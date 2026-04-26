using ConsultaHub.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OmieController(IClienteOmieApiClient clienteOmieApiClient, IConfiguration configuration) : ControllerBase
    {
        [Authorize]
        [HttpGet("clientesResumidos")]
        public async Task<ActionResult> GetClientesOmie()
        {
            try
            {
                var appKey = configuration["Omie:AppKey"];
                var appSecret = configuration["Omie:AppSecret"];
                var clientes = await clienteOmieApiClient.GetClientesOmie(appKey, appSecret);
                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao buscar clientes: {ex.Message}");
            }
        }
    }
}
