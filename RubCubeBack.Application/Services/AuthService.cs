using RubCubeBack.Application.DTOs;
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
    public class AuthService : IAuthService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IUserRepository _userRepository;

        public AuthService(IJwtTokenGenerator jwtTokenGenerator, IPasswordHasher passwordHasher, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _passwordHasher = passwordHasher;
            _userRepository = userRepository;
        }

        public async Task<LoginResponseDTO> LoginAsync(LoginRequestDTO request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByEmail(request.Email, cancellationToken) ?? throw new UnauthorizedException("Invalid Credentials");

            var passwordIsValid = await _passwordHasher.VerifyPasswordAsync(user.Password, request.Password);

            if (!passwordIsValid)
            {
                throw new UnauthorizedException("Invalid Credentials");
            }

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new LoginResponseDTO(token, DateTime.UtcNow.AddHours(1));
        }
    }
}
