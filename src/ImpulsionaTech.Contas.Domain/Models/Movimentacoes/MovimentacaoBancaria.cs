using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ImpulsionaTech.Contas.Domain.Shared.Enum;

namespace ImpulsionaTech.Contas.Domain.Models.Movimentacoes
{
  [Table("TB_MOVIMENTACAO_BANCARIA")]
  public class MovimentacaoBancaria
  {
    [Key]
    public int MovimentacaoBancariaId { get; set; }

    [Required]
    public int ContaId { get; set; }

    [Required]
    public int ClienteId { get; set; }

    [Required]
    public DateTime Data { get; set; }
    [Required]
    public TipoMovimentacao TipoMovimentacao { get; set; }
    [Required]
    public decimal Valor { get; set; }
    public Status Status { get; private set; }

    public void ReverteDadosMovimentacao()
    {
      UpdateStatus();
      UpdateTipoMovimentacao();
    }

    public void UpdateTipoMovimentacao()
    {
      if (this.TipoMovimentacao == TipoMovimentacao.Deposito)
        this.TipoMovimentacao = TipoMovimentacao.Saque;
      else
        this.TipoMovimentacao = TipoMovimentacao.Deposito;
    }

    public void UpdateStatus()
    {
      if (this.Status == Status.Ativo)
        this.Status = Status.Inativo;
      else
        this.Status = Status.Ativo;
    }
  }
}
