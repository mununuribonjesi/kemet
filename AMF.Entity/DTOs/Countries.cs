using System;
using System.ComponentModel.DataAnnotations;

namespace AMF.Entities.DTOs
{
    public class Countries
    {
        [Key]
        public Guid CountryID { get; set; }
        public String Country { get; set; }
    }
}
