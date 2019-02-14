using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CFTFurnitureWeb.Models
    {
    public class Cart
        {
        private List<CartLine> lineCollection = new List<CartLine>();
        public virtual void AddItem(Furniture furniture, int quantity)
            {
            CartLine line = lineCollection
            .Where(p => p.Furniture.FurnitureID == furniture.FurnitureID)
            .FirstOrDefault();
            if (line == null)
                {
                lineCollection.Add(new CartLine
                    {
                    Furniture = furniture,
                    Quantity = quantity
                    });
                }
            else
                {
                line.Quantity += quantity;
                }
            }
        public virtual void RemoveLine(Furniture furniture) =>
        lineCollection.RemoveAll(l => l.Furniture.FurnitureID == furniture.FurnitureID);
        public virtual decimal ComputeTotalValue() =>
        lineCollection.Sum(e => e.Furniture.Price * e.Quantity);
        public virtual void Clear() => lineCollection.Clear();
        public virtual IEnumerable<CartLine> Lines => lineCollection;
        }
    public class CartLine
        {
        public int CartLineID { get; set; }
        public Furniture Furniture { get; set; }
        public int Quantity { get; set; }

        }
    }
