using Newtonsoft.Json;

namespace Gerenciador.Transferencia.Application.Models.Request
{
    public class TransferenciaRequest
    {
        [JsonProperty("id_conta_origem", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int IdContaOrigem { get; set; }

        [JsonProperty("id_conta_destino", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int IdContaDestino { get; set; }

        [JsonProperty("valor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal Valor { get; set; }
    }
}
