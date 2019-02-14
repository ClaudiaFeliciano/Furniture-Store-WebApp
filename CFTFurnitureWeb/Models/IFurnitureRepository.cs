using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFTFurnitureWeb.Models
    {
    public interface IFurnitureRepository
        {

        IQueryable<Furniture> Furnitures { get; }
        void SaveFurniture(Furniture furniture);
        Furniture DeleteFurniture(int furnitureID);
        }
    }

