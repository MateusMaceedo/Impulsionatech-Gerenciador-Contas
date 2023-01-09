using ImpulsionaTech.Contas.Domain.Shared.Enum;

namespace ImpulsionaTech.Contas.Domain.Base
{
  public class BaseEntity
    {
        public Status Status { get; set; }
        public virtual void Update(Status status)
        {
            this.Status = status;
        }
    }
}
