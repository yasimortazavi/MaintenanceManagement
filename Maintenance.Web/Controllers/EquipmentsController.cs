using Maintenance.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Maintenance.Web.Controllers
{
    public class EquipmentsController : Controller
    {
        private readonly IEquipmentService _equipmentService;

        public EquipmentsController(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService;
        }

        public async Task<IActionResult> Index()
        {
            var equipments = await _equipmentService.GetAllAsync();

            return View(equipments);
        }

        public async Task<IActionResult> Details(int id)
        {
            var equipment = await _equipmentService.GetByIdAsync(id);

            if (equipment == null)
                return NotFound();

            return View(equipment);
        }
        public async Task<IActionResult> Active()
        {
            var equipments = await _equipmentService.GetActiveAsync();

            return View(equipments);
        }
    }
}
