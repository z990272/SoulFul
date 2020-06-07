using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Razor.Generator;

namespace Soulful.ViewModels
{
    public class AlbumViewModel
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        public string Pic { get; set; }

        public string Singer { get; set; }

        public string About { get; set; }

        public int Id { get; set; }
    }

}