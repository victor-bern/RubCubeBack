using RubCubeBack.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Domain.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User?> GetByEmail(string email, CancellationToken cancellationToken = default);
    }
}
