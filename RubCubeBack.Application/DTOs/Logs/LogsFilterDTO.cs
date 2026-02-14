using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.DTOs.Log
{
    public record LogsFilterDTO
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? UserId { get; set; }
        public DateTime? StartAt { get; set; }
        public DateTime? EndAt { get; set; }
     
        public string? Endpoint { get; set; }
    }
}
