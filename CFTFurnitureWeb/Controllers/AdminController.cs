using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CFTFurnitureWeb.Models;
using Microsoft.AspNetCore.Authorization;

namespace CFTFurnitureWeb.Controllers
    {
    [Authorize(Roles = "Admins" )]
    public class AdminController : Controller
        {
        private IFurnitureRepository repository;

        public AdminController(IFurnitureRepository repo)
            {
            repository = repo;
            }
        public ViewResult Index() => View(repository.Furnitures);

        public ViewResult Edit(int furnitureId) =>
            View(repository.Furnitures
            .FirstOrDefault(p => p.FurnitureID == furnitureId));

        [HttpPost]
        public IActionResult Edit(Furniture furniture)
            {
            if (ModelState.IsValid)
                {
                repository.SaveFurniture(furniture);
                TempData["message"] = $"{furniture.Name} has been saved";
                return RedirectToAction("Index");
                }
            else
                {
                return View(furniture);
                }
            }
        public ViewResult Create() => View("Edit", new Furniture());

        [HttpPost]
        public IActionResult Delete(int furnitureId)
            {
            Furniture deletedFurniture = repository.DeleteFurniture(furnitureId);
            if (deletedFurniture != null)
                {
                TempData["message"] = $"{deletedFurniture.Name} was deleted";
                }
            return RedirectToAction("Index");
            }
        }
    }