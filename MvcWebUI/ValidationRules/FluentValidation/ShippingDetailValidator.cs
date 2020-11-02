﻿using FluentValidation;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator : AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("İsim gereklidir!");
            RuleFor(s => s.FirstName).MinimumLength(2);
            RuleFor(s => s.LastName).NotEmpty();
            RuleFor(s => s.Address).NotEmpty();
            RuleFor(s => s.City).NotEmpty();
            RuleFor(s => s.Age).NotEmpty();
            RuleFor(s => s.Age).InclusiveBetween(18, 65);
            RuleFor(s => s.Email).NotEmpty();
            RuleFor(s => s.Email).EmailAddress();
        }
    }
}
