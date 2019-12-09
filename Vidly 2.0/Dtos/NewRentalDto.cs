using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly_2._0.Dtos
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}