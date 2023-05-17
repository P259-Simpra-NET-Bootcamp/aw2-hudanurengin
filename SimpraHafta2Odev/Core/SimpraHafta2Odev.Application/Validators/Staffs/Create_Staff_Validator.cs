using FluentValidation;
using SimpraHafta2Odev.Application.ViewModels.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHafta2Odev.Application.Validators.Staffs
{
    public class Create_Staff_Validator : AbstractValidator<VM_Create_Staff>
    {
        public Create_Staff_Validator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                    .WithMessage("Lütfen adınızı boş geçmeyiniz.")
                .NotNull()
                    .WithMessage("Lütfen adınızı boş geçmeyiniz.")
                .MaximumLength(50);

            RuleFor(x => x.LastName)
                .NotEmpty()
                    .WithMessage("Lütfen soyadınızı boş geçmeyiniz.")
                .NotNull()
                    .WithMessage("Lütfen soyadınızı boş geçmeyiniz")
                .MaximumLength(50);

            RuleFor(x => x.Email)
                .NotEmpty()
                    .WithMessage("Lütfen mail adresinizi giriniz.")
                .NotNull()
                    .WithMessage("Lütfen mail adresinizi giriniz.")
                .EmailAddress()
                    .WithMessage("Lütfen mail adresinizi doğru formatta giriniz.")
                .MaximumLength(50);

            RuleFor(x => x.Phone)
                .NotEmpty()
                    .WithMessage("Lütfen telefon numaranızı giriniz.")
                .NotNull()
                    .WithMessage("Lütfen telefon numaranızı giriniz")
                .MaximumLength(11)
                .MinimumLength(11)
                    .WithMessage("Telefon numaranızı başında sıfır bulunacak şekilde giriniz.");

        }
    

    }
}

