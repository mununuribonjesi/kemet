using Microsoft.EntityFrameworkCore;

namespace AMF.Entities.Models
{
    public class  WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options)
        { }
    }
}
