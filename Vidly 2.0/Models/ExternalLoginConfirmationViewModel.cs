using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly_2._0.Models
{
    public class ExternalLoginConfirmationViewModel
    {
            [Required]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(255, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
            [Display(Name = "Driving License")]
            public string DrivingLicense { get; set; }

            [Required]
            [StringLength(50, ErrorMessage = "This {0} must be at least {2} characters long.", MinimumLength = 3)]
            public string Phone { get; set; }
    }
}