using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Api.Models
{
    public class User : IEntity
    {
        private string name;
        private string password;
        private string email;
        private ICollection <Posts> post;
        private ICollection <Comments> comment;

        public User(string name, string password, string email)
        {
            this.name = name;
            this.password = password;
            this.email = email;
        }
        public int Id { get; set; }
        [MaxLength(40)]
        [Required]
        public string Name { get => name; set => name = value; }
        [MaxLength(9)]
        [Required]
        public string Password { get => password; set => password = value; }
        [MaxLength(30)]
        [Required]
        public string Email { get => email; set => email = value; }
        public ICollection<Posts> Posts { get => post; set => post = value; }
        public ICollection<Comments> Comment { get => comment; set => comment = value; }
    }
}
