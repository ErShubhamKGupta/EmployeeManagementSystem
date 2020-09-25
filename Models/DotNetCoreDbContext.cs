using System;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.Models
{
    public class DotNetCoreDbContext : DbContext
    {
        public DotNetCoreDbContext(DbContextOptions<DotNetCoreDbContext> options): base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
