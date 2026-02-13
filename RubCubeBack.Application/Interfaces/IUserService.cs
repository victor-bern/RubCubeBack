using RubCubeBack.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserResponseDTO>> GetUsersAsync(CancellationToken cancellationToken);
        Task<string> CreateUserAsync(CreateUserRequestDTO createUserRequestDTO, CancellationToken cancellationToken);
        Task<UserResponseDTO> UpdateUserAsync(Guid userId, UpdateUserRequestDTO updateUserRequestDTO, CancellationToken cancellationToken);
        Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken);
    }
}
