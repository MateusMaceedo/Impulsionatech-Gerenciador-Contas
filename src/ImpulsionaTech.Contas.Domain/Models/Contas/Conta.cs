using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImpulsionaTech.Contas.Domain.Models.Clientes;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using ImpulsionaTech.Contas.Domain.Base;

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
