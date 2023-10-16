using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Validators
{
    public class MusteriValidator:AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
            RuleFor(x => x.Adi).NotNull().WithMessage("Adı boş geçilemez");
            RuleFor(x => x.Soyadi).NotNull().WithMessage("Soyadı boş geçilemez");
            RuleFor(x => x.Dogum_Tarihi).NotNull().WithMessage("Doğum tarihi boş geçilemez");
            RuleFor(x => x.Adi).MinimumLength(2).WithMessage("Adı alanı en az 2 karakter içermeli");
            RuleFor(x => x.Soyadi).MinimumLength(2).WithMessage("Soyadı alanı en az 2 karakter içermeli");
            RuleFor(x => x.Adi).MaximumLength(25).WithMessage("Adı alanı 25 karakterden fazla olamaz");
            RuleFor(x => x.Soyadi).MaximumLength(25).WithMessage("Soyadı alanı 25 karakterden fazla olamaz");
            RuleFor(x => x.E_mail).EmailAddress().WithMessage("Geçerli bir email adresi girin");
            RuleFor(x => x.Telefon).MaximumLength(11).WithMessage("Telefon numarası 11 haneden büyük olamaz");
            RuleFor(x => x.Telefon).MinimumLength(11).WithMessage("Telefon numarası 11 haneden küçük olamaz");
            RuleFor(x => x.Dogum_Tarihi).LessThan(DateTime.Now.Date).WithMessage("Lütfen geçerli bir doğum taihi giriniz");
            RuleFor(x => x.Dogum_Tarihi).GreaterThan(Convert.ToDateTime ("01.01.1900")).WithMessage("Doğum tarihi 01.01.1900'den önce olamaz");
        } 
    }
}
