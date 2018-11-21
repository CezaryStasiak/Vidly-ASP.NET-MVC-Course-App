using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Migrations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public MovieGenre Genre { get; set; }
        
        [Required]
        public byte MovieGenreId { get; set; }
        
        [Required]
        public DateTime ReleasedDate { get; set; }

        public DateTime DateAdded { get; set; }
        
        [Required]
        [Range(1, 20)]
        public int InStock { get; set; }
    }
}