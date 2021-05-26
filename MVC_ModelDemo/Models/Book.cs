using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ModelDemo.Models
{
    public class Book 
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(15)]

        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public int YearPublished { get; set; }
        [Required]
        public int Pages { get; set; }

    }
}
