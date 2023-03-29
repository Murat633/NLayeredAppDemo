using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    //Fluent validation
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpty().WithMessage("Ürün Adı Boş Bırakılamaz");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Kategori Boş Bırakılamaz");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Ürün Fiyatı Boş Bırakılamaz");
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("Birim Miktarı Boş Bırakılamaz");
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Stok Adedi Boş Bırakılamaz");

            RuleFor(p=>p.UnitPrice).GreaterThan(0).WithMessage("Ürün Fiyatı 0'dan bütük olmalıdır.");
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo( (short) 0 );

            //RuleFor(p => p.ProductName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
