using Contratos.Domain.Entities;

namespace Contratos.Shared.Common.Interfaces
{
    public interface IContratoRepository
    {
        Task AddAsync(ContratoModel contrato);
        Task<ContratoModel> GetByIdAsync(Guid id);
        Task<List<ContratoModel>> GetAllAsync();
    }
}
