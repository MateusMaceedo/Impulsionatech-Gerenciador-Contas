using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpulsionaTech.Contas.Domain.Models.Contas
{
  [Table("TB_CONTAS")]
  public class Conta : BaseEntity
  {
    [Key]
    public int ContaId { get; set; }

    [Required]
    public int TipoContaId { get; set; }
    public TipoConta TipoConta { get; set; }
    public decimal Saldo { get; set; }

    [Required]
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
  }
}
