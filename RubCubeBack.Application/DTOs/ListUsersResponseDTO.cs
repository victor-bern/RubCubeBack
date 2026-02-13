using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.DTOs
{
    public record ListUsersResponseDTO
    {
        public string Name { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
    }
}
