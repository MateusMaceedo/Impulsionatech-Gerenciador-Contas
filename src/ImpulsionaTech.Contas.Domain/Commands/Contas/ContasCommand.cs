using ImpulsionaTech.Contas.Domain.Commands.Clientes;
using ImpulsionaTech.Contas.Domain.Commands.TiposContas;

namespace ImpulsionaTech.Contas.Domain.Commands.Contas
{
  public class ContasCommand
  {
    public int ContaId { get; set; }
    public int TipoContaId { get; set; }
    public TiposContasCommand? TipoConta { get; set; }
    public decimal Saldo { get; set; }
    public int ClienteId { get; set; }
    public ClientesCommand? Cliente { get; set; }
  }
}
