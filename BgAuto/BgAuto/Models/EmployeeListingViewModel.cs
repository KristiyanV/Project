using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Models
{
    public class EmployeeListingViewModel
    {
        
        public string Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(10)]
        public string Phone { get; set; }
        [Required]
        public string JobTitle { get; set; }
        public string UserId { get; set; }
        [Display(Name = "Admin")]
        public bool IsAdmin { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
