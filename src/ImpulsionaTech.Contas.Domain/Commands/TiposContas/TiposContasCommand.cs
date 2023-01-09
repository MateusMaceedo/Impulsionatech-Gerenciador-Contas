using ImpulsionaTech.Contas.Domain.Commands.Contas;

namespace ImpulsionaTech.Contas.Domain.Commands.TiposContas
{
  public class TiposContasCommand
  {
    public int TipoContaId { get; set; }
    public string? Descricao { get; set; }
    public ContasCommand? Conta { get; set; }
  }
}
