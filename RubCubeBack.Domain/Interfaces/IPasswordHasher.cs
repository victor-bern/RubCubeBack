using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Domain.Interfaces
{
    public interface IPasswordHasher
    {
        Task<string> HashPasswordAsync(string password, CancellationToken cancellationToken = default);
        Task<bool> VerifyPasswordAsync(string hashedPassword, string providedPassword, CancellationToken cancellationToken = default);
    }
}
