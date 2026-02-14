using FluentValidation;
using RubCubeBack.Application.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Validators.Auth
{
    public class LoginRequestDTOValidator : AbstractValidator<LoginRequestDTO>
    {
        public LoginRequestDTOValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.")
                .MaximumLength(25).WithMessage("Password cannot exceed 25 characters.");
        }
    }
}
