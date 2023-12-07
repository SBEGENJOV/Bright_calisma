using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Ad ve Soyad boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar Mail boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar Şifre boş geçilemez").Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,}$").WithMessage("Şifre en az 8 karakter uzunluğunda olmalı ve en az bir büyük harf, bir küçük harf ve bir özel karakter içermelidir.");

        }
    }
}
