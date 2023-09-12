using Microsoft.EntityFrameworkCore;

namespace MoneyManager.Data
{
    public class MoneyManagerContext : DbContext
    {
        public MoneyManagerContext(DbContextOptions<MoneyManagerContext> options) : base(options)
        {

        }



    }
}
