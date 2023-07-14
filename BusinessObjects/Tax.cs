using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Tax
    {
        public Guid Id { get; set; }
        public double? SocialTax { get; set; }
    }
}
