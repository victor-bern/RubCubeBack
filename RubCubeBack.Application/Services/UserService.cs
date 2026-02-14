using RubCubeBack.Application.DTOs.Common;
using RubCubeBack.Application.DTOs.User;
using RubCubeBack.Application.Exceptions;
using RubCubeBack.Application.Interfaces;
using RubCubeBack.Domain.Interfaces;
using RubCubeBack.Domain.Models;
using RubCubeBack.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public UserService(IUserRepository userRepository, IPasswordHasher passwordHasher, IJwtTokenGenerator jwtTokenGenerator)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<ListItemsResponse<IList<UserResponseDTO>>> GetUsersAsync(UserFilterDTO filter, CancellationToken cancellationToken)
        {
            filter.Page = filter.Page <= 0 ? 1 : filter.Page;

            var users = await _userRepository.GetAsync(
            p => (string.IsNullOrEmpty(filter.Name) || p.Name.ToLower().Contains(filter.Name.ToLower()))
            && (string.IsNullOrEmpty(filter.Email) || p.Email.ToLower().Contains(filter.Email.ToLower())
            ), filter.Page, filter.PageSize, cancellationToken);

            return new ListItemsResponse<IList<UserResponseDTO>>()
            {
                Page = filter.Page,
                PageSize = filter.PageSize,
                Items = [.. users.Select(u => new UserResponseDTO(u.Name, u.LastName, u.Email))]
            };
        }

        public async Task<string> CreateUserAsync(CreateAndUpdateUserRequestDTO createUserRequestDTO, CancellationToken cancellationToken)
        {
            var passwordHashed = await _passwordHasher.HashPasswordAsync(createUserRequestDTO.Password, cancellationToken);

            var user = new User
            {
                Name = createUserRequestDTO.Name,
                LastName = createUserRequestDTO.LastName,
                Email = createUserRequestDTO.Email,
                Password = passwordHashed,
            };

            await _userRepository.CreateAsync(user, cancellationToken);

            return _jwtTokenGenerator.GenerateToken(user);
        }

        public async Task<UserResponseDTO> UpdateUserAsync(Guid userId, CreateAndUpdateUserRequestDTO updateUserRequestDTO, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(userId, cancellationToken) ?? throw new UserNotFoundException("User not found");

            user.Name = string.IsNullOrEmpty(updateUserRequestDTO.Name) ? user.Name : updateUserRequestDTO.Name;
            user.LastName = string.IsNullOrEmpty(updateUserRequestDTO.LastName) ? user.LastName : updateUserRequestDTO.LastName;
            user.Email = string.IsNullOrEmpty(updateUserRequestDTO.Email) ? user.Email : updateUserRequestDTO.Email;

            if (!string.IsNullOrEmpty(updateUserRequestDTO.Password))
            {
                user.Password = await _passwordHasher.HashPasswordAsync(updateUserRequestDTO.Password, cancellationToken);
            }

            await _userRepository.UpdateAsync(user, cancellationToken);

            return new UserResponseDTO(user.Name, user.LastName, user.Email);

        }

        public async Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(userId, cancellationToken) ?? throw new UserNotFoundException("User not found");
            
            await _userRepository.DeleteAsync(user, cancellationToken);
        }
    }
}
