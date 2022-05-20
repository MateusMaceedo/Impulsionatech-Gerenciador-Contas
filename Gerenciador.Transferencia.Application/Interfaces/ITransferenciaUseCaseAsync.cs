using Gerenciador.Transferencia.Application.Models.Request;
using Gerenciador.Transferencia.Application.Models.Response;

namespace Gerenciador.Transferencia.Application.Interfaces
{
    public interface ITransferenciaUseCaseAsync : IUseCaseAsync<TransferenciaRequest, int>
    {}
}
