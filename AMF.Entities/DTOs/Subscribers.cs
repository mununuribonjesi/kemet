using System;

using System.ComponentModel.DataAnnotations;

namespace AMF.Entities.DTOs
{
    public class Subscribers
    {
        [Key]
        public Guid SubscriptionID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid CountryID { get; set; }
        public Guid EmailID { get; set; }
        public String City { get; set; }
        public String PostCode { get; set; }

    }
}
