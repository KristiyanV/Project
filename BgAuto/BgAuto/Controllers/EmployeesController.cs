using BgAuto.Abstraction;
using BgAuto.Areas.Identity.Pages.Account;
using BgAuto.Domain;
using BgAuto.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService service;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ILogger<LogoutModel> logger;

        public EmployeesController(IEmployeeService service, UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager, ILogger<LogoutModel> logger)
        {
            this.service = service;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.logger = logger;
        }

        public async Task<IActionResult> All()
        {
            var employees = service.GetEmployees()
                .Select(x => new EmployeeListingViewModel
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Phone = x.Phone,
                    JobTitle = x.JobTitle,
                    UserId = x.UserId,
                    UserName = x.User.UserName,
                    Email = x.User.Email
                }).ToList();

            var adminIds = (await userManager.GetUsersInRoleAsync("Administrator"))
                .Select(x => x.Id).ToList();

            foreach (var employee in employees)
            {
                employee.IsAdmin = adminIds.Contains(employee.UserId);
            }

            employees = employees.OrderByDescending(x => x.IsAdmin).ThenBy(x => x.UserName).ToList();
            return View(employees);
        }

        [HttpPost]
        public async Task<IActionResult> Promote(string userId)
        {
            if (userId == null)
            {
                return RedirectToAction("All");
            }
            var user = await userManager.FindByIdAsync(userId);

            if (user == null || await userManager.IsInRoleAsync(user, "Administrator"))
            {
                return RedirectToAction("All");
            }
            await userManager.AddToRoleAsync(user, "Administrator");

            return RedirectToAction("All");
        }
        [HttpPost]
        public async Task<IActionResult> Demote(string userId)
        {
            if (userId == null)
            {
                return RedirectToAction("All");
            }
            var user = await userManager.FindByIdAsync(userId);

            if (user == null || !await userManager.IsInRoleAsync(user, "Administrator"))
            {
                return RedirectToAction("All");
            }
            await userManager.RemoveFromRoleAsync(user, "Administrator");

            return RedirectToAction("All");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeCreateViewModel employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }
            if (await userManager.FindByNameAsync(employee.Username) == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = employee.Username;
                user.Email = employee.Email;

                var result = await userManager.CreateAsync(user, "employee123");

                if (result.Succeeded)
                {
                    var created = service.CreateEmployee(employee.FirstName, employee.LastName, employee.PhoneNumber, employee.JobTitle, user.Id);

                    if (created)
                    {
                        userManager.AddToRoleAsync(user, "Employee").Wait();

                        return RedirectToAction("All");
                    }
                }
            }
            ModelState.AddModelError(string.Empty, "The user exists.");
            return View();
        }
    }
}
