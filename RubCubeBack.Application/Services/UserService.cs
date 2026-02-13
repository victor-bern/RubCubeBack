using RubCubeBack.Application.DTOs;
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

        public async Task<string> CreateUserAsync(CreateUserRequestDTO createUserRequestDTO, CancellationToken cancellationToken)
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

        public async Task<IEnumerable<ListUsersResponseDTO>> GetUsersAsync(CancellationToken cancellationToken)
        {
          var users = await _userRepository.GetAsync(null, cancellationToken);
           return [.. users.Select(u => new ListUsersResponseDTO
            {
                Name = u.Name,
                LastName = u.LastName,
                Email = u.Email
           })];
        }
    }
}
