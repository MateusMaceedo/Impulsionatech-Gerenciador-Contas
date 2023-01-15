using ImpulsionaTech.Contas.Domain.Shared.Enum;

namespace ImpulsionaTech.Contas.Domain.Commands.Movimentacoes
{
  public class MovimentacoesCommand
  {
    public int MovimentacaoBancariaId { get; set; }
    public int ContaId { get; set; }
    public int ClienteId { get; set; }
    public DateTime Data { get; set; }
    public TipoMovimentacao TipoMovimentacao { get; set; }
    public decimal Valor { get; set; }
    public Status Status { get; private set; }
  }
}
