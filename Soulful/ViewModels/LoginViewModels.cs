using Microsoft.Owin.BuilderProperties;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Soulful.Models
{
    public class LoginViewModels
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "密碼")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "3~30")]
        public string PassWord { get; set; }
    }

    
}
