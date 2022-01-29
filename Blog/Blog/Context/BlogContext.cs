using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using Blog.Entity;

namespace Blog.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Yisus;Database=Alkemy1;Trusted_Connection=True;");
        }


        public DbSet<Comments> Comments { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
