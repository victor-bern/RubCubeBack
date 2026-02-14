using FluentValidation;
using RubCubeBack.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Validators.User
{
    public class UpdateUserRequestDTOValidator : AbstractValidator<UpdateUserRequestDTO>
    {
        public UpdateUserRequestDTOValidator()
        {
            RuleFor(x => x.Name)
                .MaximumLength(50).WithMessage("Name cannot exceed 50 characters.");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Invalid email format.")
                .MaximumLength(60).WithMessage("Email cannot exceed 60 characters.");
        }
    }
}
