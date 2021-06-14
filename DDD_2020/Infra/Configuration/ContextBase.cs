
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Configuration
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConectionConfig()
        {
            //Desenvolvimento

            string strCon = "Data Source=DESKTOP-1KFN6OI;Database=DDD_2020;Integrate Security=true";

            return strCon;
        }
    }
}
