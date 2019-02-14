using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CFTFurnitureWeb.Models;

using CFTFurnitureWeb.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace CFTFurnitureWeb.Controllers
    {
    
    [Authorize(Roles = "generalRol, Admins, anonymous")]
    public class FurnitureController : Controller
        {
        private IFurnitureRepository repository;
        public int PageSize = 4;



        public FurnitureController(IFurnitureRepository repo)
            {
            repository = repo;
            }
        public ViewResult List(string category, int furniturePage = 1)
            => View(new FurnituresListViewModel
                {
                Furnitures = repository.Furnitures
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.FurnitureID)
                .Skip((furniturePage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                    {
                    CurrentPage = furniturePage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        repository.Furnitures.Count() :
                        repository.Furnitures.Where(e => e.Category == category).Count()
                    },
                CurrentCategory = category
                });

        public IActionResult Index()
            {
            return View();
            }
        }
    }
