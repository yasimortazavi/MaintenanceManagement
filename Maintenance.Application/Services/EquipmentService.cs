using Maintenance.Application.Interfaces.Repositories;
using Maintenance.Application.Interfaces.Services;
using Maintenance.Domain.Entities;

namespace Maintenance.Application.Services;

public class EquipmentService : IEquipmentService
{
    private readonly IEquipmentRepository _equipmentRepository;

    public EquipmentService(IEquipmentRepository equipmentRepository)
    {
        _equipmentRepository = equipmentRepository;
    }

    public async Task<List<Equipment>> GetAllAsync()
    {
        return await _equipmentRepository.GetAllAsync();
    }

    public async Task<Equipment?> GetByIdAsync(int id)
    {
        return await _equipmentRepository.GetByIdAsync(id);
    }

}