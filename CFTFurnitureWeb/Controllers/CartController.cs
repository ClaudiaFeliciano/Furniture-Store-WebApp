using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CFTFurnitureWeb.Infrastructure;
using CFTFurnitureWeb.Models;
using CFTFurnitureWeb.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace CFTFurnitureWeb.Controllers
    {
    [Authorize(Roles = "generalRol, Admins")]
  
    public class CartController : Controller
        {
        private IFurnitureRepository repository;
        private Cart cart;
        public CartController(IFurnitureRepository repo, Cart cartService)
            {
            repository = repo;
            cart = cartService;
            }
        public ViewResult Index(string returnUrl)
            {
            return View(new CartIndexViewModel
                {
                Cart = cart,
                ReturnUrl = returnUrl
                });
            }
        
        public RedirectToActionResult AddToCart(int furnitureId, string returnUrl)
            {
            Furniture furniture = repository.Furnitures
            .FirstOrDefault(p => p.FurnitureID == furnitureId);
            if (furniture != null)
                {
                cart.AddItem(furniture, 1);
                }
            return RedirectToAction("Index", new { returnUrl });
            }
        
        public RedirectToActionResult RemoveFromCart(int furnitureId,
        string returnUrl)
            {
            Furniture furniture = repository.Furnitures
            .FirstOrDefault(p => p.FurnitureID == furnitureId);
            if (furniture != null)
                {
                cart.RemoveLine(furniture);
                }
            return RedirectToAction("Index", new { returnUrl });
            }
        }
    }
