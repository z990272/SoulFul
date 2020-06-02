using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Soulful.ViewModels
{
    public class RegisterViewModels
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "電子郵件")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "確認密碼")]
        [Compare("Password", ErrorMessage = "密碼和確認密碼不相符。")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "行動電話")]
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$", ErrorMessage = "需為09xx-xxx-xxx格式")]
        public string Mobile { get; set; }
    }
}