using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Models
{
    public class OrderCreateViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }
        public string Id { get; set; }
        [Required]
        public string CarId { get; set; }
        public Car Car { get; set; }
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        public DateTime OrderedOn { get; set; }
    }
}
