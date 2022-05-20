using Newtonsoft.Json;
using System;

namespace Gerenciador.Transferencia.Application.Models.Response
{
    public class TransferenciaResponse
    {
        [JsonProperty("id_conta_origem", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int IdContaOrigem { get; set; }

        [JsonProperty("id_conta_destino", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int IdContaDestino { get; set; }

        [JsonProperty("nome_cliente_origem", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string NomeClienteOrigem { get; set; }

        [JsonProperty("nome_cliente_destino", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string NomeClienteDestino { get; set; }

        [JsonProperty("valor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal Valor { get; private set; }

        [JsonProperty("data_hora_tranferencia", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DataHoraTransfencia { get; set; }
    }
}
