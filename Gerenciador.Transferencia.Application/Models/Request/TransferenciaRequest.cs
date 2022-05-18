using Amazon.DynamoDBv2.DataModel;
using System;

namespace Gerenciador.Transferencia.Application.Models.Request
{
    [DynamoDBTable("conta_transferencia")]

    public class TransferenciaRequest
    {
        [DynamoDBProperty("id_transferencia")]
        [DynamoDBHashKey]
        public Guid IdTransferencia { get; set; }

        [DynamoDBProperty("nome_cliente_origem")]
        public string NomeClienteOrigem { get; set; }

        [DynamoDBProperty("conta_cliente_origem")]
        public string ContaClienteOrigem { get; set; }

        [DynamoDBProperty("nome_cliente_destino")]
        public string NomeClienteDestino { get; set; }

        [DynamoDBProperty("conta_cliente_origem")]
        public string ContaClienteDestino { get; set; }

        [DynamoDBProperty("data_hora_transferencia")]
        public DateTime DataHoraTransferencia { get; set; }
    }
}
