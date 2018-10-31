using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Movly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [DisplayName("Membership Type")]
        public string Name { get; set; }
        public short SingUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

    }
}