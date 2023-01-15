using ImpulsionaTech.Contas.Domain.Interfaces;
using ImpulsionaTech.Contas.Domain.Models.Contas;
using ImpulsionaTech.Contas.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;

namespace ImpulsionaTech.Contas.Infra.Data.Repository
{
  public class ContasRepository : IContasRepository
  {
    protected readonly ContasContext Db;
    protected readonly DbSet<Conta> DbSet;

    public ContasRepository(ContasContext context)
    {
      Db = context;
      DbSet = Db.Set<Conta>();
    }

    public IUnitOfWork UnitOfWork => Db;

    public void Add(Conta conta)
    {
      DbSet.Add(conta);
    }

    public void Dispose()
    {
      Db.Dispose();
    }

    public async Task<IEnumerable<Conta>> GetAll()
    {
      return await DbSet.ToListAsync();
    }

    public async Task<Conta> GetByEmail(string cpf)
    {
      return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Cliente.CPF == cpf);
    }

    public async Task<Conta> GetById(Guid id)
    {
      return await DbSet.FindAsync(id);
    }

    public void Remove(Conta conta)
    {
      DbSet.Remove(conta);
    }

    public void Update(Conta conta)
    {
      DbSet.Update(conta);
    }
  }
}
