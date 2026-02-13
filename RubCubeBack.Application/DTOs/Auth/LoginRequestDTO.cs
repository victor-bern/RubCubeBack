using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.DTOs.Auth
{
    public record LoginRequestDTO(string Email, string Password);
}
