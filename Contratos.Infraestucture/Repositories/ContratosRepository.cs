using Contratos.Domain.Entities;
using Contratos.Infraestucture.Context;
using Contratos.Shared.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Contratos.Infraestucture.Repositories
{
    public class ContratosRepository : IContratoRepository
    {
        private readonly ContratosDbContext _context;
        public ContratosRepository(ContratosDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(ContratoModel contrato)
        {
            await _context.Contratos.AddAsync(contrato);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ContratoModel>> GetAllAsync()
        {
           return await _context.Contratos.ToListAsync();

        }

        public async Task<ContratoModel> GetByIdAsync(Guid id)
        {
            return await _context.Contratos.FindAsync(id);
        }
    }
}
