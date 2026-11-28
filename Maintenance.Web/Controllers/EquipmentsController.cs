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


  
        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            if (pageNumber < 1)
                pageNumber = 1;

            int pageSize = 5;

            var equipments = await _equipmentService.GetAllAsync(
                pageNumber,
                pageSize);

            if (equipments.TotalPages > 0 &&
                pageNumber > equipments.TotalPages)
            {
                pageNumber = equipments.TotalPages;

                equipments = await _equipmentService.GetAllAsync(
                    pageNumber,
                    pageSize);
            }

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
