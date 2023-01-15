using System.ComponentModel.DataAnnotations;
using ImpulsionaTech.Contas.Application.EventSourcedNormalizers;
using ImpulsionaTech.Contas.Application.ViewModels;

namespace ImpulsionaTech.Contas.Application.Interfaces
{
  public interface IContasAppService : IDisposable
  {
    Task<IEnumerable<ClienteViewModel>> GetAll();
    Task<ClienteViewModel> GetById(Guid id);
    Task<ValidationResult> Register(ClienteViewModel clienteViewModel);
    Task<ValidationResult> Update(ClienteViewModel clienteViewModel);
    Task<ValidationResult> Remove(Guid id);
    Task<IList<ClienteHistoryData>> GetAllHistory(Guid id);
  }
}
