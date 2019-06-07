using System;
using System.Collections.Generic;
using System.Text;
using AMF.Data.Interfaces;
using AMF.Data.UnitOfWork.Models;

namespace AMF.Data.Repositories
{
    public class TodoRepository:Repository<Todo>, ITodoRepository
    {

        public TodoRepository(ApplicationContext context):base(context)
        { }
    }
}
