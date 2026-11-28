using Maintenance.Domain.Entities;
using Maintenance.Application.Models;
using System;

namespace Maintenance.Application.Interfaces.Services;

public interface IEquipmentService
{
  
    Task<PagedResult<Equipment>> GetAllAsync(
        int pageNumber,
        int pageSize);
    Task<Equipment?> GetByIdAsync(int id);
    Task<List<Equipment>> GetActiveAsync();
}