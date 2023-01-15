using ImpulsionaTech.Contas.Domain.Models.Contas;
using NetDevPack.Data;

namespace ImpulsionaTech.Contas.Domain.Interfaces
{
  public interface IContasRepository : IRepository<Conta>
  {
    Task<Conta> GetById(Guid id);
    Task<Conta> GetByEmail(string email);
    Task<IEnumerable<Conta>> GetAll();

    void Add(Conta conta);
    void Update(Conta conta);
    void Remove(Conta conta);
  }
}
