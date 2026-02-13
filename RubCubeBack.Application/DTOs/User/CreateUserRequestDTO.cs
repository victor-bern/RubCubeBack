using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.DTOs.User
{
    public record CreateUserRequestDTO(string Name, string? LastName, string Email, string Password);
}
