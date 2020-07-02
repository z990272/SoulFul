using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soulful.ViewModels
{
    public class HitViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Pic { get; set; }

        public string Singer { get; set; }

        public int WeekHits { get; set; }

        public int MonthHits { get; set; }

        public int TotalHits { get; set; }

        public string VideoUrl { get; set; }
        public decimal Price { get; set; }
    }
}