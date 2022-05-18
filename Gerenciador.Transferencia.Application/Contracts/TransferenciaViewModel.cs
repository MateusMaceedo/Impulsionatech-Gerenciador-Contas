using Gerenciador.Transferencia.Application.Enum;
using Gerenciador.Transferencia.Application.Models.Request;
using System.Collections.Generic;

namespace Gerenciador.Transferencia.Application.Contracts
{
    public class TransferenciaViewModel
    {
        public IEnumerable<TransferenciaRequest> Transferencia { get; set; }
        public HistoricoTransferencia Historico { get; set; }
        public string PaginationToken { get; set; }
    }
}
