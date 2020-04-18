using System;
namespace Сайт.Models
{
    public class ItemClass
    {
        public String Picture { get; set; }

        public String Description { get; set; }
        public String ColorC { get; set; }
        public Decimal Price { get; set; }
        public Boolean InStock { get; set; }

        public ItemClass()
        {
            InStock = false;
            Description = "Новый товар";
            Price = 0;
            ColorC ="ds ";
        }

        public ItemClass(String discription,String picrure, Decimal price, string ColorC): base()
        {
            this.Description = discription;
            this.Picture = picrure;
            this.Price = price;
            this.ColorC = ColorC;

        }
    }
}
