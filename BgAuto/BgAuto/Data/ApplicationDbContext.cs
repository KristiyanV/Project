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
        public DbSet<BgAuto.Models.TestDriveListingViewModel> TestDriveListingViewModel { get; set; }
        public DbSet<BgAuto.Models.TestDriveCreateBindingModel> TestDriveCreateBindingModel { get; set; }
        public DbSet<BgAuto.Models.CarAllViewModel> CarAllViewModel { get; set; }
        public DbSet<BgAuto.Models.CarDetailsViewModel> CarDetailsViewModel { get; set; }
        public DbSet<BgAuto.Models.CarCreateViewModel> CarCreateViewModel { get; set; }
        public DbSet<BgAuto.Models.ClientCreateViewModel> ClientCreateViewModel { get; set; }
    }
}
