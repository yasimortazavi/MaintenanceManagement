using Maintenance.Application.Interfaces.Repositories;
using Maintenance.Application.Interfaces.Services;
using Maintenance.Application.Models;
using Maintenance.Domain.Entities;

namespace Maintenance.Application.Services;

public class EquipmentService : IEquipmentService
{
    private readonly IEquipmentRepository _equipmentRepository;

    public EquipmentService(IEquipmentRepository equipmentRepository)
    {
        _equipmentRepository = equipmentRepository;
    }


    public Task<PagedResult<Equipment>> GetAllAsync(
        int pageNumber,
        int pageSize)
    {
        return _equipmentRepository.GetAllAsync(
            pageNumber,
            pageSize);
    }


    public async Task<Equipment?> GetByIdAsync(int id)
    {
        return await _equipmentRepository.GetByIdAsync(id);
    }

    public Task<List<Equipment>> GetActiveAsync()
    {
        return _equipmentRepository.GetActiveAsync();
    }


}