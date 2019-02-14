using CFTFurnitureWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFTFurnitureWeb.Components
    {
    public class NavigationMenuViewComponent : ViewComponent
        {

        private IFurnitureRepository repository;
        public NavigationMenuViewComponent(IFurnitureRepository repo)
            {
            repository = repo;
            }
        public IViewComponentResult Invoke()
            {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Furnitures
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x));
            }
        }
    }
