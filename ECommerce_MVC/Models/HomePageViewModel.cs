using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_MVC.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Product> LatestProducts{ get; set; }
        public IEnumerable<Product> RandomProducts{ get; set; }
        public IEnumerable<Category> RandomCategories{ get; set; }
        public IEnumerable<Brand> Brands{ get; set; }
        public IEnumerable<Announcement> Announcements{ get; set; }
    }
}
