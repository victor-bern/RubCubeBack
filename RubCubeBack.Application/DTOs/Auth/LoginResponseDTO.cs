using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.DTOs.Auth
{
    public record LoginResponseDTO(string Token, DateTime Expiration);
}
