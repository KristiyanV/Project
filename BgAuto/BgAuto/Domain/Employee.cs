﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Domain
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(10)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(30)]
        public string JobTitle { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
