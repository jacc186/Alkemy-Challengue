using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DTOs
{
    internal class UsuarioDTO : Serializable
    { 
            private int userId;
            private string name;
            private string password;
            private string email;
            private List<Posts> posts;
            private List<Comments> comments;

        public UsuarioDTO(string name, string password, string email)
        {
            this.name = name;
            this.password = password;
            this.email = email;
        }

        public int Id { get => userId; set => userId = value; }
            public string Name { get => name; set => name = value; }
            public string Password { get => password; set => password = value; }
            public string Email { get => email; set => email = value; }
            public List<Posts> Posts { get => posts; set => posts = value; }
            public List<Comments> Comments { get => comments; set => comments = value; }
        
    }
}
