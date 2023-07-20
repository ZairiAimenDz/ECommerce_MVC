﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }
        public List<UserFavProduct> LikedProducts { get; set; }
    }
}
