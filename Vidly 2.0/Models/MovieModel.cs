using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_2._0.Models
{
    public class MovieModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public GenreModel Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1,100)]
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }
    }
}