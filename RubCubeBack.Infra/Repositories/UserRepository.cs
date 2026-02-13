using Microsoft.EntityFrameworkCore;

using RubCubeBack.Domain.Models;
using RubCubeBack.Domain.Repositories;
using RubCubeBack.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RubCubeBack.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly RubAppDbContext _context;
        public UserRepository(RubAppDbContext context)
        {
            _context = context;
        }

        public async Task<User> CreateAsync(User entity, CancellationToken cancellationToken = default)
        {
           await _context.Users.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return entity;
        }

        public async Task DeleteAsync(User entity, CancellationToken cancellationToken = default)
        {
           _context.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<IEnumerable<User>> GetAsync(Expression<Func<User, bool>>? predicate = null, int page = 1, int pageSize = 10, CancellationToken cancellationToken = default)
        {
            var query = _context.Users.AsNoTracking().AsQueryable();

            if (predicate is not null)
            {
                query = query.Where(predicate);
            }

            return await query
                .OrderBy(u => u.Name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync(cancellationToken);
        }

        public Task<User?> GetByEmail(string email, CancellationToken cancellationToken = default)
        {
            return _context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
        }

        public async Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
        }

        public async Task<User> UpdateAsync(User entity, CancellationToken cancellationToken = default)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity;
        }
    }
}
