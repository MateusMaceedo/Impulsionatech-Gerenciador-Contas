using System.ComponentModel.DataAnnotations;

namespace ImpulsionaTech.Contas.Application.ViewModels
{
  public class ContaViewModel
  {
    [Key]
    public int ContaId { get; set; }

    [Required]
    public int TipoContaId { get; set; }
    public TipoContaViewModel TipoConta { get; set; }
    public decimal Saldo { get; set; }

    [Required]
    public int ClienteId { get; set; }
    public ClienteViewModel Cliente { get; set; }
  }
}
