using System;
using System.Collections.Generic;
using System.Text;

namespace AMF.Data.UnitOfWork.Models
{
    public class Todo
    {
        public Todo()
        {

            Id = new Guid();
            CreatedOn = DateTime.Now;
            IsCompleted = false;

        }

        public Guid Id {get; set;}

        public DateTime CreatedOn { get; set;}

        public string Title { get; set; }

        public string Body { get; set; }

        public bool IsCompleted { get; set; }
    }
}
