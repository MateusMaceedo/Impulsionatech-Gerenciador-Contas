using System.ComponentModel.DataAnnotations;

namespace Gerenciador.Transferencia.Domain.Shared
{
    public abstract class TEntity<Tid>
    {
        //protected TEntity()
        //{
        //    ValidationResult = new ValidationResult();
        //}

        public Tid Id { get; set; }

        public ValidationResult ValidationResult { get; set; }
    }
}
