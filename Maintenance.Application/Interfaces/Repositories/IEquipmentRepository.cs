using Maintenance.Domain.Entities;

namespace Maintenance.Application.Interfaces.Repositories;

public interface IEquipmentRepository
{
    Task<List<Equipment>> GetAllAsync();
    Task<Equipment?> GetByIdAsync(int id);
    Task<List<Equipment>> GetActiveAsync();
}