using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Soulful.ViewModels
{
    public class OrderViewModel
    {

        [Required]
        [StringLength(128)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string RecieverName { get; set; }

        public string RecieverPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string RecieverAdress { get; set; }
    }
}