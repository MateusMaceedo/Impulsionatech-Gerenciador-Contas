using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
