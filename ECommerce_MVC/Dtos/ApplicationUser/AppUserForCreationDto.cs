﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_MVC.Dtos.ApplicationUser
{
    public class AppUserForCreationDto
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
    }
}
