using RubCubeBack.Application.DTOs.Common;
using RubCubeBack.Application.DTOs.Log;
using RubCubeBack.Application.Interfaces;
using RubCubeBack.Domain.Models;
using RubCubeBack.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Services
{
    public class LogService : ILogService
    {
        private readonly ILogRepository _logRepository;

        public LogService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        public async Task<ListItemsResponse<Log>> GetLogs(LogFilterDTO filter, CancellationToken cancellationToken)
        {
           var logs =  await _logRepository.GetLogs(l =>
    (string.IsNullOrEmpty(filter.UserId) || l.UserId == Guid.Parse(filter.UserId))
    && (!filter.StartAt.HasValue || l.Created >= filter.StartAt.Value)
    && (!filter.EndAt.HasValue || l.Created <= filter.EndAt.Value)
    && (string.IsNullOrEmpty(filter.Endpoint) || l.Path.Contains(filter.Endpoint)),
           filter.Page, 
           filter.PageSize, 
           cancellationToken);
            return new ListItemsResponse<Log>
            {
                Items = logs,
                Page = filter.Page,
                PageSize = filter.PageSize,
            };
        }
    }
}
