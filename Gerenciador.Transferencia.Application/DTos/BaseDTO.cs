using FluentValidation.Results;

namespace Gerenciador.Transferencia.Application.DTos
{
    public abstract class BaseDTO
    {
        [System.Text.Json.Serialization.JsonIgnore]
        public ValidationResult ValidationResult { get; set; }

        protected BaseDTO()
        {
            ValidationResult = new ValidationResult();
        }
    }

    public abstract class BaseDTOEntity<Tid> : BaseDTO
    {
        public Tid Identificador { get; set; }
    }
}
