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

        public async Task<ListItemsResponse<IList<Log>>> GetLogs(LogFilterDTO filter, CancellationToken cancellationToken)
        {
            var startUtc = filter.StartAt.HasValue
    ? DateTime.SpecifyKind(filter.StartAt.Value, DateTimeKind.Utc)
    : (DateTime?)null;
            var endUtc = filter.EndAt.HasValue
      ? DateTime.SpecifyKind(filter.EndAt.Value, DateTimeKind.Utc)
      : (DateTime?)null;

            var logs = await _logRepository.GetLogs(l =>
      (string.IsNullOrEmpty(filter.UserId) || l.UserId == Guid.Parse(filter.UserId))
      && (!startUtc.HasValue || l.Created >= startUtc.Value)
      && (!endUtc.HasValue || l.Created <= endUtc.Value)
      && (string.IsNullOrEmpty(filter.Endpoint) || l.Path.Contains(filter.Endpoint)),
      filter.Page, filter.PageSize, cancellationToken);
            return new ListItemsResponse<IList<Log>>
            {
                Items = logs,
                Page = filter.Page,
                PageSize = filter.PageSize,
            };
        }
    }
}
