using Gerenciador.Transferencia.Application.Interfaces;
using Gerenciador.Transferencia.Application.Models.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gerenciador.Transferencia.Application.UseCases
{
    public class ObterHistoricoUseCaseAsync : IObterHistoricoUseCaseAsync
    {
        public Task<List<TransferenciaRequest>> Executar(int param)
        {
            throw new System.NotImplementedException();
        }
    }
}
