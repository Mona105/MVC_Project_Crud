using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_Project.Models
{
    public class ApplicationDbContext:DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
     public DbSet<Locations> Locations { get; set; }
     public DbSet<Students> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
