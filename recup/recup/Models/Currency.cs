using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace recup.Models
{
    public class Currency
    {
       [Key]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Symbol { get; set; }

    }
}