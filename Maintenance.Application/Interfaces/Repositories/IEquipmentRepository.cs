using Maintenance.Application.Models;
using Maintenance.Domain.Entities;
using System;

namespace Maintenance.Application.Interfaces.Repositories;

public interface IEquipmentRepository
{
   
    Task<PagedResult<Equipment>> GetAllAsync(
    int pageNumber,
    int pageSize);
    Task<Equipment?> GetByIdAsync(int id);
    Task<List<Equipment>> GetActiveAsync();
}