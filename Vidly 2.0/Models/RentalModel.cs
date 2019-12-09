using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_2._0.Models
{
    public class RentalModel
    {
        public int Id { get; set; }
        [Required]
        public MovieModel Movie { get; set; }

        [Required]
        public CustomerModel Customer { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}