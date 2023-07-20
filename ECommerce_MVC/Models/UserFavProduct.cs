using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class UserFavProduct
    {
        public Product Product { get; set; }
        public Guid ProductId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
    }
}
