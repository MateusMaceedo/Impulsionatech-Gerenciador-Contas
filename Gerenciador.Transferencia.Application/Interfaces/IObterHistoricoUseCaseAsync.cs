using Gerenciador.Transferencia.Application.Models.Request;
using System.Collections.Generic;

namespace Gerenciador.Transferencia.Application.Interfaces
{
    public interface IObterHistoricoUseCaseAsync : IUseCaseAsync<int, List<TransferenciaRequest>>
    {}
}
