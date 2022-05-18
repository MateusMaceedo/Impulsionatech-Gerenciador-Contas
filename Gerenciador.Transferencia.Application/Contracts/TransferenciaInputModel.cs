using System;

namespace Gerenciador.Transferencia.Application.Contracts
{
    public class TransferenciaInputModel
    {
        public Guid IdTransferencia { get; set; }
        public string NomeClienteOrigem { get; set; }
        public string NomeClienteDestino { get; set; }
        public string ContaClienteOrigem { get; set; }
        public string ContaClienteDestino { get; set; }
        public DateTime DataHoraTransferencia { get; set; }
    }
}
