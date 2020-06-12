using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soulful.ViewModels
{
    public class ProductDetailViewModel
    {
        public int ProductId { get; set; }
        public int Count { get; set; }

        public string Pic { get; set; }
        public decimal Price { get; set; }
    }
}