using RubCubeBack.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<ListUsersResponseDTO>> GetUsersAsync(CancellationToken cancellationToken);
        Task<string> CreateUserAsync(CreateUserRequestDTO createUserRequestDTO, CancellationToken cancellationToken);
    }
}
