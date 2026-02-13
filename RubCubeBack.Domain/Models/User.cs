using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RubCubeBack.Domain.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public User CreateUser(string name, string? lastName, string email, string password)
        {
            return new User
            {
                Id = Guid.NewGuid(),
                Name = name,
                LastName = lastName,
                Email = email,
                Password = password
            };
        }
    }
}
