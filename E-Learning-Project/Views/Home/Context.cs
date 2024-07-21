using Microsoft.EntityFrameworkCore;

namespace E_Learning_Project.Views.Home
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
