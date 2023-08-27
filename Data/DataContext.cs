using Login_Register_App.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Login_Register_App.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

