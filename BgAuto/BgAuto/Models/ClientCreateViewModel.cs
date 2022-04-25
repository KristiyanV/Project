using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Models
{
    public class ClientCreateViewModel
    {
        [Key]
        public string Id { get; set; }
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        [Display(Name = "Address")]
        [MaxLength(30)]
        public string Address { get; set; }
    }
}
