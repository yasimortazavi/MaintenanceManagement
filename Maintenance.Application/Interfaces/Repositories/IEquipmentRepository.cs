using Maintenance.Domain.Entities;

namespace Maintenance.Application.Interfaces.Repositories;

public interface IEquipmentRepository
{
    Task<List<Equipment>> GetAllAsync();
}