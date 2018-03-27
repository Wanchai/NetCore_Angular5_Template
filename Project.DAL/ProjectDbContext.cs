using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Project.DAL.Models;

namespace Project.DAL
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

    }
}
