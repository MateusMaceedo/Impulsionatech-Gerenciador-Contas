using ImpulsionaTech.Contas.Domain.Commands.Contas;

namespace ImpulsionaTech.Contas.Domain.Commands.Clientes
{
  public class ClientesCommand
  {
    public int ClienteId { get; set; }
    public string CPF { get; set; }
    public string Nome { get; set; }
    public IEnumerable<ContasCommand> Contas { get; set; }
  }
}
