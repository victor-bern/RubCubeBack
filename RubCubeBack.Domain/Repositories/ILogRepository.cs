using RubCubeBack.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RubCubeBack.Domain.Repositories
{
    public interface ILogRepository
    {
        Task<IList<Log>> GetLogs(Expression<Func<Log, bool>>? predicate = null, int page = 1, int pageSize = 10, CancellationToken cancellationToken = default);
        Task<Log>CreateLog(Log log, CancellationToken cancellationToken = default);
    }
}
