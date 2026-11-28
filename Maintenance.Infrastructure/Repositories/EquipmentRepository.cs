using Maintenance.Application.Interfaces.Repositories;
using Maintenance.Domain.Entities;
using Maintenance.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Maintenance.Infrastructure.Repositories;

public class EquipmentRepository : IEquipmentRepository
{
    private readonly MaintenanceDbContext _context;

    public EquipmentRepository(MaintenanceDbContext context)
    {
        _context = context;
    }

    public async Task<List<Equipment>> GetAllAsync()
    {
        return await _context.Equipments
            .OrderByDescending(e => e.IsActive)
             .ThenByDescending(e => e.Name)
             .ToListAsync();
    }
    public async Task<Equipment?> GetByIdAsync(int id)
    {
        return await _context.Equipments
            .FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<List<Equipment>> GetActiveAsync()
    {
        return await _context.Equipments
            .Where(e => e.IsActive)
             .OrderByDescending(e => e.Name)
            .ToListAsync();
    }

}