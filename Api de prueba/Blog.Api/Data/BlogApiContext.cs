using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blog.Api.Models;

namespace Blog.Api.Data
{
    public class BlogApiContext : DbContext
    {
        public BlogApiContext (DbContextOptions<BlogApiContext> options)
            : base(options)
        {
        }

        public DbSet<Blog.Api.Models.Comments> Comments { get; set; }

        public DbSet<Blog.Api.Models.Posts> Post { get; set; }

        public DbSet<Blog.Api.Models.User> User { get; set; }
    }
}
