using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Soulful.ViewModels
{
    public class GiveBackViewModel
    {
        [Required]
        public string Name { get; set; }

        [RegularExpression("[@]+", ErrorMessage = "{0}必須為信箱格式")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }

        public string Status { get; set; }

    }
}