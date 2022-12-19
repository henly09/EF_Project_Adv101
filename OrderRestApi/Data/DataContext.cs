using Microsoft.EntityFrameworkCore;

namespace OrderRestApi.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Order> BakeryOrders { get; set; }

    }
}
