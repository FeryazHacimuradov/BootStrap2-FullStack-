using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootStrap2.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required]
        public string Logo { get; set; }
        [MaxLength(150), Required]
        public string Title { get; set; }
        [MaxLength(150), Required]
        public string SubTitle { get; set; }
        [MaxLength(300), Required]
        public string CopyrightYear { get; set; }
    }
}
