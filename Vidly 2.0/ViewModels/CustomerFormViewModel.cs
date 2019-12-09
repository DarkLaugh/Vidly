using System;
using System.Collections.Generic;
using Vidly_2._0.Models;
using System.Linq;
using System.Web;

namespace Vidly_2._0.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public CustomerModel Customer { get; set; }
    }
}