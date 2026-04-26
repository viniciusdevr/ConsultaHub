namespace ConsultaHub.Models.Entities
{
    public class ClienteOmie
    {
        public string cnpj_cpf { get; set; } = string.Empty;
        public long codigo_cliente { get; set; }
        public string codigo_cliente_integracao { get; set; } = string.Empty;
        public string nome_fantasia { get; set; } = string.Empty;
        public string razao_social { get; set; } = string.Empty;
    }
}
