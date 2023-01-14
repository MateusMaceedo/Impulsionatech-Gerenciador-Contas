using System.ComponentModel.DataAnnotations;

namespace ImpulsionaTech.Contas.Application.ViewModels
{
  public class TipoContaViewModel
  {
    [Key]
    public int TipoContaId { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "Descrição deve apresentar no máximo 50 caracteres")]
    public string Descricao { get; set; }

    public ContaViewModel Conta { get; set; }
  }
}
