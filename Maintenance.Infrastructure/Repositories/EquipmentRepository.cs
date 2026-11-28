using Maintenance.Application.Interfaces.Repositories;
using Maintenance.Domain.Entities;
using Maintenance.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Maintenance.Application.Models;

namespace Maintenance.Infrastructure.Repositories;

public class EquipmentRepository : IEquipmentRepository
{
    private readonly MaintenanceDbContext _context;

    public EquipmentRepository(MaintenanceDbContext context)
    {
        _context = context;
    }

    public async Task<PagedResult<Equipment>> GetAllAsync(
        int pageNumber,
        int pageSize)
    {
        var totalCount = await _context.Equipments.CountAsync();

        var equipments = await _context.Equipments
            .OrderByDescending(e => e.IsActive)
            .ThenByDescending(e => e.Name)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new PagedResult<Equipment>
        {
            Items = equipments,
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalCount = totalCount
        };
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