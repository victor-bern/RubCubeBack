using RubCubeBack.Application.DTOs.Common;
using RubCubeBack.Application.DTOs.Log;
using RubCubeBack.Application.DTOs.User;
using RubCubeBack.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Interfaces
{
    public interface ILogService
    {
        Task<ListItemsResponse<Log>> GetLogs(LogFilterDTO filter, CancellationToken cancellationToken);
    }
}
