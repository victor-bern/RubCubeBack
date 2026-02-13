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
    public class LogRepository : ILogRepository
    {

        private readonly RubAppDbContext _context;

        public LogRepository(RubAppDbContext context)
        {
            _context = context;
        }
        public async Task<IList<Log>> GetLogs(Expression<Func<Log, bool>>? predicate = null, int page = 1, int pageSize = 10, CancellationToken cancellationToken = default)
        {
            var query = _context.Logs.AsNoTracking().AsQueryable();

            if (predicate is not null)
            {
                query = query.Where(predicate);
            }

            return await query
                .OrderBy(u => u.Path)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync(cancellationToken);
        }

        public async Task<Log> CreateLog(Log log, CancellationToken cancellationToken = default)
        {
            await _context.Logs.AddAsync(log, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return log;
        }
    }
}
