using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.DTOs
{
    public class UpdateUserRequestDTO
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
    }
}
