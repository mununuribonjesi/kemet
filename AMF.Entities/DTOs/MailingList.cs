using System;
using System.Collections.Generic;
using System.Text;

namespace AMF.Entities.DTOs
{
    public class MailingList
    {
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float DobDay { get; set; }
        public float DobMonth { get; set; }
        public float  DobYear { get; set; }
    }
}
