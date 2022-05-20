using Gerenciador.Transferencia.Domain.Aggregate.Customer;

namespace Gerenciador.Transferencia.Domain.Interfaces
{
    public interface ICustomerRedisRepository : IRedisRepository<Customer, int>
    {}
}
