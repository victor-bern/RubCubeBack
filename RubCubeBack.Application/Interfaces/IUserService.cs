using RubCubeBack.Application.DTOs.Common;
using RubCubeBack.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Interfaces
{
    public interface IUserService
    {
        Task<ListItemsResponse<IList<UserResponseDTO>>> GetUsersAsync(UserFilterDTO filter, CancellationToken cancellationToken);
        Task<string> CreateUserAsync(CreateAndUpdateUserRequestDTO createUserRequestDTO, CancellationToken cancellationToken);
        Task<UserResponseDTO> UpdateUserAsync(Guid userId, CreateAndUpdateUserRequestDTO updateUserRequestDTO, CancellationToken cancellationToken);
        Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken);
    }
}
