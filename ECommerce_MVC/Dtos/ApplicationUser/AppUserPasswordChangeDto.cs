using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_MVC.Dtos.ApplicationUser
{
    public class AppUserPasswordChangeDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
    }
}
