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
            .ToListAsync();
    }
    public async Task<Equipment?> GetByIdAsync(int id)
    {
        return await _context.Equipments
            .FirstOrDefaultAsync(e => e.Id == id);
    }
}