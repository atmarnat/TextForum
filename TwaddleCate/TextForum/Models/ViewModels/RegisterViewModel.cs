using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TextForum.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = " Enter a username"), StringLength(20)]
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Required(ErrorMessage = "E-Mail Required")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Required")]
        [StringLength(50)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [StringLength(50)]
        public string ConfirmPassword { get; set; }

    }
}
