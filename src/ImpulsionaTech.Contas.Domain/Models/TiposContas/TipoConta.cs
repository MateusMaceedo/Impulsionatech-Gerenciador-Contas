using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpulsionaTech.Contas.Domain.Models.TiposContas
{
  [Table("TB_TIPO_CONTAS")]
  public class TipoConta : BaseEntity
  {
    [Key]
    public int TipoContaId { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "Descrição deve apresentar no máximo 50 caracteres")]
    public string Descricao { get; set; }

    public Conta Conta { get; set; }
  }
}
