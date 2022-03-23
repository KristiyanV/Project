using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Abstraction
{
    public interface ITestDriveService
    {
        public bool Create(string Id, string CustomerId, string userId, ApplicationUser Customer, string CarId, Car Car, DateTime OrderedOn, DateTime TestOn);
        public List<TestDrive> All();
        public List<TestDrive> My(string customerId);
    }
}
