using BgAuto.Abstraction;
using BgAuto.Domain;
using BgAuto.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BgAuto.Controllers
{
    public class ClientsController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IClientService service;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ILogger<ChangePasswordModel> logger;

        public ClientsController(UserManager<ApplicationUser> userManager,
            IClientService service,
            SignInManager<ApplicationUser> signInManager,
             ILogger<ChangePasswordModel> logger)
        {
            this.userManager = userManager;
            this.service = service;
            this.signInManager = signInManager;
            this.logger = logger;
        }
        // GET: ClientsController
        public IActionResult All()
        {
            var employees = service.GetClients()
                .Select(x => new ClientListingModel
                {
                    Id = x.Id,
                    Phone = x.Phone,
                    FirstName = x.User.FirstName,
                    LastName = x.User.LastName,
                    Address = x.Address,
                    UserId = x.UserId,
                    UserName = x.User.UserName,
                    Email = x.User.Email
                }).ToList();


            employees = employees.OrderBy(x => x.UserName).ToList();
            return View(employees);
        }

        // GET: ClientsController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClientCreateViewModel clientCreateViewModel)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var userIdAlreadyClient = this.service
                .GetClients()
                .Any(d => d.UserId == userId);
                var iscreated = service.CreateClient(clientCreateViewModel.PhoneNumber, clientCreateViewModel.Address, userId);
                if(iscreated)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(clientCreateViewModel);
        }
    }
}
