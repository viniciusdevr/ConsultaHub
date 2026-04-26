using ConsultaHub.Models.Entities.Integration_Objects;

namespace ConsultaHub.Models.Entities
{
        public class PerfilIntegracaoOmie
        {
            public string tenantId { get; set; }
            public string tenant_name { get; set; }
            public Auvo auvo { get; set; }
            public Omie omie { get; set; }
        }

    }