using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.DTOs
{
    public record UserResponseDTO(string Name, string? LastName, string Email);
}
