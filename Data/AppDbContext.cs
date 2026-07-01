using Microsoft.EntityFrameworkCore;
using MyFirstWebAPI.Models;
using System.Collections.Generic;

namespace MyFirstWebAPI.Datas
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // This represents the Students TABLE in database
        public DbSet<Student> Students { get; set; }
    }
}
