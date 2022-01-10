using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootStrap2.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [MaxLength(200), Required]
        public string Name { get; set; }
    }
}
