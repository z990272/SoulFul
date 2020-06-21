using Soulful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soulful.ViewModels
{
    public class OrderDetailViewModel
    {

        public int OrderId { get; set; }

        public List<ApiOrderDetail> OrderDetails { get; set; }
    }

    public class ApiOrderDetail
    {
        public string Product { get; set; }
        public int Count { get; set; }
        public decimal UnitPrice { get; set; }

    }

}