﻿using BgAuto.Abstraction;
using BgAuto.Data;
using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext context;

        public EmployeeService(ApplicationDbContext _context)
        {
            this.context = _context;
        }
        public bool CreateEmployee(string firstName, string lastName, string phone, string jobTitle, string userId)
        {
            if (context.Employees.Any(x => x.UserId == userId))
            {
                throw new InvalidOperationException("User already exist.");
            }

            Employee employee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                JobTitle = jobTitle,
                UserId = userId,
                Phone = phone
            };
            context.Employees.Add(employee);
            return context.SaveChanges() != 0;
        }

        public Employee GetEmployee(string employeeId)
        {
            var employee = context.Employees.FirstOrDefault(x => x.UserId == employeeId);
            employee.User = context.Users.FirstOrDefault(x => x.Id == employee.UserId);

            return employee;
        }

        public List<Employee> GetEmployees()
        {
            var list = context.Employees.ToList();

            foreach (var item in list)
            {
                if (item.User == null)
                {
                    item.User = context.Users.Find(item.UserId);
                }
            }
            return list;
        }

        public string GetFullName(string employeeId)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(string employeeId)
        {
            var employee = context.Employees.Find(employeeId);
            var myTestDrive = context.TestDrives.Where(x => x.CustomerId == employee.UserId);

            if (employee == null)
            {
                return false;
            }

            foreach (var order in myTestDrive)
            {
                context.TestDrives.Remove(order);
            }
            var user = context.Users.Find(employee.UserId);

            context.Users.Remove(user);
            context.Employees.Remove(employee);

            return context.SaveChanges() != 0;
        }
    }
}
