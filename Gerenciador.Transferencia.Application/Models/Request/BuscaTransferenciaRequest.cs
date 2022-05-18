using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciador.Transferencia.Application.Models.Request
{
    public class BuscaTransferenciaRequest
    {
        public string NomeClienteOrigem { get; set; }
        public string NomeClienteDestino { get; set; }
        public string ContaClienteOrigem { get; set; }
        public string ContaClienteDestino { get; set; }
    }
}
