using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class LmsDbContext : DbContext
    {
        public LmsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
