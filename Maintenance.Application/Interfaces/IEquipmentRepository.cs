using Maintenance.Domain.Entities;

namespace Maintenance.Application.Interfaces;

public interface IEquipmentRepository
{
    Task<List<Equipment>> GetAllAsync();
}