using RubCubeBack.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDTO> LoginAsync(LoginRequestDTO request, CancellationToken cancellationToken);
    }
}
