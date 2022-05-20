using System;

namespace Gerenciador.Transferencia.Application.Contracts
{
    public class TransferenciaInputModel
    {
        public Guid IdTransferencia { get; private set; }
        public string NomeClienteOrigem { get; private set; }
        public string NomeClienteDestino { get; private set; }
        public int IdContaClienteOrigem { get; private set; }
        public int IdContaClienteDestino { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataHoraTransferencia { get; set; }
    }
}
