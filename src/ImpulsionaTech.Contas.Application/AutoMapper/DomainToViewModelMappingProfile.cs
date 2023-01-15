using AutoMapper;
using ImpulsionaTech.Contas.Application.ViewModels;
using ImpulsionaTech.Contas.Domain.Models.Clientes;
using ImpulsionaTech.Contas.Domain.Models.Contas;
using ImpulsionaTech.Contas.Domain.Models.TiposContas;

namespace ImpulsionaTech.Contas.Application.AutoMapper
{
  public class DomainToViewModelMappingProfile : Profile
  {
    public DomainToViewModelMappingProfile()
    {
      CreateMap<Cliente, ClienteViewModel>();
      CreateMap<Conta, ContaViewModel>();
      CreateMap<TipoConta, TipoContaViewModel>();
    }
  }
}
