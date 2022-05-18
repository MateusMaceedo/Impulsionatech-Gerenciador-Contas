using Gerenciador.Transferencia.Application.Contracts;
using Gerenciador.Transferencia.Application.Models.Request;
using Gerenciador.Transferencia.Application.UseCases;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gerenciador.Transferencia.Repository.Repository.Interfaces
{
    public interface ITransferenciaRepository
    {
        Task<TransferenciaUseCase> Single(Guid readerId);
        Task<TransferenciaViewModel> All(string paginationToken = "");
        Task<IEnumerable<TransferenciaRequest>> Find(BuscaTransferenciaRequest buscaReq);
        Task Add(TransferenciaInputModel entity);
        Task Remove(Guid readerId);
        Task Update(Guid readerId, TransferenciaInputModel entity);
    }
}
