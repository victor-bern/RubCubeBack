using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RubCubeBack.Domain.Models
{
    public class Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Path { get; set; }
        public string? Request { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public int StatusCode { get; set; }
        public DateTime Created { get; set; }
    }
}
