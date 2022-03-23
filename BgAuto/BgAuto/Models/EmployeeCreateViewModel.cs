using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Models
{
    public class EmployeeCreateViewModel
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Job Title")]
        [MaxLength(30)]
        public string JobTitle { get; set; }
    }
}
