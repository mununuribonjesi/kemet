using System;
using System.Collections.Generic;
using System.Text;

namespace AMF.Entities.DTOs
{
    public class Customer
    {
        public int Id { get; set;}
        
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public DateTime DOB { get; set; }

        public String Address { get; set; }
    }
}
