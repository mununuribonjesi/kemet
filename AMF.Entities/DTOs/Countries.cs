using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AMF.Entities.DTOs
{
    public class Countries
    {
        [Key]
        public Guid CountryID { get; set; }
        public String Country { get; set; }
    }
}
