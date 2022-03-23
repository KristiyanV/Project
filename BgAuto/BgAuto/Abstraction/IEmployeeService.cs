using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Abstraction
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployees();
        public Employee GetEmployee(string employeeId);
        public bool CreateEmployee(string firstName, string lastName, string phone, string jobTitle, string userId);
        public bool Remove(string employeeId);
        public string GetFullName(string employeeId);
    }
}
