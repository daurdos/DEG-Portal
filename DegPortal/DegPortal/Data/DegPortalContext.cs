using DegPortal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DegPortal.Data
{
    public class DegPortalContext : IdentityDbContext<User>
    {
        public DegPortalContext(DbContextOptions<DegPortalContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
    }
}
