using Gerenciador.Transferencia.Domain.Shared;
using System;

namespace Gerenciador.Transferencia.Domain.Aggregate.Customer
{
    public class Customer : TEntity<int>
    {
        //TODO: Testar como protected
        public Customer()
        {

        }

        public Customer(
            string nomeOrigem, 
            string nomeDestino,
            int idContaDestino,
            int idContaOrigem)
        {
            NomeDestino = nomeDestino;
            NomeOrigem = nomeOrigem;    
            IdContaDestino = idContaDestino;
            IdContaOrigem = idContaOrigem;
            DataHoraProcessamento = DateTime.Now;
        }

        public string NomeDestino { get; private set; } 

        public string NomeOrigem { get; private set; }

        public int IdContaDestino { get; private set; }

        public int IdContaOrigem { get; private set; }

        public DateTime DataHoraProcessamento { get; private set; }

        //public virtual ICollection<TipoConta> Address { get; set; } // ValueObject
    }
}
