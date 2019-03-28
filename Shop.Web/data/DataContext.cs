

namespace Shop.Web.data
{
    using Microsoft.EntityFrameworkCore;
    using Shop.Web.data.Entities;

    public class DataContext :  DbContext 
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
