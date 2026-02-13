using RubCubeBack.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Infra.Security
{
    public class PasswordHasher : IPasswordHasher
    {
        public Task<string> HashPasswordAsync(string password, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return Task.FromResult(BCrypt.Net.BCrypt.HashPassword(password));
        }

        public async Task<bool> VerifyPasswordAsync(string hashedPassword, string providedPassword, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return await Task.FromResult(BCrypt.Net.BCrypt.Verify(providedPassword, hashedPassword));
        }
    }
}
