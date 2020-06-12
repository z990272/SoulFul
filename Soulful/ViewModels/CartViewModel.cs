using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soulful.ViewModels
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public string CartId{ get; set; }
        public int RecordId { get; set; }
        public string Name { get; set; }
        public string Pic { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}