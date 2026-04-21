namespace ConsultaHub.Models
{
    public class ClienteDetalhado
    {
        
            public string bairro { get; set; }
            public string bloquear_faturamento { get; set; }
            public string cep { get; set; }
            public string cidade { get; set; }
            public string cidade_ibge { get; set; }
            public string cnae { get; set; }
            public string cnpj_cpf { get; set; }
            public string codigo_cliente_integracao { get; set; }
            public long codigo_cliente_omie { get; set; }
            public string codigo_pais { get; set; }
            public string complemento { get; set; }
            public string contato { get; set; }
            public Dadosbancarios dadosBancarios { get; set; }
            public string email { get; set; }
            public string endereco { get; set; }
            public Enderecoentrega enderecoEntrega { get; set; }
            public string endereco_numero { get; set; }
            public string enviar_anexos { get; set; }
            public string estado { get; set; }
            public string exterior { get; set; }
            public string inativo { get; set; }
            public Info info { get; set; }
            public string inscricao_estadual { get; set; }
            public string inscricao_municipal { get; set; }
            public string nome_fantasia { get; set; }
            public string optante_simples_nacional { get; set; }
            public string pessoa_fisica { get; set; }
            public string razao_social { get; set; }
            public Recomendacoes recomendacoes { get; set; }
            public Tag[] tags { get; set; }
            public string telefone1_ddd { get; set; }
            public string telefone1_numero { get; set; }
            public string tipo_atividade { get; set; }
        }

        public class Dadosbancarios
        {
            public string agencia { get; set; }
            public string cChavePix { get; set; }
            public string codigo_banco { get; set; }
            public string conta_corrente { get; set; }
            public string doc_titular { get; set; }
            public string nome_titular { get; set; }
            public string transf_padrao { get; set; }
        }

        public class Enderecoentrega
        {
        }

        public class Info
        {
            public string cImpAPI { get; set; }
            public string dAlt { get; set; }
            public string dInc { get; set; }
            public string hAlt { get; set; }
            public string hInc { get; set; }
            public string uAlt { get; set; }
            public string uInc { get; set; }
        }

        public class Recomendacoes
        {
            public string gerar_boletos { get; set; }
            public string tipo_assinante { get; set; }
        }

        public class Tag
        {
            public string tag { get; set; }
        }

    }

