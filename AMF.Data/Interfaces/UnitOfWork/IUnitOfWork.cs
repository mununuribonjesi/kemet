using System;
using System.Collections.Generic;
using System.Text;

namespace AMF.Data.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        int Complete();
    }
}
