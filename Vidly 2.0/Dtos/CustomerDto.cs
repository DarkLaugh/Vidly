using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidly_2._0.Models;
using System.Linq;
using System.Web;

namespace Vidly_2._0.Dtos
{
    public class CustomerDto
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public int Id { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public byte MembershipTypeId { get; set; }

        //[Min18YearsIfaMember]
        public DateTime? Birthdate { get; set; }
    }
}