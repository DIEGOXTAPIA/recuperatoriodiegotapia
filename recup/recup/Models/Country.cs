using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace recup.Models
{
    public class Country
    {
        [Key]
        [StringLength(100,MinimumLength =3,ErrorMessage ="ingrese entre 3 a100 caracteres")]
        public string Name { get; set; }
        [Required]
        public string Capital { get; set; }
        public int Population { get; set; }
        public List<string> Timezones{ get; set; }
        public List<Currency> Currencies { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0-yyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime Birthday { get; set; }

    }
}