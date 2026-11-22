using Maintenance.Application.Interfaces;
using Maintenance.Domain.Entities;

namespace Maintenance.Application.Services;

public class EquipmentService
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
}