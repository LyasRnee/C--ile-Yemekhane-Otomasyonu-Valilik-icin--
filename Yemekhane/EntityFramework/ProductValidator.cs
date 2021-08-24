using System;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yemekhane;

namespace EntityFramework
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()  // balance 50 den az olamaz,foodprice 10 dan yukarı olamaz.
        {
            RuleFor(p => p.Balance).GreaterThanOrEqualTo((double)50);
            RuleFor(p => p.FoodPrice).LessThanOrEqualTo((double)15);
        }
    }
}
