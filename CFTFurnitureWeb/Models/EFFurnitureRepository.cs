using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFTFurnitureWeb.Models
    {
    public class EFFurnitureRepository : IFurnitureRepository
        {
        private ApplicationDbContext context;
        public EFFurnitureRepository(ApplicationDbContext ctx)
            {
            context = ctx;
            }
        public IQueryable<Furniture> Furnitures => context.Furnitures;
        public void SaveFurniture(Furniture furniture)
            {
            if (furniture.FurnitureID == 0)
                {
                context.Furnitures.Add(furniture);
                }
            else
                {
                Furniture dbEntry = context.Furnitures
                .FirstOrDefault(p => p.FurnitureID == furniture.FurnitureID);
                if (dbEntry != null)
                    {
                    dbEntry.Name = furniture.Name;
                    dbEntry.Description = furniture.Description;
                    dbEntry.Price = furniture.Price;
                    dbEntry.Category = furniture.Category;
                    }
                }
            context.SaveChanges();
            }
        public Furniture DeleteFurniture(int furnitureID)
            {
            Furniture dbEntry = context.Furnitures
            .FirstOrDefault(p => p.FurnitureID == furnitureID);
            if (dbEntry != null)
                {
                context.Furnitures.Remove(dbEntry);
                context.SaveChanges();
                }
            return dbEntry;
            }
        }
    }
