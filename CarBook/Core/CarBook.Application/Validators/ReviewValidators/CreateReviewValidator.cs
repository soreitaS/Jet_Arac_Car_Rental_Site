﻿using CarBook.Application.Features.Mediator.Commands.ReservationCommands;
using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Validators.ReviewValidators
{
    public class CreateReviewValidator:AbstractValidator<CreateReviewCommand>
    {
        public CreateReviewValidator() 
        {
            RuleFor(x=> x.CustomerName).NotEmpty().WithMessage("Lütfen müşteri adını boş geçmeyiniz!"); 
            RuleFor(x=> x.CustomerName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız!"); 
            RuleFor(x=> x.RatingValue).NotEmpty().WithMessage("Lütfen puan değerini boş geçmeyiniz!"); 
            RuleFor(x=> x.Comment).NotEmpty().WithMessage("Lütfen yorum kısmını boş geçmeyiniz!"); 
            RuleFor(x=> x.Comment).MinimumLength(50).WithMessage("Lütfen yorum kısmınına en az 50 karakter veri girişi yapınız!"); 
            RuleFor(x=> x.Comment).MaximumLength(500).WithMessage("Lütfen yorum kısmınına en fazla 500 karakter veri girişi yapınız!"); 
        }
    }
}
