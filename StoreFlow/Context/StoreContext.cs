using Microsoft.EntityFrameworkCore;

namespace StoreFlow.Context
{
    public class StoreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9K7H8F2;Database=StoreFlowDb;Trusted_Connection=True;");
        }
    }
}
