using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.DTOs.User
{
    public record CreateAndUpdateUserRequestDTO(string Name, string? LastName, string Email, string Password);
}
