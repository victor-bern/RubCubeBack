using FluentValidation;
using RubCubeBack.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Validators.User
{
    public class CreateAndUpdateUserRequestDTOValidator : AbstractValidator<CreateAndUpdateUserRequestDTO>
    {
        public CreateAndUpdateUserRequestDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(50).WithMessage("Name cannot exceed 50 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.")
                .MaximumLength(60).WithMessage("Email cannot exceed 60 characters.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.")
                .MaximumLength(25).WithMessage("Password cannot exceed 25 characters.");
        }
    }
}
