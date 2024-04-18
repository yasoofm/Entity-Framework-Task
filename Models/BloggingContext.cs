using Microsoft.EntityFrameworkCore;
using System.Runtime.ExceptionServices;

namespace Entity_FrameWork.Models
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=asp.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            List<Blog> blogs = [new Blog() { Id = 1, Name = "first", Url = "https://hi" }, new Blog() { Id = 2, Name = "second", Url = "https://hi" }, new Blog() { Id = 3, Name = "third", Url = "https://hi" },];
            modelBuilder.Entity<Blog>().HasData(blogs);
        }
    }
}
