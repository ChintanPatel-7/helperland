using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Please enter E-mail address")]
        [EmailAddress(ErrorMessage = "Please enter Valid email Address")]
        public string Email { get; set; }
    }
}
