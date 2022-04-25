using BgAuto.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BgAuto.Models;

namespace BgAuto.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<TestDrive> TestDrives { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<BgAuto.Models.EmployeeListingViewModel> EmployeeListingViewModel { get; set; }
        public DbSet<BgAuto.Models.ClientCreateViewModel> ClientCreateViewModel { get; set; }
        public DbSet<BgAuto.Models.ClientListingModel> ClientListingModel { get; set; }
    }
}
