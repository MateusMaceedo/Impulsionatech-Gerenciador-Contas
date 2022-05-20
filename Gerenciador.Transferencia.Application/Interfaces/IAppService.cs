using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gerenciador.Transferencia.Application.Interfaces
{
    public interface IAppService<T, Tid> where T : class
    {
        Task<T> Add(T itemDTO);
        Task<T> Update(T itemDTO);
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Tid Tid);
        Task<bool> Remover(Tid Tid);
    }
}
