using Maintenance.Domain.Entities;

namespace Maintenance.Application.Interfaces.Services;

public interface IEquipmentService
{
    Task<List<Equipment>> GetAllAsync();
}