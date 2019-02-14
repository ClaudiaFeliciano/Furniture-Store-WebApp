using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFTFurnitureWeb.Models
    { 
   public class FakeFurnitureRepository /*: IFurnitureRepository*/
    {

    public IQueryable<Furniture> Furnitures => new List<Furniture> {
            new Furniture {
                    FurnitureID = 001,
                    Name = "Adalberto TV Stand for TVs up to 65",
                    Description = "Include our rustic barn door style TV stand in your home" +
                    " to not only enhance the décor of your living area, but create ample " +
                    "storage for all of your media.",
                    Price = 250,
                    Category = "Living Room",
                    ProtectionPlan = "true",
                    ImagenURL = "01.jpg"},

                new Furniture {
                    FurnitureID = 002,
                    Name = "Bissonnette TV Stand for TVs up to 58",
                    Description ="Set a streamlined foundation in your entertainment ensemble" +
                    " with this understated TV stand. Crafted from manufactured wood with " +
                    "laminate in a neutral finish, this budget-friendly piece measures 25'' " +
                    "H x 58'' W x 16'' D overall to accommodate flat-screens up to 58",
                    Price = 950,
                    Category = "Living Room",
                    ImagenURL = "02.jpg"},

                new Furniture {
                    FurnitureID = 003,
                    Name = "Cobbs Convertible Sofa",
                    Description = "The split back design of this convertible sofa is made to" +
                    " offer each guest their own level of comfort, from sitting up to lounging" +
                    " back. You can even lay flat both the seat and back cushions to create a " +
                    "comfortable place for overnight guests to sleep.",
                    Price = 320.99M,
                    Category = "Living Room",
                    ImagenURL = "03.jpg"},

                new Furniture {
                    FurnitureID = 004,
                    Name = "Inglenook TV Stand for TVs up to 60 with Fireplace",
                    Description = "Crafted of manufactured wood with rustic laminate veneers," +
                    " this 58 TV stand strikes a clean, rectangular silhouette with chunky " +
                    "mouldings and tapered feet.",
                    Price = 1500,
                    Category = "Living Room",
                    ImagenURL = "04.jpg"},

                new Furniture {
                    FurnitureID = 005,
                    Name = "Kailani Reclining Loveseat",
                    Description = "Console: Yes. Loveseat Heigh - Top to Bottom: 39 Inches." +
                    " Loveseat Width - Side to Side: 49 Inches. Loveseat Depth - Front to Back:" +
                    " 51 Inches",
                    Price = 1250,
                    Category = "Living Room",
                    ImagenURL = "03.jpg"},

                new Furniture {
                    FurnitureID = 006,
                    Name = "Step One 6 Drawer Double Dresser",
                    Description = "This Step One 6-drawer double dresser has a" +
                    " timeless look and blends in easily with any decor. The contemporary" +
                    " lines are softened by the curved kick plate, and metal handles add " +
                    "character and value to the furniture.",
                    Price = 653,
                    Category = "Bedroom",
                    ImagenURL = "03.jpg"},

                new Furniture {
                    FurnitureID = 007,
                    Name = "Step One Platform Bed",
                    Description ="Complete with spacious storage, this bed will suit the " +
                    "needs for anyone limited on space. Your belongings are entirely hidden," +
                    " making for a discreet storage solution. In addtion to roomy storage," +
                    " this bed is cost efficient as it does not require a box spring or " +
                    "foundation- simply place your mattress directly on top of the bed frame.",
                    Price = 183.77M,
                    Category = "Bedroom" ,
                    ImagenURL = "03.jpg"},

                new Furniture {
                    FurnitureID = 008,
                    Name = "Snider Traditional Rectangle Dining Table",
                    Description = "Traditional design with a modern flair, this Dining Table is" +
                    " built to last.",
                    Price = 105.99M,
                    Category = "Dinning Room",
                    ImagenURL = "03.jpg"},

                new Furniture {
                    FurnitureID = 010,
                    Name = "Abigail Standard Bookcase",
                    Description = "Looking for a budget-friendly place to stash all your " +
                    "favourite reads? This bookcase fits the bill! Measuring 69.75' ' H x 35.25'" +
                    " ' W x 13.25' ' D, its five shelves are adjustable, so you can find the" +
                    " perfect fit for your novels, vases, and other decorative objects. ",
                    Price = 289.99M,
                    Category = "Office",
                    ImagenURL = "03.jpg"},

                new Furniture {
                    FurnitureID = 011,
                    Name = "Salina L - Shape Corner Desk ",
                    Description ="Maximize your home office space with this L-Shaped Desk - " +
                    "this desk fits perfectly in a corner or up against any wall. ",
                    Price = 289.99M,
                    Category = "Office",
                    ImagenURL = "03.jpg"},

                new Furniture {
                    FurnitureID = 012,
                    Name = "Hillsdale L-Shaped Computer Desk",
                    Description ="Whether working on your next great novel or just need a " +
                    "space to craft DIY masterpieces, this desk is a must-have for your home " +
                    "office. One pedestal base features a computer tower cabinet behind a fluted " +
                    "glass panel door, while the other pedestal includes two drawers on " +
                    "full-extension ball bearing glides to accommodate letter, legal or A4 " +
                    "sized paperwork.",
                    Price = 470.00M,
                    Category = "Office",
                    ImagenURL = "03.jpg"}

            }.AsQueryable<Furniture>();
    }
}
