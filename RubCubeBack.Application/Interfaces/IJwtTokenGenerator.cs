using RubCubeBack.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
