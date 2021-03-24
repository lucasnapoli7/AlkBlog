using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlkBlog.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
