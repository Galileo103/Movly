using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Movly.Models;


namespace Movly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //[MinAgeForChooseMembershipType]
        public DateTime? Birthdate { get; set; }

        [Required]
        public byte MembershipTypeId { get; set; }
    }
}