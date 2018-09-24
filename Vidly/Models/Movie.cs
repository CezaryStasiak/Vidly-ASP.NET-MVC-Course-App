using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public MovieGenre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte MovieGenreId { get; set; }

        [Display(Name = "Released Date")]
        [Required]
        public DateTime ReleasedDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "In Stock")]
        [Required]
        [Range(1, 20)]
        public int InStock { get; set; }
    }
    
}