using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Brand
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string BrandImage { get; set; }
        [NotMapped]
        public IFormFile ImageFile{ get; set; }

        public List<Product> Products { get; set; }
    }

    public class BrandCreationModel
    {
        public string Name { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
