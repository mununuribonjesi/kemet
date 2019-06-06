using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
    public class MyWebApiContext : DbContext
    {
        public MyWebApiContext(DbContextOptions<MyWebApiContext> options) : base(options)
        { }
    }
}
