using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.DTOs
{
    public record LoginResponseDTO(string Token, DateTime Expiration);
}
