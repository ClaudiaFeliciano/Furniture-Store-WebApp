using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFTFurnitureWeb.Models;

namespace CFTFurnitureWeb.Models.ViewModels
    {
    public class FurnituresListViewModel
        {
        public IEnumerable<Furniture> Furnitures { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
        }
    }

