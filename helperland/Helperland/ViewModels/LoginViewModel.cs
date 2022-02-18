using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter an email")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter a password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
