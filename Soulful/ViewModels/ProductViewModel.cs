using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soulful.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Pic { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public decimal Price { get; set; }
        public int UnitInStock { get; set; }
        public int Count { get; set; }
    }
}