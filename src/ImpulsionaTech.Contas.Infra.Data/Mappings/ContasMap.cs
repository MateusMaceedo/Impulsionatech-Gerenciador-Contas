using ImpulsionaTech.Contas.Domain.Models.Contas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImpulsionaTech.Contas.Infra.Data.Mappings
{
  public class ContasMap : IEntityTypeConfiguration<Conta>
  {
    public void Configure(EntityTypeBuilder<Conta> builder)
    {
      builder.Property(c => c.ContaId)
                .HasColumnName("ContaId");

      builder.Property(c => c.Cliente.Nome)
          .HasColumnType("varchar(100)")
          .HasMaxLength(100)
          .IsRequired();

      builder.Property(c => c.Cliente.CPF)
          .HasColumnType("varchar(100)")
          .HasMaxLength(100)
          .IsRequired();
    }
  }
}
