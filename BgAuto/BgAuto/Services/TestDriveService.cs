using BgAuto.Abstraction;
using BgAuto.Data;
using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Services
{
    public class TestDriveService:ITestDriveService
    {
        private readonly ApplicationDbContext context;

        public TestDriveService(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        public List<TestDrive> All()
        {
            var testdrives = context.TestDrives.ToList();

            foreach (var testdrive in testdrives)
            {
                testdrive.Customer = context.Users.Find(testdrive.CustomerId);
            }

            return testdrives;
        }
        public List<TestDrive> My(string customerId)
        {
            var testdrives = context.TestDrives.Where(x => x.CustomerId == customerId).ToList();
            var list = context.Cars.ToList();

            foreach (var testdrive in testdrives)
            {
                testdrive.Car = context.Cars.Find(testdrive.CarId);
                testdrive.Customer = context.Users.Find(testdrive.CustomerId);
            }

            return testdrives;
        }

        public bool Create(string Id, string CustomerId, string userId, ApplicationUser Customer, string CarId, Car Car, DateTime OrderedOn, DateTime TestOn)
        {
            var user = context.Users.SingleOrDefault(s => s.Id == CustomerId);

            TestDrive testdrives = new TestDrive
            {
                Id = Id,
                CustomerId = CustomerId,
                Customer = Customer,
                Car = Car,
                CarId = CarId,
                OrderedOn = OrderedOn,
                TestOn = TestOn
            };
            context.TestDrives.Add(testdrives);
            return context.SaveChanges() != 0;
        }
    }
}
