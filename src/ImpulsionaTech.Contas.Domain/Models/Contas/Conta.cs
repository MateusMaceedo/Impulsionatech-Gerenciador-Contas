using ImpulsionaTech.Contas.Domain.Models.Clientes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ImpulsionaTech.Contas.Domain.Base;
using ImpulsionaTech.Contas.Domain.Models.TiposContas;
using NetDevPack.Domain;

namespace ImpulsionaTech.Contas.Domain.Models.Contas
{
  [Table("TB_CONTAS")]
  public class Conta : BaseEntity, IAggregateRoot
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
