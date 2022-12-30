using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpulsionaTech.Contas.Domain.Models.Clientes
{
  [Table("TB_CLIENTES")]
  public class Cliente : BaseEntity
  {
    [Key]
    public int ClienteId { get; set; }

    [Required]
    [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF informado não é válido")]
    public string CPF { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Nome não pode ter mais de 50 caracteres")]
    public string Nome { get; set; }

    public IEnumerable<Conta> Contas { get; set; }
    public void Update(string cpf, string nome)
    {
      this.CPF = cpf;
      this.Nome = nome;
    }
  }
}
