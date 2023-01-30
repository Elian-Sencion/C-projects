using System;

namespace VentasOnline.Web.Models
{
    public class ProductsModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
