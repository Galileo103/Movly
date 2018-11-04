using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movly.Models
{
    public class MinAgeForChooseMembershipType : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Cast Object Instance to Customer Object
            Customer customer = validationContext.ObjectInstance as Customer;

            if (customer.MembershipTypeId == (byte) Membership.Unknown || customer.MembershipTypeId == (byte) Membership.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Should be at least 18 years old to go on a membership");

        }
    }
}