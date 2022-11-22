
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.PowerBI.Api.Models;
using System.Collections.Generic;

namespace GoodnessClothing.Data
{
    
    
        public class DataContext : IdentityDbContext<AppUser>
        {
            public DataContext(DbContextOptions<DataContext> options) : base(options)
            { }
            public DbSet<Product> Products { get; set; }
            public DbSet<Category> Categories { get; set; }
        }
    
}
