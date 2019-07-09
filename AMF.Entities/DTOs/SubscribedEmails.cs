using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AMF.Entities.DTOs
{
    public class SubscribedEmails
    {
        [Key]
        public Guid EmailID { get; set; }
        public String Email { get; set; }

    }
}
