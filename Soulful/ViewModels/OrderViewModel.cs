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
        [StringLength(50)]
        public string RecieverName { get; set; }
        [Required]
        [RegularExpression(@"^09\d{2}\-?\d{3}\-?\d{3}$", ErrorMessage = "需為09xx-xxx-xxx格式")]
        public string RecieverPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string RecieverAdress { get; set; }

    }
}